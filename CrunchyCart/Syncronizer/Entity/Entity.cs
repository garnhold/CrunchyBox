using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using Lidgren.Network;

namespace Crunchy.Cart
{
    using Dough;
    using Salt;
    using Noodle;
    using Sodium;
    
    public partial class Syncronizer
    {
        public class Entity
        {
            private int id;
            private object target;
            private Authority authority;
            private ObjectLiaison liaison;

            private System constructor_system;
            private SystemMethod_Constructor constructor;
            private object[] constructor_arguments;

            private EntityManager manager;

            private void CedeAuthority(Authority new_authority, bool force_broadcast = false)
            {
                bool was_local = GetNetworkActor().IsAuthority(authority);
                bool is_local = GetNetworkActor().IsAuthority(new_authority);

                authority = new_authority;

                if (force_broadcast || GetNetworkActor().IsServer())
                {
                    GetSyncronizer().CreateMessage(MessageType.ChangeEntityAuthority, NetDeliveryMethod.ReliableOrdered, delegate(Buffer buffer) {
                        buffer.WriteEntityReference(this);

                        buffer.WriteAuthority(authority);
                    }).Send();
                }

                if (was_local == false && is_local)
                    manager.NotifyGainedAuthority(this);

                if (was_local && is_local == false)
                    manager.NotifyLostAuthority(this);
            }

            private void Destroy()
            {
                manager.UnregisterEntity(this);

                if (GetNetworkActor().IsServer())
                {
                    GetSyncronizer().CreateMessage(MessageType.DestroyEntity, NetDeliveryMethod.ReliableOrdered, delegate(Buffer buffer) {
                        buffer.WriteEntityReference(this);
                    }).Send();
                }
            }

            public Entity(int i, object t, System cs, SystemMethod_Constructor c, object[] ca, EntityManager m)
            {
                id = i;
                target = t;
                authority = Authority_Server.INSTANCE;
                liaison = TypeSerializer.InstanceLiaison(target.GetTypeEX());

                constructor_system = cs;
                constructor = c;
                constructor_arguments = ca.ToArray();

                manager = m;
            }

            public void Update()
            {
                if (GetNetworkActor().IsServer())
                    SendUpdate();
                else
                    liaison.Update(target);
            }

            public void ReadMethodInvoke(Buffer buffer)
            {
                if (buffer.GetSender().IsAuthority(authority))
                    buffer.ReadEntityMethod().ReadMethodInvoke(this, buffer);
            }
            public void SendMethodInvoke(string name, object[] arguments)
            {
                SendMethodInvoke(EntityMethod.GetEntityMethodBySignature(GetTargetType(), name), arguments);
            }
            public void SendMethodInvoke(MethodInfo method, object[] arguments)
            {
                SendMethodInvoke(EntityMethod.GetEntityMethod(method), arguments);
            }
            public void SendMethodInvoke(EntityMethod method, object[] arguments)
            {
                if (GetNetworkActor().IsAuthority(authority))
                    method.SendMethodInvoke(this, arguments);
            }

            public void SendConstructReplay(NetworkRecipient recipient)
            {
                if (GetNetworkActor().IsServer())
                    constructor.SendConstructorReplay(constructor_system, recipient, constructor_arguments, this);
            }
            public void ReadSync(Buffer buffer)
            {
                CedeAuthority(buffer.ReadAuthority());
                liaison.GetTypeSerializer().ReadInPlace(target, buffer);
            }
            public void WriteSync(Buffer buffer)
            {
                buffer.WriteAuthority(authority);
                liaison.GetTypeSerializer().Write(target, buffer);
            }

            public void ReadAuthority(Buffer buffer)
            {
                if (buffer.GetSender().IsAuthority(authority))
                    CedeAuthority(buffer.ReadAuthority());
            }
            public void SendAuthority(Authority new_authority)
            {
                if (GetNetworkActor().IsAuthority(authority))
                    CedeAuthority(new_authority, true);
            }

            public void ReadDestroy(Buffer buffer)
            {
                if (buffer.GetSender().IsServer())
                    Destroy();
            }
            public void SendDestroy()
            {
                if (GetNetworkActor().IsServer())
                    Destroy();
            }

            public void ReadUpdate(Buffer buffer)
            {
                if (buffer.GetSender().IsServer())
                    liaison.Read(target, buffer);
            }
            public void SendUpdate()
            {
                if (GetNetworkActor().IsServer())
                {
                    GetSyncronizer().CreateMessage(MessageType.UpdateEntity, NetDeliveryMethod.UnreliableSequenced, delegate(Buffer buffer) {
                        buffer.WriteEntityReference(this);

                        return liaison.Write(target, buffer);
                    }).IfNotNull(m => m.Send());
                }
            }

            public int GetId()
            {
                return id;
            }

            public object GetTarget()
            {
                return target;
            }

            public Type GetTargetType()
            {
                return target.GetTypeEX();
            }

            public Authority GetAuthority()
            {
                return authority;
            }

            public EntityManager GetManager()
            {
                return manager;
            }

            public Syncronizer GetSyncronizer()
            {
                return GetManager().GetSyncronizer();
            }

            public NetworkActor GetNetworkActor()
            {
                return GetSyncronizer().GetNetworkActor();
            }
        }
    }
}