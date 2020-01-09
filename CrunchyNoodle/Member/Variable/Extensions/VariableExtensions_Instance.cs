using System;

namespace Crunchy.Noodle
{
    using Dough;
    
    static public class VariableExtensions_Instance
    {
        static public VariableInstance CreateInstance(this Variable item, TargetInstance target)
        {
            return new VariableInstance(target, item);
        }

        static public VariableInstance CreateWeakInstance(this Variable item, object obj)
        {
            return item.CreateInstance(obj.GetWeakTarget());
        }

        static public VariableInstance CreateStrongInstance(this Variable item, object obj)
        {
            return item.CreateInstance(obj.GetStrongTarget());
        }
    }
}