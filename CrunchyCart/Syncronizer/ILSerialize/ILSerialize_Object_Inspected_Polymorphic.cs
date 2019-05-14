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
            static private ILValue GenerateInspectedObjectRead_Polymorphic(Type type, ILValue buffer)
            {
                return typeof(TypeSerializer).GetILInvoke("ReadObject",
                    buffer.GetILInvoke("ReadType"),
                    buffer
                );
            }

            static private ILStatement GenerateInspectedObjectWrite_Polymorphic(ILValue value, ILValue buffer)
            {
                ILBlock block = new ILBlock();
                ILLocal type = block.CreateLocal(value.GetILTypeEX(), true);

                block.AddStatement(buffer.GetILInvoke("WriteType", type));
                block.AddStatement(
                    new ILIf(
                        type.GetILIsNotNull(),
                        typeof(TypeSerializer).GetILInvoke("WriteObject", value)
                    )
                );

                return block;
            }
        }
    }
}