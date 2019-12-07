using System;
using System.Text;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public abstract class TextDocumentNode : DocumentNode<TextDocumentCanvas>
    {
        private TextDocumentNodeType type;

        public TextDocumentNode(TextDocumentNodeType t)
        {
            type = t;
        }

        public TextDocumentNodeType GetTextDocumentNodeType()
        {
            return type;
        }
    }
}