﻿using System;
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
        public class SystemMethod_ConstructorAttribute : SystemMethodAttribute
        {
            private int delivery_channel;

            public SystemMethod_ConstructorAttribute(int dc)
            {
                delivery_channel = dc;
            }

            public override SystemMethod CreateSystemMethod(MethodInfo method)
            {
                return new SystemMethod_Constructor(method, delivery_channel);
            }
        }

        public class SystemMethod_Constructor : SystemMethod
        {
            private int delivery_channel;

            public SystemMethod_Constructor(MethodInfo m, int dc) : base(m)
            {
                delivery_channel = dc;
            }

            public override void ReadMethodInvoke(System system, Buffer buffer)
            {
                Syncronizer syncronizer = system.GetSyncronizer();
                NetworkActor actor = syncronizer.GetNetworkActor();

                object[] arguments = ReadArguments(buffer);

                if (actor.IsServer())
                    SendMethodInvoke(system, arguments);
                else
                {
                    object spawned = Invoke(system.GetTarget(), arguments);
                    Entity spawned_entity = syncronizer.entity_manager.RegisterEntityTarget(buffer.ReadInt32(), spawned, system, this, arguments);

                    spawned_entity.ReadUpdate(buffer);
                }
            }

            public override void SendMethodInvoke(System system, object[] arguments)
            {
                Syncronizer syncronizer = system.GetSyncronizer();
                NetworkActor actor = syncronizer.GetNetworkActor();

                if (actor.IsServer())
                {
                    object spawned = Invoke(system.GetTarget(), arguments);
                    Entity spawned_entity = syncronizer.entity_manager.RegisterEntityTarget(spawned, system, this, arguments);

                    SendConstructorReplay(system, NetworkRecipient_All.INSTANCE, arguments, spawned_entity);
                }
                else
                {
                    SendConstructorReplay(system, NetworkRecipient_All.INSTANCE, arguments, null);
                }
            }

            public void SendConstructorReplay(System system, NetworkRecipient recipient, object[] arguments, Entity spawned_entity)
            {
                Syncronizer syncronizer = system.GetSyncronizer();
                NetworkActor actor = syncronizer.GetNetworkActor();

                syncronizer.Send(recipient, MessageType.InvokeSystemMethod, NetDeliveryMethod.ReliableOrdered, delivery_channel, delegate(Buffer buffer) {
                    buffer.WriteSystemReference(system);
                    buffer.WriteSystemMethod(this);

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