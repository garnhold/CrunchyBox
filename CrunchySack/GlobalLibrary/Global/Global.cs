using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
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