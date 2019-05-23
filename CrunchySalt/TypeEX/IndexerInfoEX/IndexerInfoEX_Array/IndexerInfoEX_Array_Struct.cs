using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using CrunchyDough;

namespace CrunchySalt
{
    public class IndexerInfoEX_Array_Struct : IndexerInfoEX_Array
    {
        public IndexerInfoEX_Array_Struct(Type e) : base(e)
        {
        }

        public override void RenderIL_Load(ILCanvas canvas, ILValue target, ILValue index)
        {
            target.RenderIL_Load(canvas);
            index.RenderIL_Load(canvas);

            canvas.Emit_Ldelema(GetElementType());
            canvas.Emit_Ldobj(GetElementType());
        }

        public override void RenderIL_Store(ILCanvas canvas, ILValue target, ILValue index, ILValue value)
        {
            target.RenderIL_Load(canvas);
            index.RenderIL_Load(canvas);

            canvas.Emit_Ldelema(GetElementType());
            value.RenderIL_Load(canvas);
            canvas.Emit_Stobj(GetElementType());
        }
    }
}