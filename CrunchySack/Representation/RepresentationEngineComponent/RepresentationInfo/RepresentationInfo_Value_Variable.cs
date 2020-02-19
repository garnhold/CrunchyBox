using System;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class RepresentationInfo_Value_Variable : RepresentationInfo_Value
    {
        private Variable variable;

        public RepresentationInfo_Value_Variable(string n, Variable v) : base(n, v.GetDeclaringType())
        {
            variable = v;
        }

        public override void SetValue(CmlContext context, object representation, object value)
        {
            variable.SetContents(representation, value);
        }
    }

    static public partial class RepresentationEngineExtensions_Add
    {
        static public void AddValueInfo(this RepresentationEngine item, string n, Variable v)
        {
            item.AddInfo(new RepresentationInfo_Value_Variable(n, v));
        }

        static public void AddValueInfo(this RepresentationEngine item, Variable v)
        {
            item.AddValueInfo(v.GetVariableName(), v);
        }

        static public void AddValueInfo<REPRESENTATION_TYPE>(this RepresentationEngine item, string n, string p)
        {
            item.AddValueInfo(n, typeof(REPRESENTATION_TYPE).GetVariableByPath(p));
        }
    }
}