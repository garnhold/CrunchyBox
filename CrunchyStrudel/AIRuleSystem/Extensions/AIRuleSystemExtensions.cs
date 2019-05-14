using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;

namespace CrunchyStrudel
{
    static public class AIRuleSystemExtensions
    {
        static public void Add<T>(this AIRuleSystem<T> item, IEnumerable<AIRule<T>> to_add)
        {
            to_add.Process(r => item.Add(r));
        }
    }
}