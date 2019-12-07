using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Noodle;
    
    [ApplicationEXSatellite]
    static public class ReflectionSystemPrerunner
    {
        static public void Start()
        {
            ReflectionSystem.Prerun();
        }
    }
}