using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
    public class ILCase
    {
        private ILLiteral label;
        private ILStatement statement;

        public ILCase(ILLiteral l, ILStatement s)
        {
            label = l;
            statement = s;
        }

        public ILStatement GenerateStatement(ILValue value, IList<ILCase> cases, ILStatement else_statement, int min_index, int max_index, int index)
        {
            int less_index = (index + min_index) / 2;
            int greater_index = (index + max_index) / 2;

            if (index == min_index || index == max_index)
            {
                return new ILIf(
                    value.GetILEqualTo(label),
                    statement,
                    else_statement
                );
            }

            return new ILIf(
                value.GetILLessThan(label),
                cases[less_index].GenerateStatement(value, cases, else_statement, min_index, index, less_index),
                cases[greater_index].GenerateStatement(value, cases, else_statement, index, max_index, greater_index)
            );
        }

        public void RenderText_Case(ILTextCanvas canvas)
        {
            canvas.AppendNewline();
            canvas.AppendNewline();

            canvas.AppendToLine("case ");
            label.RenderText_Value(canvas);
            canvas.AppendToLine(":");

            canvas.Indent();
                statement.RenderText_Statement(canvas);
                canvas.AppendToNewline("break;");
            canvas.Dedent();
        }

        public object GetLabelValue()
        {
            return label.GetLiteralValue();
        }
    }
}