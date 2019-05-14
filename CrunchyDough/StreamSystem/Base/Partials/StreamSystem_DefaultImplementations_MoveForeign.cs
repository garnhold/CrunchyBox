using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public abstract partial class StreamSystem
    {
        public virtual AttemptResult MoveDirectoryForeign(string src_path, StreamSystem dst, string dst_path, bool overwrite, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            AttemptResult result = CopyDirectoryForeign(src_path, dst, dst_path, overwrite, milliseconds);

            if (result.IsDesired())
                DeleteDirectory(src_path);

            return result;
        }

        public virtual AttemptResult MoveStreamForeign(string src_path, StreamSystem dst, string dst_path, bool overwrite, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            AttemptResult result = CopyStreamForeign(src_path, dst, dst_path, overwrite, milliseconds);

            if (result.IsDesired())
                DeleteStream(src_path);

            return result;
        }
    }
}