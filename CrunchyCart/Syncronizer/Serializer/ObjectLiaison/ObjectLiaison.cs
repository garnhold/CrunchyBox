using System;
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

            public void Read(object target, Buffer buffer)
            {
                type_serializer.Read(target, this, buffer);
            }

            public void Write(object target, Buffer buffer)
            {
                type_serializer.Write(target, this, buffer);
            }

            public int GetDeliveryChannel()
            {
                return 0;
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