using System;

namespace Crunchy.Noodle
{
    using Dough;
    
    static public class VariableInstanceExtensions_Contents
    {
        static public bool ClearContents(this VariableInstance item)
        {
            return item.GetVariable().ClearContents(item.GetTarget());
        }

        static public bool CreateContents(this VariableInstance item, Type type)
        {
            return item.GetVariable().CreateContents(item.GetTarget(), type);
        }

        static public bool EnsureContents(this VariableInstance item, Type type)
        {
            return item.GetVariable().EnsureContents(item.GetTarget(), type);
        }
    }
}