using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
    public class ILThis : ILValue, ILAddressable
    {
        private Type this_type;

        public ILThis(Type t)
        {
            this_type = t;
        }

        public override void RenderIL_Load(ILCanvas canvas)
        {
            canvas.Emit_Ldarg(0);
        }

        public void RenderIL_LoadAddress(ILCanvas canvas)
        {
            canvas.Emit_Ldarga(0);
        }

        public override void RenderText_Value(ILTextCanvas canvas)
        {
            canvas.AppendToLine("this");
        }

        public override Type GetValueType()
        {
            return this_type;
        }

        public override bool IsILCostTrivial()
        {
            return true;
        }

        public override bool CanLoad()
        {
            return true;
        }
    }
}