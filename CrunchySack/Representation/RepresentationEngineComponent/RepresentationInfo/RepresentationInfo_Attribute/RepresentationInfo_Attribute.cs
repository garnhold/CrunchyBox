using System;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;
    
    public abstract class RepresentationInfo_Attribute : RepresentationInfo
    {
        private string name;

        public RepresentationInfo_Attribute(string n, Type r) : base(r)
        {
            name = n;
        }

        public virtual void SetRepresentationValue(CmlExecution execution, object representation, object value)
        {
            throw new CmlRuntimeError_AttributeSupportException("setting values", this);
        }

        public virtual void SetVariableLink(CmlExecution execution, object representation, VariableInstance variable_instance, string group)
        {
            throw new CmlRuntimeError_AttributeSupportException("linking values", this);
        }

        public virtual void AddRepresentationValue(CmlExecution execution, object representation, object value)
        {
            throw new CmlRuntimeError_AttributeSupportException("setting children", this);
        }

        public virtual void SetEffigyLink(CmlExecution execution, object representation, VariableInstance variable_instance, EffigyClassInfo @class, string group)
        {
            throw new CmlRuntimeError_AttributeSupportException("linking children", this);
        }

        public virtual void SetRepresentationFunction(CmlExecution execution, object representation, FunctionInstance function_instance)
        {
            throw new CmlRuntimeError_AttributeSupportException("function", this);
        }

        public string GetName()
        {
            return name;
        }
    }
}