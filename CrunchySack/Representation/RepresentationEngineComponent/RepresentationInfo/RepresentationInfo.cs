using System;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;
    
    public abstract class RepresentationInfo : RepresentationEngineComponent
    {
        private string name;
        private Type representation_type;

        public const string UnamedChildren = "<unamed_children>";

        public RepresentationInfo(string n, Type r)
        {
            name = n;
            representation_type = r;
        }

        public virtual void SetValue(CmlContext context, object representation, object value)
        {
            throw new CmlRuntimeError_InfoSupportException("setting values", this);
        }

        public virtual void SetMultipleValues(CmlContext context, object representation, IEnumerable<object> values)
        {
            throw new CmlRuntimeError_InfoSupportException("setting multiple values", this);
        }

        public virtual void LinkValue(CmlContext context, object representation, VariableInstance variable_instance, HasInfo info)
        {
            throw new CmlRuntimeError_InfoSupportException("linking values", this);
        }

        public virtual void LinkValueWithEntity(CmlContext context, object representation, VariableInstance variable_instance, CmlEntity entity, HasInfo info)
        {
            throw new CmlRuntimeError_InfoSupportException("linking values with entity", this);
        }

        public virtual void InjectFunction(CmlContext context, object representation, FunctionInstance function_instance)
        {
            throw new CmlRuntimeError_InfoSupportException("injecting functions", this);
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