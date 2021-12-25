using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    [DefinitionDeconstruction]
    static public class DefinitionDeconstructionMethods_RouletteWheel
    {
        [DefinitionDeconstruction]
        static public Roulette<T> Deconstruct<T>(RouletteWheel<T> item)
        {
            return item.GetRoulette();
        }
    }
}