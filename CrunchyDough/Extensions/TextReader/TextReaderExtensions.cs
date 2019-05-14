using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class TextReaderExtensions
    {
        static public IEnumerable<string> ReadLines(this TextReader item)
        {
            string line;

            while ((line = item.ReadLine()) != null)
                yield return line;
        }
    }
}