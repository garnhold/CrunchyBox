using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Pantry
{
    using Dough;
    
    static public class StorageStructureExtensions
    {
        static public void Set<T>(this StorageStructure<T> item, IEnumerable<T> files) where T : FileSnapshot
        {
            item.Clear();
            files.Process(f => item.Add(f));
        }
    }
}