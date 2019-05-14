using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using CrunchyDough;

namespace CrunchySalt
{
    public abstract class IndexerInfoEX_Array : IndexerInfoEX
    {
        public IndexerInfoEX_Array(Type e) : base(e.MakeArrayType(), typeof(int), e)
        {
        }

        public override void RenderIL_LoadAddress(ILCanvas canvas, ILValue target, ILValue index)
        {
            target.RenderIL_Load(canvas);
            index.RenderIL_Load(canvas);

            canvas.Emit_Ldelema(GetElementType());
        }

        public override bool CanLoad()
        {
            return true;
        }

        public override bool CanStore()
        {
            return true;
        }
    }
}