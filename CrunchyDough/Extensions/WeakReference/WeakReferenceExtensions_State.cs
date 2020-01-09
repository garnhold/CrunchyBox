using System;

namespace Crunchy.Dough
{
    static public class WeakReferenceExtensions_State
    {
        static public bool IsAlive(this WeakReference item)
        {
            if (item.IsAlive)
                return true;

            return false;
        }

        static public bool IsDead(this WeakReference item)
        {
            if (item.IsAlive() == false)
                return true;

            return false;
        }
    }
}