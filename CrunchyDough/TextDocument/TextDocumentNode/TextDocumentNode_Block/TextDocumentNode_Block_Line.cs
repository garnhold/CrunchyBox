using System;
using System.Text;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class TextDocumentNode_Block_Line : TextDocumentNode_Container
    {
        public TextDocumentNode_Block_Line() : base(TextDocumentNodeType.Block, TextDocumentNodeType.Inline) { }

        public override void Render(TextDocumentCanvas canvas)
        {
            canvas.AppendNewline();
            base.Render(canvas);
        }
    }
}