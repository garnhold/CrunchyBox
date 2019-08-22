using System;
using System.Reflection;

namespace CrunchyDough
{
    static public class TemporalExtensions_General
    {
        static public bool IsStopped(this Temporal item)
        {
            if (item.IsRunning() == false)
                return true;

            return false;
        }
    }
}