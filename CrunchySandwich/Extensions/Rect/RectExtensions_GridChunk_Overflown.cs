﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class RectExtensions_GridChunk_Overflown
    {
        static public Rect GetOverflownGridChunk(this Rect item, int x, int y, Vector2 cell_size)
        {
            return new Rect(item.min + new Vector2(x * cell_size.x, y * cell_size.y), cell_size);
        }
        static public Rect GetOverflownGridChunk(this Rect item, VectorI2 coords, Vector2 cell_size)
        {
            return item.GetOverflownGridChunk(coords.x, coords.y, cell_size);
        }

        static public IEnumerable<Tuple<int, int, Rect>> GetOverflownGridChunkInfos(this Rect item, Vector2 cell_size)
        {
            int width_in_cells = Mathf.CeilToInt(item.width / cell_size.x);
            int height_in_cells = Mathf.CeilToInt(item.height / cell_size.y);

            for (int y = 0; y < height_in_cells; y++)
            {
                for (int x = 0; x < width_in_cells; x++)
                    yield return Tuple.New(x, y, item.GetOverflownGridChunk(x, y, cell_size));
            }
        }

        static public IEnumerable<Rect> GetOverflownGridChunks(this Rect item, Vector2 cell_size)
        {
            return item.GetOverflownGridChunkInfos(cell_size).Convert(t => t.item3);
        }

        static public void ProcessOverflownGrid(this Rect item, Vector2 cell_size, Process<int, int, Rect> process)
        {
            item.GetOverflownGridChunkInfos(cell_size).Process(t => process(t.item1, t.item2, t.item3));
        }

        static public Rect GetContainingOverflownGridChunk(this Rect item, Vector2 point, Vector2 cell_size)
        {
            return item.GetOverflownGridChunk(item.GetContainingGridIndex(point, cell_size), cell_size);
        }
    }
}