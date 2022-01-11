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

        static private OperationCache<ILObject, Type, object> GET_IL_OBJECT = ReflectionCache.Get().NewOperationCache("GET_IL_OBJECT", delegate (Type type, object obj) {
            return new ILObject(type, obj);
        });
        static public ILObject GetILObject(Type type, object obj)
        {
            return GET_IL_OBJECT.Fetch(type, obj);
        }
        static public ILObject GetILObject(object obj)
        {
            return GetILObject(obj.GetTypeEX(), obj);
        }

        protected ILObject(Type type, object obj)
        {
            value = obj;
            field = TypeCreator.CreateField(type, "ILObject" + NEXT_FIELD_ID++);

            field.SetValue(null, value);
        }

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