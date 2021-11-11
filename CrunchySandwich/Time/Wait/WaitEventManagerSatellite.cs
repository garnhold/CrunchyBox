using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    [ApplicationEXSatellite]
    static public class WaitEventManagerSatellite
    {
        static private void Update()
        {
            WaitEventManager.GetInstance().Update();
        }
    }
}