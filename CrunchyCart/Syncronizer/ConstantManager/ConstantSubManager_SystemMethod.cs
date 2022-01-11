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
        public class ConstantSubManager_SystemMethod : ConstantSubManager<SystemMethod>
        {
            protected override SystemMethod ReadConstantValue(Buffer buffer)
            {
                return SystemMethod.GetSystemMethodBySignature(
                    buffer.ReadType(),
                    buffer.ReadString()
                );
            }

            protected override void WriteConstantValue(SystemMethod value, Buffer buffer)
            {
                buffer.WriteType(value.GetDeclaringType());
                buffer.WriteString(value.GetName());
            }

            public ConstantSubManager_SystemMethod(ConstantManager m) : base(m) { }
        }
    }
}