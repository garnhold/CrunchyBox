using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

using CrunchyDough;

namespace CrunchySalt
{
    public class PropInfoEX_Property : PropInfoEX
    {
        private PropertyInfoEX property_info;

        private PropInfoEX_MethodPair method_pair;

        public PropInfoEX_Property(PropertyInfoEX p)
        {
            property_info = p;

            method_pair = new PropInfoEX_MethodPair(
                property_info.GetSetMethod(true).GetMethodInfoEX(),
                property_info.GetGetMethod(true).GetMethodInfoEX()
            );
        }

        public override string GetName()
        {
            return property_info.Name;
        }

        public override Type GetPropType()
        {
            return property_info.PropertyType;
        }

        public override Type GetDeclaringType()
        {
            return property_info.DeclaringType;
        }

        public override bool CanSet()
        {
            return method_pair.CanSet();
        }

        public override bool CanGet()
        {
            return method_pair.CanGet();
        }

        public override bool IsSetPublic()
        {
            return method_pair.IsSetPublic();
        }

        public override bool IsGetPublic()
        {
            return method_pair.IsGetPublic();
        }

        public override BasicValueSetter GetBasicValueSetter()
        {
            return method_pair.GetBasicValueSetter();
        }

        public override BasicValueGetter GetBasicValueGetter()
        {
            return method_pair.GetBasicValueGetter();
        }

        public override IEnumerable<Attribute> GetAllCustomAttributes(bool inherit)
        {
            return property_info.GetAllCustomAttributes(inherit);
        }

        public override void EmitLoad(ILCanvas canvas, ILValue target)
        {
            method_pair.EmitLoad(canvas, target);
        }

        public override void EmitLoadAddress(ILCanvas canvas, ILValue target)
        {
            method_pair.EmitLoadAddress(canvas, target);
        }

        public override void EmitStore(ILCanvas canvas, ILValue target, ILValue to_store)
        {
            method_pair.EmitStore(canvas, target, to_store);
        }

        public override int GetHashCode()
        {
            return property_info.GetHashCodeEX();
        }

        public override bool Equals(object obj)
        {
            PropInfoEX_Property cast;

            if (obj.Convert<PropInfoEX_Property>(out cast))
            {
                if (cast.property_info == property_info)
                    return true;
            }

            return false;
        }
    }
}