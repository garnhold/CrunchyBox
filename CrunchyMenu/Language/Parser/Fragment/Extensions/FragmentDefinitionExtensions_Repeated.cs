using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    static public class FragmentDefinitionExtensions_Repeated
    {
        static public FragmentDefinition<T[]> MakeRepeated<T>(this FragmentDefinition<T> item, int min, int max)
        {
            return item.GetLanguage().Repeated(item, min, max);
        }
    }
}