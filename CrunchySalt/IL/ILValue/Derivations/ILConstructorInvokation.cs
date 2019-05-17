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
    public class ILConstructorInvokation : ILValue
    {
        private ILValue caller;
        private ConstructorInfo constructor;

        private List<ILValue> arguments;

        static public implicit operator ILStatement(ILConstructorInvokation m) { return m.CreateILCalculate(); }

        public ILConstructorInvokation(ILValue c, ConstructorInfo m, IEnumerable<ILValue> a)
        {
            constructor = m;

            caller = c;
            arguments = a.ToList();
        }

        public ILConstructorInvokation(ILValue c, ConstructorInfo m, params ILValue[] a) : this(c, m, (IEnumerable<ILValue>)a) { }

        public override void RenderIL_Load(ILCanvas canvas)
        {
            caller.RenderIL_Load(canvas);

            arguments.GetILImplicitCasts(constructor.GetEffectiveParameterTypes())
                .RenderIL_Load(canvas);

            canvas.Emit_Call(constructor);
        }

        public override void RenderIL_Store(ILCanvas canvas, ILValue value)
        {
            throw new InvalidOperationException(GetType() + " doesn't support storing.");
        }

        public override void RenderText_Value(ILTextCanvas canvas)
        {
            canvas.AppendToLine(".cctor");
            canvas.AppendToLine("(");
                arguments.RenderText_Value(canvas, ", ");
            canvas.AppendToLine(")");
        }

        public override Type GetValueType()
        {
            return typeof(void);
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