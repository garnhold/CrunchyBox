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
        public class BufferDefermentException_MissingConstant : BufferDefermentException
        {
            private int compressed_id;

            private ConstantSubManager manager;

            public BufferDefermentException_MissingConstant(int i, ConstantSubManager m)
            {
                compressed_id = i;

                manager = m;
            }

            public override bool IsReadyForReattempt()
            {
                if (manager.CanUncompress(compressed_id))
                    return true;

                return false;
            }
        }
    }
}