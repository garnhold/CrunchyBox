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
        public delegate void ObjectLiaisonReader(object liaison, object target, Buffer buffer);
        public delegate void ObjectLiaisonWriter(object liaison, object target, Buffer buffer);

        public class ObjectLiaison
        {
            private object target;
            private int delivery_channel;

            private ObjectLiaisonReader reader;
            private ObjectLiaisonWriter writer;

            private TypeSerializer type_serializer;

            public ObjectLiaison(ObjectLiaisonReader r, ObjectLiaisonWriter w, TypeSerializer t)
            {
                reader = r;
                writer = w;

                type_serializer = t;
            }

            public void ReadUpdateInternal(object t, Buffer buffer)
            {
                target = t;

                reader(this, target, buffer);
            }

            public void WriteUpdateInternal(object t, Buffer buffer)
            {
                target = t;

                writer(this, target, buffer);
            }

            public object GetTarget()
            {
                return target;
            }

            public TypeSerializer GetTypeSerializer()
            {
                return type_serializer;
            }

            public int GetDeliveryChannel()
            {
                return delivery_channel;
            }

            public Type GetTargetType()
            {
                return GetTypeSerializer().GetTargetType();
            }

            public bool Validate(Type type)
            {
                if (type == GetTargetType())
                    return true;

                return false;
            }
            public bool Validate()
            {
                return Validate(GetTarget().GetTypeEX());
            }
        }
    }
}