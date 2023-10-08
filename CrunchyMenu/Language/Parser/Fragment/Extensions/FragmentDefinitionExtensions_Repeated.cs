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
            return FragmentDefinitions.Repeated(item, min, max);
        }

        static public FragmentDefinition<T[]> MakeZeroOrMore<T>(this FragmentDefinition<T> item)
        {
            return FragmentDefinitions.ZeroOrMore(item);
        }

        static public FragmentDefinition<T[]> MakeOneOrMore<T>(this FragmentDefinition<T> item)
        {
            return FragmentDefinitions.OneOrMore(item);
        }
    }
}