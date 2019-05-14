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
    public class ILAs : ILValue
    {
        private Type destination_type;

        private ILValue value;

        public ILAs(Type d, ILValue v)
        {
            destination_type = d;

            value = v;
        }

        public override void RenderIL_Load(ILCanvas canvas)
        {
            value.RenderIL_Load(canvas);

            canvas.Emit_Isinst(destination_type);
        }

        public override void RenderIL_Store(ILCanvas canvas, ILValue value)
        {
            throw new InvalidOperationException(GetType() + " doesn't support storing.");
        }

        public override void RenderText_Value(ILTextCanvas canvas)
        {
            canvas.AppendToLine("(");
                value.RenderText_Value(canvas);

                canvas.AppendToLine(" as ");
                canvas.AppendToLine(destination_type.Name);
            canvas.AppendToLine(")");
        }

        public override Type GetValueType()
        {
            return destination_type;
        }

        public override bool IsILCostTrivial()
        {
            return false;
        }

        public override bool CanLoad()
        {
            return true;
        }

        public override bool CanStore()
        {
            return false;
        }
    }
}