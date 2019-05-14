using System;
using System.IO;

namespace CrunchyDough
{
    public interface StreamSystemDirectory
    {
        string GetPath();
        StreamSystem GetStreamSystem();
    }
}