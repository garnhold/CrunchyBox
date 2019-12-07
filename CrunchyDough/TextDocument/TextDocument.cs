using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class TextDocument : TextDocumentNode_Container
    {
        public TextDocument() : base(TextDocumentNodeType.Root, TextDocumentNodeType.Block) { }

        public virtual string RenderDocument()
        {
            return this.Render().ToString();
        }

        public TextDocumentBuilder CreateTextBuilder()
        {
            return new TextDocumentBuilder(this);
        }
    }
}