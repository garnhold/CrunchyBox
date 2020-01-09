using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    static public class GlobalLibraryExtensions_Add
    {
        static public void AddGlobals(this GlobalLibrary item, IEnumerable<Global> to_add)
        {
            to_add.Process(g => item.AddGlobal(g));
        }
        static public void AddGlobals(this GlobalLibrary item, params Global[] to_add)
        {
            item.AddGlobals((IEnumerable<Global>)to_add);
        }
    }
}