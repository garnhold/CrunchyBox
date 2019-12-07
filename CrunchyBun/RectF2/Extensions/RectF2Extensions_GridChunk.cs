using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bun
{
    using Dough;
    
    static public class RectF2Extensions_GridChunk
    {
        static public RectF2 GetOverflownGridChunk(this RectF2 item, int x, int y, VectorF2 cell_size)
        {
            return new RectF2(item.min + new VectorF2(x * cell_size.x, y * cell_size.y), cell_size);
        }
        static public IEnumerable<Tuple<int, int, RectF2>> GetOverflownGridChunkInfos(this RectF2 item, VectorF2 cell_size)
        {
            int width_in_cells = Mathq.CeilToInt(item.GetWidth() / cell_size.x);
            int height_in_cells = Mathq.CeilToInt(item.GetHeight() / cell_size.y);

            for (int y = 0; y < height_in_cells; y++)
            {
                for (int x = 0; x < width_in_cells; x++)
                    yield return Tuple.New(x, y, item.GetOverflownGridChunk(x, y, cell_size));
            }
        }
        static public IEnumerable<RectF2> GetOverflownGridChunks(this RectF2 item, VectorF2 cell_size)
        {
            return item.GetOverflownGridChunkInfos(cell_size).Convert(t => t.item3);
        }

        static public void ProcessOverflownGrid(this RectF2 item, VectorF2 cell_size, Process<int, int, RectF2> process)
        {
            item.GetOverflownGridChunkInfos(cell_size).Process(t => process(t.item1, t.item2, t.item3));
        }

        static public RectF2 GetCroppedGridChunk(this RectF2 item, int x, int y, VectorF2 cell_size)
        {
            return item.GetIntersection(item.GetOverflownGridChunk(x, y, cell_size));
        }
        static public IEnumerable<Tuple<int, int, RectF2>> GetCroppedGridChunkInfos(this RectF2 item, VectorF2 cell_size)
        {
            int width_in_cells = Mathq.CeilToInt(item.GetWidth() / cell_size.x);
            int height_in_cells = Mathq.CeilToInt(item.GetHeight() / cell_size.y);

            for (int y = 0; y < height_in_cells; y++)
            {
                for (int x = 0; x < width_in_cells; x++)
                    yield return Tuple.New(x, y, item.GetCroppedGridChunk(x, y, cell_size));
            }
        }
        static public IEnumerable<RectF2> GetCroppedGridChunks(this RectF2 item, VectorF2 cell_size)
        {
            return item.GetCroppedGridChunkInfos(cell_size).Convert(t => t.item3);
        }

        static public void ProcessCroppedGrid(this RectF2 item, VectorF2 cell_size, Process<int, int, RectF2> process)
        {
            item.GetCroppedGridChunkInfos(cell_size).Process(t => process(t.item1, t.item2, t.item3));
        }
    }
}