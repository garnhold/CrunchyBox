using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Tilemaps;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    public class OctoTile : CustomTile_MultiSprite_NeighborRuled
    {
        [SerializeField]private OctoSubTile[] sub_tiles;

        public override void Initialize(IEnumerable<Sprite> sprites)
        {
            sub_tiles = sprites.Convert(s => new OctoSubTile(s))
                .ToArray();
        }

        public override Sprite GetApplicableSprite(Vector3Int position, ITilemap tilemap)
        {
            int hash = position.GetHashCode();
            OctoMask mask = tilemap.GetOctoMask(position, t => t.EqualsEX(this));

            return sub_tiles
                .Narrow(t => t.GetMask().HasNoOtherBits(mask))
                .FindAllHighestRated(t => t.GetMask().GetComplexity())
                .PickACongruent(hash, t => t.GetWeight())
                .IfNotNull(t => t.GetSprite());
        }
    }
}