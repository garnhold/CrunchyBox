using System;
using System.IO;

using CrunchyDough;

namespace CrunchyPantry
{
    static public class NookMonitorExtensions
    {
        static public void ProcessChange(this NookMonitor item, Process process)
        {
            if (item.IsChanged())
            {
                item.Validate();

                process();
            }
        }
    }
}