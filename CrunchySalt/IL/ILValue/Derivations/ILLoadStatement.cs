using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
    public class ILLoadStatement : ILValue
    {
        private Type type;
        private ILStatement statement;

        public ILLoadStatement(Type t, ILStatement s)
        {
            type = t;
            statement = s;
        }

        public ILLoadStatement(Operation<ILValue, ILBlock> o)
        {
            ILBlock block = new ILBlock();
            ILValue value = o(block);

            block.AddStatement(new ILLoad(value));

            type = value.GetValueType();
            statement = block;
        }

        public override void RenderIL_Load(ILCanvas canvas)
        {
            statement.RenderIL_Execute(canvas);
        }

        public override void RenderIL_Store(ILCanvas canvas, ILValue value)
        {
            throw new InvalidOperationException(GetType() + " doesn't support storing.");
        }

        public override void RenderText_Value(ILTextCanvas canvas)
        {
            canvas.AppendToLine("{");
            canvas.AppendNewline();
            canvas.Indent();
                statement.RenderText_Statement(canvas);
            canvas.Dedent();
            canvas.AppendToNewline("}");
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