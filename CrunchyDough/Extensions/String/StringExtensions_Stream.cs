using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class StringExtensions_Stream
    {
        static public Stream CreateStream(this string item)
        {
            Stream stream = new MemoryStream();

            stream.WriteText(item);
            stream.Position = 0;
            return stream;
        }
    }
}