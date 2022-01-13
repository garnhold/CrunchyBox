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
    
    public class ILCast : ILValue, ILAddressable
    {
        private ILCastInfo cast;

        private ILValue value;

        static public ILCast NewCustomCast(Type d, ILValue v, bool cou, bool aio, bool aeo)
        {
            return new ILCast(ILCastInfos.GetILCastInfo(v.GetValueType(), d, cou, aio, aeo), v);
        }
        static public ILCast NewThinCast(Type d, ILValue v)
        {
            return new ILCast(ILCastInfos.GetThinILCastInfo(v.GetValueType(), d), v);
        }
        static public ILCast NewImplicitCast(Type d, ILValue v)
        {
            return new ILCast(ILCastInfos.GetImplicitILCastInfo(v.GetValueType(), d), v);
        }
        static public ILCast NewExplicitCast(Type d, ILValue v)
        {
            return new ILCast(ILCastInfos.GetExplicitILCastInfo(v.GetValueType(), d), v);
        }

        private ILCast(ILCastInfo c, ILValue v)
        {
            cast = c;
            value = v;
        }

        public override void RenderIL_Load(ILCanvas canvas)
        {
            cast.EmitCast(canvas, value);
        }

        public void RenderIL_LoadAddress(ILCanvas canvas)
        {
            cast.EmitCastAddress(canvas, value);
        }

        public override void RenderText_Value(ILTextCanvas canvas)
        {
            canvas.AppendToLine("(");
                canvas.AppendToLine(cast.GetDestinationType().Name);
            canvas.AppendToLine(")");

            canvas.AppendToLine("(");
                value.RenderText_ValueEX(canvas);
            canvas.AppendToLine(")");
        }

        public override Type GetValueType()
        {
            return cast.GetDestinationType();
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