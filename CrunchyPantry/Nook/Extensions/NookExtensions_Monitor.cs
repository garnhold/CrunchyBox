using System;
using System.IO;

using CrunchyDough;

namespace CrunchyPantry
{
    static public class NookExtensions_Monitor
    {
        static public NookMonitor CreateNookMonitor(this Nook item)
        {
            return new NookMonitor(item);
        }
    }
}