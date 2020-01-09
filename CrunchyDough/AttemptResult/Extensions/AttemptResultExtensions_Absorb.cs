using System;

namespace Crunchy.Dough
{
    static public class AttemptResultExtensions_Absorb
    {
        static public int GetSeverity(this AttemptResult item)
        {
            switch (item)
            {
                case AttemptResult.Unneeded: return 0;
                case AttemptResult.Succeeded: return 1;
                case AttemptResult.Tried: return 2;
                case AttemptResult.Failed: return 3;
            }

            throw new UnaccountedBranchException("item", item);
        }

        static public AttemptResult GetAbsorbed(this AttemptResult item, AttemptResult to_absorb)
        {
            if (to_absorb.GetSeverity() > item.GetSeverity())
                return to_absorb;

            return item;
        }
    }
}