using System;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;
    
    public class RepresentationInfo_SetMember : RepresentationInfo
    {
        private RepresentationInfoSet set;

        public RepresentationInfo_SetMember(string n, RepresentationInfoSet s) : base(n, s.GetRepresentationType())
        {
            set = s;
        }

        public override void SetValue(CmlExecution execution, object representation, object value)
        {
            execution.GetCallContext().GetSetSpace()
                .GetSet(set)
                .SetValue(GetName(), value);
        }

        public override void LinkValue(CmlExecution execution, object representation, VariableInstance variable_instance, HasInfo info)
        {
            execution.GetCallContext().GetSetSpace()
                .GetSet(set)
                .LinkValue(GetName(), variable_instance, info);
        }

        public override void LinkValueWithEntity(CmlExecution execution, object representation, VariableInstance variable_instance, CmlEntity entity, HasInfo info)
        {
            execution.GetCallContext().GetSetSpace()
                .GetSet(set)
                .LinkValueWithEntity(GetName(), variable_instance, entity, info);
        }
    }
}