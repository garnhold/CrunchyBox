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
        public class EntityMethod_CommandAttribute : EntityMethodAttribute
        {
            private NetDeliveryMethod delivery_method;

            public EntityMethod_CommandAttribute(NetDeliveryMethod dm)
            {
                delivery_method = dm;
            }

            public override EntityMethod CreateEntityMethod(MethodInfo method)
            {
                return new EntityMethod_Command(method, delivery_method);
            }
        }

        public class EntityMethod_Command : EntityMethod
        {
            private NetDeliveryMethod delivery_method;

            public EntityMethod_Command(MethodInfo m, NetDeliveryMethod dm) : base(m)
            {
                delivery_method = dm;
            }

            public override void ReadMethodInvoke(Entity entity, Buffer buffer)
            {
                Syncronizer syncronizer = entity.GetSyncronizer();
                NetworkActor actor = syncronizer.GetNetworkActor();

                object[] arguments = ReadArguments(buffer);

                if (actor.IsServer())
                    Invoke(entity.GetTarget(), arguments);
            }

            public override void SendMethodInvoke(Entity entity, object[] arguments)
            {
                Syncronizer syncronizer = entity.GetSyncronizer();
                NetworkActor actor = syncronizer.GetNetworkActor();

                if (actor.IsServer())
                    Invoke(entity.GetTarget(), arguments);
                else
                {
                    syncronizer.CreateMessage(MessageType.InvokeEntityMethod, delivery_method, delegate(Buffer buffer) {
                        buffer.WriteEntityReference(entity);
                        buffer.WriteEntityMethod(this);

                        WriteArguments(arguments, buffer);
                    }).Send();
                }
            }
        }
    }
}