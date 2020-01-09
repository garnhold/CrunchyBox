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

        public virtual void SetRepresentationValue(object representation, object value)
        {
            throw new CmlRuntimeError_AttributeSupportException("setting", this);
        }

        public virtual EffigyInfo GetRepresentationEffigyInfo()
        {
            throw new CmlRuntimeError_AttributeSupportException("children", this);
        }

        public virtual Variable GetRepresentationVariable()
        {
            throw new CmlRuntimeError_AttributeSupportException("linking", this);
        }

        public virtual void InjectRepresentationFunction(object representation, FunctionSyncro function_syncro)
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