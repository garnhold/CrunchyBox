using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Sandwich;
    
    static public class SpriteGeneratorExtensions
    {
        [InspectorAction]
        static public void GenerateAsset(this SpriteGenerator item)
        {
            item.GenerateSheet().SaveAsAsset(item.name);
        }
    }
}