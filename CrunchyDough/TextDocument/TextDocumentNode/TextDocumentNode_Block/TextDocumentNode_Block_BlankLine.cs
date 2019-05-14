using System;
using System.Text;

using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class TextDocumentNode_Block_BlankLine : TextDocumentNode
    {
        public TextDocumentNode_Block_BlankLine() : base(TextDocumentNodeType.Block) { }

        public override bool IsVisible()
        {
            return true;
        }

        public override void Render(TextDocumentCanvas canvas)
        {
            canvas.AppendNewline();
        }
    }
}