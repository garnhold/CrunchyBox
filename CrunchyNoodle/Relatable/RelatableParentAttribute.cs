using System;

namespace CrunchyNoodle
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Method)]
    public class RelatableParentAttribute : Attribute
    {
    }
}