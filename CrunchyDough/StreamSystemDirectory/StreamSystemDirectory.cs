using System;
using System.IO;

namespace Crunchy.Dough
{
    public interface StreamSystemDirectory
    {
        string GetPath();
        StreamSystem GetStreamSystem();
    }
}