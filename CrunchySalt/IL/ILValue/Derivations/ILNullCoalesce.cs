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

            foreach (ILValue value in values.Trim(1))
            {
                value.RenderIL_Load(canvas);
                canvas.Emit_Dup();

                label.Emit_Brtrue();
                canvas.Emit_Pop();
            }
            values.GetLast().RenderIL_Load(canvas);

            label.Emit_Label();
        }

        public override void RenderIL_Store(ILCanvas canvas, ILValue value)
        {
            throw new InvalidOperationException(GetType() + " doesn't support storing.");
        }

        public override void RenderText_Value(ILTextCanvas canvas)
        {
            values.RenderText_Value(canvas, " ?? ");
        }

        public override Type GetValueType()
        {
            return values.Convert(v => v.GetValueType()).GetCommonAncestor();
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