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
    
    public class ILField : ILValue, ILAddressable
    {
        private ILValue target;
        private FieldInfo field;

        private void RenderIL_LoadTarget(ILCanvas canvas)
        {
            target.GetILImplicitCast(field.GetILFieldInvokationType())
                .RenderIL_Load(canvas);
        }

        public ILField(ILValue t, FieldInfo f)
        {
            target = t;
            field = f;
        }

        public override void RenderIL_Load(ILCanvas canvas)
        {
            if (field.IsInstanceField())
            {
                RenderIL_LoadTarget(canvas);

                canvas.Emit_Ldfld(field);
            }
            else
            {
                canvas.Emit_Ldsfld(field);
            }
        }

        public void RenderIL_LoadAddress(ILCanvas canvas)
        {
            if (field.IsInstanceField())
            {
                RenderIL_LoadTarget(canvas);

                canvas.Emit_Ldflda(field);
            }
            else
            {
                canvas.Emit_Ldsflda(field);
            }
        }

        public override void RenderIL_Store(ILCanvas canvas, ILValue value)
        {
            if (field.IsInstanceField())
            {
                RenderIL_LoadTarget(canvas);

                value.GetILImplicitCast(field.FieldType)
                    .RenderIL_Load(canvas);

                canvas.Emit_Stfld(field);
            }
            else
            {
                value.GetILImplicitCast(field.FieldType)
                    .RenderIL_Load(canvas);

                canvas.Emit_Stsfld(field);
            }
        }

        public override void RenderText_Value(ILTextCanvas canvas)
        {
            if (field.IsInstanceField())
                target.RenderText_ValueEX(canvas);
            else
                canvas.AppendToLine(field.DeclaringType.Name);

            canvas.AppendToLine(".");
            canvas.AppendToLine(field.Name);
        }

        public override Type GetValueType()
        {
            return field.FieldType;
        }

        public override bool IsILCostTrivial()
        {
            if (target.IsILCostTrivial())
                return true;

            return false;
        }

        public override bool CanLoad()
        {
            return true;
        }

        public override bool CanStore()
        {
            return true;
        }
    }
}