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
        public abstract class TypeSerializerProp
        {
            private PropInfoEX target_prop;

            private TypeSerializer type_serializer;

            protected abstract ILStatement GenerateReadInternal(ILValue prop, ILValue liaison, ILValue buffer);
            protected abstract ILStatement GenerateWriteInternal(ILValue prop, ILValue liaison, ILValue buffer);

            static public TypeSerializerProp Create(TypeBuilder type_builder, PropInfoEX prop, TypeSerializer type_serializer)
            {
                if (prop.GetPropType().HasCustomAttributeOfTypeOnAnInstanceMember<Value_SpecialAttribute>())
                    return new TypeSerializerProp_NestedLiaison(type_builder, prop, type_serializer);

                return new TypeSerializerProp_Simple(prop, type_serializer);
            }

            public TypeSerializerProp(PropInfoEX p, TypeSerializer t)
            {
                target_prop = p;

                type_serializer = t;
            }

            public ILStatement GenerateRead(ILValue target, ILValue liaison, ILValue buffer)
            {
                return GenerateReadInternal(target.GetILProp(target_prop), liaison, buffer);
            }

            public ILStatement GenerateWrite(ILValue target, ILValue liaison, ILValue buffer)
            {
                return GenerateWriteInternal(target.GetILProp(target_prop), liaison, buffer);
            }

            public Type GetPropType()
            {
                return target_prop.GetPropType();
            }

            public bool IsPolymorphic()
            {
                if (target_prop.GetPropType().HasChildTypes())
                    return true;

                return false;
            }
        }
    }
}