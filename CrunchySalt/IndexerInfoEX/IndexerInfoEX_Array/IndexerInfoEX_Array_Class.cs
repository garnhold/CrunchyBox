﻿using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using CrunchyDough;

namespace CrunchySalt
{
    public class IndexerInfoEX_Array_Class : IndexerInfoEX_Array
    {
        public IndexerInfoEX_Array_Class(Type e) : base(e) { }

        public override void RenderIL_Load(ILCanvas canvas, ILValue target, ILValue index)
        {
            target.RenderIL_Load(canvas);
            index.RenderIL_Load(canvas);

            canvas.Emit_Ldelem_Ref();
        }

        public override void RenderIL_Store(ILCanvas canvas, ILValue target, ILValue index, ILValue value)
        {
            target.RenderIL_Load(canvas);
            index.RenderIL_Load(canvas);

            value.RenderIL_Load(canvas);

            canvas.Emit_Stelem_Ref();
        }
    }
}