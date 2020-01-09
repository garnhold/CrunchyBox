using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class GlobalLibrary
    {
        private Dictionary<string, Global> globals;

        public GlobalLibrary()
        {
            globals = new Dictionary<string, Global>();
        }

        public void AddGlobal(Global global)
        {
            globals[global.GetName()] = global;
        }

        public Global GetGlobal(string id)
        {
            return globals.GetValue(id);
        }

        public CmlScriptValue CreateScriptValue(string id, CmlScriptValue_Argument_Host host)
        {
            return GetGlobal(id).IfNotNull(g => g.CreateScriptValue(host));
        }
    }
}