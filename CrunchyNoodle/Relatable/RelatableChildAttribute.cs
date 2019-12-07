using System;

namespace Crunchy.Noodle
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Method)]
    public class RelatableChildAttribute : Attribute
    {
    }
}