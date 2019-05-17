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
            protected override ILStatement GenerateReadInternal(ILValue target, ILValue liaison, ILValue buffer)
            {
                return ILSerialize.GenerateObjectReadInto(target, buffer);
            }

            protected override ILStatement GenerateWriteInternal(ILValue target, ILValue liaison, ILValue buffer)
            {
                return ILSerialize.GenerateObjectWrite(target, buffer);
            }

            public TypeSerializerProp_Simple(PropInfoEX p, TypeSerializer t) : base(p, t)
            {
            }
        }
    }
}