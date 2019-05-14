using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class StreamSystemExtensions_Auto_Rename
    {
        static public AttemptResult Rename(this StreamSystem item, string path, string new_name, bool overwrite, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            if (item.DoesStreamExist(path))
                return item.RenameStream(path, new_name, overwrite, milliseconds);

            if (item.DoesDirectoryExist(path))
                return item.RenameDirectory(path, new_name, overwrite, milliseconds);

            return AttemptResult.Failed;
        }
    }
}