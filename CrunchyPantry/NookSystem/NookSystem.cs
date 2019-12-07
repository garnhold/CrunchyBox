using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Pantry
{
    using Dough;
    
    public abstract class NookSystem
    {
        public abstract bool Delete(string path);

        public abstract bool IsPresent(string path);
        public abstract string GetHash(string path);
        public abstract bool TryGetLocalPath(string path, out string local_path);

        public abstract bool Read(string path, Process<Stream> process);
        public abstract bool Write(string path, Process<Stream> process);

        public abstract IEnumerable<string> GetPaths(string path);
    }
}