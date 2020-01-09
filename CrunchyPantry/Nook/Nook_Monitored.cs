using System;
using System.IO;

namespace Crunchy.Pantry
{
    using Dough;
    
    public class Nook_Monitored : Nook
    {
        private Nook nook;
        private NookMonitor nook_monitor;

        public Nook_Monitored(Nook n)
        {
            nook = n;
            nook_monitor = nook.CreateNookMonitor();
        }

        public override bool Delete()
        {
            return nook.Delete();
        }

        public override bool IsPresent()
        {
            return nook.IsPresent();
        }

        public override string GetHash()
        {
            return nook.GetHash();
        }

        public override string GetPath()
        {
            return nook.GetPath();
        }

        public override bool TryGetLocalPath(out string local_path)
        {
            return nook.TryGetLocalPath(out local_path);
        }

        public override bool Read(Process<Stream> process)
        {
            return nook.Read(process);
        }

        public override bool Write(Process<Stream> process)
        {
            return nook.Write(process);
        }

        public NookMonitor GetNookMonitor()
        {
            return nook_monitor;
        }
    }
}