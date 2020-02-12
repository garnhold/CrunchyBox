using System;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;
    
    public class RepresentationInfo_Attribute_Set : RepresentationInfo_Attribute
    {
        private RepresentationInfo_Set set_info;

        public RepresentationInfo_Attribute_Set(string n, RepresentationInfo_Set s) : base(n, s.GetRepresentationType())
        {
            set_info = s;
        }

        public override void SetRepresentationValue(CmlExecution execution, object representation, object value)
        {
            execution.GetCallContext().GetSetSpace()
                .GetSet(set_info)
                .SetAttribute(GetName(), value);
        }

        public override void SetVariableLink(CmlExecution execution, object representation, VariableInstance variable_instance, string group)
        {
            execution.GetCallContext().GetSetSpace()
                .GetSet(set_info)
                .SetAttributeLink(GetName(), variable_instance, group);
        }

        public override void AddRepresentationValue(CmlExecution execution, object representation, object value)
        {
            execution.GetCallContext().GetSetSpace()
                .GetSet(set_info)
                .AddAttributeChild(GetName(), value);
        }

        public override void SetEffigyLink(CmlExecution execution, object representation, VariableInstance variable_instance, EffigyClassInfo @class, string group)
        {
            execution.GetCallContext().GetSetSpace()
                .GetSet(set_info)
                .SetAttributeChildrenLink(GetName(), variable_instance, @class, group);
        }
    }
}