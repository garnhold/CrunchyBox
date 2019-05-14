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