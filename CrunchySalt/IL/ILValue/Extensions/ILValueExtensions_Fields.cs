using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class ILValueExtensions_Fields
    {
        static public ILField GetILField(this ILValue item, FieldInfo field)
        {
            return field.IfNotNull(f => new ILField(item, f));
        }
        static public ILField GetILField(this ILValue item, string name)
        {
            return item.GetILField(item.GetValueType().GetInstanceField(name));
        }
    }
}