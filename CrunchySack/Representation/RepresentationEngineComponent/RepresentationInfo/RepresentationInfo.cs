using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;
    
    public abstract class RepresentationInfo : RepresentationEngineComponent
    {
        private string name;
        private Type representation_type;

        public const string UnamedChildren = "<unamed_children>";

        private bool PushToRepresentationInternal(CmlValue value, object representation, CmlContext context)
        {
            return false;
        }

        public RepresentationInfo(string n, Type r)
        {
            name = n;
            representation_type = r;
        }

        public void PushToRepresentation(CmlContext context, object representation, CmlValue value)
        {
            if (this.CallSpecializationMethodWithReturn<bool, CmlValue, object, CmlContext>(
                "PushToRepresentationInternal",
                value,
                representation,
                context) == false)
            {
                throw new CmlRuntimeError_InfoSupportException(value.GetTypeEX(), this);
            }
        }

        public string GetName()
        {
            return name;
        }

        public Type GetRepresentationType()
        {
            return representation_type;
        }
    }
}