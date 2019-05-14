using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
    public class ILParameter : ILValue, ILAddressable
    {
        private ParameterInfo parameter;

        public ILParameter(ParameterInfo p)
        {
            parameter = p;
        }

        public override void RenderIL_Load(ILCanvas canvas)
        {
            canvas.Emit_Ldarg(parameter.Position);
        }

        public void RenderIL_LoadAddress(ILCanvas canvas)
        {
            canvas.Emit_Ldarga(parameter.Position);
        }

        public override void RenderIL_Store(ILCanvas canvas, ILValue value)
        {
            value.GetILImplicitCast(GetValueType())
                .RenderIL_Load(canvas);

            canvas.Emit_Starg(parameter.Position);
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