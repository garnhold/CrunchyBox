using System;
using System.Text;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class TextDocumentCanvas
    {
        private StringBuilder string_builder;
        private StringIndentation_Tab indentation;

        public TextDocumentCanvas()
        {
            string_builder = new StringBuilder();
            indentation = new StringIndentation_Tab();
        }

        public void AppendToLine(string text)
        {
            string_builder.Append(text.MakeSingleLine());
        }

        public void AppendToNewline(string text)
        {
            AppendNewline();
            AppendToLine(text);
        }

        public void AppendLines(string text)
        {
            text.Split('\n').Process(s => AppendToNewline(s));
        }

        public void AppendNewline()
        {
            string_builder.Append(indentation.GetIndentedNewlineString());
        }

        public void Indent()
        {
            indentation.IncreaseLevel();
        }

        public void Dedent()
        {
            indentation.DecreaseLevel();
        }

        public override string ToString()
        {
            return string_builder.ToString();
        }
    }
}