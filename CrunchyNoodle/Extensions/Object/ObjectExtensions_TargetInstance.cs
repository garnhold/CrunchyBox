using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    static public class ObjectExtensions_TargetInstance
    {
        static public TargetInstance GetWeakTarget(this object item)
        {
            return new TargetInstance_Weak(item);
        }

        static public TargetInstance GetStrongTarget(this object item)
        {
            return new TargetInstance_Strong(item);
        }
    }
}