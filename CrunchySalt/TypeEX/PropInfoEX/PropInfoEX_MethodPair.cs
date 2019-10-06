using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

using CrunchyDough;

namespace CrunchySalt
{
    public class PropInfoEX_MethodPair : PropInfoEX
    {
        private MethodInfoEX set_method;
        private MethodInfoEX get_method;

        public PropInfoEX_MethodPair(MethodInfoEX s, MethodInfoEX g)
        {
            set_method = s;
            get_method = g;
        }

        public override string GetName()
        {
            return set_method.IfNotNull(m => m.Name.DetectEntityPropName()) ??
                get_method.IfNotNull(m => m.Name.DetectEntityPropName());
        }

        public override Type GetPropType()
        {
            return set_method.IfNotNull(m => m.GetEffectiveParameterType(0)) ??
                get_method.IfNotNull(m => m.ReturnType);
        }

        public override Type GetDeclaringType()
        {
            return set_method.IfNotNull(m => m.GetMethodEffectiveType()) ??
                get_method.IfNotNull(m => m.GetMethodEffectiveType());
        }

        public override bool CanSet()
        {
            if (set_method != null)
                return true;

            return false;
        }

        public override bool CanGet()
        {
            if (get_method != null)
                return true;

            return false;
        }

        public override bool IsSetPublic()
        {
            return set_method.IfNotNull(m => m.IsPublic);
        }

        public override bool IsGetPublic()
        {
            return get_method.IfNotNull(m => m.IsPublic);
        }

        public override PropInfoEXType GetPropInfoType()
        {
            if (get_method.IfNotNull(m => m.IsPropertyGetMethod()))
                return PropInfoEXType.PropertyMethods;

            if (set_method.IfNotNull(m => m.IsPropertySetMethod()))
                return PropInfoEXType.PropertyMethods;

            return PropInfoEXType.UnassociatedMethods;
        }

        public override BasicValueSetter GetBasicValueSetter()
        {
            return set_method.IfNotNull(m => m.GetSimulatedBasicValueSetter());
        }

        public override BasicValueGetter GetBasicValueGetter()
        {
            return get_method.IfNotNull(m => m.GetSimulatedBasicValueGetter());
        }

        public override IEnumerable<Attribute> GetAllCustomAttributes(bool inherit)
        {
            return set_method.IfNotNull(m => m.GetAllCustomAttributes(inherit)).Append(
                get_method.IfNotNull(m => m.GetAllCustomAttributes(inherit))
            );
        }

        public override void EmitLoad(ILCanvas canvas, ILValue target)
        {
            new ILMethodInvokation(target, get_method)
                .RenderIL_Load(canvas);
        }

        public override void EmitLoadAddress(ILCanvas canvas, ILValue target)
        {
            new ILMethodInvokation(target, get_method)
                .RenderIL_LoadAddress(canvas);
        }

        public override void EmitStore(ILCanvas canvas, ILValue target, ILValue to_store)
        {
            new ILMethodInvokation(target, set_method, to_store)
                .CreateILCalculate()
                .RenderIL_Execute(canvas);
        }

        public MethodInfoEX GetSetMethodInfo()
        {
            return set_method;
        }

        public MethodInfoEX GetGetMethodInfo()
        {
            return get_method;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;

                hash = hash * 23 + set_method.GetHashCodeEX();
                hash = hash * 23 + get_method.GetHashCodeEX();
                return hash;
            }
        }

        public override bool Equals(object obj)
        {
            PropInfoEX_MethodPair cast;

            if (obj.Convert<PropInfoEX_MethodPair>(out cast))
            {
                if (cast.get_method == get_method)
                {
                    if (cast.set_method == set_method)
                        return true;
                }
            }

            return false;
        }
    }
}