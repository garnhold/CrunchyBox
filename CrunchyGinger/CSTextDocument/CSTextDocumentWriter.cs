using System;
using System.IO;
using System.Text;

using CrunchyDough;

namespace CrunchyGinger
{
    public class CSTextDocumentWriter
    {
        private CSLine line;
        private CSTextDocumentBuilder document_builder;

        public CSTextDocumentWriter(CSLine l, CSTextDocumentBuilder b)
        {
            line = l;
            document_builder = b;
        }

        public CSTextDocumentWriter(CSLine l, TextDocumentNode_Container c) : this(l, new CSTextDocumentBuilder(c)) { }

        public void Write(string text)
        {
            document_builder.Add(new TextDocumentNode_Block_LineText(line.Translate(text)));
        }

        public void Write(string text, Process process, bool require_braces = true, bool require_block = true)
        {
            document_builder.Add(new TextDocumentNode_Block_Section_Indented_CSBlock(line.Translate(text), require_block, require_braces), process);
        }

        public T Write<T>(string text, Operation<T> operation, bool require_braces = true, bool require_block = true)
        {
            T return_value = default(T);

            Write(text, delegate() {
                return_value = operation();
            }, require_braces, require_block);

            return return_value;
        }

        public void SkipLine()
        {
            document_builder.Add(new TextDocumentNode_Block_BlankLine());
        }

        public CSTextDocumentBuilder InsertSection()
        {
            return new CSTextDocumentBuilder(document_builder.Add(new TextDocumentNode_Block_Section()));
        }
    }
}