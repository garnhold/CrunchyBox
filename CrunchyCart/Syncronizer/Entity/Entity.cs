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

            private NetworkActor? authority;asfd

            private System constructor_system;
            private SystemMethod_Constructor constructor;
            private object[] constructor_arguments;

            private EntityManager manager;

            private void CedeAuthority(NetworkActor successor, bool force_broadcast = false)
            {
                LocalAuthorityState state;

                authority = authority.CedeAuthority(successor, out state);

                if (force_broadcast || GetNetworkActor().IsServer())
                    SendAuthority();

                switch (state)
                {
                    case LocalAuthorityState.GainedAuthority: manager.NotifyGainedAuthority(this); break;
                    case LocalAuthorityState.LosedAuthority: manager.NotifyLosedAuthority(this); break;
                }
            }

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
            public void ReadSync(Buffer buffer)
            {
                CedeAuthority(buffer.ReadNetworkActor());
                liaison.GetTypeSerializer().ReadInPlace(target, buffer);
            }
            public void WriteSync(Buffer buffer)
            {
                buffer.WriteNetworkActor(authority);
                liaison.GetTypeSerializer().Write(target, buffer);
            }

            public void ReadAuthority(Buffer buffer)
            {
                if (buffer.GetSender().HasAuthorityOver(this))
                    CedeAuthority(buffer.ReadNetworkActor());
            }
            public void SendAuthority(NetworkActor actor)
            {
                if (GetNetworkActor().HasAuthorityOver(this))
                    CedeAuthority(actor, true);
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

            public void ReadDestroy(Buffer buffer)
            {
                if (buffer.GetSender().HasAuthorityOver(this))
                    manager.UnregisterEntity(this);
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