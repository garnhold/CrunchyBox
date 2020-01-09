using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class ILValueExtensions_Cast
    {
        static private ILValue GetILCast(this ILValue item, Type destination_type, Operation<ILCast, Type, ILValue> operation)
        {
            if (item.GetValueType().CanILTreatAs(destination_type))
                return item;

            return operation(destination_type, item);
        }

        static public ILValue GetILThinCast(this ILValue item, Type destination_type)
        {
            return item.GetILCast(destination_type, ILCast.NewThinCast);
        }
        static public ILValue GetILImplicitCast(this ILValue item, Type destination_type)
        {
            return item.GetILCast(destination_type, ILCast.NewImplicitCast);
        }
        static public ILValue GetILExplicitCast(this ILValue item, Type destination_type)
        {
            return item.GetILCast(destination_type, ILCast.NewExplicitCast);
        }
    }
}