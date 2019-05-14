using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class TextDocumentWriter
    {
        private TextDocumentBuilder document_builder;

        public TextDocumentWriter(TextDocumentBuilder b)
        {
            document_builder = b;
        }

        public TextDocumentWriter(TextDocumentNode_Container c) : this(new TextDocumentBuilder(c)) { }

        public void WriteLine(string text)
        {
            document_builder.Add(new TextDocumentNode_Block_LineText(text));
        }

        public void WriteBlankLine()
        {
            document_builder.Add(new TextDocumentNode_Block_BlankLine());
        }

        public void WriteIndented(Process process)
        {
            document_builder.Add(new TextDocumentNode_Block_Section_Indented(), process);
        }

        public TextDocumentBuilder InsertSection()
        {
            return new TextDocumentBuilder(document_builder.Add(new TextDocumentNode_Block_Section()));
        }
    }
}