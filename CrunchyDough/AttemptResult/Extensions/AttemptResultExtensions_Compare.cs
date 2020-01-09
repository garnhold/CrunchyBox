using System;

namespace Crunchy.Dough
{
    static public class AttemptResultExtensions_Compare
    {
        static public bool IsDesired(this AttemptResult item)
        {
            switch (item)
            {
                case AttemptResult.Succeeded:
                case AttemptResult.Unneeded:
                    return true;

                case AttemptResult.Failed:
                case AttemptResult.Tried:
                    return false;
            }

            return false;
        }
        static public bool IsUndesired(this AttemptResult item)
        {
            if (item.IsDesired() == false)
                return true;

            return false;
        }

        static public bool IsIncomplete(this AttemptResult item)
        {
            if (item == AttemptResult.Tried)
                return true;

            return false;
        }
        static public bool IsComplete(this AttemptResult item)
        {
            if (item.IsIncomplete() == false)
                return true;

            return false;
        }
    }
}