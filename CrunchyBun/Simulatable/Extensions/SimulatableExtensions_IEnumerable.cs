using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bun
{
    using Dough;
    
    static public class SimulatableExtensions_IEnumerable
    {
        static public void UpdateSimulatables<T>(this IEnumerable<T> item, float step) where T : Simulatable
        {
            item.Process(s => s.Update(step));
        }
    }
}