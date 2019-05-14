using System;
using System.IO;
using System.Resources;
using System.Collections;
using System.Collections.Generic;

using System.Globalization;

namespace CrunchyDough
{
    public abstract class StreamSystem_ReadOnly : StreamSystem
    {
        private DateTime timestamp;

        public StreamSystem_ReadOnly()
        {
            timestamp = DateTime.UtcNow;
        }

        public override AttemptResult CreateDirectory(string path, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            throw new InvalidOperationException(GetType() + " cannot create directories.");
        }

        public override AttemptResult DeleteDirectory(string path, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            throw new InvalidOperationException(GetType() + " cannot delete directories.");
        }

        public override AttemptResult DeleteStream(string path, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            throw new InvalidOperationException(GetType() + " cannot delete streams.");
        }

        public override AttemptResult MoveDirectoryNative(string src_path, string dst_path, bool overwrite, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            throw new InvalidOperationException(GetType() + " cannot move directories.");
        }

        public override AttemptResult CopyDirectoryNative(string src_path, string dst_path, bool overwrite, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            throw new InvalidOperationException(GetType() + " cannot copy directories.");
        }

        public override AttemptResult MoveStreamNative(string src_path, string dst_path, bool overwrite, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            throw new InvalidOperationException(GetType() + " cannot move streams.");
        }

        public override AttemptResult CopyStreamNative(string src_path, string dst_path, bool overwrite, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            throw new InvalidOperationException(GetType() + " cannot copy streams.");
        }

        public override AttemptResult OpenStreamForWriting(string path, out Stream stream, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            throw new InvalidOperationException(GetType() + " cannot open streams for writing.");
        }

        public override ByteSequence GetStreamHash(string path, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return HashTypes.SHA1.CalculateAsUnicode(path);
        }

        public override DateTime GetStreamTimestamp(string path)
        {
            return timestamp;
        }
    }
}