using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class TextWriterExtensions
    {
        static public void WriteLines(this TextWriter item, IEnumerable<string> lines)
        {
            lines.Process(l => item.WriteLine(l));
        }
    }
}