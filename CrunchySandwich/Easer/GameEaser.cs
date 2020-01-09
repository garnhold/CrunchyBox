using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Salt;
    using Noodle;
    using Bun;
    
    public class GameEaser : Easer
    {
        public GameEaser(EaseOperation o, float d, TimeType t) : base(o, new GameTimer(d, t)) { }
    }
}