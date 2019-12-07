using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Pantry
{
    using Dough;
    
    public class FileSnapshot_ByPath : FileSnapshot
    {
        private string path;

        public FileSnapshot_ByPath(string p, string n, string m, string h, DateTime w) : base(n, m, h, w)
        {
            path = p;
        }

        public override string GetPath()
        {
            return path;
        }
    }
}