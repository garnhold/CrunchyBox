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
        public class ConstantSubManager_Type : ConstantSubManager<Type>
        {
            protected override Type ReadConstantValue(Buffer buffer)
            {
                return Types.GetFilteredTypes(
                    Filterer_Type.IsNamed(buffer.ReadString())
                ).GetFirst();
            }

            protected override void WriteConstantValue(Type value, Buffer buffer)
            {
                buffer.WriteString(value.Name);
            }

            public ConstantSubManager_Type(ConstantManager m) : base(m) { }
        }
    }
}