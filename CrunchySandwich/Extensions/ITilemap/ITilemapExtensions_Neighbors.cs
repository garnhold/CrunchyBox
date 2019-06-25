using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

using UnityEngine;
using UnityEngine.Tilemaps;

namespace CrunchySandwich
{
    static public class ITilemapExtensions_Neighbors
    {
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
        static public NeighborMask GetNeighborMask(this ITilemap item, Vector3Int position, Predicate<TileBase> predicate)
        {
            return new NeighborMask(
                item.GetNeighbors(position)
                    .Convert(t => predicate(t))
                    .PackBitsToByte()
            );
        }
    }
}