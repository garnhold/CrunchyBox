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
        public class SystemMethod_CallAttribute : SystemMethodAttribute
        {
            private int delivery_channel;
            private NetDeliveryMethod delivery_method;

            public SystemMethod_CallAttribute(int dc, NetDeliveryMethod dm)
            {
                delivery_channel = dc;
                delivery_method = dm;
            }

            public override SystemMethod CreateSystemMethod(MethodInfo method)
            {
                return new SystemMethod_Call(method, delivery_channel, delivery_method);
            }
        }

        public class SystemMethod_Call : SystemMethod
        {
            private int delivery_channel;
            private NetDeliveryMethod delivery_method;

            public SystemMethod_Call(MethodInfo m, int dc, NetDeliveryMethod dm) : base(m)
            {
                delivery_channel = dc;
                delivery_method = dm;
            }

            public override void ReadMethodInvoke(System system, Buffer buffer)
            {
                Syncronizer syncronizer = system.GetSyncronizer();
                NetworkActor actor = syncronizer.GetNetworkActor();

                object[] arguments = ReadArguments(buffer);

                if (actor.IsServer())
                    SendMethodInvoke(system, arguments);
                else
                    Invoke(system.GetTarget(), arguments);
            }

            public override void SendMethodInvoke(System system, object[] arguments)
            {
                Syncronizer syncronizer = system.GetSyncronizer();
                NetworkActor actor = syncronizer.GetNetworkActor();

                syncronizer.Send(NetworkRecipient_All.INSTANCE, MessageType.InvokeSystemMethod, delivery_method, delivery_channel, delegate(Buffer buffer) {
                    buffer.WriteSystemReference(system);
                    buffer.WriteSystemMethod(this);

                    WriteArguments(arguments, buffer);

                    if (actor.IsServer())
                        Invoke(system.GetTarget(), arguments);
                });
            }
        }
    }
}