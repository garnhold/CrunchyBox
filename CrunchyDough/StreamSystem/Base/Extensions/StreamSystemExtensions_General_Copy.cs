using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class StreamSystemExtensions_General_Copy
    {
        static public AttemptResult CopyDirectory(this StreamSystem item, string src_path, StreamSystem dst, string dst_path, bool overwrite, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            if (dst == item)
                return item.CopyDirectoryNative(src_path, dst_path, overwrite, milliseconds);

            return item.CopyDirectoryForeign(src_path, dst, dst_path, overwrite, milliseconds);
        }

        static public AttemptResult CopyStream(this StreamSystem item, string src_path, StreamSystem dst, string dst_path, bool overwrite, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            if (dst == item)
                return item.CopyStreamNative(src_path, dst_path, overwrite, milliseconds);

            return item.CopyStreamForeign(src_path, dst, dst_path, overwrite, milliseconds);
        }
    }
}