using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

using CrunchyDough;

namespace CrunchySalt
{
    public class PropInfoEX_PermissiveProperty : PropInfoEX
    {
        private PropertyInfoEX property_info;

        private PropInfoEX_MethodPair method_pair;
        private PropInfoEX_Field backing_field;

        public PropInfoEX_PermissiveProperty(PropertyInfoEX p)
        {
            property_info = p;

            method_pair = new PropInfoEX_MethodPair(
                property_info.GetSetMethod(true).GetMethodInfoEX(),
                property_info.GetGetMethod(true).GetMethodInfoEX()
            );

            backing_field = property_info.GetBackingField().IfNotNull(f => new PropInfoEX_Field(f.GetFieldInfoEX()));
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
            if (backing_field != null)
                return true;

            return method_pair.CanSet();
        }

        public override bool CanGet()
        {
            if (backing_field != null)
                return true;

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
            return method_pair.GetBasicValueSetter() ?? backing_field.GetBasicValueSetter();
        }

        public override BasicValueGetter GetBasicValueGetter()
        {
            return method_pair.GetBasicValueGetter() ?? backing_field.GetBasicValueGetter();
        }

        public override IEnumerable<Attribute> GetAllCustomAttributes(bool inherit)
        {
            return property_info.GetAllCustomAttributes(inherit);
        }

        public override void EmitLoad(ILCanvas canvas, ILValue target)
        {
            if (method_pair.CanGet())
                method_pair.EmitLoad(canvas, target);
            else if (backing_field != null)
                backing_field.EmitLoad(canvas, target);
        }

        public override void EmitLoadAddress(ILCanvas canvas, ILValue target)
        {
            if (method_pair.CanGet())
                method_pair.EmitLoadAddress(canvas, target);
            else if (backing_field != null)
                backing_field.EmitLoadAddress(canvas, target);
        }

        public override void EmitStore(ILCanvas canvas, ILValue target, ILValue to_store)
        {
            if (method_pair.CanSet())
                method_pair.EmitStore(canvas, target, to_store);
            else if (backing_field != null)
                backing_field.EmitStore(canvas, target, to_store);
        }

        public override int GetHashCode()
        {
            return property_info.GetHashCodeEX();
        }

        public override bool Equals(object obj)
        {
            PropInfoEX_PermissiveProperty cast;

            if (obj.Convert<PropInfoEX_PermissiveProperty>(out cast))
            {
                if (cast.property_info == property_info)
                    return true;
            }

            return false;
        }
    }
}