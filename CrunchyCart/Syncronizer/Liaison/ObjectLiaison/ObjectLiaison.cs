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
            public abstract object GetTarget();
            public abstract TypeLiaison GetLiaison();

            public abstract int GetDeliveryChannel();

            public abstract void ReadUpdateInternal(object target, Buffer buffer);
            public abstract void WriteUpdateInternal(object target, Buffer buffer);

            public Type GetTargetType()
            {
                return GetLiaison().GetTargetType();
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