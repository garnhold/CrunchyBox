using System;
using System.IO;

namespace Crunchy.Pantry
{
    using Dough;
    
    public class NookMonitor
    {
        private Nook nook;
        private string last_hash;

        public NookMonitor(Nook n)
        {
            nook = n;
        }

        public void Validate()
        {
            last_hash = nook.GetHash();
        }

        public void Invalidate()
        {
            last_hash = null;
        }

        public bool IsChanged()
        {
            if (nook.GetHash() != last_hash)
                return true;

            return false;
        }
    }
}