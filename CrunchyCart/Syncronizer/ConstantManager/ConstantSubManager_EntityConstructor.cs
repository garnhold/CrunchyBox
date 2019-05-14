using System;
using System.Net;
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
        public class ConstantSubManager_EntityConstructor : ConstantSubManager<EntityConstructor>
        {
            protected override EntityConstructor ReadConstantValue(Buffer buffer)
            {
                return EntityConstructor.GetEntityConstructorBySignature(
                    buffer.ReadType(),
                    buffer.ReadString()
                );
            }

            protected override void WriteConstantValue(EntityConstructor value, Buffer buffer)
            {
                buffer.WriteType(value.GetDeclaringType());
                buffer.WriteString(value.GetName());
            }

            public ConstantSubManager_EntityConstructor(ConstantManager m) : base(m) { }
        }
    }
}