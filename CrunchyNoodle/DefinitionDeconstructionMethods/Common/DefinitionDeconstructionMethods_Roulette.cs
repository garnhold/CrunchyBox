using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    [DefinitionDeconstruction]
    static public class DefinitionDeconstructionMethods_Roulette
    {
        [DefinitionDeconstruction]
        static public IEnumerable<KeyValuePair<T, float>> Deconstruct<T>(Roulette<T> item)
        {
            return item.Deconstruct();
        }
    }
}