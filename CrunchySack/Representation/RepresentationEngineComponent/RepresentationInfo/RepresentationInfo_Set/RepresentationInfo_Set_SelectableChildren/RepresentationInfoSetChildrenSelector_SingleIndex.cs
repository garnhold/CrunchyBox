using System;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;
    
    public class RepresentationInfoSetChildrenSelector_SingleIndex : RepresentationInfoSetChildrenSelector
    {
        private Variable variable;

        public RepresentationInfoSetChildrenSelector_SingleIndex(string n, Variable v) : base(n)
        {
            variable = v;
        }

        public override void SolidifyInstance(CmlExecution execution, object representation, EffigyLink effigy_link, CmlSetAttribute attribute)
        {
            execution.AddVariableLink(
                attribute.GetGroup(),

                new VariableLink_Simple_Process(
                    new VariableNode(attribute.GetVariableInstance()),
                    new VariableNode(variable.CreateStrongInstance(representation)),
                    o => effigy_link.GetValues().FindIndexOf(o),
                    i => effigy_link.GetValues().Get(i.ConvertEX<int>())
                )
            );
        }
    }

    static public partial class RepresentationInfoSetSelectableChildrenExtensions_Add
    {
        static public void AddSingleIndexChildSelectorLink(this RepresentationInfo_Set_SelectableChildren item, string n, Variable v)
        {
            item.AddSelector(new RepresentationInfoSetChildrenSelector_SingleIndex(n, v));
        }
        static public void AddSingleIndexChildSelectorLink(this RepresentationInfo_Set_SelectableChildren item, Variable v)
        {
            item.AddSingleIndexChildSelectorLink(v.GetVariableName(), v);
        }

        static public void AddSingleIndexChildSelectorLink(this RepresentationInfo_Set_SelectableChildren item, string n, string p)
        {
            item.AddSingleIndexChildSelectorLink(n, item.GetRepresentationType().GetVariableByPath(p));
        }

        static public void AddSingleIndexChildSelectorLink<REPRESENTATION_TYPE>(this RepresentationInfo_Set_SelectableChildren item, string n, Variable v, Operation<bool, REPRESENTATION_TYPE> i)
        {
            item.AddSingleIndexChildSelectorLink(n, new Variable_Blockable<REPRESENTATION_TYPE>(v, i));
        }

        static public void AddSingleIndexChildSelectorLink<REPRESENTATION_TYPE>(this RepresentationInfo_Set_SelectableChildren item, Variable v, Operation<bool, REPRESENTATION_TYPE> i)
        {
            item.AddSingleIndexChildSelectorLink<REPRESENTATION_TYPE>(v.GetVariableName(), v, i);
        }

        static public void AddSingleIndexChildSelectorLink<REPRESENTATION_TYPE, VALUE_TYPE>(this RepresentationInfo_Set_SelectableChildren item, string n, Process<REPRESENTATION_TYPE, VALUE_TYPE> a, Operation<VALUE_TYPE, REPRESENTATION_TYPE> r, Operation<bool, REPRESENTATION_TYPE> i)
        {
            item.AddSingleIndexChildSelectorLink<REPRESENTATION_TYPE>(
                new Variable_Operation<REPRESENTATION_TYPE, VALUE_TYPE>(n, a, r),
                i
            );
        }
    }
}