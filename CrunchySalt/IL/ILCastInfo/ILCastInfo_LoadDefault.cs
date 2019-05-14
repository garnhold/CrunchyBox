﻿using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchySalt
{
    public class ILCastInfo_LoadDefault : ILCastInfo
    {
        public ILCastInfo_LoadDefault(Type s, Type d) : base(s, d) { }

        public override void EmitCast(ILCanvas canvas, ILValue value)
        {
            value.RenderIL_Load(canvas);

            new ILDefault(GetDestinationType()).RenderIL_Load(canvas);
        }
    }
}