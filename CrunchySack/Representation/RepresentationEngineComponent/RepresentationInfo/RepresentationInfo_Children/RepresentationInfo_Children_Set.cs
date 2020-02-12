using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;
    
    public class RepresentationInfo_Children_Set : RepresentationInfo_Children
    {
        private RepresentationInfo_Set set_info;

        public RepresentationInfo_Children_Set(RepresentationInfo_Set s) : base(s.GetRepresentationType())
        {
            set_info = s;
        }

        public override void AddRepresentationValue(CmlExecution execution, object representation, object value)
        {
            execution.GetCallContext().GetSetSpace()
                .GetSet(set_info)
                .AddChild(value);
        }

        public override void SetEffigyLink(CmlExecution execution, object representation, VariableInstance variable_instance, EffigyClassInfo @class, string group)
        {
            execution.GetCallContext().GetSetSpace()
                .GetSet(set_info)
                .SetChildrenLink(variable_instance, @class, group);
        }
    }
}