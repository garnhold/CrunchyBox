using System;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Variable_Static_Readonly_Value : Variable_Static_Readonly
    {
        private string name;
        private object value;

        static public Variable_Static_Readonly_Value New(string name, Type type, object value)
        {
            return new Variable_Static_Readonly_Value(name, type, value);
        }
        static public Variable_Static_Readonly_Value New(string name, object value)
        {
            return New(name, value.GetTypeEX(), value);
        }
        static public Variable_Static_Readonly_Value New(object value)
        {
            return New("const", value);
        }

        protected override object GetStaticContentsInternal()
        {
            return value;
        }

        protected override string GetVariableNameInternal()
        {
            return name;
        }

        public Variable_Static_Readonly_Value(string n, Type t, object v) : base(t)
        {
            name = n;
            value = v;
        }
    }
}