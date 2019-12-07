using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Crunchy.Dough
{
    static public class AssemblyExtensions_StreamSystem
    {
        static public StreamSystem GetStreamSystem(this Assembly item)
        {
            return new StreamSystem_Assembly(item);
        }
    }
}