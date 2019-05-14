using System;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class Variable_Static_Value : Variable_Static
    {
        private string name;
        private object current_value;

        static public Variable_Static_Value New(string name, Type type, object value)
        {
            return new Variable_Static_Value(name, type, value);
        }
        static public Variable_Static_Value New(string name, Type type)
        {
            return New(name, type, null);
        }
        static public Variable_Static_Value New(Type type)
        {
            return New("static", type);
        }

        protected override void SetStaticContentsInternal(object value)
        {
 	        current_value = value;
        }

        protected override object GetStaticContentsInternal()
        {
 	        return current_value;
        }

        protected override string GetVariableNameInternal()
        {
            return name;
        }

        public Variable_Static_Value(string n, Type t, object v) : base(t)
        {
            name = n;
            current_value = v;
        }
    }
}