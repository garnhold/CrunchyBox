using System;

namespace CrunchyNoodle
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class ConversionAttribute : Attribute
    {
    }
}