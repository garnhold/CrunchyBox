using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class StreamSystemExtensions_Auto_Move
    {
        static public AttemptResult Move(this StreamSystem item, string src_path, StreamSystem dst, string dst_path, bool overwrite, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            if (item.DoesStreamExist(src_path))
                return item.MoveStream(src_path, dst, dst_path, overwrite, milliseconds);

            if (item.DoesDirectoryExist(src_path))
                return item.MoveDirectory(src_path, dst, dst_path, overwrite, milliseconds);

            return AttemptResult.Failed;
        }
    }
}