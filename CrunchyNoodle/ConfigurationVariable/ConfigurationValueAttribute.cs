using System;

namespace Crunchy.Noodle
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Class)]
    public abstract class ConfigurationValueAttribute : Attribute
    {
        public abstract bool CheckOptionString(string option_string);
    }
}