using System;
using System.Collections;
using System.Collections.Generic;

using Lidgren.Network;

namespace Crunchy.Cart
{
    using Dough;
    using Salt;
    using Noodle;
    using Sodium;
    
    public partial class Syncronizer
    {
        public abstract class ObjectLiaison
        {
            private TypeSerializer type_serializer;

            public ObjectLiaison(TypeSerializer t)
            {
                type_serializer = t;
            }

            public bool Validate(object target)
            {
                if (target.GetTypeEX() == GetTypeSerializerType())
                    return true;

                return false;
            }
            public bool Validate(object target, Type desired_type)
            {
                if (Validate(target) && GetTypeSerializerType() == desired_type)
                    return true;

                return false;
            }

            public void Read(object target, Buffer buffer)
            {
                type_serializer.ReadWithLiaison(target, this, buffer);
            }

            public bool Write(object target, Interval field_update_interval, Buffer buffer)
            {
                return type_serializer.WriteWithLiaison(target, field_update_interval, this, buffer);
            }
            public bool Write(object target, Buffer buffer)
            {
                return type_serializer.WriteWithLiaison(target, this, buffer);
            }

            public void Update(object target)
            {
                type_serializer.UpdateWithLiaison(target, this);
            }

            public TypeSerializer GetTypeSerializer()
            {
                return type_serializer;
            }

            public Type GetTypeSerializerType()
            {
                return GetTypeSerializer().GetTargetType();
            }
        }
    }
}