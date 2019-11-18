using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Tilemaps;

using CrunchyDough;

namespace CrunchySandwich
{
    public abstract class CustomTile_MultiSprite_NeighborRuled : CustomTile_MultiSprite
    {
        public abstract Sprite GetApplicableSprite(Vector3Int position, ITilemap tilemap);

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
            tileData.colliderType = GetColliderType();
            tileData.sprite = GetApplicableSprite(position, tilemap);
        }
    }
}