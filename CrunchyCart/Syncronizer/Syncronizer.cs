using System;
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
        private NetworkPeer peer;
        private MessageProcessor message_processor;

        private EntityManager entity_manager;
        private SystemManager system_manager;
        private ConstantManager constant_manager;

        public event MultiProcess<NetConnection> OnNewClient;

        public event MultiProcess<Entity> OnGainAuthority
        {
            add { entity_manager.OnGainAuthority += value; }
            remove { entity_manager.OnGainAuthority -= value; }
        }

        public event MultiProcess<Entity> OnLoseAuthority
        {
            add { entity_manager.OnLoseAuthority += value; }
            remove { entity_manager.OnLoseAuthority -= value; }
        }

        private bool ReadBuffer(Buffer buffer)
        {
            return buffer.ExecuteRead(delegate(MessageType message_type) {
                switch (message_type)
                {
                    case MessageType.RequestConstant: constant_manager.ReadRequest(buffer); break;
                    case MessageType.UpdateConstant: constant_manager.ReadUpdate(buffer); break;
                    case MessageType.FullUpdateConstant: constant_manager.ReadFullUpdate(buffer); break;

                    case MessageType.InvokeEntityMethod: entity_manager.ReadMethodInvoke(buffer); break;
                    case MessageType.ChangeEntityAuthority: entity_manager.ReadAuthority(buffer); break;
                    case MessageType.DestroyEntity: entity_manager.ReadDestroy(buffer); break;
                    case MessageType.UpdateEntity: entity_manager.ReadUpdate(buffer); break;

                    case MessageType.InvokeSystemMethod: system_manager.ReadMethodInvoke(buffer); break;

                    default: throw new UnaccountedBranchException("message_type", message_type);
                }
            });
        }

        protected Message CreateMessage(NetDeliveryMethod delivery_method, int delivery_channel)
        {
            return new Message(peer.CreateEnvelope(delivery_method, delivery_channel), this);
        }

        protected Message CreateMessage(MessageType type, NetDeliveryMethod delivery_method, Process<Buffer> process)
        {
            Message message = CreateMessage(delivery_method, type.GetDeliveryChannel());
            Buffer buffer = message.GetBuffer();

            buffer.ExecuteWrite(type);
            process(buffer);

            return message;
        }

        protected Message CreateMessage(MessageType type, NetDeliveryMethod delivery_method, TryProcess<Buffer> process)
        {
            bool is_valid = false;

            Message message = CreateMessage(type, delivery_method, delegate(Buffer buffer) {
                is_valid = process(buffer);
            });

            if (is_valid)
                return message;

            return null;
        }

        public Syncronizer(NetworkPeer p, IEnumerable<object> ts)
        {
            peer = p;
            message_processor = new MessageProcessor(this, b => ReadBuffer(b));

            entity_manager = new EntityManager(this);
            system_manager = new SystemManager(this, ts);
            constant_manager = new ConstantManager(this);

            if (GetNetworkActor().IsServer())
            {
                peer.OnConnect += delegate(NetIncomingMessage message) {
                    constant_manager.SendFullUpdate(new NetworkRecipient_Single(message.SenderConnection));
                    entity_manager.InitializeRecipient(new NetworkRecipient_Single(message.SenderConnection));

                    OnNewClient.InvokeAll(message.SenderConnection);
                    return true;
                };
            }

            peer.OnData += delegate(NetIncomingMessage message) {
                return message_processor.ProcessMessage(message);
            };
        }

        public Syncronizer(NetworkPeer p, params object[] ts) : this(p, (IEnumerable<object>)ts) { }

        public void Update()
        {
            peer.ProcessMessages();
            message_processor.ProcessBacklog();

            entity_manager.Update();

            peer.Flush();
        }

        public Entity GetEntity(object target)
        {
            return entity_manager.ReferenceObject(target);
        }

        public System GetSystem(object target)
        {
            return system_manager.ReferenceObject(target);
        }

        public NetworkActor GetNetworkActor()
        {
            return peer.GetNetworkActor();
        }

        public NetworkActor GetNetworkActorById(long id)
        {
            return peer.GetNetworkActorById(id);
        }
    }
}