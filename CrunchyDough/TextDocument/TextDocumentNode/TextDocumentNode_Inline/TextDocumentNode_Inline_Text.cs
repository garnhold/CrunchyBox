using System;
using System.Text;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class TextDocumentNode_Inline_Text : TextDocumentNode
    {
        private string text;

        public TextDocumentNode_Inline_Text(string t) : base(TextDocumentNodeType.Inline)
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
            canvas.AppendToLine(text);
        }
    }
}