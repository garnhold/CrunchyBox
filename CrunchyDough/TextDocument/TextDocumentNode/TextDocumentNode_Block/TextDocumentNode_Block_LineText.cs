using System;
using System.Text;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class TextDocumentNode_Block_LineText : TextDocumentNode
    {
        private string text;

        public TextDocumentNode_Block_LineText(string t) : base(TextDocumentNodeType.Block)
        {
            text = t;
        }

        public override bool IsVisible()
        {
            if (text.IsVisible())
                return true;

            return false;
        }

        public override void Render(TextDocumentCanvas target)
        {
            target.AppendToNewline(text);
        }
    }
}