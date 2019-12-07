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

        public override void SetRepresentationValue(object representation, object value)
        {
            variable.SetContents(representation, value);
        }
    }
}