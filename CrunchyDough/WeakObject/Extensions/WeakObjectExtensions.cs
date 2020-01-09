using System;

namespace Crunchy.Dough
{
    static public class WeakObjectExtensions
    {
        static public bool IsDead(this WeakObject item)
        {
            if (item.IsAlive() == false)
                return true;

            return false;
        }
    }
}