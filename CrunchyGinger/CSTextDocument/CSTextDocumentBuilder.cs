using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyGinger
{
    public class CSTextDocumentBuilder : DocumentBuilder<TextDocumentNode, TextDocumentCanvas>
    {
        public CSTextDocumentBuilder(TextDocumentNode_Container c) : base(c) { }

        public CSTextDocumentWriter CreateWriter()
        {
            return new CSTextDocumentWriter(new CSLine_Simple(), this);
        }

        public CSTextDocumentWriter CreateWriterWithVariablePairs(IEnumerable<KeyValuePair<string, string>> pairs)
        {
            return new CSTextDocumentWriter(new CSLine_VariableTable(pairs), this);
        }
        public CSTextDocumentWriter CreateWriterWithVariablePairs(params KeyValuePair<string, string>[] pairs)
        {
            return new CSTextDocumentWriter(new CSLine_VariableTable(pairs), this);
        }
        public CSTextDocumentWriter CreateWriterWithVariablePairs(IEnumerable<string> pairs)
        {
            return new CSTextDocumentWriter(new CSLine_VariableTable(pairs), this);
        }
        public CSTextDocumentWriter CreateWriterWithVariablePairs(params string[] pairs)
        {
            return new CSTextDocumentWriter(new CSLine_VariableTable(pairs), this);
        }
    }
}