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
    
    public class ILChain : ILValue
    {
        private ILStatement statement;
        private ILValue value;

        public ILChain(ILStatement s, ILValue v)
        {
            statement = s;
            value = v;
        }

        public override void RenderIL_Load(ILCanvas canvas)
        {
            statement.RenderIL_Execute(canvas);
            value.RenderIL_Load(canvas);
        }

        public override void RenderText_Value(ILTextCanvas canvas)
        {
            canvas.AppendToLine("{");
                statement.RenderText_Statement(canvas);
            canvas.AppendToLine("}");

            canvas.AppendToLine("->{");
                value.RenderText_Value(canvas);
            canvas.AppendToLine("}");
        }

        public override Type GetValueType()
        {
            return value.GetValueType();
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