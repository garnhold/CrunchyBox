using System;
using System.Reflection;
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
        public class Entity
        {
            private int id;
            private object target;
            private ObjectLiaison liaison;

            private NetworkActor authority;

            private System constructor_system;
            private SystemMethod_Constructor constructor;
            private object[] constructor_arguments;

            private EntityManager manager;

            public Entity(int i, object t, System cs, SystemMethod_Constructor c, object[] ca, EntityManager m)
            {
                id = i;
                target = t;
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
                if (buffer.GetSender().HasAuthorityOver(this))
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
                if (GetNetworkActor().HasAuthorityOver(this))
                    method.SendMethodInvoke(this, arguments);
            }

            public void SendConstructReplay(NetworkRecipient recipient)
            {
                if (GetNetworkActor().IsServer())
                    constructor.SendConstructorReplay(constructor_system, recipient, constructor_arguments, this);
            }

            public void ReadAuthority(Buffer buffer)
            {
                if (buffer.GetSender().HasAuthorityOver(this))
                    authority = buffer.ReadNetworkActor();
            }

            public void SendAuthority(NetworkActor actor)
            {
                if (GetNetworkActor().HasAuthorityOver(this))
                {
                    authority = actor;

                    SendAuthority();
                }
            }
            public void SendAuthority()
            {
                if (GetNetworkActor().HasAuthorityOver(this))
                {
                    GetSyncronizer().CreateMessage(MessageType.ChangeEntityAuthority, NetDeliveryMethod.ReliableOrdered, delegate(Buffer buffer) {
                        buffer.WriteEntityReference(this);

                        buffer.WriteNetworkActor(authority);
                    }).Send();
                }
            }

            public bool ReadDestroy(Buffer buffer)
            {
                if (buffer.GetSender().HasAuthorityOver(this))
                {
                    return true;
                }

                return false;
            }

            public void SendDestroy()
            {
                if (GetNetworkActor().HasAuthorityOver(this))
                {
                    GetSyncronizer().CreateMessage(MessageType.DestroyEntity, NetDeliveryMethod.ReliableOrdered, delegate(Buffer buffer) {
                        buffer.WriteEntityReference(this);
                    }).Send();
                }
            }

            public void ReadUpdate(Buffer buffer)
            {
                if (buffer.GetSender().HasAuthorityOver(this))
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

            public NetworkActor GetAuthority()
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