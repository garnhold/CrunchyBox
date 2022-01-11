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
            static public ILValue GenerateObjectReferenceRead(Type type, ILValue buffer)
            {
                if(type.HasCustomAttributeOfType<EntityTypeAttribute>(true))
                    return buffer.GetILInvoke("ReadReference");

                return buffer.GetILInvoke("Read" + type.Name.StyleAsFunctionName() + "Reference");
            }

            static public ILStatement GenerateObjectReferenceWrite(ILValue src, ILValue buffer)
            {
                if (src.GetValueType().HasCustomAttributeOfType<EntityTypeAttribute>(true))
                    return buffer.GetILInvoke("WriteReference", src);

                return buffer.GetILInvoke("Write" + src.GetValueType().Name.StyleAsFunctionName() + "Reference", src);
            }
        }
    }
}