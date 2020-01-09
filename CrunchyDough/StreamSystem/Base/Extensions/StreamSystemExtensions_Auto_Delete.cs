using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class StreamSystemExtensions_Auto_Delete
    {
        static public AttemptResult Delete(this StreamSystem item, string path, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            if (item.DoesStreamExist(path))
                return item.DeleteStream(path, milliseconds);

            if (item.DoesDirectoryExist(path))
                return item.DeleteDirectory(path, milliseconds);

            return AttemptResult.Failed;
        }
    }
}