using System;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;
    
    public class RepresentationInfoSetChildrenSelector_SingleIndex : RepresentationInfoSetChildrenSelector
    {
        private Variable variable;

        private void SolidifyInstanceInternal(CmlValue_Link value, object representation, EffigyLink effigy_link, CmlContext context)
        {
            context.AddVariableLink(
                value.GetGroup(),

                new VariableLink_Simple_Process(
                    new VariableNode(value.GetVariableInstance()),
                    new VariableNode(variable.CreateStrongInstance(representation)),
                    o => effigy_link.GetValues().FindIndexOf(o),
                    i => effigy_link.GetValues().Get(i.ConvertEX<int>())
                )
            );
        }

        public RepresentationInfoSetChildrenSelector_SingleIndex(string n, Variable v) : base(n)
        {
            variable = v;
        }
    }

    static public partial class RepresentationInfoSetSelectableChildrenExtensions_Add
    {
        static public void AddSingleIndexChildSelectorLinkInfo(this RepresentationInfoSet_SelectableChildren item, string n, Variable v)
        {
            item.AddSelector(new RepresentationInfoSetChildrenSelector_SingleIndex(n, v));
        }
        static public void AddSingleIndexChildSelectorLinkInfo(this RepresentationInfoSet_SelectableChildren item, Variable v)
        {
            item.AddSingleIndexChildSelectorLinkInfo(v.GetVariableName(), v);
        }

        static public void AddSingleIndexChildSelectorLinkInfo(this RepresentationInfoSet_SelectableChildren item, string n, string p)
        {
            item.AddSingleIndexChildSelectorLinkInfo(n, item.GetRepresentationType().GetVariableByPath(p));
        }

        static public void AddSingleIndexChildSelectorLinkInfo<REPRESENTATION_TYPE>(this RepresentationInfoSet_SelectableChildren item, string n, Variable v, Operation<bool, REPRESENTATION_TYPE> i)
        {
            item.AddSingleIndexChildSelectorLinkInfo(n, new Variable_Blockable<REPRESENTATION_TYPE>(v, i));
        }

        static public void AddSingleIndexChildSelectorLinkInfo<REPRESENTATION_TYPE>(this RepresentationInfoSet_SelectableChildren item, Variable v, Operation<bool, REPRESENTATION_TYPE> i)
        {
            item.AddSingleIndexChildSelectorLinkInfo<REPRESENTATION_TYPE>(v.GetVariableName(), v, i);
        }

        static public void AddSingleIndexChildSelectorLinkInfo<REPRESENTATION_TYPE, VALUE_TYPE>(this RepresentationInfoSet_SelectableChildren item, string n, Process<REPRESENTATION_TYPE, VALUE_TYPE> a, Operation<VALUE_TYPE, REPRESENTATION_TYPE> r, Operation<bool, REPRESENTATION_TYPE> i)
        {
            item.AddSingleIndexChildSelectorLinkInfo<REPRESENTATION_TYPE>(
                new Variable_Operation<REPRESENTATION_TYPE, VALUE_TYPE>(n, a, r),
                i
            );
        }
    }
}