using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public partial class Files
    {
        static public DateTime GetFileTimestamp(string filename)
        {
            DateTime creation_time = File.GetCreationTimeUtc(filename);
            DateTime last_write_time = File.GetLastWriteTimeUtc(filename);

            if (last_write_time > creation_time)
                return last_write_time;

            return creation_time;
        }

        static public bool IsFileNewer(string filename, string than)
        {
            if (GetFileTimestamp(filename) > GetFileTimestamp(than))
                return true;

            return false;
        }

        static public bool IsFileOlder(string filename, string than)
        {
            if (GetFileTimestamp(filename) < GetFileTimestamp(than))
                return true;

            return false;
        }
    }
}