using System;
using System.Reflection;
using System.Reflection.Emit;

using CrunchyDough;

namespace CrunchySalt
{
    public class ParameterInfoEX_Quick : ParameterInfoEX
    {
        private Type parameter_type;
        private int position;

        private MemberInfo member;

        public override ParameterAttributes Attributes { get { return ParameterAttributes.None; } }
        public override Type ParameterType { get { return parameter_type; } }
        public override int Position { get { return position; } }
        public override string Name { get { return ""; } }
        public override object DefaultValue { get { return System.DBNull.Value; } }
        public override object RawDefaultValue { get { return System.DBNull.Value; } }

        public override MemberInfo Member { get { return member; } }

        public ParameterInfoEX_Quick(Type pt, int p, MemberInfo m)
        {
            parameter_type = pt;
            position = p;

            member = m;
        }

        public override object[] GetCustomAttributes(bool inherit)
        {
            return Empty.Array<object>();
        }

        public override object[] GetCustomAttributes(Type attributeType, bool inherit)
        {
            return Empty.Array<object>();
        }

        public override Type[] GetOptionalCustomModifiers()
        {
            return Empty.Array<Type>();
        }

        public override Type[] GetRequiredCustomModifiers()
        {
            return Empty.Array<Type>();
        }

        public override bool IsDefined(Type attributeType, bool inherit)
        {
            return false;
        }

        public override string ToString()
        {
            return parameter_type + "(" + position + ")";
        }
    }
}