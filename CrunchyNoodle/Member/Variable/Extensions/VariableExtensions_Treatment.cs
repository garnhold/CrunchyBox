using System;

namespace Crunchy.Noodle
{
    using Dough;
    
    static public class VariableExtensions_Treatment
    {
        static public bool IsVariableArray(this Variable item)
        {
            if (item.GetVariableType().IsArray)
                return true;

            return false;
        }

        static public bool IsVariableTypicalIEnumerable(this Variable item)
        {
            if (item.GetVariableType().IsTypicalIEnumerable())
                return true;

            return false;
        }
    }
}