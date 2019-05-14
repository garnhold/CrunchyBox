using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
    public class ILVirtualParameter : ILValue, ILAddressable
    {
        private Type parameter_type;
        private int technical_parameter_index;

        private ILValue GetILParameter(MethodBase method)
        {
            return method.IfNotNull(m => m.GetTechnicalILParameter(technical_parameter_index));
        }
        private ILValue GetILParameter(ILCanvas canvas)
        {
            return GetILParameter(canvas.GetMethod());
        }
        private ILValue GetILParameter(ILTextCanvas canvas)
        {
            return GetILParameter(canvas.GetMethod());
        }

        private ILValue GetILCastParameter(ILCanvas canvas)
        {
            return GetILParameter(canvas).GetILImplicitCast(GetValueType());
        }

        public ILVirtualParameter(Type t, int i)
        {
            parameter_type = t;
            technical_parameter_index = i;
        }

        public override void RenderIL_Load(ILCanvas canvas)
        {
            GetILCastParameter(canvas)
                .RenderIL_Load(canvas);
        }

        public void RenderIL_LoadAddress(ILCanvas canvas)
        {
            GetILCastParameter(canvas)
                .RenderIL_LoadAddress(canvas);
        }

        public override void RenderIL_Store(ILCanvas canvas, ILValue value)
        {
            GetILParameter(canvas)
                .RenderIL_Store(canvas, value);
        }

        public override void RenderText_Value(ILTextCanvas canvas)
        {
            GetILParameter(canvas)
                .IfNotNull(
                    p => p.RenderText_Value(canvas),
                    () => canvas.AppendToLine("vparameter" + technical_parameter_index)
                );
        }

        public override Type GetValueType()
        {
            return parameter_type;
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