using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
    public class Global_Direct_VariableInstance : Global_Direct
    {
        private VariableInstance variable;

        protected override CmlScriptValue_Argument CreateScriptValueArgument()
        {
            return new CmlScriptValue_Argument_Single_VariableInstance(variable);
        }

        public Global_Direct_VariableInstance(string n, VariableInstance v) : base(n)
        {
            variable = v;
        }

        public Global_Direct_VariableInstance(VariableInstance v) : this(v.GetVariable().GetVariableName(), v) { }
    }
}