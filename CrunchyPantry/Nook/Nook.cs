using System;
using System.IO;

using CrunchyDough;

namespace CrunchyPantry
{
    public abstract class Nook
    {
        public abstract bool Delete();

        public abstract bool IsPresent();
        public abstract string GetHash();
        public abstract string GetPath();
        public abstract bool TryGetLocalPath(out string local_path);

        public abstract bool Read(Process<Stream> process);
        public abstract bool Write(Process<Stream> process);
    }
}