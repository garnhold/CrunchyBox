using System;
using System.IO;

using CrunchyDough;

namespace CrunchyPantry
{
    public class Nook_Pair_Linked : Nook_Pair
    {
        public Nook_Pair_Linked(Nook d, Nook s) : base(d, s)
        {
        }

        public void Update()
        {
            if (GetDominateNook().GetNookMonitor().IsChanged())
                PropagateDominate();
            else if (GetSubmissiveNook().GetNookMonitor().IsChanged())
                PropagateSubmissive();
        }

        public void PropagateDominate()
        {
            GetDominateNook().CopyTo(GetSubmissiveNook());

            GetDominateNook().GetNookMonitor().Validate();
            GetSubmissiveNook().GetNookMonitor().Validate();
        }

        public void PropagateSubmissive()
        {
            GetSubmissiveNook().CopyTo(GetDominateNook());

            GetDominateNook().GetNookMonitor().Validate();
            GetSubmissiveNook().GetNookMonitor().Validate();
        }
    }
}