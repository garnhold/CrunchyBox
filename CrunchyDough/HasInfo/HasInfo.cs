using System;

namespace Crunchy.Dough
{
    public interface HasInfo
    {
        LookupBackedSet<string, string> GetInfoSettings();
    }
}