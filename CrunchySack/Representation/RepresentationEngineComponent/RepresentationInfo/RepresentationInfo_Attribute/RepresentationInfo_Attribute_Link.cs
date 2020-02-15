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

        public override void SetRepresentationValue(CmlExecution execution, object representation, object value)
        {
            variable.SetContents(representation, value);
        }

        public override void SetVariableLink(CmlExecution execution, object representation, VariableInstance variable_instance, string group)
        {
            execution.AddVariableLink(
                group,

                new VariableLink_Simple_Direct(
                    new VariableNode(variable_instance),
                    new VariableNode(variable.CreateStrongInstance(representation))
                )
            );
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

        static public void AddAttributeLink<REPRESENTATION_TYPE>(this RepresentationEngine item, string n, string p)
        {
            item.AddAttributeLink(n, typeof(REPRESENTATION_TYPE).GetVariableByPath(p));
        }

        static public void AddAttributeLink<REPRESENTATION_TYPE>(this RepresentationEngine item, string n, Variable v, Operation<bool, REPRESENTATION_TYPE> i)
        {
            item.AddAttributeLink(n, new Variable_Blockable<REPRESENTATION_TYPE>(v, i));
        }

        static public void AddAttributeLink<REPRESENTATION_TYPE>(this RepresentationEngine item, Variable v, Operation<bool, REPRESENTATION_TYPE> i)
        {
            item.AddAttributeLink<REPRESENTATION_TYPE>(v.GetVariableName(), v, i);
        }

        static public void AddAttributeLink<REPRESENTATION_TYPE, VALUE_TYPE>(this RepresentationEngine item, string n, Process<REPRESENTATION_TYPE, VALUE_TYPE> a, Operation<VALUE_TYPE, REPRESENTATION_TYPE> r, Operation<bool, REPRESENTATION_TYPE> i)
        {
            item.AddAttributeLink<REPRESENTATION_TYPE>(
                new Variable_Operation<REPRESENTATION_TYPE, VALUE_TYPE>(n, a, r),
                i
            );
        }
    }
}