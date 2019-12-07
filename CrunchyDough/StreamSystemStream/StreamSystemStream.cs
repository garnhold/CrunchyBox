using System;
using System.IO;

namespace Crunchy.Dough
{
    public interface StreamSystemStream
    {
        string GetPath();
        StreamSystem GetStreamSystem();
    }
}