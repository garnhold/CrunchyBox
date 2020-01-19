using System;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class RepresentationInfo_Attribute_Link : RepresentationInfo_Attribute
    {
        private Variable variable;

        public RepresentationInfo_Attribute_Link(string n, Variable v) : base(n, v.GetDeclaringType())
        {
            variable = v;
        }

        public RepresentationInfo_Attribute_Link(Variable v) : this(v.GetVariableName(), v) { }

        public override void SetRepresentationValue(object representation, object value)
        {
            GetRepresentationVariable().SetContents(representation, value);
        }

        public override Variable GetRepresentationVariable()
        {
            return variable;
        }
    }

    static public partial class RepresentationEngineExtensions_Add
    {
        static public void AddAttributeLink(this RepresentationEngine item, string n, Variable v)
        {
            item.AddAttributeInfo(
                new RepresentationInfo_Attribute_Link(n, v)
            );
        }
        static public void AddAttributeLink(this RepresentationEngine item, Variable v)
        {
            item.AddAttributeInfo(
                new RepresentationInfo_Attribute_Link(v)
            );
        }
    }
}