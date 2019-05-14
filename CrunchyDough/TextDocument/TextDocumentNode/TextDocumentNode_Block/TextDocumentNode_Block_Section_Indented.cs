using System;
using System.Text;

using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class TextDocumentNode_Block_Section_Indented : TextDocumentNode_Block_Section
    {
        public override void Render(TextDocumentCanvas canvas)
        {
            canvas.Indent();
                base.Render(canvas);
            canvas.Dedent();
        }
    }
}