﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    public class WalkerSystem2D : Subsystem<WalkerSystem2D>
    {
        [SerializeFieldEX]private Duration update_interval = Duration.Hertz(4.0f);

        public Duration GetUpdateInterval()
        {
            return update_interval;
        }
    }
}