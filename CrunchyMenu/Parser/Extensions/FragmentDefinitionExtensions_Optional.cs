using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    static public class FragmentDefinitionExtensions_Optional
    {
        static public FragmentDefinition<T> MakeOptional<T>(this FragmentDefinition<T> item)
        {
            return FragmentDefinitions.Optional(item);
        }
    }
}