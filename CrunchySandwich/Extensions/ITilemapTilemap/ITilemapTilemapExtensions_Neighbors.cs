using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Tilemaps;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
	static public class ITilemapTilemapExtensions_Neighbors
    {
        static public IEnumerable<TileBase> GetCardinalNeighbors(this Tilemap item, Vector3Int position)
        {
            yield return item.GetTile(position + new Vector3Int(0, 1, 0));

            yield return item.GetTile(position + new Vector3Int(-1, 0, 0));
            yield return item.GetTile(position + new Vector3Int(1, 0, 0));

            yield return item.GetTile(position + new Vector3Int(0, -1, 0));
        }

        static public IEnumerable<TileBase> GetOrdinalNeighbors(this Tilemap item, Vector3Int position)
        {
            yield return item.GetTile(position + new Vector3Int(-1, 1, 0));
            yield return item.GetTile(position + new Vector3Int(1, 1, 0));

            yield return item.GetTile(position + new Vector3Int(-1, -1, 0));
            yield return item.GetTile(position + new Vector3Int(1, -1, 0));
        }

        static public IEnumerable<TileBase> GetNeighbors(this Tilemap item, Vector3Int position)
        {
            yield return item.GetTile(position + new Vector3Int(-1, 1, 0));
            yield return item.GetTile(position + new Vector3Int(0, 1, 0));
            yield return item.GetTile(position + new Vector3Int(1, 1, 0));

            yield return item.GetTile(position + new Vector3Int(-1, 0, 0));
            yield return item.GetTile(position + new Vector3Int(1, 0, 0));

            yield return item.GetTile(position + new Vector3Int(-1, -1, 0));
            yield return item.GetTile(position + new Vector3Int(0, -1, 0));
            yield return item.GetTile(position + new Vector3Int(1, -1, 0));
        }
        
        static public OctoMask GetOctoMask(this Tilemap item, Vector3Int position, Predicate<TileBase> predicate)
        {
            return new OctoMask(
                item.GetNeighbors(position)
                    .Convert(t => predicate(t))
                    .PackBitsToByte()
            );
        }
        static public IEnumerable<TileBase> GetCardinalNeighbors(this ITilemap item, Vector3Int position)
        {
            yield return item.GetTile(position + new Vector3Int(0, 1, 0));

            yield return item.GetTile(position + new Vector3Int(-1, 0, 0));
            yield return item.GetTile(position + new Vector3Int(1, 0, 0));

            yield return item.GetTile(position + new Vector3Int(0, -1, 0));
        }

        static public IEnumerable<TileBase> GetOrdinalNeighbors(this ITilemap item, Vector3Int position)
        {
            yield return item.GetTile(position + new Vector3Int(-1, 1, 0));
            yield return item.GetTile(position + new Vector3Int(1, 1, 0));

            yield return item.GetTile(position + new Vector3Int(-1, -1, 0));
            yield return item.GetTile(position + new Vector3Int(1, -1, 0));
        }

        static public IEnumerable<TileBase> GetNeighbors(this ITilemap item, Vector3Int position)
        {
            yield return item.GetTile(position + new Vector3Int(-1, 1, 0));
            yield return item.GetTile(position + new Vector3Int(0, 1, 0));
            yield return item.GetTile(position + new Vector3Int(1, 1, 0));

            yield return item.GetTile(position + new Vector3Int(-1, 0, 0));
            yield return item.GetTile(position + new Vector3Int(1, 0, 0));

            yield return item.GetTile(position + new Vector3Int(-1, -1, 0));
            yield return item.GetTile(position + new Vector3Int(0, -1, 0));
            yield return item.GetTile(position + new Vector3Int(1, -1, 0));
        }
        
        static public OctoMask GetOctoMask(this ITilemap item, Vector3Int position, Predicate<TileBase> predicate)
        {
            return new OctoMask(
                item.GetNeighbors(position)
                    .Convert(t => predicate(t))
                    .PackBitsToByte()
            );
        }
	}
}