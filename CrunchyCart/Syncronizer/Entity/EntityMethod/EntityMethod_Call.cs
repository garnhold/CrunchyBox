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
        public class Method_CallAttribute : MethodAttribute
        {
            private int delivery_channel;
            private NetDeliveryMethod delivery_method;

            public Method_CallAttribute(int dc, NetDeliveryMethod dm)
            {
                delivery_channel = dc;
                delivery_method = dm;
            }

            public override EntityMethod CreateEntityMethod(MethodInfo method)
            {
                return new EntityMethod_Call(method, delivery_channel, delivery_method);
            }
        }

        public class EntityMethod_Call : EntityMethod
        {
            private int delivery_channel;
            private NetDeliveryMethod delivery_method;

            public EntityMethod_Call(MethodInfo m, int dc, NetDeliveryMethod dm) : base(m)
            {
                delivery_channel = dc;
                delivery_method = dm;
            }

            public override void ReadMethodInvoke(Entity entity, Buffer buffer)
            {
                Syncronizer syncronizer = entity.GetSyncronizer();
                NetworkActor actor = syncronizer.GetNetworkActor();

                object[] arguments = ReadArguments(buffer);

                if (actor.IsServer())
                    SendMethodInvoke(entity, arguments);
                else
                    Invoke(entity.GetTarget(), arguments);
            }

            public override void SendMethodInvoke(Entity entity, object[] arguments)
            {
                Syncronizer syncronizer = entity.GetSyncronizer();
                NetworkActor actor = syncronizer.GetNetworkActor();

                syncronizer.Send(NetworkRecipient_All.INSTANCE, MessageType.InvokeEntityMethod, delivery_method, delivery_channel, delegate(Buffer buffer) {
                    buffer.WriteEntityReference(entity);
                    buffer.WriteEntityMethod(this);

                    WriteArguments(arguments, buffer);

                    if (actor.IsServer())
                        Invoke(entity.GetTarget(), arguments);
                });
            }
        }
    }
}