using System;
using System.IO;

namespace Crunchy.Pantry
{
    using Dough;
    
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