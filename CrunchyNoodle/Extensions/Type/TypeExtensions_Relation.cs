using System;

namespace Crunchy.Noodle
{
    using Dough;
    
    static public class TypeExtensions_Relation
    {
        static public bool IsImmediateParentOf(this Type item, Type type, bool flatten_interfaces = false)
        {
            if (type.BaseType == item)
                return true;

            if (type.GetImmediateInterfaces(flatten_interfaces).Has(item))
                return true;

            return false;
        }

        static public bool IsImmediateChildOf(this Type item, Type type, bool flatten_interfaces = false)
        {
            if (type.IsImmediateParentOf(item, flatten_interfaces))
                return true;

            return false;
        }
    }
}