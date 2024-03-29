using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Collections;
using System.Collections.Generic;

using Lidgren.Network;

namespace Crunchy.Cart
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class Syncronizer
    {
        public class SystemMethod_CallAttribute : SystemMethodAttribute
        {
            private NetDeliveryMethod delivery_method;

            public SystemMethod_CallAttribute(NetDeliveryMethod dm)
            {
                delivery_method = dm;
            }

            public override SystemMethod CreateSystemMethod(MethodInfo method)
            {
                return new SystemMethod_Call(method, delivery_method);
            }
        }

        public class SystemMethod_Call : SystemMethod
        {
            private NetDeliveryMethod delivery_method;

            public SystemMethod_Call(MethodInfo m, NetDeliveryMethod dm) : base(m)
            {
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

                syncronizer.CreateMessage(MessageType.InvokeSystemMethod, delivery_method, delegate(Buffer buffer) {
                    buffer.WriteSystemReference(system);
                    buffer.WriteSystemMethod(this);

                    WriteArguments(arguments, buffer);

                    if (actor.IsServer())
                        Invoke(system.GetTarget(), arguments);
                }).Send();
            }
        }
    }
}