using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Cart
{
    using Dough;
    using Salt;
    using Noodle;
    
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
                ILLocal type = block.CreateCementedLocal(value.GetILTypeEX());

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