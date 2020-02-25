using System;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class RepresentationInfo_Value : RepresentationInfo
    {
        private Variable variable;

        private bool PushToRepresentation(CmlValue_SystemValue value, object representation, CmlContext context)
        {
            variable.SetContents(representation, value.GetSystemValue());

            return true;
        }

        public RepresentationInfo_Value(string n, Variable v) : base(n, v.GetDeclaringType())
        {
            variable = v;
        }
    }

    static public partial class RepresentationEngineExtensions_Add
    {
        static public void AddValueInfo(this RepresentationEngine item, string n, Variable v)
        {
            item.AddInfo(new RepresentationInfo_Value(n, v));
        }
        static public void AddValueInfo(this RepresentationEngine item, Variable v)
        {
            item.AddValueInfo(v.GetVariableName(), v);
        }

        static public void AddValueInfo<REPRESENTATION_TYPE>(this RepresentationEngine item, string n, string p)
        {
            item.AddValueInfo(n, typeof(REPRESENTATION_TYPE).GetVariableByPath(p));
        }

        static public void AddValueInfo<REPRESENTATION_TYPE, VALUE_TYPE>(this RepresentationEngine item, string n, Process<REPRESENTATION_TYPE, VALUE_TYPE> p)
        {
            item.AddValueInfo(
                new Variable_Operation<REPRESENTATION_TYPE, VALUE_TYPE>(n, p, null)
            );
        }
    }
}