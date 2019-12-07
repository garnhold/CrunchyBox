using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public abstract partial class StreamSystem
    {
        private StreamDirectory_Root root;

        public const long DEFAULT_WAIT = 25;

        public abstract AttemptResult CreateDirectory(string path, long milliseconds = StreamSystem.DEFAULT_WAIT);

        public abstract AttemptResult DeleteDirectory(string path, long milliseconds = StreamSystem.DEFAULT_WAIT);
        public abstract AttemptResult DeleteStream(string path, long milliseconds = StreamSystem.DEFAULT_WAIT);

        public abstract AttemptResult CopyDirectoryNative(string src_path, string dst_path, bool overwrite, long milliseconds = StreamSystem.DEFAULT_WAIT);
        public abstract AttemptResult MoveDirectoryNative(string src_path, string dst_path, bool overwrite, long milliseconds = StreamSystem.DEFAULT_WAIT);

        public abstract AttemptResult CopyStreamNative(string src_path, string dst_path, bool overwrite, long milliseconds = StreamSystem.DEFAULT_WAIT);
        public abstract AttemptResult MoveStreamNative(string src_path, string dst_path, bool overwrite, long milliseconds = StreamSystem.DEFAULT_WAIT);

        public abstract AttemptResult OpenStreamForWriting(string path, out Stream stream, long milliseconds = StreamSystem.DEFAULT_WAIT);
        public abstract AttemptResult OpenStreamForReading(string path, out Stream stream, long milliseconds = StreamSystem.DEFAULT_WAIT);

        public abstract bool TryGetLocalPath(string path, out string local_path);

        public abstract bool DoesStreamExist(string path);
        public abstract bool DoesDirectoryExist(string path);

        public abstract DateTime GetStreamTimestamp(string path);

        public abstract IEnumerable<string> GetStreamNames(string path);
        public abstract IEnumerable<string> GetDirectoryNames(string path);

        public StreamSystem()
        {
            root = new StreamDirectory_Root(this);
        }

        public StreamDirectory GetRoot()
        {
            return root;
        }

        public StreamSource GetStreamSource(string path)
        {
            return new StreamSource(path, this);
        }
    }
}