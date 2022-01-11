using System;
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
        public class MessageProcessor
        {
            private List<Buffer> message_queue;
            private Dictionary<int, Buffer> sequenced_message_queue;
            private Dictionary<int, List<Buffer>> ordered_message_queue;

            private TryProcess<Buffer> read_process;

            private Syncronizer syncronizer;

            private bool ProcessDataUnordered(Buffer buffer, int channel)
            {
                if (read_process(buffer))
                    return true;

                message_queue.Add(buffer);
                return false;
            }

            private bool ProcessDataSequenced(Buffer buffer, int channel)
            {
                if (read_process(buffer))
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
                    if (read_process(buffer))
                        return true;
                }

                queue.Add(buffer);
                return false;
            }

            public MessageProcessor(Syncronizer s, TryProcess<Buffer> r)
            {
                message_queue = new List<Buffer>();
                sequenced_message_queue = new Dictionary<int, Buffer>();
                ordered_message_queue = new Dictionary<int, List<Buffer>>();

                read_process = r;

                syncronizer = s;
            }

            public bool ProcessMessage(NetIncomingMessage message)
            {
                Buffer buffer = new Buffer(message, message.SenderConnection.GetNetworkActor(), syncronizer);

                switch (message.DeliveryMethod)
                {
                    case NetDeliveryMethod.ReliableOrdered: return ProcessDataOrdered(buffer, message.SequenceChannel);
                    case NetDeliveryMethod.ReliableSequenced: return ProcessDataSequenced(buffer, message.SequenceChannel);
                    case NetDeliveryMethod.ReliableUnordered: return ProcessDataUnordered(buffer, message.SequenceChannel);
                }

                read_process(buffer);
                return true;
            }

            public void ProcessBacklog()
            {
                message_queue.RemoveAll(m => read_process(m));
                sequenced_message_queue.RemoveAll(p => read_process(p.Value));
                ordered_message_queue.Process(p => p.Value.RemoveAllUntil(b => read_process(b) == false, false));
            }
        }
    }
}