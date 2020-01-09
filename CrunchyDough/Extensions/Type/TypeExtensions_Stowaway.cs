using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Crunchy.Dough
{
    static public class TypeExtensions_Stowaway
    {
        static public StowawayFile GetTypeAssemblyStowaway(this Type item, string dst_directory)
        {
            return item.Assembly.GetAssemblyStowaway(dst_directory);
        }
    }
}