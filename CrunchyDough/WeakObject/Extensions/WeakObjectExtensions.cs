using System;

namespace CrunchyDough
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