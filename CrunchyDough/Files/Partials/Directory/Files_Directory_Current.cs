using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public partial class Files
    {
        static public string GetWorkingDirectory()
        {
            return Filename.CleanPath(Directory.GetCurrentDirectory() + "/");
        }
    }
}