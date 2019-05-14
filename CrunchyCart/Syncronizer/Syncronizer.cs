using System;
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
        private NetworkPeer peer;

        private List<Buffer> message_queue;
        private Dictionary<int, Buffer> sequenced_message_queue;
        private Dictionary<int, List<Buffer>> ordered_message_queue;

        private EntityManager entity_manager;
        private ConstantManager constant_manager;

        private bool ProcessDataUnordered(Buffer buffer, int channel)
        {
            if (ReadBuffer(buffer))
                return true;

            message_queue.Add(buffer);
            return false;
        }

        private bool ProcessDataSequenced(Buffer buffer, int channel)
        {
            if (ReadBuffer(buffer))
            {
                sequenced_message_queue.Remove(channel);
                return true;
            }

            sequenced_message_queue[channel] = buffer;
            return false;
        }

        private bool ProcessDataOrdered(Buffer buffer, int channel)
        {
            List<Buffer> queue = ordered_message_queue.GetOrCreateDefaultValue(channel);

            if (queue.IsEmpty())
            {
                if (ReadBuffer(buffer))
                    return true;
            }

            queue.Add(buffer);
            return false;
        }

        private bool ReadBuffer(Buffer buffer)
        {
            return buffer.ExecuteRead(delegate(MessageType message_type) {
                switch (message_type)
                {
                    case MessageType.RequestConstant: constant_manager.ReadRequest(buffer); break;
                    case MessageType.UpdateConstant: constant_manager.ReadUpdate(buffer); break;
                    case MessageType.FullUpdateConstant: constant_manager.ReadFullUpdate(buffer); break;

                    case MessageType.InvokeEntityConstructor: entity_manager.ReadConstructorInvoke(buffer); break;
                    case MessageType.InvokeEntityMethod: entity_manager.ReadMethodInvoke(buffer); break;
                    case MessageType.ChangeEntityAuthority: entity_manager.ReadAuthority(buffer); break;
                    case MessageType.DestroyEntity: entity_manager.ReadDestroy(buffer); break;
                    case MessageType.UpdateEntity: entity_manager.ReadUpdate(buffer); break;

                    default: throw new UnaccountedBranchException("message_type", message_type);
                }
            });
        }

        protected void Send(NetworkRecipient recipient, MessageType message_type, NetDeliveryMethod delivery_method, int channel, Process<Buffer> process)
        {
            peer.SendMessage(recipient, delivery_method, channel, delegate(NetOutgoingMessage message) {
                Buffer buffer = new Buffer(message, GetNetworkActor(), this);

                buffer.ExecuteWrite(message_type, delegate() {
                    process(buffer);
                });
            });
        }
        protected T Send<T>(NetworkRecipient recipient, MessageType message_type, NetDeliveryMethod delivery_method, int channel, Operation<T, Buffer> operation)
        {
            T to_return = default(T);

            Send(recipient, message_type, delivery_method, channel, delegate(Buffer buffer) {
                to_return = operation(buffer);
            });

            return to_return;
        }

        public Syncronizer(NetworkPeer p)
        {
            peer = p;

            message_queue = new List<Buffer>();
            sequenced_message_queue = new Dictionary<int, Buffer>();
            ordered_message_queue = new Dictionary<int, List<Buffer>>();

            entity_manager = new EntityManager(this);
            constant_manager = new ConstantManager(this);

            peer.OnConnect += delegate(NetIncomingMessage message) {
                constant_manager.SendFullUpdate(new NetworkRecipient_Single(message.SenderConnection));
                entity_manager.InitializeRecipient(new NetworkRecipient_Single(message.SenderConnection));
                return true;
            };

            peer.OnData += delegate(NetIncomingMessage message) {
                Buffer buffer = new Buffer(message, message.SenderConnection.GetNetworkActor(), this);

                switch (message.DeliveryMethod)
                {
                    case NetDeliveryMethod.ReliableOrdered: return ProcessDataOrdered(buffer, message.SequenceChannel);
                    case NetDeliveryMethod.ReliableSequenced: return ProcessDataSequenced(buffer, message.SequenceChannel);
                    case NetDeliveryMethod.ReliableUnordered: return ProcessDataUnordered(buffer, message.SequenceChannel);
                }

                ReadBuffer(buffer);
                return true;
            };
        }

        public void Update()
        {
            peer.ProcessMessages();

            message_queue.RemoveAll(m => ReadBuffer(m));
            sequenced_message_queue.RemoveAll(p => ReadBuffer(p.Value));
            ordered_message_queue.Process(p => p.Value.RemoveAllUntil(b => ReadBuffer(b) == false, false));

            peer.Flush();
        }

        public Entity GetEntity(object target)
        {
            return entity_manager.ReferenceObject(target);
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