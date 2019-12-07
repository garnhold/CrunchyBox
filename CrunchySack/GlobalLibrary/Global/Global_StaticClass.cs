using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class Global_StaticClass<T> : Global_StaticClass
    {
        static public readonly Global_StaticClass<T> INSTANCE = new Global_StaticClass<T>();

        private Global_StaticClass() : base(typeof(T)) { }
    }

    public class Global_StaticClass : Global
    {
        private Type static_type;

        public Global_StaticClass(string n, Type st) : base(n)
        {
            static_type = st;
        }

        public Global_StaticClass(Type st) : this(st.Name, st) { }

        public override CmlScriptValue CreateScriptValue(CmlScriptValue_Argument_Host host)
        {
            return new CmlScriptValue_StaticClass(static_type);
        }
    }
}