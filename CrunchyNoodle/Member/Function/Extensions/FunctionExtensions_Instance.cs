using System;

namespace Crunchy.Noodle
{
    using Dough;
    
    static public class FunctionExtensions_Instance
    {
        static public FunctionInstance CreateInstance(this Function item, TargetInstance target)
        {
            return new FunctionInstance(target, item);
        }

        static public FunctionInstance CreateWeakInstance(this Function item, object obj)
        {
            return item.CreateInstance(obj.GetWeakTarget());
        }

        static public FunctionInstance CreateStrongInstance(this Function item, object obj)
        {
            return item.CreateInstance(obj.GetStrongTarget());
        }
    }
}