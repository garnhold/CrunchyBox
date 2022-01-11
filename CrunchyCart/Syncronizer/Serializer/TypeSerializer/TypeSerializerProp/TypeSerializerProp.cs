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
        public abstract class TypeSerializerProp
        {
            private PropInfoEX target_prop;

            private TypeSerializer type_serializer;

            protected abstract ILStatement GenerateReadInternal(ILValue prop, ILValue liaison, ILValue buffer);
            protected abstract ILStatement GenerateWriteInternal(ILValue prop, ILValue liaison, ILValue buffer);

            protected virtual ILStatement GenerateConstructorInternal(ILValue liaison) { return ILNothing.INSTANCE; }
            protected virtual ILStatement GenerateUpdateInternal(ILValue prop, ILValue liaison) { return ILNothing.INSTANCE; }

            static public TypeSerializerProp Create(TypeBuilder type_builder, PropInfoEX prop)
            {
                if (prop.GetPropType().HasCustomAttributeOfTypeOnAnInstanceMember<Value_SpecialAttribute>())
                    return new TypeSerializerProp_NestedLiaison(type_builder, prop);

                Value_SpecialAttribute attribute;
                if (prop.TryGetCustomAttributeOfType<Value_SpecialAttribute>(true, out attribute))
                    return attribute.CreateTypeSerializerProp(type_builder, prop);

                return new TypeSerializerProp_Simple(prop);
            }

            public TypeSerializerProp(PropInfoEX p)
            {
                target_prop = p;
            }

            public ILStatement GenerateConstructor(ILValue liaison)
            {
                return GenerateConstructorInternal(liaison);
            }

            public ILStatement GenerateRead(ILValue target, ILValue liaison, ILValue buffer)
            {
                return GenerateReadInternal(target.GetILProp(target_prop), liaison, buffer);
            }

            public ILStatement GenerateWrite(ILValue target, ILValue liaison, ILValue buffer)
            {
                return GenerateWriteInternal(target.GetILProp(target_prop), liaison, buffer);
            }

            public ILStatement GenerateUpdate(ILValue target, ILValue liaison)
            {
                return GenerateUpdateInternal(target.GetILProp(target_prop), liaison);
            }

            public Type GetPropType()
            {
                return target_prop.GetPropType();
            }

            public Interval GetUpdateInterval()
            {
                return target_prop.GetCustomAttributeOfType<ValueAttribute>(true)
                    .IfNotNull(a => a.GetUpdateInterval(), Interval.Default);
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