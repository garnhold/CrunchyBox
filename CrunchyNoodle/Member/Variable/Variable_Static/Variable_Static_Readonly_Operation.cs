using System;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Variable_Static_Readonly_Operation : Variable_Static_Readonly
    {
        private string name;
        private Operation<object> operation;

        static public Variable_Static_Readonly_Operation New(string name, Type type, Operation<object> operation)
        {
            return new Variable_Static_Readonly_Operation(name, type, operation);
        }

        protected override object GetStaticContentsInternal()
        {
            return operation();
        }

        protected override string GetVariableNameInternal()
        {
            return name;
        }

        public Variable_Static_Readonly_Operation(string n, Type t, Operation<object> o) : base(t)
        {
            name = n;
            operation = o;
        }
    }
}