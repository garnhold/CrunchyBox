using System;
using System.Net;
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