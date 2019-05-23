using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
    public class ILEnum : ILLiteral
    {
        private Enum value;

        public ILEnum(Enum v)
        {
            value = v;
        }

        public override void RenderIL_Load(ILCanvas canvas)
        {
            ILLiteral.New(GetValueType().GetEnumUnderlyingType(), value)
                .RenderIL_Load(canvas);
        }

        public override void RenderText_Value(ILTextCanvas canvas)
        {
            canvas.AppendToLine(value.ToString());
        }

        public override Type GetValueType()
        {
            return value.GetTypeEX();
        }

        public override object GetLiteralValue()
        {
            return value;
        }
    }
    public abstract partial class ILValue
    {
        static public implicit operator ILValue(Enum item)
        {
            return new ILEnum(item);
        }
    }
    public abstract partial class ILLiteral
    {
        static public implicit operator ILLiteral(Enum item)
        {
            return new ILEnum(item);
        }
    }
}