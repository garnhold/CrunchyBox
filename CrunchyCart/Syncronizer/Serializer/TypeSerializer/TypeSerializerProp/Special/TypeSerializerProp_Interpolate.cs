using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Collections;
using System.Collections.Generic;

using Lidgren.Network;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchySodium;

namespace CrunchyCart
{
    public partial class Syncronizer
    {
        public class Value_InterpolateAttribute : Value_SpecialAttribute
        {
            private float smooth_amount;

            public Value_InterpolateAttribute(float s)
            {
                smooth_amount = s;
            }

            public override TypeSerializerProp CreateTypeSerializerProp(TypeBuilder type_builder, PropInfoEX prop, TypeSerializer type_serializer)
            {
                return new TypeSerializerProp_Interpolate(smooth_amount, type_builder, prop, type_serializer);
            }
        }

        public class TypeSerializerProp_Interpolate : TypeSerializerProp
        {
            private float smooth_amount;

            protected override ILStatement GenerateReadInternal(ILValue prop, ILValue liaison, ILValue buffer)
            {
                ILValue new_value = ILSerialize.GenerateObjectRead(prop.GetValueType(), buffer);

                return new ILAssign(
                    prop,
                    prop.GetILInvoke("GetInterpolate", new_value, smooth_amount)
                );
            }

            protected override ILStatement GenerateWriteInternal(ILValue prop, ILValue liaison, ILValue buffer)
            {
                return ILSerialize.GenerateObjectWrite(prop, buffer);
            }

            public TypeSerializerProp_Interpolate(float s, TypeBuilder type_builder, PropInfoEX p, TypeSerializer t) : base(p, t)
            {
                smooth_amount = s;
            }
        }
    }
}