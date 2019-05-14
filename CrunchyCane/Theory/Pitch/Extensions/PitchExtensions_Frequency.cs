﻿using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyCane
{
    static public class PitchExtensions_Frequency
    {
        static public double GetFrequency(this Pitch item)
        {
            return 440.0 * Math.Pow(2.0, (item.GetSemitones() - 69.0) / 12.0);
        }
    }
}