using System;

namespace Crunchy.Noodle
{
    using Dough;
    
    static public class TargetInstanceExtensions_Type
    {
        static public Type GetTargetType(this TargetInstance item)
        {
            return item.GetTarget().GetTypeEX();
        }
    }
}