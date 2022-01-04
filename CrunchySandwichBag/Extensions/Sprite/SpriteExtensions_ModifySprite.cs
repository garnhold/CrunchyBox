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
    
    static public class SpriteExtensions_ModifySprite
    {
        static public void ModifySprite(this Sprite item, Process<SerializedProperty> process)
        {
            item.texture.ModifySprite(item, process);
        }
    }
}