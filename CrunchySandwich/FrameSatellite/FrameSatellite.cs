using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bread;

    [ApplicationEXSatellite]
    static public class FrameSatellite
    {
        static public void Update()
        {
            Frame.AdvanceFrame();
        }
    }
}