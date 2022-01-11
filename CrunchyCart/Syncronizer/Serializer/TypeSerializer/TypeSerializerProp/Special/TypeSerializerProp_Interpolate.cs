using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Collections;
using System.Collections.Generic;

using Lidgren.Network;

namespace Crunchy.Cart
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class Syncronizer
    {
        public class Value_InterpolateAttribute : Value_SpecialAttribute
        {
            private float smooth_amount;

            public Value_InterpolateAttribute(Interval ui, float s) : base(ui)
            {
                smooth_amount = s;
            }

            public Value_InterpolateAttribute(float s) : this(Interval.Default, s) { }

            public override TypeSerializerProp CreateTypeSerializerProp(TypeBuilder type_builder, PropInfoEX prop)
            {
                return new TypeSerializerProp_Interpolate(smooth_amount, type_builder, prop);
            }
        }

        public class TypeSerializerProp_Interpolate : TypeSerializerProp
        {
            private FieldInfo target_field;
            private float smooth_amount;

            protected override ILStatement GenerateReadInternal(ILValue prop, ILValue liaison, ILValue buffer)
            {
                return new ILAssign(
                    liaison.GetILField(target_field),
                    ILSerialize.GenerateObjectRead(prop.GetValueType(), buffer)
                );
            }

            protected override ILStatement GenerateWriteInternal(ILValue prop, ILValue liaison, ILValue buffer)
            {
                return ILSerialize.GenerateObjectWrite(prop, buffer);
            }

            protected override ILStatement GenerateUpdateInternal(ILValue prop, ILValue liaison)
            {
                return new ILAssign(
                    prop,
                    prop.GetILInvoke("GetInterpolate", liaison.GetILField(target_field), smooth_amount)
                );
            }

            public TypeSerializerProp_Interpolate(float s, TypeBuilder type_builder, PropInfoEX p) : base(p)
            {
                target_field = type_builder.CreateFieldBuilder(GetPropType(), "interpolate_target", FieldAttributesExtensions.PRIVATE);

                smooth_amount = s;
            }
        }
    }
}