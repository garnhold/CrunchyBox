using System;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;
    
    public class RepresentationInfoSetChildrenSelector_Index : RepresentationInfoSetChildrenSelector
    {
        private Variable variable;

        public RepresentationInfoSetChildrenSelector_Index(string n, Variable v) : base(n)
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
}