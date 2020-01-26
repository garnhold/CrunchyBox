using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class RectExtensions_GridChunk_Cropped
    {
        static public Rect GetCroppedGridChunk(this Rect item, int x, int y, Vector2 cell_size)
        {
            return item.GetIntersection(item.GetOverflownGridChunk(x, y, cell_size));
        }
        static public Rect GetCroppedGridChunk(this Rect item, VectorI2 coords, Vector2 cell_size)
        {
            return item.GetCroppedGridChunk(coords.x, coords.y, cell_size);
        }

        static public IEnumerable<Tuple<int, int, Rect>> GetCroppedGridChunkInfos(this Rect item, Vector2 cell_size)
        {
            int width_in_cells = Mathf.CeilToInt(item.width / cell_size.x);
            int height_in_cells = Mathf.CeilToInt(item.height / cell_size.y);

            for (int y = 0; y < height_in_cells; y++)
            {
                for (int x = 0; x < width_in_cells; x++)
                    yield return Tuple.New(x, y, item.GetCroppedGridChunk(x, y, cell_size));
            }
        }

        static public IEnumerable<Rect> GetCroppedGridChunks(this Rect item, Vector2 cell_size)
        {
            return item.GetCroppedGridChunkInfos(cell_size).Convert(t => t.item3);
        }

        static public void ProcessCroppedGrid(this Rect item, Vector2 cell_size, Process<int, int, Rect> process)
        {
            item.GetCroppedGridChunkInfos(cell_size).Process(t => process(t.item1, t.item2, t.item3));
        }

        static public Rect GetContainingCroppedGridChunk(this Rect item, Vector2 point, Vector2 cell_size)
        {
            return item.GetCroppedGridChunk((point - item.min).GetDeflated(cell_size), cell_size);
        }
    }
}