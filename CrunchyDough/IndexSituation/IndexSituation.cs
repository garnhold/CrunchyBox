using System;

namespace Crunchy.Dough
{
    public struct IndexSituation
    {
        private int index;
        private int count;

        public IndexSituation(int i, int c)
        {
            index = i;
            count = c;
        }

        public bool IsFound()
        {
            if (index >= 0 && index < count)
                return true;

            return false;
        }

        public bool IsSole()
        {
            if (IsFound())
            {
                if (count == 1)
                    return true;
            }

            return false;
        }

        public bool IsShared()
        {
            if (IsFound())
            {
                if (count > 1)
                    return true;
            }

            return false;
        }

        public int GetIndex()
        {
            return index;
        }

        public int GetCount()
        {
            return count;
        }
    }
}