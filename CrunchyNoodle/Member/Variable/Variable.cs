using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    public abstract class Variable : Member, IDynamicCustomAttributeProvider
    {
        private Type variable_type;

        protected abstract bool SetContentsInternal(object target, object value);
        protected virtual ILStatement CompileSetContentsInternal(ILValue target, ILValue value) { return null; }

        protected abstract object GetContentsInternal(object target);
        protected virtual ILValue CompileGetContentsInternal(ILValue target) { return null; }

        protected abstract string GetVariableNameInternal();
        protected virtual IEnumerable<Attribute> GetAllCustomAttributesInternal(bool inherit) { return Empty.IEnumerable<Attribute>(); }

        public Variable(Type d, Type v) : base(d)
        {
            variable_type = v;
        }

        public bool SetContents(object target, object value)
        {
            if (target.CanObjectBeTreatedAs(GetDeclaringType()))
                return SetContentsInternal(target, PrepareValue(value));

            return false;
        }
        public ILStatement CompileSetContents(ILValue target, ILValue value)
        {
            if (target.GetValueType().CanBeTreatedAs(GetDeclaringType()))
                return CompileSetContentsInternal(target, CompilePrepareValue(value));

            return null;
        }

        public ValueChangeResult ChangeContents(object target, object value)
        {
            if (target.CanObjectBeTreatedAs(GetDeclaringType()))
            {
                object prepared_value = PrepareValue(value);

                if (prepared_value.NotEqualsEX(GetContentsInternal(target)))
                {
                    if (SetContentsInternal(target, prepared_value))
                        return ValueChangeResult.SuccessChanged;
                }

                return ValueChangeResult.SuccessUnchanged;
            }

            return ValueChangeResult.Failure;
        }

        public object GetContents(object target)
        {
            object value = null;

            if (target.CanObjectBeTreatedAs(GetDeclaringType()))
                value = GetContentsInternal(target);

            return value;
        }
        public ILValue CompileGetContents(ILValue target)
        {
            if (target.GetValueType().CanBeTreatedAs(GetDeclaringType()))
                return CompileGetContentsInternal(target);

            return null;
        }

        public object PrepareValue(object value)
        {
            return value.ConvertEX(variable_type);
        }
        public ILValue CompilePrepareValue(ILValue value)
        {
            return value.GetILConvertEX(variable_type);
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