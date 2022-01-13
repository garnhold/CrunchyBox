using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
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

        public override void RenderText_Value(ILTextCanvas canvas)
        {
            canvas.AppendToLine("{");
            canvas.AppendNewline();
            canvas.Indent();
                statement.RenderText_StatementEX(canvas);
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
    }
}