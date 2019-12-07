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
        public abstract class BufferDefermentException : Exception
        {
            public abstract bool IsReadyForReattempt();
        }
    }
}