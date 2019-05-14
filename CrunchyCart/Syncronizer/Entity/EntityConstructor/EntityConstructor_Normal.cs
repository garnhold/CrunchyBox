using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Collections;
using System.Collections.Generic;

using Lidgren.Network;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchySodium;

namespace CrunchyCart
{
    public partial class Syncronizer
    {
        public class Constructor_NormalAttribute : ConstructorAttribute
        {
            private int delivery_channel;

            public override EntityConstructor CreateEntityConstructor(MethodInfo method)
            {
                return new EntityConstructor_Normal(method, delivery_channel);
            }
        }

        public class EntityConstructor_Normal : EntityConstructor
        {
            private int delivery_channel;

            public EntityConstructor_Normal(MethodInfo m, int dc) : base(m)
            {
                delivery_channel = dc;
            }

            public override void ReadConstructorInvoke(Syncronizer syncronizer, Buffer buffer)
            {
                NetworkActor actor = syncronizer.GetNetworkActor();

                object[] arguments = ReadArguments(buffer);

                if (actor.IsServer())
                    SendConstructorInvoke(syncronizer, arguments);
                else
                {
                    object spawned = Invoke(null, arguments);
                    Entity spawned_entity = syncronizer.entity_manager.RegisterEntityTarget(buffer.ReadInt32(), this, arguments);

                    spawned_entity.ReadUpdate(buffer);
                }
            }

            public override void SendConstructorInvoke(Syncronizer syncronizer, object[] arguments)
            {
                NetworkActor actor = syncronizer.GetNetworkActor();

                if (actor.IsServer())
                {
                    object spawned = Invoke(null, arguments);
                    Entity spawned_entity = syncronizer.entity_manager.RegisterEntityTarget(spawned, this, arguments);

                    SendConstructorReplay(syncronizer, NetworkRecipient_All.INSTANCE, arguments, spawned_entity);
                }
                else
                {
                    SendConstructorReplay(syncronizer, NetworkRecipient_All.INSTANCE, arguments, null);
                }
            }

            public override void SendConstructorReplay(Syncronizer syncronizer, NetworkRecipient recipient, object[] arguments, Entity spawned_entity)
            {
                NetworkActor actor = syncronizer.GetNetworkActor();

                syncronizer.Send(recipient, MessageType.InvokeEntityConstructor, NetDeliveryMethod.ReliableOrdered, delivery_channel, delegate(Buffer buffer) {
                    buffer.WriteEntityConstructor(this);

                    WriteArguments(arguments, buffer);

                    if (actor.IsServer())
                    {
                        buffer.WriteInt32(spawned_entity.GetId());
                        spawned_entity.WriteUpdate(buffer);
                    }
                });
            }
        }
    }
}