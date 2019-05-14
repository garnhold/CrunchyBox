using System;

namespace CrunchyDough
{
    public interface HasInfo
    {
        LookupBackedSet<string, string> GetInfoSettings();
    }
}