using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    public class ILParameter : ILValue, ILAddressable
    {
        private ParameterInfo parameter;

        private int GetArgIndex(ILCanvas canvas)
        {
            if (canvas.GetMethod().IsTechnicallyInstanceMethod())
                return parameter.Position + 1;

            return parameter.Position;
        }

        public ILParameter(ParameterInfo p)
        {
            parameter = p;
        }

        public override void RenderIL_Load(ILCanvas canvas)
        {
            canvas.Emit_Ldarg(GetArgIndex(canvas));
        }

        public void RenderIL_LoadAddress(ILCanvas canvas)
        {
            canvas.Emit_Ldarga(GetArgIndex(canvas));
        }

        public override void RenderIL_Store(ILCanvas canvas, ILValue value)
        {
            value.GetILImplicitCast(GetValueType())
                .RenderIL_Load(canvas);

            canvas.Emit_Starg(GetArgIndex(canvas));
        }

        public override void RenderText_Value(ILTextCanvas canvas)
        {
            canvas.AppendToLine(parameter.Name.CoalesceBlank("parameter" + parameter.Position));
        }

        public override Type GetValueType()
        {
            return parameter.ParameterType;
        }

        public override bool IsILCostTrivial()
        {
            return true;
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