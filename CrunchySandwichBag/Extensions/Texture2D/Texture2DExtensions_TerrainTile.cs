using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    static public class Texture2DExtensions_TerrainTile
    {
        static public OctoTile CreateSimpleTerrainTile(this Texture2D item)
        {
            return CustomAssets.CreateExternalCustomAsset<OctoTile>(
                Filename.SetExtension(item.GetAssetPath(), "asset"),
                s => s.Initialize(item.GetSprites())
            );
        }

        [MenuItem("Assets/Sprite/Create/TerrainTile")]
        static private void CreateTerrainTile()
        {
            ((Texture2D)Selection.activeObject).CreateSimpleTerrainTile();
        }

        [MenuItem("Assets/Sprite/Create/TerrainTile", true)]
        static private bool CreateTerrainTileValidate()
        {
            if (Selection.activeObject is Texture2D)
                return true;

            return false;
        }
    }
}