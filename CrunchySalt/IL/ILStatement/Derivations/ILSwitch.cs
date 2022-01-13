using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    public class ILSwitch : ILStatement
    {
        private ILValue input;

        private List<ILCase> cases;
        private ILStatement default_statement;

        private void RenderIL_ExecuteInternal(ILCanvas canvas, ILValue value, ILStatement else_statement)
        {
            int index = cases.Count / 2;

            canvas.UseValue(value, delegate(ILValue local) {
                cases[index].GenerateStatement(local, cases, else_statement, 0, cases.Count, index)
                    .RenderIL_Execute(canvas);
            });
        }

        public ILSwitch(ILValue i, ILStatement d, IEnumerable<ILCase> c)
        {
            input = i;

            cases = c.Sort(z => (IComparable)z.GetLabelValue()).ToList();
            default_statement = d;
        }

        public ILSwitch(ILValue i, ILStatement d, params ILCase[] c) : this(i, d, (IEnumerable<ILCase>)c) { }

        public ILSwitch(ILValue i, IEnumerable<ILCase> c) : this(i, null, c) { }
        public ILSwitch(ILValue i, params ILCase[] c) : this(i, (IEnumerable<ILCase>)c) { }

        public override void RenderIL_Execute(ILCanvas canvas)
        {
            if (default_statement == null)
                RenderIL_ExecuteInternal(canvas, input, null);
            else
            {
                ILInjectCave cave = new ILInjectCave(default_statement);

                RenderIL_ExecuteInternal(canvas, input, cave.CreateGoTo());
                cave.RenderIL_Execute(canvas);
            }
        }

        public override void RenderText_Statement(ILTextCanvas canvas)
        {
            canvas.AppendNewline();

            canvas.AppendToLine("switch(");
                input.RenderText_ValueEX(canvas);
            canvas.AppendToLine(")");

            canvas.AppendToNewline("{");
            canvas.Indent();
                cases.Process(c => c.RenderText_Case(canvas));

                if (default_statement != null)
                {
                    canvas.AppendToNewline("default case:");
                    canvas.Indent();
                        default_statement.RenderText_StatementEX(canvas);
                        canvas.AppendToNewline("break;");
                    canvas.Dedent();
                }
            canvas.Dedent();
            canvas.AppendToNewline("}");
        }
    }
}