using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class ILValueExtensions_Fields
    {
        static public IEnumerable<ILField> GetAllInstanceILFields(this ILValue item)
        {
            return item.GetValueType()
                .GetAllInstanceFields()
                .Convert(f => item.GetILField(f));
        }

        static public IEnumerable<ILField> GetFilteredInstanceILFields(this ILValue item, IEnumerable<Filterer<FieldInfo>> filters)
        {
            return item.GetValueType()
                .GetFilteredInstanceFields(filters)
                .Convert(f => item.GetILField(f));
        }
        static public IEnumerable<ILField> GetFilteredInstanceILFields(this ILValue item, params Filterer<FieldInfo>[] filters)
        {
            return item.GetFilteredInstanceILFields((IEnumerable<Filterer<FieldInfo>>)filters);
        }
    }
}