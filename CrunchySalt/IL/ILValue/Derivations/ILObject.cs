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
    
    public class ILObject : ILLiteral
    {
        private object value;
        private FieldInfo field;

        static private int NEXT_FIELD_ID = 1;

        public ILObject(Type type, object obj)
        {
            value = obj;
            field = TypeCreator.CreateField(type, "ILObject" + NEXT_FIELD_ID++);

            field.SetValue(null, value);
        }

        public ILObject(object obj) : this(obj.GetTypeEX(), obj) { }

        public override void RenderIL_Load(ILCanvas canvas)
        {
            canvas.Emit_Ldsfld(field);
        }

        public override void RenderText_Value(ILTextCanvas canvas)
        {
            canvas.AppendToLine("<Literal " + GetValueType() + ">");
        }

        public override Type GetValueType()
        {
            return field.FieldType;
        }

        public override object GetLiteralValue()
        {
            return value;
        }
    }
}