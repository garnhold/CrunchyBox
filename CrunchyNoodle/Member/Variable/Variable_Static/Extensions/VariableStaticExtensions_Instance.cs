using System;

using CrunchyDough;

namespace CrunchyNoodle
{
    static public class VariableStaticExtensions_Instance
    {
        static public VariableInstance CreateInstance(this Variable_Static item)
        {
            return item.CreateInstance(TargetInstance_Static.INSTANCE);
        }
    }
}