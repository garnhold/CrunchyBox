using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public abstract partial class StreamSystem
    {
        public virtual AttemptResult RenameStream(string path, string new_name, bool overwrite, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return MoveStreamNative(path, Filename.SetFilenameWithExtension(path, new_name), overwrite, milliseconds);
        }

        public virtual AttemptResult RenameDirectory(string path, string new_name, bool overwrite, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return MoveDirectoryNative(path, Filename.SetFilenameWithExtension(path, new_name), overwrite, milliseconds);
        }
    }
}