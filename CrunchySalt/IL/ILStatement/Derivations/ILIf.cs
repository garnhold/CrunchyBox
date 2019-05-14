using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
    public class ILIf : ILStatement
    {
        private ILValue condition;

        private ILStatement if_true_statement;
        private ILStatement if_false_statement;

        public ILIf(ILValue c, ILStatement t, ILStatement f)
        {
            condition = c;

            if_true_statement = t;
            if_false_statement = f;
        }

        public ILIf(ILValue c, ILStatement t) : this(c, t, null) { }

        public override void RenderIL_Execute(ILCanvas canvas)
        {
            ILCanvasLabel exit_label = canvas.CreateLabel();

            condition.GetILImplicitCast(typeof(bool))
                .RenderIL_Load(canvas);

            if (HasElse())
            {
                ILCanvasLabel false_label = canvas.CreateLabel();

                false_label.Emit_Brfalse();
                if_true_statement.RenderIL_Execute(canvas);
                exit_label.Emit_Br();

                false_label.Emit_Label();
                if_false_statement.RenderIL_Execute(canvas);
            }
            else
            {
                exit_label.Emit_Brfalse();
                if_true_statement.RenderIL_Execute(canvas);
            }

            exit_label.Emit_Label();
        }

        public override void RenderText_Statement(ILTextCanvas canvas)
        {
            canvas.AppendNewline();

            canvas.AppendToLine("if(");
                condition.RenderText_Value(canvas);
            canvas.AppendToLine(")");

            canvas.AppendToNewline("{");
            canvas.Indent();
                if_true_statement.RenderText_Statement(canvas);
            canvas.Dedent();
            canvas.AppendToNewline("}");

            if (HasElse())
            {
                canvas.AppendToNewline("else");
                canvas.AppendToNewline("{");
                canvas.Indent();
                    if_false_statement.RenderText_Statement(canvas);
                canvas.Dedent();
                canvas.AppendToNewline("}");
            }
        }

        public bool HasElse()
        {
            if (GetIfFalseStatement() != null)
                return true;

            return false;
        }

        public ILValue GetCondition()
        {
            return condition;
        }

        public ILStatement GetIfTrueStatement()
        {
            return if_true_statement;
        }

        public ILStatement GetIfFalseStatement()
        {
            return if_false_statement;
        }
    }
}