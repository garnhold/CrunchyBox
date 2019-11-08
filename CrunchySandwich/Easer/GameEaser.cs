using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyBun;

namespace CrunchySandwich
{
    public class GameEaser : Easer
    {
        public GameEaser(EaseOperation o, float d, TimeType t) : base(o, new GameTimer(d, t)) { }
    }
}