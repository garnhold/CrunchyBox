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
    
    public class ILNullCoalesce : ILValue
    {
        private List<ILValue> values;

        public ILNullCoalesce(IEnumerable<ILValue> v)
        {
            values = v.ToList();
        }

        public ILNullCoalesce(params ILValue[] v) : this((IEnumerable<ILValue>)v) { }

        public override void RenderIL_Load(ILCanvas canvas)
        {
            ILCanvasLabel label = canvas.CreateLabel();

            foreach (ILValue value in values.TruncateFromEnd(1))
            {
                value.RenderIL_Load(canvas);
                canvas.Emit_Dup();

                label.Emit_Brtrue();
                canvas.Emit_Pop();
            }
            values.GetLast().RenderIL_Load(canvas);

            label.Emit_Label();
        }

        public override void RenderText_Value(ILTextCanvas canvas)
        {
            values.RenderText_ValueEX(canvas, " ?? ");
        }

        public override Type GetValueType()
        {
            return values.GetValueTypes().GetCommonAncestor();
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