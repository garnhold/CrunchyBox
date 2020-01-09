using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sodium
{
    using Dough;
    using Noodle;
    using Salt;
    
    static public class ILValueSRCExtensions_Props
    {
        static public ILProp GetILProp(this ILValue item, string name)
        {
            return item.GetILProp(item.GetValueType().GetInstanceProp(name));
        }

        static public IEnumerable<ILProp> GetAllInstanceILProps(this ILValue item)
        {
            return item.GetValueType()
                .GetAllInstanceProps()
                .Convert(p => item.GetILProp(p));
        }

        static public IEnumerable<ILProp> GetFilteredInstanceILProps(this ILValue item, IEnumerable<Filterer<PropInfoEX>> filters)
        {
            return item.GetValueType()
                .GetFilteredInstanceProps(filters)
                .Convert(p => item.GetILProp(p));
        }
        static public IEnumerable<ILProp> GetFilteredInstanceILProps(this ILValue item, params Filterer<PropInfoEX>[] filters)
        {
            return item.GetFilteredInstanceILProps((IEnumerable<Filterer<PropInfoEX>>)filters);
        }
    }
}