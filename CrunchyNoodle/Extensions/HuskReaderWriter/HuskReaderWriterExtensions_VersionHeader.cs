using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Crunchy.Noodle
{
    using Dough;
    
    static public class HuskReaderWriterExtensions_VersionHeader
    {
        static public void WriteVersionHeader(this HuskWriter item)
        {
            item.WriteHeader(VersionInfo.GetId().GetBytes());
        }

        static public bool VerifyVersionHeader(this HuskReader item)
        {
            return item.VerifyHeader(VersionInfo.GetId().GetBytes());
        }
    }
}