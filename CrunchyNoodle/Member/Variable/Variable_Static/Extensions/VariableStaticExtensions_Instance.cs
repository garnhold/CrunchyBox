using System;

namespace Crunchy.Noodle
{
    using Dough;
    
    static public class VariableStaticExtensions_Instance
    {
        static public VariableInstance CreateInstance(this Variable_Static item)
        {
            return item.CreateInstance(TargetInstance_Static.INSTANCE);
        }
    }
}