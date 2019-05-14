using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
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