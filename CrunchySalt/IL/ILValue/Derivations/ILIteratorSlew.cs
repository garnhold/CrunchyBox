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
    public class ILIteratorSlew : ILValue
    {
        private List<ILValue> targets;

        public ILIteratorSlew(IEnumerable<ILValue> t)
        {
            targets = t.ToList();
        }

        static private IEnumerable None()
        {
            yield break;
        }
        static private IEnumerable Wrap(object to_wrap)
        {
            yield return to_wrap;
        }
        static private IEnumerable Append(IEnumerable item, IEnumerable to_append)
        {
            if (item != null)
            {
                foreach (object obj in item)
                    yield return obj;
            }

            if (to_append != null)
            {
                foreach (object obj in to_append)
                    yield return obj;
            }
        }

        public override void RenderIL_Load(ILCanvas canvas)
        {
            int i = 0;

            if (targets.IsNotEmpty())
            {
                MethodInfo wrap_method = GetType().GetStaticMethod<object>("Wrap").GetNativeMethodInfo();
                MethodInfo append_method = GetType().GetStaticMethod<IEnumerable, IEnumerable>("Append").GetNativeMethodInfo();

                foreach (ILValue value in targets)
                {
                    value.RenderIL_Load(canvas);

                    if (value.GetValueType().IsTypicalIEnumerable() == false)
                        canvas.Emit_Call(wrap_method);

                    if (i > 0)
                        canvas.Emit_Call(append_method);

                    i++;
                }
            }
            else
            {
                canvas.Emit_Call(GetType().GetStaticMethod("None"));
            }
        }

        public override void RenderIL_Store(ILCanvas canvas, ILValue value)
        {
            throw new InvalidOperationException(GetType() + " doesn't support storing.");
        }

        public override void RenderText_Value(ILTextCanvas canvas)
        {
            canvas.AppendToLine("[");
                targets.RenderText_Value(canvas, " + ");
            canvas.AppendToLine("]");
        }

        public override Type GetValueType()
        {
            return typeof(IEnumerable);
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