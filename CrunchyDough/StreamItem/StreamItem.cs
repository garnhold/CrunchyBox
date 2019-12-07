using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public abstract class StreamItem
    {
        private string name;
        private StreamDirectory parent_directory;

        public abstract string GetPath();

        private void SetName(string n)
        {
            name = Filename.CleanFilename(n);
        }

        private void SetParentDirectory(StreamDirectory d)
        {
            parent_directory = d;
        }

        public StreamItem(string n, StreamDirectory d)
        {
            SetName(n);
            SetParentDirectory(d);
        }

        public AttemptResult Delete(long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return GetStreamSystem().Delete(GetPath(), milliseconds);
        }

        public AttemptResult Rename(string new_name, bool overwrite, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            AttemptResult result = GetStreamSystem().Rename(
                GetPath(),
                new_name,
                overwrite,
                milliseconds
            );

            if (result.IsDesired())
                SetName(new_name);

            return result;
        }

        public AttemptResult CopyTo(StreamDirectory destination, bool overwrite, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return GetStreamSystem().Copy(
                GetPath(),
                destination.GetStreamSystem(),
                destination.GetChildPath(GetName()),
                overwrite,
                milliseconds
            );
        }

        public AttemptResult MoveTo(StreamDirectory destination, bool overwrite, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            AttemptResult result = GetStreamSystem().Move(
                GetPath(),
                destination.GetStreamSystem(),
                destination.GetChildPath(GetName()),
                overwrite,
                milliseconds
            );

            if (result.IsDesired())
                SetParentDirectory(destination);

            return result;
        }

        public string GetName()
        {
            return name;
        }

        public StreamDirectory GetParentDirectory()
        {
            return parent_directory;
        }

        public virtual StreamSystem GetStreamSystem()
        {
            return parent_directory.IfNotNull(d => d.GetStreamSystem());
        }
    }
}