using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Tilemaps;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class TilemapExtensions_Tiles
    {
        static public void CopyTiles(this Tilemap item, Tilemap source)
        {
            item.ClearAllTiles();

            item.SetTilesBlock(
                source.cellBounds,
                source.GetTilesBlock(source.cellBounds)
            );
        }
    }
}