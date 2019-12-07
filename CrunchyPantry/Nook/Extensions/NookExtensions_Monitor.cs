using System;
using System.IO;

namespace Crunchy.Pantry
{
    using Dough;
    
    static public class NookExtensions_Monitor
    {
        static public NookMonitor CreateNookMonitor(this Nook item)
        {
            return new NookMonitor(item);
        }
    }
}