using System;
using System.Text;

using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class TextDocumentNode_Block_Section : TextDocumentNode_Container
    {
        public TextDocumentNode_Block_Section() : base(TextDocumentNodeType.Block, TextDocumentNodeType.Block) { }
    }
}