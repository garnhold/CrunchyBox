using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class TerrainDataExtensions_Cell
    {
        static public Vector3 GetHeightMapCellSize(this TerrainData item)
        {
            return new Vector3(item.size.x / item.heightmapWidth, item.size.y, item.size.z / item.heightmapHeight);
        }

        static public Vector3 GetAlphaMapCellSize(this TerrainData item)
        {
            return new Vector3(item.size.x / item.alphamapWidth, item.size.y, item.size.z / item.alphamapHeight);
        }
    }
}