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
            static private ILValue GenerateInspectedObjectRead_Nullable(Type type, ILValue buffer)
            {
                return new ILIfValue(
                    buffer.GetILInvoke("ReadBoolean"),
                    TypeSerializer.GetTypeSerializer(type).GenerateRead(buffer),
                    null
                );
            }

            static private ILStatement GenerateInspectedObjectWrite_Nullable(ILValue value, ILValue buffer)
            {
                return new ILIf(
                    value.GetILIsNotNull(),
                    new ILBlock(
                        buffer.GetILInvoke("WriteBoolean", true),
                        TypeSerializer.GetTypeSerializer(value.GetValueType()).GenerateWrite(value, buffer)
                    ),
                    new ILBlock(
                        buffer.GetILInvoke("WriteBoolean", false)
                    )
                );
            }
        }
    }
}