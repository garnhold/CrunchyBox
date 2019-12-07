using System;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Variable_This : Variable
    {
        static public Variable_This New(Type d)
        {
            return new Variable_This(d);
        }

        protected override bool SetContentsInternal(object target, object value)
        {
            throw new InvalidOperationException("Cannot set the contents of a Variable_This.");
        }

        protected override object GetContentsInternal(object target)
        {
            return target;
        }

        protected override string GetVariableNameInternal()
        {
            return "this";
        }

        public Variable_This(Type d) : base(d, d) { }
    }
}