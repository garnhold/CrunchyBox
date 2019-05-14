using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class StreamSystem_FileStream : StreamSystem
    {
        static public readonly StreamSystem_FileStream INSTANCE = new StreamSystem_FileStream();

        private StreamSystem_FileStream() { }

        public override AttemptResult CreateDirectory(string path, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return Files.CreateDirectory(path, milliseconds);
        }

        public override AttemptResult DeleteDirectory(string path, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return Files.DeleteDirectory(path, milliseconds);
        }

        public override AttemptResult DeleteStream(string path, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return Files.DeleteFile(path, milliseconds);
        }

        public override AttemptResult CopyDirectoryNative(string path, string new_path, bool overwrite, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return Files.CopyDirectory(path, new_path, overwrite, milliseconds);
        }

        public override AttemptResult MoveDirectoryNative(string path, string new_path, bool overwrite, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return Files.MoveDirectory(path, new_path, overwrite, milliseconds);
        }

        public override AttemptResult MoveStreamNative(string path, string new_path, bool overwrite, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return Files.MoveFile(path, new_path, overwrite, milliseconds);
        }

        public override AttemptResult CopyStreamNative(string path, string new_path, bool overwrite, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return Files.CopyFile(path, new_path, overwrite, milliseconds);
        }

        public override AttemptResult OpenStreamForReading(string path, out Stream stream, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return Files.OpenStreamForReading(path, out stream, milliseconds);
        }

        public override AttemptResult OpenStreamForWriting(string path, out Stream stream, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return Files.OpenStreamForWriting(path, out stream, milliseconds);
        }

        public override bool TryGetLocalPath(string path, out string local_path)
        {
            local_path = path;

            return true;
        }

        public override bool DoesStreamExist(string path)
        {
            return Files.DoesFileExist(path);
        }

        public override bool DoesDirectoryExist(string path)
        {
            return Files.DoesDirectoryExist(path);
        }

        public override DateTime GetStreamTimestamp(string path)
        {
            return Files.GetFileTimestamp(path);
        }

        public override IEnumerable<string> GetStreamNames(string path)
        {
            return Files.GetRelativeFilenamesInDirectory(path);
        }

        public override IEnumerable<string> GetDirectoryNames(string path)
        {
            return Files.GetRelativeDirectorysInDirectory(path);
        }
    }
}