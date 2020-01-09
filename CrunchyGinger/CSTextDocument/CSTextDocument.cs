using System;
using System.IO;
using System.Text;

namespace Crunchy.Ginger
{
    using Dough;
    
    public class CSTextDocument : TextDocument
    {
        private CSHeader header;

        static private CSHeader DEFAULT_HEADER = new CSHeader_SimpleDated();

        public CSTextDocument(CSHeader h)
        {
            SetHeader(h);
        }

        public CSTextDocument() : this(null) { }

        public void SetHeader(CSHeader h)
        {
            header = h;
        }

        public string GenerateHeader()
        {
            if (header != null)
                return header.GenerateHeader();

            return DEFAULT_HEADER.GenerateHeader();
        }

        public CSTextDocumentBuilder CreateCSTextBuilder()
        {
            return new CSTextDocumentBuilder(this);
        }

        public override string RenderDocument()
        {
            TextDocumentCanvas canvas = new TextDocumentCanvas();

            canvas.AppendLines(GenerateHeader());
            canvas.AppendNewline();

            Render(canvas);
            return canvas.ToString();
        }
    }
}