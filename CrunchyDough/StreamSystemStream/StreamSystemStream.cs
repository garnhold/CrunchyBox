using System;
using System.IO;

namespace CrunchyDough
{
    public interface StreamSystemStream
    {
        string GetPath();
        StreamSystem GetStreamSystem();
    }
}