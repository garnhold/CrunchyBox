using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    public class ILInjectCave : ILStatement
    {
        private ILLabel entry_label;
        private ILStatement statement;

        public ILInjectCave(ILStatement s)
        {
            entry_label = new ILLabel();
            statement = s;
        }

        public ILGoTo CreateGoTo()
        {
            return entry_label.CreateGoTo();
        }

        public override void RenderIL_Execute(ILCanvas canvas)
        {
            ILCanvasLabel after_label = canvas.CreateLabel();

            after_label.Emit_Br();

            entry_label.RenderIL_Execute(canvas);
            statement.RenderIL_Execute(canvas);

            after_label.Emit_Label();
        }

        public override void RenderText_Statement(ILTextCanvas canvas)
        {
            canvas.AppendNewline();

            canvas.AppendToLine("if(false)");
            canvas.AppendToNewline("{");
            canvas.Indent();
                entry_label.RenderText_Statement(canvas);
                statement.RenderText_Statement(canvas);
            canvas.Dedent();
            canvas.AppendToNewline("}");
        }

        public ILLabel GetEntryLabel()
        {
            return entry_label;
        }
    }
}