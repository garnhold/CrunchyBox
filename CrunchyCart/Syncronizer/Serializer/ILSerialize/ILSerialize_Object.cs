using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Cart
{
    using Dough;
    using Salt;
    using Noodle;
    using Sodium;
    
    public partial class Syncronizer
    {
        static public partial class ILSerialize
        {
            static public ILValue GenerateObjectRead(Type type, ILValue buffer)
            {
                return GeneratePrimitiveObjectRead(type, buffer) ??
                    GenerateObjectReferenceRead(type, buffer) ??
                    GenerateInspectedObjectRead(type, buffer);
            }
            static public ILStatement GenerateObjectReadInto(ILValue dst, ILValue buffer)
            {
                return GenerateObjectRead(dst.GetValueType(), buffer)
                    .IfNotNull(v => new ILAssign(dst, v));
            }

            static public ILStatement GenerateObjectWrite(ILValue src, ILValue buffer)
            {
                return GeneratePrimitiveObjectWrite(src, buffer) ??
                    GenerateObjectReferenceWrite(src, buffer) ??
                    GenerateInspectedObjectWrite(src, buffer);
            }
        }
    }
}