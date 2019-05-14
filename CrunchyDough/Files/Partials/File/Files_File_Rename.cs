using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public partial class Files
    {
        static public AttemptResult RenameFile(string full_filename, string new_filename, bool overwrite, long milliseconds = DEFAULT_WAIT)
        {
            return MoveFile(full_filename, Filename.MakeFilename(full_filename, new_filename), overwrite, milliseconds);
        }
    }
}