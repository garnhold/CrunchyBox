using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public abstract class StampTileBrush : GridBrush
    {
        protected abstract IEnumerable<Vector2Int> GetPoints();

        private TileBase CalculateTile(Tilemap tile_map, Vector3Int position)
        {
            if (cellCount <= 1)
                return cells.GetRandom().tile;
            else
            {
                IDictionary<TileBase, int> brush_itemize = cells.SkipNull()
                    .Convert(c => KeyValuePair.New(c.tile, int.MaxValue))
                    .ToDictionary();

                IDictionary<TileBase, int> neighbor_itemize = tile_map.GetNeighbors(position)
                    .SkipNull()
                    .ItemizeUniques();

                brush_itemize.SubtractNumericValues(neighbor_itemize);

                return brush_itemize
                    .FindAllHighestRated(p => p.Value)
                    .GetRandom()
                    .Key;
            }
        }

        public void PaintPreview(Tilemap tile_map, Vector3Int position)
        {
            GetPointsAt(position).Process(delegate(Vector3Int point) {
                tile_map.SetEditorPreviewTile(point, CalculateTile(tile_map, point));
            });
        }

        public override void Paint(GridLayout grid_layout, GameObject brush_target, Vector3Int position)
        {
            Tilemap tile_map = brush_target.GetComponent<Tilemap>();

            GetPointsAt(position).Process(delegate(Vector3Int point) {
                tile_map.SetTile(point, CalculateTile(tile_map, point));
            });
        }

        public override void Erase(GridLayout grid_layout, GameObject brush_target, Vector3Int position)
        {
            GetPointsAt(position).Process(p => base.Erase(grid_layout, brush_target, p));
        }

        public IEnumerable<Vector3Int> GetPointsAt(Vector3Int center)
        {
            return GetPoints().Convert(p => center + p.GetVector3Int());
        }
    }
}