using System;
using System.IO;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class StreamSystem_Assembly : StreamSystem_ReadOnly
    {
        private Assembly assembly;

        public StreamSystem_Assembly(Assembly a)
        {
            assembly = a;
        }

        public override AttemptResult OpenStreamForReading(string path, out Stream stream, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            stream = assembly.GetManifestResourceStream(path);
            if (stream != null)
                return AttemptResult.Succeeded;

            return AttemptResult.Failed;
        }

        public override bool TryGetLocalPath(string path, out string local_path)
        {
            local_path = "";

            return false;
        }

        public override bool DoesStreamExist(string path)
        {
            if (assembly.GetManifestResourceNames().Has(path))
                return true;

            return false;
        }

        public override bool DoesDirectoryExist(string path)
        {
            return false;
        }

        public override IEnumerable<string> GetStreamNames(string path)
        {
            return assembly.GetManifestResourceNames();
        }

        public override IEnumerable<string> GetDirectoryNames(string path)
        {
            return Empty.IEnumerable<string>();
        }
    }
}