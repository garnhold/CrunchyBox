using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    using Salt;
    
    public class ILLogicalAND : ILValue
    {
        private List<ILValue> values;

        public ILLogicalAND(IEnumerable<ILValue> v)
        {
            values = v.ToList();
        }

        public ILLogicalAND(params ILValue[] v) : this((IEnumerable<ILValue>)v) { }

        public override void RenderIL_Load(ILCanvas canvas)
        {
            ILCanvasLabel end_label = canvas.CreateLabel();
            ILCanvasLabel false_label = canvas.CreateLabel();

            foreach (ILValue value in values)
            {
                value.RenderIL_Load(canvas);
                false_label.Emit_Brfalse();
            }

            canvas.Emit_Ldc_I4(1);
            end_label.Emit_Br();

            false_label.Emit_Label();
            canvas.Emit_Ldc_I4(0);

            end_label.Emit_Label();
        }

        public override void RenderText_Value(ILTextCanvas canvas)
        {
            values.RenderText_Value(canvas, " && ");
        }

        public override Type GetValueType()
        {
            return typeof(bool);
        }

        public override bool IsILCostTrivial()
        {
            return false;
        }

        public override bool CanLoad()
        {
            return true;
        }
    }
}