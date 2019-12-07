using System;
using System.IO;
using System.Resources;
using System.Collections;
using System.Collections.Generic;

using System.Globalization;

namespace Crunchy.Dough
{
    public class StreamSystem_ResourceManager : StreamSystem_ReadOnly
    {
        private ResourceManager resource_manager;

        public StreamSystem_ResourceManager(ResourceManager r)
        {
            resource_manager = r;
        }

        public override AttemptResult OpenStreamForReading(string path, out Stream stream, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            stream = resource_manager.GetStreamEX(path);
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
            return resource_manager.DoesResourceExist(path);
        }

        public override bool DoesDirectoryExist(string path)
        {
            return false;
        }

        public override IEnumerable<string> GetStreamNames(string path)
        {
            return resource_manager.GetKeys();
        }

        public override IEnumerable<string> GetDirectoryNames(string path)
        {
            return Empty.IEnumerable<string>();
        }
    }
}