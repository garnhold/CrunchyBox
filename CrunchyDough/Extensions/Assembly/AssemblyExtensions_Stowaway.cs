using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace CrunchyDough
{
    static public class AssemblyExtensions_Stowaway
    {
        static public StowawayFile GetAssemblyStowaway(this Assembly item, string dst_directory)
        {
            return new StowawayFile(item.GetAssemblyFilename(), dst_directory);
        }
    }
}