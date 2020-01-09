using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class FieldInfoExtensions_Backing
    {
        static public PropertyInfo GetBackedProperty(this FieldInfo item)
        {
            return item.DeclaringType.GetMemberProperty(item.Name.StyleAsPropertyName());
        }

        static public bool IsBackingField(this FieldInfo item)
        {
            if (item.GetBackedProperty() != null)
                return true;

            return false;
        }

        static public bool IsBackedPropertySetPublic(this FieldInfo item)
        {
            if (item.GetBackedProperty().IfNotNull(p => p.IsSetPublic()))
                return true;

            return false;
        }

        static public bool IsBackedPropertyGetPublic(this FieldInfo item)
        {
            if (item.GetBackedProperty().IfNotNull(p => p.IsGetPublic()))
                return true;

            return false;
        }
    }
}