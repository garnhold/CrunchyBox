using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class EmbeddedResources
    {
        static public StreamSystem GetStreamSystem()
        {
            return Assembly.GetEntryAssembly().GetStreamSystem();
        }
    }
}