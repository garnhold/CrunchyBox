using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract class Global
    {
        private string name;

        public abstract CmlScriptValue CreateScriptValue(CmlScriptValue_Argument_Host host);

        public Global(string n)
        {
            name = n;
        }

        public string GetName()
        {
            return name;
        }
    }
}