using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    static public class FragmentDefinitionExtensions_Joined
    {
        static public FragmentDefinition<T[]> MakeJoined<T>(this FragmentDefinition<T> item, FragmentDefinition j, int min, int max)
        {
            return FragmentDefinitions.Joined(item, j, min, max);
        }

        static public FragmentDefinition<T[]> MakeZeroOrMoreJoined<T>(this FragmentDefinition<T> item, FragmentDefinition j)
        {
            return FragmentDefinitions.ZeroOrMoreJoined(item, j);
        }

        static public FragmentDefinition<T[]> MakeOneOrMoreJoined<T>(this FragmentDefinition<T> item, FragmentDefinition j)
        {
            return FragmentDefinitions.OneOrMoreJoined(item, j);
        }
    }
}