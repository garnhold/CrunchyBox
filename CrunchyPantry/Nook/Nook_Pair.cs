using System;
using System.IO;

namespace Crunchy.Pantry
{
    using Dough;
    
    public abstract class Nook_Pair : Nook
    {
        private Nook_Monitored dominate_nook;
        private Nook_Monitored submissive_nook;

        public Nook_Pair(Nook d, Nook s)
        {
            dominate_nook = new Nook_Monitored(d);
            submissive_nook = new Nook_Monitored(s);
        }

        public override bool Delete()
        {
            return dominate_nook.Delete() & submissive_nook.Delete();
        }

        public override bool IsPresent()
        {
            return dominate_nook.IsPresent();
        }

        public override string GetHash()
        {
            return dominate_nook.GetHash();
        }

        public override string GetPath()
        {
            return dominate_nook.GetPath();
        }

        public override bool TryGetLocalPath(out string local_path)
        {
            if (dominate_nook.TryGetLocalPath(out local_path))
                return true;

            if (submissive_nook.TryGetLocalPath(out local_path))
                return true;

            return false;
        }

        public override bool Read(Process<Stream> process)
        {
            return dominate_nook.Read(process);
        }

        public override bool Write(Process<Stream> process)
        {
            return dominate_nook.Write(process);
        }

        public Nook_Monitored GetDominateNook()
        {
            return dominate_nook;
        }

        public Nook_Monitored GetSubmissiveNook()
        {
            return submissive_nook;
        }
    }
}