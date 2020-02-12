using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;
    
    public class RepresentationInfo_Children : RepresentationInfo
    {
        public RepresentationInfo_Children(Type r) : base(r)
        {
        }

        public virtual void AddRepresentationValue(CmlExecution execution, object representation, object value)
        {
            throw new CmlRuntimeError_ChildrenSupportException("setting values", this);
        }

        public virtual void SetEffigyLink(CmlExecution execution, object representation, VariableInstance variable_instance, EffigyClassInfo @class, string group)
        {
            throw new CmlRuntimeError_ChildrenSupportException("linking values", this);
        }
    }
}