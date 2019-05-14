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
    public class ILProp : ILValue, ILAddressable
    {
        private ILValue target;
        private PropInfoEX prop;

        public ILProp(ILValue t, PropInfoEX p)
        {
            target = t;
            prop = p;
        }

        public override void RenderIL_Load(ILCanvas canvas)
        {
            prop.EmitLoad(canvas, target);
        }

        public void RenderIL_LoadAddress(ILCanvas canvas)
        {
            prop.EmitLoadAddress(canvas, target);
        }

        public override void RenderIL_Store(ILCanvas canvas, ILValue value)
        {
            prop.EmitStore(canvas, target, value);
        }

        public override void RenderText_Value(ILTextCanvas canvas)
        {
            target.RenderText_Value(canvas);

            canvas.AppendToLine("->");
            canvas.AppendToLine(prop.GetName());
        }

        public override Type GetValueType()
        {
            return prop.GetPropType();
        }

        public override bool IsILCostTrivial()
        {
            if (target.IsILCostTrivial())
                return true;

            return false;
        }

        public override bool CanLoad()
        {
            if (prop.CanGet())
                return true;

            return false;
        }

        public override bool CanStore()
        {
            if (prop.CanSet())
                return true;

            return false;
        }
    }
}