using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Tilemaps;

namespace Crunchy.Sandwich
{
    using Dough;
    public class OctoTile : CustomTile_MultiSprite_NeighborRuled
    {
        [SerializeField]private OctoSubTile[] sub_tiles;
        [SerializeField]private bool randomize_with_position;

        private OperationCache<List<OctoSubTile>, OctoMask> cache;

        protected override void LateConstruct()
        {
            base.LateConstruct();

            cache = new OperationCache<List<OctoSubTile>, OctoMask>("cache", delegate (OctoMask mask) {
                return sub_tiles
                    .Narrow(t => t.GetMask().HasNoOtherBits(mask))
                    .FindAllHighestRated(t => t.GetMask().GetComplexity())
                    .ToList();
            });
        }

        public override void Initialize(IEnumerable<Sprite> sprites)
        {
            sub_tiles = sprites.Convert(s => new OctoSubTile(s))
                .ToArray();
        }

        public override Sprite GetApplicableSprite(Vector3Int position, ITilemap tilemap)
        {
            int hash = position.GetHashCode();
            OctoMask mask = tilemap.GetOctoMask(position, t => t.EqualsEX(this));

            if (randomize_with_position)
                hash = hash.AbsorbObjectHash(tilemap.GetComponent<Transform>().GetSpacarPosition());

            return cache.Fetch(mask)
                .PickACongruent(hash, t => t.GetWeight())
                .IfNotNull(t => t.GetSprite());
        }
    }
}