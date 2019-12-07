using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Sandwich;
    
    [CustomEditor(typeof(StampTileBrush), true)]
    public class StampTileBrushEditor : GridBrushEditor
    {
        public override void OnPaintSceneGUI(GridLayout grid, GameObject brush_target, BoundsInt position, GridBrushBase.Tool tool, bool executing)
        {
            StampTileBrush brush = (StampTileBrush)target;
            Tilemap tile_map = brush_target.GetComponent<Tilemap>();

            base.OnPaintSceneGUI(grid, brush_target, position, tool, executing);

            tile_map.ClearAllEditorPreviewTiles();

            if (tool == GridBrushBase.Tool.Paint)
                brush.PaintPreview(tile_map, position.min);
        }
    }
}