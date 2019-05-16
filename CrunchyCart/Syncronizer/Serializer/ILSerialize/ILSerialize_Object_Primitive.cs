using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchySodium;

namespace CrunchyCart
{
    public partial class Syncronizer
    {
        static public partial class ILSerialize
        {
            static public ILValue GeneratePrimitiveObjectRead(Type type, ILValue buffer)
            {
                return buffer.GetILInvoke("Read" + type.Name.StyleAsFunctionName());
            }

            static public ILStatement GeneratePrimitiveObjectWrite(ILValue src, ILValue buffer)
            {
                return buffer.GetILInvoke("Write" + src.GetValueType().Name.StyleAsFunctionName(), src);
            }
        }
    }
}