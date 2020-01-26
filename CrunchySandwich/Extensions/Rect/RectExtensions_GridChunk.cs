using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class RectExtensions_GridChunk
    {
        static public Rect GetGridChunk(this Rect item, int x, int y, int number_columns, int number_rows)
        {
            return item.GetOverflownGridChunk(x, y, item.GetSize().GetComponentDivide(number_columns, number_rows));
        }
        static public Rect GetGridChunk(this Rect item, VectorI2 coords, int number_columns, int number_rows)
        {
            return item.GetGridChunk(coords.x, coords.y, number_columns, number_rows);
        }

        static public IEnumerable<Tuple<int, int, Rect>> GetGridChunkInfos(this Rect item, int number_columns, int number_rows)
        {
            return item.GetOverflownGridChunkInfos(item.GetSize().GetComponentDivide(number_columns, number_rows));
        }

        static public IEnumerable<Rect> GetGridChunks(this Rect item, int number_columns, int number_rows)
        {
            return item.GetGridChunkInfos(number_columns, number_rows).Convert(t => t.item3);
        }

        static public void ProcessGrid(this Rect item, int number_columns, int number_rows, Process<int, int, Rect> process)
        {
            item.GetGridChunkInfos(number_columns, number_rows).Process(t => process(t.item1, t.item2, t.item3));
        }

        static public Rect GetContainingGridChunk(this Rect item, Vector2 point, int number_columns, int number_rows)
        {
            return item.GetContainingOverflownGridChunk(point, item.GetSize().GetComponentDivide(number_columns, number_rows));
        }
    }
}