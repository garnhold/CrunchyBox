using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    public abstract class Variable : Member, IDynamicCustomAttributeProvider
    {
        private Type variable_type;

        protected abstract bool SetContentsInternal(object target, object value);
        protected abstract object GetContentsInternal(object target);

        protected abstract string GetVariableNameInternal();
        protected virtual IEnumerable<Attribute> GetAllCustomAttributesInternal(bool inherit) { return Empty.IEnumerable<Attribute>(); }

        public Variable(Type d, Type v) : base(d)
        {
            variable_type = v;
        }

        public bool SetContents(object target, object value)
        {
            if (target != null)
                return SetContentsInternal(target, PrepareValue(value));

            return false;
        }

        public bool UpdateContents(object target, object value)
        {
            if (target != null)
            {
                object prepared_value = PrepareValue(value);

                if (prepared_value.NotEqualsEX(GetContentsInternal(target)))
                    return SetContentsInternal(target, prepared_value);

                return true;
            }

            return false;
        }

        public object GetContents(object target)
        {
            object value = null;

            if (target != null)
                value = GetContentsInternal(target);

            return value;
        }

        public object PrepareValue(object value)
        {
            return value.ConvertEX(variable_type);
        }

        public Type GetVariableType()
        {
            return variable_type;
        }

        public string GetVariableName()
        {
            return GetVariableNameInternal();
        }

        public IEnumerable<Attribute> GetAllCustomAttributes(bool inherit)
        {
            return GetAllCustomAttributesInternal(inherit);
        }

        public string ToString(bool include_declaring_type, bool include_variable_type)
        {
            string to_return = GetVariableName();

            if (include_declaring_type)
                to_return = GetDeclaringType() + "::" + to_return;

            if(include_variable_type)
                to_return = GetVariableType() + " " + to_return;

            return to_return;
        }

        public override string ToString()
        {
            return ToString(true, true);
        }
    }
}