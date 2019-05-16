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
            public TypeSerializerProp_Simple(PropInfoEX p, TypeSerializer t) : base(p, t)
            {
            }

            public override ILStatement GenerateRead(MethodBase method, ILValue buffer)
            {
                return ILSerialize.GenerateObjectReadInto(GetILProp(method), buffer);
            }

            public override ILStatement GenerateWrite(MethodBase method, ILValue buffer)
            {
                return ILSerialize.GenerateObjectWrite(GetILProp(method), buffer);
            }
        }
    }
}