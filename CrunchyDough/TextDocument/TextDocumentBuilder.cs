using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class TextDocumentBuilder : DocumentBuilder<TextDocumentNode, TextDocumentCanvas>
    {
        public TextDocumentBuilder(TextDocumentNode_Container c) : base(c) { }

        public TextDocumentWriter CreateTextWriter()
        {
            return new TextDocumentWriter(this);
        }
    }
}