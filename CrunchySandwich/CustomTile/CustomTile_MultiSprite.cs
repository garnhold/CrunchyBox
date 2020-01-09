using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Tilemaps;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public abstract class CustomTile_MultiSprite : CustomTile
    {
        [SerializeField] private Tile.ColliderType collider_type;

        public abstract void Initialize(IEnumerable<Sprite> sprites);

        [InspectorFunction]
        public void ReinitializeWithSprites(List<UnityEngine.Object> sprites)
        {
            Initialize(sprites.Convert<UnityEngine.Object, Sprite>());
        }

        public Tile.ColliderType GetColliderType()
        {
            return collider_type;
        }
    }
}