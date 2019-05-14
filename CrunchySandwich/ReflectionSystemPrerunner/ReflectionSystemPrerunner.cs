using System;

using UnityEngine;

using CrunchyDough;
using CrunchyNoodle;

namespace CrunchySandwich
{
    [ApplicationEXSatellite]
    static public class ReflectionSystemPrerunner
    {
        static public void Start()
        {
            CrunchyNoodle.ReflectionSystem.Prerun();
        }
    }
}