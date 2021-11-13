using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    [ApplicationEXSatellite]
    static public class AsyerManagerSatellite
    {
        static private void Update()
        {
            AsyerManager.GetInstance().Update();
        }
    }
}