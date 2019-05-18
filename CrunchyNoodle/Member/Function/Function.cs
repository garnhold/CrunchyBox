using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    public abstract class Function : Member, IDynamicCustomAttributeProvider
    {
        private Type return_type;
        private List<Type> parameter_types;

        protected abstract object ExecuteInternal(object target, object[] arguments);

        protected abstract string GetFunctionNameInternal();
        protected virtual IEnumerable<Attribute> GetAllCustomAttributesInternal(bool inherit) { return Empty.IEnumerable<Attribute>(); }

        public Function(Type d, Type r, IEnumerable<Type> p) : base(d)
        {
            return_type = r;
            parameter_types = p.ToList();
        }

        public object Execute(object target, IEnumerable<object> arguments)
        {
            object return_value = null;

            if (target != null)
            {
                return_value = ExecuteInternal(
                    target,
                    parameter_types.PairPermissive(arguments, (t, a) => a.ConvertEX(t)).ToArray()
               );
            }

            return return_value;
        }

        public Action CreateAction(IEnumerable<object> arguments)
        {
            return Action_Function.New(this, arguments);
        }
        public Action CreateAction(params object[] arguments)
        {
            return CreateAction((IEnumerable<object>)arguments);
        }

        public Type GetReturnType()
        {
            return return_type;
        }

        public string GetFunctionName()
        {
            return GetFunctionNameInternal();
        }

        public IEnumerable<Type> GetParameterTypes()
        {
            return parameter_types;
        }

        public int GetNumberParameters()
        {
            return parameter_types.Count;
        }

        public Type GetParameterType(int index)
        {
            return parameter_types.GetDropped(index);
        }

        public IEnumerable<Attribute> GetAllCustomAttributes(bool inherit)
        {
            return GetAllCustomAttributesInternal(inherit);
        }

        public string ToString(bool include_return_type, bool include_declaring_type, bool include_parameter_types)
        {
            string to_return = GetFunctionName();

            if (include_parameter_types)
                to_return = to_return + "(" + GetParameterTypes().ToString(", ") + ")";

            if (include_declaring_type)
                to_return = GetDeclaringType() + "::" + to_return;

            if (include_return_type)
                to_return = GetReturnType() + " " + to_return;

            return to_return;
        }

        public override string ToString()
        {
            return ToString(true, true, true);
        }
    }
}