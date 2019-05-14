using System;
using System.Text;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyGinger
{
    public class TextDocumentNode_Block_Section_Indented_CSBlock : TextDocumentNode_Block_Section_Indented
    {
        private string text;
        private bool is_required;
        private bool is_braces_required;

        public TextDocumentNode_Block_Section_Indented_CSBlock(string t, bool r, bool br)
        {
            text = t;
            is_required = r;
            is_braces_required = br;
        }

        public override bool IsVisible()
        {
            if(is_required || this.HasVisibleChild())
                return true;

            return false;
        }

        public override void Render(TextDocumentCanvas canvas)
        {
            canvas.AppendToNewline(text);
                canvas.AppendToNewline("{");
                    base.Render(canvas);
                canvas.AppendToNewline("}");
            canvas.AppendNewline();
        }
    }
}