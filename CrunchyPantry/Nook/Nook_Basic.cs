using System;
using System.IO;

namespace Crunchy.Pantry
{
    using Dough;
    
    public class Nook_Basic : Nook
    {
        private string path;
        private NookSystem nook_system;

        public Nook_Basic(string p, NookSystem n)
        {
            path = p;
            nook_system = n;
        }

        public override bool Delete()
        {
            return nook_system.Delete(path);
        }

        public override bool IsPresent()
        {
            return nook_system.IsPresent(path);
        }

        public override string GetHash()
        {
            return nook_system.GetHash(path);
        }

        public override string GetPath()
        {
            return path;
        }

        public override bool TryGetLocalPath(out string local_path)
        {
            return nook_system.TryGetLocalPath(path, out local_path);
        }

        public override bool Read(Process<Stream> process)
        {
            return nook_system.Read(path, process);
        }

        public override bool Write(Process<Stream> process)
        {
            return nook_system.Write(path, process);
        }
    }
}