using System;

using CrunchyDough;

namespace CrunchyNoodle
{
    public abstract class Variable_Static_Readonly : Variable_Static
    {
        protected override void SetStaticContentsInternal(object value)
        {
            throw new InvalidOperationException("Cannot set the contents of a Variable_Static_Readonly.");
        }

        public Variable_Static_Readonly(Type t) : base(t) { }
    }
}