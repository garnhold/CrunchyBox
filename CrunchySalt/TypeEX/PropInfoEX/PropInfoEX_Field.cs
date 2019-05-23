using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

using CrunchyDough;

namespace CrunchySalt
{
    public class PropInfoEX_Field : PropInfoEX
    {
        private FieldInfoEX field_info;

        public PropInfoEX_Field(FieldInfoEX f)
        {
            field_info = f;
        }

        public override string GetName()
        {
            return field_info.Name;
        }

        public override Type GetPropType()
        {
            return field_info.FieldType;
        }

        public override Type GetDeclaringType()
        {
            return field_info.DeclaringType;
        }

        public override bool CanSet()
        {
            return true;
        }

        public override bool CanGet()
        {
            return true;
        }

        public override bool IsSetPublic()
        {
            return field_info.IsPublic;
        }

        public override bool IsGetPublic()
        {
            return field_info.IsPublic;
        }

        public override BasicValueSetter GetBasicValueSetter()
        {
            return field_info.GetBasicValueSetter();
        }

        public override BasicValueGetter GetBasicValueGetter()
        {
            return field_info.GetBasicValueGetter();
        }

        public override IEnumerable<Attribute> GetAllCustomAttributes(bool inherit)
        {
            return field_info.GetAllCustomAttributes(inherit);
        }

        public override void EmitLoad(ILCanvas canvas, ILValue target)
        {
            new ILField(target, field_info).RenderIL_Load(canvas);
        }

        public override void EmitLoadAddress(ILCanvas canvas, ILValue target)
        {
            new ILField(target, field_info).RenderIL_LoadAddress(canvas);
        }

        public override void EmitStore(ILCanvas canvas, ILValue target, ILValue to_store)
        {
            new ILField(target, field_info).RenderIL_Store(canvas, to_store);
        }

        public FieldInfoEX GetFieldInfo()
        {
            return field_info;
        }

        public override int GetHashCode()
        {
            return field_info.GetHashCodeEX();
        }

        public override bool Equals(object obj)
        {
            PropInfoEX_Field cast;

            if (obj.Convert<PropInfoEX_Field>(out cast))
            {
                if (cast.field_info == field_info)
                    return true;
            }

            return false;
        }
    }
}