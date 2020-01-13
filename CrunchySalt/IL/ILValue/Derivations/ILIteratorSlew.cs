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
            if (to_wrap != null)
                yield return to_wrap;
        }
        static private IEnumerable Join(IEnumerable[] enumerables)
        {
            foreach (IEnumerable enumerable in enumerables)
            {
                if (enumerable != null)
                {
                    foreach (object obj in enumerable)
                    {
                        if (obj != null)
                            yield return obj;
                    }
                }
            }
        }

        public override void RenderIL_Load(ILCanvas canvas)
        {
            if (targets.IsNotEmpty())
            {
                MethodInfo wrap_method = GetType().GetStaticMethod<object>("Wrap").GetNativeMethodInfo();
                MethodInfo join_method = GetType().GetStaticMethod<IEnumerable[]>("Join").GetNativeMethodInfo();

                join_method.GetStaticILMethodInvokation(
                    new ILNewPopulatedArray(
                        typeof(IEnumerable),
                        targets.Exchange(
                            v => v.GetValueType().IsTypicalIEnumerable() == false,
                            v => wrap_method.GetStaticILMethodInvokation(v)
                        )
                    )
                ).RenderIL_Load(canvas);
            }
            else
            {
                canvas.Emit_Call(GetType().GetStaticMethod("None"));
            }
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
    }
}