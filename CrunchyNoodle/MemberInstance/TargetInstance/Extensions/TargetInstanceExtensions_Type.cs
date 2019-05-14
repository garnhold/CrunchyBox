using System;

using CrunchyDough;

namespace CrunchyNoodle
{
    static public class TargetInstanceExtensions_Type
    {
        static public Type GetTargetType(this TargetInstance item)
        {
            return item.GetTarget().GetTypeEX();
        }
    }
}