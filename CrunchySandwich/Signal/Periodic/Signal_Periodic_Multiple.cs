﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public abstract class Signal_Periodic_Multiple : Signal_Periodic_Typical
    {
        [SerializeFieldEX][PolymorphicField]private List<Signal> functions;

        public IEnumerable<Signal> GetFunctions()
        {
            return functions;
        }
    }
}