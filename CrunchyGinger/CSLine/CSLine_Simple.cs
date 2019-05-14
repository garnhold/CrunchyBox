using System;
using System.Collections;
using System.Collections.Generic;

using System.IO;
using System.Text;
using System.Text.RegularExpressions;

using CrunchyDough;

namespace CrunchyGinger
{
    public class CSLine_Simple : CSLine
    {
        public CSLine_Simple()
        {
        }

        public override string Translate(string input)
        {
            return input;
        }
    }
}