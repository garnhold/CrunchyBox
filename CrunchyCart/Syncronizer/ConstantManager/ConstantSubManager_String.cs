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
    using Sodium;
    
    public partial class Syncronizer
    {
        public class ConstantSubManager_String : ConstantSubManager<string>
        {
            protected override string ReadConstantValue(Buffer buffer)
            {
                return buffer.ReadString();
            }

            protected override void WriteConstantValue(string value, Buffer buffer)
            {
                buffer.WriteString(value);
            }

            public ConstantSubManager_String(ConstantManager m) : base(m) { }
        }
    }
}