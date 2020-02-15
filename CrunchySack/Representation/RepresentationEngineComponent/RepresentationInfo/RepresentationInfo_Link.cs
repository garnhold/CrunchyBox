using System;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class RepresentationInfo_Link : RepresentationInfo
    {
        private Variable variable;

        public RepresentationInfo_Link(string n, Variable v) : base(n, v.GetDeclaringType())
        {
            variable = v;
        }

        public override void SetValue(CmlExecution execution, object representation, object value)
        {
            variable.SetContents(representation, value);
        }

        public override void LinkValue(CmlExecution execution, object representation, VariableInstance variable_instance, HasInfo info)
        {
            execution.AddVariableLink(
                info.GetInfoValue("group"),

                new VariableLink_Simple_Direct(
                    new VariableNode(variable_instance),
                    new VariableNode(variable.CreateStrongInstance(representation))
                )
            );
        }
    }

    static public partial class RepresentationEngineExtensions_Add
    {
        static public void AddLinkInfo(this RepresentationEngine item, string n, Variable v)
        {
            item.AddInfo(new RepresentationInfo_Link(n, v));
        }
        static public void AddLinkInfo(this RepresentationEngine item, Variable v)
        {
            item.AddLinkInfo(v.GetVariableName(), v);
        }

        static public void AddLinkInfo<REPRESENTATION_TYPE>(this RepresentationEngine item, string n, string p)
        {
            item.AddLinkInfo(n, typeof(REPRESENTATION_TYPE).GetVariableByPath(p));
        }

        static public void AddLinkInfo<REPRESENTATION_TYPE>(this RepresentationEngine item, string n, Variable v, Operation<bool, REPRESENTATION_TYPE> i)
        {
            item.AddLinkInfo(n, new Variable_Blockable<REPRESENTATION_TYPE>(v, i));
        }

        static public void AddLinkInfo<REPRESENTATION_TYPE>(this RepresentationEngine item, Variable v, Operation<bool, REPRESENTATION_TYPE> i)
        {
            item.AddLinkInfo<REPRESENTATION_TYPE>(v.GetVariableName(), v, i);
        }

        static public void AddLinkInfo<REPRESENTATION_TYPE, VALUE_TYPE>(this RepresentationEngine item, string n, Process<REPRESENTATION_TYPE, VALUE_TYPE> a, Operation<VALUE_TYPE, REPRESENTATION_TYPE> r, Operation<bool, REPRESENTATION_TYPE> i)
        {
            item.AddLinkInfo<REPRESENTATION_TYPE>(
                new Variable_Operation<REPRESENTATION_TYPE, VALUE_TYPE>(n, a, r),
                i
            );
        }
    }
}