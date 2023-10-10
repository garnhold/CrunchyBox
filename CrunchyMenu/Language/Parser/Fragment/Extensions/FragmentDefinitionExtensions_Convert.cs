using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    static public class FragmentDefinitionExtensions_Convert
    {
        static public FragmentDefinition<T> MakeConvert<T, J>(this FragmentDefinition<J> item, Operation<T, J> operation)
        {
            return FragmentDefinitions.Convert(item, operation);
        }
    }
}