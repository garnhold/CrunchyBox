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
            static public ILValue GenerateInspectedObjectRead(Type type, ILValue buffer)
            {
                if (type.HasChildTypes())
                    return GenerateInspectedObjectRead_Polymorphic(type, buffer);

                if (type.IsNullable())
                    return GenerateInspectedObjectRead_Nullable(type, buffer);

                return TypeSerializer.GetTypeSerializer(type).GenerateRead(buffer);
            }

            static public ILStatement GenerateInspectedObjectWrite(ILValue src, ILValue buffer)
            {
                if (src.GetValueType().HasChildTypes())
                    return GenerateInspectedObjectWrite_Polymorphic(src, buffer);

                if (src.GetValueType().IsNullable())
                    return GenerateInspectedObjectWrite_Nullable(src, buffer);

                return TypeSerializer.GetTypeSerializer(src.GetValueType()).GenerateWrite(src, buffer);
            }
        }
    }
}