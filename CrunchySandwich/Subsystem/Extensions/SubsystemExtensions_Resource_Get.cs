using System;
using System.IO;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class SubsystemExtensions_Resource_Get
    {
        static public string GetSubsystemResourcePath(this Subsystem item)
        {
            return SubsystemExtensions_Resource.GetSubsystemResourcePath(item.GetType());
        }
    }
}