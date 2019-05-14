using System;
using System.Text;

using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class TextDocumentNode_Block_BlockText : TextDocumentNode
    {
        private string text;

        public TextDocumentNode_Block_BlockText(string t) : base(TextDocumentNodeType.Block)
        {
            text = t;
        }

        public override bool IsVisible()
        {
            if (text.IsVisible())
                return true;

            return false;
        }

        public override void Render(TextDocumentCanvas canvas)
        {
            canvas.AppendLines(text);
        }
    }
}