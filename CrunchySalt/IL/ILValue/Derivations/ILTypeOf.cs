using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;

    public class ILTypeOf : ILLiteral
    {
        private Type constant;

        public ILTypeOf(Type c)
        {
            constant = c;
        }

        public override void RenderIL_Load(ILCanvas canvas)
        {
            canvas.Emit_Ldtoken(constant);
            canvas.Emit_Call(typeof(Type).GetStaticMethod<RuntimeTypeHandle>("GetTypeFromHandle"));
        }

        public override void RenderText_Value(ILTextCanvas canvas)
        {
            canvas.AppendToLine("typeof(" + constant.ToStringEX() + ")");
        }

        public override Type GetValueType()
        {
            return typeof(Type);
        }

        public override object GetLiteralValue()
        {
            return constant;
        }
    }
    public abstract partial class ILValue
    {
        static public implicit operator ILValue(Type item)
        {
            return new ILTypeOf(item);
        }
    }
    public abstract partial class ILLiteral
    {
        static public implicit operator ILLiteral(Type item)
        {
            return new ILTypeOf(item);
        }
    }
}