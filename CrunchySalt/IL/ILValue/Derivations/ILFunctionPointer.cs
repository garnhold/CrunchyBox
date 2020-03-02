using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    public class ILFunctionPointer : ILValue
    {
        private MethodInfo method;

        public ILFunctionPointer(MethodInfo m)
        {
            method = m;
        }

        public override void RenderIL_Load(ILCanvas canvas)
        {
            canvas.Emit_Ldftn(method);
        }

        public override void RenderText_Value(ILTextCanvas canvas)
        {
            canvas.AppendToLine(method.ToStringEX());
        }

        public override Type GetValueType()
        {
            return typeof(IntPtr);
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