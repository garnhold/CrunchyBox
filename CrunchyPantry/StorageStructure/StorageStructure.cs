using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Pantry
{
    using Dough;
    
    public abstract class StorageStructure<T> where T : FileSnapshot
    {
        public abstract void Clear();
        public abstract void Add(T file);

        public abstract bool TryGetFile(string path, out T file);
        public abstract IEnumerable<string> GetPaths(string path);
    }
}