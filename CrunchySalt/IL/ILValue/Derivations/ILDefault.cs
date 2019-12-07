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
    
    public class ILDefault : ILValue
    {
        private Type value_type;

        public ILDefault(Type i)
        {
            value_type = i;
        }

        public override void RenderIL_Load(ILCanvas canvas)
        {
            BasicType basic_type = value_type.GetBasicType();

            switch (basic_type)
            {
                case BasicType.Bool: canvas.Emit_Ldc_I4(0); break;

                case BasicType.Byte: canvas.Emit_Ldc_I4(0); break;
                case BasicType.Short: canvas.Emit_Ldc_I4(0); break;
                case BasicType.Int: canvas.Emit_Ldc_I4(0); break;
                case BasicType.Long: canvas.Emit_Ldc_I8(0); break;

                case BasicType.Float: canvas.Emit_Ldc_R4(0.0f); break;
                case BasicType.Double: canvas.Emit_Ldc_R8(0.0); break;

                case BasicType.Char: canvas.Emit_Ldc_I4(0); break;
                case BasicType.String: canvas.Emit_Ldstr(""); break;

                case BasicType.Enum: canvas.Emit_Ldc_I4(0); break;
                case BasicType.Class: canvas.Emit_Ldnull(); break;

                case BasicType.Struct:
                    canvas.UseLocal(value_type, delegate(ILLocal local) {
                        local.RenderIL_LoadAddress(canvas);
                        canvas.Emit_Initobj(value_type);
                        local.RenderIL_Load(canvas);
                    });
                    break;

                default: throw new UnaccountedBranchException("basic_type", basic_type);
            }
        }

        public override void RenderText_Value(ILTextCanvas canvas)
        {
            canvas.AppendToLine("default(" + value_type.Name + ")");
        }

        public override Type GetValueType()
        {
            return value_type;
        }

        public override bool IsILCostTrivial()
        {
            return true;
        }

        public override bool CanLoad()
        {
            return true;
        }
    }
}