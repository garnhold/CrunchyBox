using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public abstract class Trigger : Temporal
    {
        public abstract bool Start();
        public abstract bool Pause();

        public abstract bool IsRunning();

        public abstract bool Check();
    }
}