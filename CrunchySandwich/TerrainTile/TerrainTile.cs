using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Tilemaps;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class TerrainTile : CustomTile
    {
        [SerializeField]private Tile.ColliderType collider_type;
        [SerializeField]private TerrainSubTile[] sub_tiles;

        public override void RefreshTile(Vector3Int position, ITilemap tilemap)
        {
            for (int dy = -1; dy <= 1; dy++)
            {
                for (int dx = -1; dx <= 1; dx++)
                {
                    Vector3Int sub_position = position + new Vector3Int(dx, dy, 0);

                    if (tilemap.GetTile(sub_position) == this)
                        tilemap.RefreshTile(sub_position);
                }
            }
        }

        public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData)
        {
            NeighborMask mask = tilemap.GetNeighborMask(position, t => t.EqualsEX(this));

            tileData.colliderType = collider_type;
            tileData.sprite = GetApplicableSprite(mask, position.GetHashCode());
        }

        public Sprite GetApplicableSprite(NeighborMask mask, int hash)
        {
            return sub_tiles
                .Narrow(t => t.GetMask().CanBeUsedFor(mask))
                .FindAllHighestRated(t => t.GetMask().GetComplexity())
                .GetACongruent(hash)
                .IfNotNull(t => t.GetSprite());
        }
        public Sprite GetApplicableSprite(NeighborMask mask)
        {
            return GetApplicableSprite(mask, 0);
        }
    }
}