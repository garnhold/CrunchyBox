using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class FieldInfoExtensions_Access
    {
        static public bool IsSetPublic(this FieldInfo item)
        {
            if (item.IsPublicField())
                return true;

            if (item.IsBackedPropertySetPublic())
                return true;

            return false;
        }

        static public bool IsGetPublic(this FieldInfo item)
        {
            if (item.IsPublicField())
                return true;

            if (item.IsBackedPropertyGetPublic())
                return true;

            return false;
        }
    }
}