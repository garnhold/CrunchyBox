using System;
using System.IO;

using CrunchyDough;

namespace CrunchyPantry
{
    public class Nook_Pair_Shadowed : Nook_Pair
    {
        public Nook_Pair_Shadowed(Nook d, Nook s) : base(d, s)
        {
        }

        public void Update()
        {
            if (GetDominateNook().GetNookMonitor().IsChanged())
                ForceShadow();
        }

        public void ForceShadow()
        {
            GetDominateNook().CopyTo(GetSubmissiveNook());

            GetDominateNook().GetNookMonitor().Validate();
            GetSubmissiveNook().GetNookMonitor().Validate();
        }
    }
}