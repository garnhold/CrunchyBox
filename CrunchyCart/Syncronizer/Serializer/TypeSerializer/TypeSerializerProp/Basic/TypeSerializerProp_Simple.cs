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
        public class TypeSerializerProp_Simple : TypeSerializerProp
        {
            protected override ILStatement GenerateReadInternal(ILValue prop, ILValue liaison, ILValue buffer)
            {
                return ILSerialize.GenerateObjectReadInto(prop, buffer);
            }

            protected override ILStatement GenerateWriteInternal(ILValue prop, ILValue liaison, ILValue buffer)
            {
                return ILSerialize.GenerateObjectWrite(prop, buffer);
            }

            public TypeSerializerProp_Simple(PropInfoEX p, TypeSerializer t) : base(p, t)
            {
            }
        }
    }
}