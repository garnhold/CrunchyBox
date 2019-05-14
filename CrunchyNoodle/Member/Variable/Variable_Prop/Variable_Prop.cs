using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    public class Variable_Prop : Variable
    {
        private PropInfoEX prop;

        static public Variable_Prop New(Type d, string n)
        {
            return d.GetInstanceProp(n).IfNotNull(p => new Variable_Prop(p));
        }

        protected override bool SetContentsInternal(object target, object value)
        {
            if (prop.CanSet())
            {
                prop.SetValue(target, value);

                return true;
            }

            return false;
        }

        protected override object GetContentsInternal(object target)
        {
            if(prop.CanGet())
                return prop.GetValue(target);

            return null;
        }

        protected override string GetVariableNameInternal()
        {
            return prop.GetName();
        }

        protected override IEnumerable<Attribute> GetAllCustomAttributesInternal(bool inherit)
        {
            return prop.GetAllCustomAttributes(inherit);
        }

        public Variable_Prop(PropInfoEX p) : base(p.GetDeclaringType(), p.GetPropType())
        {
            prop = p;
        }
    }
}