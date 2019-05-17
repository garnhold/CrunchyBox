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
    public class ILMethodInvokation : ILValue
    {
        private ILValue caller;
        private MethodInfo method;

        private List<ILValue> arguments;

        static public implicit operator ILStatement(ILMethodInvokation m) { return m.CreateILCalculate(); }

        public ILMethodInvokation(ILValue c, MethodInfo m, IEnumerable<ILValue> a)
        {
            method = m;

            caller = c;
            arguments = a.ToList();
        }

        public ILMethodInvokation(ILValue c, MethodInfo m, params ILValue[] a) : this(c, m, (IEnumerable<ILValue>)a) { }

        public override void RenderIL_Load(ILCanvas canvas)
        {
            if (method.IsEffectivelyInstanceMethod() && caller != null)
            {
                caller.GetILImplicitCast(method.GetILMethodInvokationType())
                    .RenderIL_Load(canvas);

                arguments.GetILImplicitCasts(method.GetEffectiveParameterTypes())
                    .RenderIL_Load(canvas);

                if (method.IsTechnicallyInstanceMethod() && method.DeclaringType.IsReferenceType())
                    canvas.Emit_Callvirt(method);
                else
                    canvas.Emit_Call(method);
            }
            else
            {
                arguments.GetILImplicitCasts(method.GetTechnicalParameterTypes())
                    .RenderIL_Load(canvas);

                canvas.Emit_Call(method);
            }
        }

        public override void RenderIL_Store(ILCanvas canvas, ILValue value)
        {
            throw new InvalidOperationException(GetType() + " doesn't support storing.");
        }

        public override void RenderText_Value(ILTextCanvas canvas)
        {
            if (method.IsEffectivelyInstanceMethod() && caller != null)
            {
                caller.RenderText_Value(canvas);
                canvas.AppendToLine(".");
            }

            canvas.AppendToLine(method.Name);
            canvas.AppendToLine("(");
                arguments.RenderText_Value(canvas, ", ");
            canvas.AppendToLine(")");
        }

        public override Type GetValueType()
        {
            return method.ReturnType;
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