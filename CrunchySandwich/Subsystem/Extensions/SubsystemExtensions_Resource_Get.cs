using System;
using System.IO;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class SubsystemExtensions_Resource_Get
    {
        static public string GetSubsystemResourcePath(this Subsystem item)
        {
            return SubsystemExtensions_Resource.GetSubsystemResourcePath(item.GetType());
        }
    }
}