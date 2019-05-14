using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchySalt
{
    public class ILCastInfo_Conv_I2 : ILCastInfo
    {
        public ILCastInfo_Conv_I2(Type s) : base(s, typeof(short)) { }

        public override void EmitCast(ILCanvas canvas, ILValue value)
        {
            value.RenderIL_Load(canvas);

            canvas.Emit_Conv_I2();
        }
    }
}