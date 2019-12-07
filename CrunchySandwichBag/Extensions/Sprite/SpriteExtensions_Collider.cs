using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Bun;
    using Sandwich;
    
    static public class SpriteExtensions_Collider
    {
        static public void GenerateSpriteCollider(this Sprite item, SpriteVectorizer vectorizer)
        {
            item.texture.GenerateSpriteCollider(item, vectorizer);
        }
    }
}