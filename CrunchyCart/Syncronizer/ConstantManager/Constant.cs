using System;
using System.Net;
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
        public class Constant<T>
        {
            private T value;
            private int compressed_id;

            private Timer activation_timer;

            static private int NEXT_COMPRESSED_ID = 1;

            public Constant()
            {
                activation_timer = new Timer(Duration.Seconds(1.5f));
            }

            public Constant(T v) : this()
            {
                value = v;
                compressed_id = NEXT_COMPRESSED_ID++;

                activation_timer.Start();
            }

            public Constant(T v, int i) : this()
            {
                value = v;
                compressed_id = i;

                activation_timer.Expire();
            }

            public bool ShouldCompress()
            {
                if (activation_timer.IsTimeOver())
                    return true;

                return false;
            }

            public T GetValue()
            {
                return value;
            }

            public int GetCompressedId()
            {
                return compressed_id;
            }
        }
    }
}