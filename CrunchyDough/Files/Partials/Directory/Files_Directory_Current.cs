using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public partial class Files
    {
        static public string GetWorkingDirectory()
        {
            return Filename.CleanPath(Directory.GetCurrentDirectory() + "/");
        }
    }
}