using System;

namespace CrunchyDough
{
    public class ForTypeAttribute : Attribute
    {
        private Type target_type;
        private bool does_include_children;

        public ForTypeAttribute(Type t, bool c)
        {
            target_type = t;
            does_include_children = c;
        }

        public bool IsFor(Type type)
        {
            if (target_type.EqualsEX(type))
                return true;

            if (does_include_children)
            {
                if (type.CanBeTreatedAs(target_type))
                    return true;
            }

            return false;
        }

        public Type GetTargetType()
        {
            return target_type;
        }

        public bool DoesIncludeChildren()
        {
            return does_include_children;
        }
    }
}