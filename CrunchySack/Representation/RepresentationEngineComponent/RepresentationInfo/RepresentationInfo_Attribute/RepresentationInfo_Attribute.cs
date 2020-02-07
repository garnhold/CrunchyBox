using System;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;
    
    public abstract class RepresentationInfo_Attribute : RepresentationInfo
    {
        private string name;
        private Type representation_type;

        public RepresentationInfo_Attribute(string n, Type r)
        {
            name = n;
            representation_type = r;
        }

        public virtual void SetRepresentationValue(CmlExecution execution, object representation, object value)
        {
            throw new CmlRuntimeError_AttributeSupportException("setting values", this);
        }

        public virtual VariableLink CreateVariableLink(CmlExecution execution, object representation, VariableInstance variable_instance)
        {
            throw new CmlRuntimeError_AttributeSupportException("linking values", this);
        }

        public virtual void AddRepresentationValue(CmlExecution execution, object representation, object value)
        {
            throw new CmlRuntimeError_AttributeSupportException("setting children", this);
        }

        public virtual EffigyLink CreateEffigyLink(CmlExecution execution, object representation, VariableInstance variable_instance, EffigyClassInfo @class)
        {
            throw new CmlRuntimeError_AttributeSupportException("linking children", this);
        }

        public virtual void InjectRepresentationFunction(CmlExecution execution, object representation, FunctionSyncro function_syncro)
        {
            throw new CmlRuntimeError_AttributeSupportException("function", this);
        }

        public string GetName()
        {
            return name;
        }

        public override Type GetRepresentationType()
        {
            return representation_type;
        }
    }
}