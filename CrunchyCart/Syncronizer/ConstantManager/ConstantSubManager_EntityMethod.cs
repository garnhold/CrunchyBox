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
        public class ConstantSubManager_EntityMethod : ConstantSubManager<EntityMethod>
        {
            protected override EntityMethod ReadConstantValue(Buffer buffer)
            {
                return EntityMethod.GetEntityMethodBySignature(
                    buffer.ReadType(),
                    buffer.ReadString()
                );
            }

            protected override void WriteConstantValue(EntityMethod value, Buffer buffer)
            {
                buffer.WriteType(value.GetDeclaringType());
                buffer.WriteString(value.GetName());
            }

            public ConstantSubManager_EntityMethod(ConstantManager m) : base(m) { }
        }
    }
}