using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    public class ILWhile : ILStatement
    {
        private ILValue condition;
        private ILStatement while_statement;

        public ILWhile(ILValue c, ILStatement w)
        {
            condition = c;
            while_statement = w;
        }

        public override void RenderIL_Execute(ILCanvas canvas)
        {
            ILCanvasLabel entry_label = canvas.CreateLabel();
            ILCanvasLabel exit_label = canvas.CreateLabel();

            entry_label.Emit_Label();

            condition.GetILImplicitCast(typeof(bool))
                .RenderIL_Load(canvas);

            exit_label.Emit_Brfalse();
            while_statement.RenderIL_Execute(canvas);
            entry_label.Emit_Br();

            exit_label.Emit_Label();
        }

        public override void RenderText_Statement(ILTextCanvas canvas)
        {
            canvas.AppendNewline();

            canvas.AppendToLine("while(");
                condition.RenderText_ValueEX(canvas);
            canvas.AppendToLine(")");

            canvas.AppendToNewline("{");
            canvas.Indent();
                while_statement.RenderText_StatementEX(canvas);
            canvas.Dedent();
            canvas.AppendToNewline("}");
        }

        public ILValue GetCondition()
        {
            return condition;
        }

        public ILStatement GetWhileStatement()
        {
            return while_statement;
        }
    }
}