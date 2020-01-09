using System;

namespace Crunchy.Dough
{
    static public class PeriodicProcessExtensions_Restart
    {
        static public void Restart(this PeriodicProcess item)
        {
            item.StopClear();
            item.Start();
        }
    }
}