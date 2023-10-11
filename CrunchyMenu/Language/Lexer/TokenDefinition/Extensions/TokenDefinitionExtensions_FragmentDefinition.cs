using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    static public class TokenDefinitionExtensions_FragmentDefinition
    {
        static public FragmentDefinition<T> MakeFragment<T>(this TokenDefinition t, Operation<T, string> o)
        {
            return FragmentDefinitions.Token(t, o);
        }

        static public FragmentDefinition<bool> MakeFragment(this TokenDefinition t)
        {
            return t.MakeFragment(s => true);
        }
    }
}