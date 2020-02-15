using System;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class RepresentationInfo_Attribute_Value_Variable : RepresentationInfo_Attribute_Value
    {
        private Variable variable;

        public RepresentationInfo_Attribute_Value_Variable(string n, Variable v) : base(n, v.GetDeclaringType())
        {
            variable = v;
        }

        public RepresentationInfo_Attribute_Value_Variable(Variable v) : this(v.GetVariableName(), v) { }

        public override void SetRepresentationValue(CmlExecution execution, object representation, object value)
        {
            variable.SetContents(representation, value);
        }
    }

    static public partial class RepresentationEngineExtensions_Add
    {
        static public void AddAttributeValue(this RepresentationEngine item, string n, Variable v)
        {
            item.AddAttributeInfo(new RepresentationInfo_Attribute_Value_Variable(n, v));
        }

        static public void AddAttributeValue(this RepresentationEngine item, Variable v)
        {
            item.AddAttributeInfo(new RepresentationInfo_Attribute_Value_Variable(v));
        }
    }
}