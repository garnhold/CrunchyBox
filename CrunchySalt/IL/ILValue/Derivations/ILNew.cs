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
    public class ILNew : ILValue
    {
        private Type type;
        private ConstructorInfo constructor;

        private List<ILValue> arguments;

        public ILNew(Type t, ConstructorInfo c, IEnumerable<ILValue> a)
        {
            type = t;
            constructor = c;

            arguments = a.ToList();
        }

        public ILNew(Type t, ConstructorInfo c, params ILValue[] a) : this(t, c, (IEnumerable<ILValue>)a) { }

        public ILNew(Type t, IEnumerable<ILValue> a) : this(t, t.GetInstanceConstructor(a.GetValueTypes()), a) { }
        public ILNew(Type t, params ILValue[] a) : this(t, (IEnumerable<ILValue>)a) { }

        public ILNew(ConstructorInfo c, IEnumerable<ILValue> a) : this(c.DeclaringType, c, a) { }
        public ILNew(ConstructorInfo c, params ILValue[] a) : this(c, (IEnumerable<ILValue>)a) { }

        public override void RenderIL_Load(ILCanvas canvas)
        {
            if (constructor != null)
            {
                constructor.GetEffectiveParameterTypes().ProcessTandemStrict(arguments,
                    (t, a) => a.GetILImplicitCast(t).RenderIL_Load(canvas)
                );

                canvas.Emit_Newobj(constructor);
            }
            else
            {
                if (type.IsStruct())
                {
                    canvas.UseLocal(type, delegate(ILLocal local) {
                        local.RenderIL_LoadAddress(canvas);
                        canvas.Emit_Initobj(type);
                        local.RenderIL_Load(canvas);
                    });
                }
                else
                {
                    canvas.Emit_Newobj(type.GetDefaultConstructor());
                }
            }
        }

        public override void RenderIL_Store(ILCanvas canvas, ILValue value)
        {
            throw new InvalidOperationException(GetType() + " doesn't support storing.");
        }

        public override void RenderText_Value(ILTextCanvas canvas)
        {
            canvas.AppendToLine("new ");
            canvas.AppendToLine(GetValueType().Name);

            canvas.AppendToLine("(");
                arguments.RenderText_Value(canvas, ", ");
            canvas.AppendToLine(")");
        }

        public override Type GetValueType()
        {
            return type;
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