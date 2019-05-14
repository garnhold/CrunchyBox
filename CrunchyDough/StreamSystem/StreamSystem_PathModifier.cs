using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public abstract class StreamSystem_PathModifier : StreamSystem
    {
        private StreamSystem stream_system;

        protected abstract string CalculatePath(string path);

        public StreamSystem_PathModifier(StreamSystem s) 
        {
            stream_system = s;
        }

        public override AttemptResult CreateDirectory(string path, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return stream_system.CreateDirectory(CalculatePath(path), milliseconds);
        }

        public override AttemptResult DeleteDirectory(string path, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return stream_system.DeleteDirectory(CalculatePath(path), milliseconds);
        }

        public override AttemptResult DeleteStream(string path, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return stream_system.DeleteStream(CalculatePath(path), milliseconds);
        }

        public override AttemptResult CopyDirectoryNative(string src_path, string dst_path, bool overwrite, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return stream_system.CopyDirectoryNative(CalculatePath(src_path), CalculatePath(dst_path), overwrite, milliseconds);
        }

        public override AttemptResult MoveDirectoryNative(string src_path, string dst_path, bool overwrite, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return stream_system.MoveDirectoryNative(CalculatePath(src_path), CalculatePath(dst_path), overwrite, milliseconds);
        }

        public override AttemptResult MoveStreamNative(string src_path, string dst_path, bool overwrite, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return stream_system.MoveStreamNative(CalculatePath(src_path), CalculatePath(dst_path), overwrite, milliseconds);
        }

        public override AttemptResult CopyStreamNative(string src_path, string dst_path, bool overwrite, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return stream_system.CopyStreamNative(CalculatePath(src_path), CalculatePath(dst_path), overwrite, milliseconds);
        }

        public override AttemptResult CopyDirectoryForeign(string src_path, StreamSystem dst, string dst_path, bool overwrite, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return stream_system.CopyDirectoryForeign(CalculatePath(src_path), dst, dst_path, overwrite, milliseconds);
        }

        public override AttemptResult MoveDirectoryForeign(string src_path, StreamSystem dst, string dst_path, bool overwrite, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return stream_system.MoveDirectoryForeign(CalculatePath(src_path), dst, dst_path, overwrite, milliseconds);
        }

        public override AttemptResult MoveStreamForeign(string src_path, StreamSystem dst, string dst_path, bool overwrite, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return stream_system.MoveStreamForeign(CalculatePath(src_path), dst, dst_path, overwrite, milliseconds);
        }

        public override AttemptResult CopyStreamForeign(string src_path, StreamSystem dst, string dst_path, bool overwrite, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return stream_system.CopyStreamForeign(CalculatePath(src_path), dst, dst_path, overwrite, milliseconds);
        }

        public override AttemptResult OpenStreamForReading(string path, out Stream stream, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return stream_system.OpenStreamForReading(CalculatePath(path), out stream, milliseconds);
        }

        public override AttemptResult OpenStreamForWriting(string path, out Stream stream, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return stream_system.OpenStreamForWriting(CalculatePath(path), out stream, milliseconds);
        }

        public override ByteSequence GetStreamHash(string path, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return stream_system.GetStreamHash(CalculatePath(path), milliseconds);
        }

        public override bool TryGetLocalPath(string path, out string local_path)
        {
            return stream_system.TryGetLocalPath(CalculatePath(path), out local_path);
        }

        public override bool DoesStreamExist(string path)
        {
            return stream_system.DoesStreamExist(CalculatePath(path));
        }

        public override bool DoesDirectoryExist(string path)
        {
            return stream_system.DoesDirectoryExist(CalculatePath(path));
        }

        public override DateTime GetStreamTimestamp(string path)
        {
            return stream_system.GetStreamTimestamp(CalculatePath(path));
        }

        public override IEnumerable<string> GetStreamNames(string path)
        {
            return stream_system.GetStreamNames(CalculatePath(path));
        }

        public override IEnumerable<string> GetDirectoryNames(string path)
        {
            return stream_system.GetDirectoryNames(CalculatePath(path));
        }

        public StreamSystem GetInternalStreamSystem()
        {
            return stream_system;
        }
    }
}