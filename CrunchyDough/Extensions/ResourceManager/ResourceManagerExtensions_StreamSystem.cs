using System;
using System.Resources;

namespace CrunchyDough
{
    static public class ResourceManagerExtensions_StreamSystem
    {
        static public StreamSystem GetStreamSystem(this ResourceManager item)
        {
            return new StreamSystem_ResourceManager(item);
        }
    }
}