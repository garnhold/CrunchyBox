using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class StreamSystemExtensions_General_Move
    {
        static public AttemptResult MoveDirectory(this StreamSystem item, string src_path, StreamSystem dst, string dst_path, bool overwrite, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            if (dst == item)
                return item.MoveDirectoryNative(src_path, dst_path, overwrite, milliseconds);

            return item.MoveDirectoryForeign(src_path, dst, dst_path, overwrite, milliseconds);
        }

        static public AttemptResult MoveStream(this StreamSystem item, string src_path, StreamSystem dst, string dst_path, bool overwrite, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            if (dst == item)
                return item.MoveStreamNative(src_path, dst_path, overwrite, milliseconds);

            return item.MoveStreamForeign(src_path, dst, dst_path, overwrite, milliseconds);
        }
    }
}