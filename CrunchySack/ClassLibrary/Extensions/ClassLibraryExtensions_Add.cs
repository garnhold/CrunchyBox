using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
    static public class ClassLibraryExtensions_Add
    {
        static public void AddClasses(this ClassLibrary item, IEnumerable<CmlEntry_Class> to_add)
        {
            to_add.Process(c => item.AddClass(c));
        }
        static public void AddClasses(this ClassLibrary item, params CmlEntry_Class[] to_add)
        {
            item.AddClasses((IEnumerable<CmlEntry_Class>)to_add);
        }

        static public void AddClassProviders(this ClassLibrary item, IEnumerable<ClassProvider> to_add)
        {
            to_add.Process(f => item.AddClassProvider(f));
        }
        static public void AddClassProviders(this ClassLibrary item, params ClassProvider[] to_add)
        {
            item.AddClassProviders((IEnumerable<ClassProvider>)to_add);
        }
    }
}