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
        public partial class Buffer
        {
            public IEnumerable<T> ReadCollection<T>(Operation<T, Buffer> operation)
            {
                int count = ReadInt32();

                for (int i = 0; i < count; i++)
                    yield return operation(this);
            }
            public void WriteCollection<T>(ICollection<T> collection, Process<Buffer, T> process)
            {
                WriteInt32(collection.Count);

                collection.Process(i => process(this, i));
            }

            public IEnumerable<T> ReadCollection<T>(Operation<T> operation)
            {
                return ReadCollection<T>(b => operation());
            }
            public void WriteCollection<T>(ICollection<T> collection, Process<T> process)
            {
                WriteCollection<T>(collection, (b, i) => process(i));
            }
        }
    }
}