using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class RectI2Extensions_GridChunk
    {
        static public RectI2 GetOverflownGridChunk(this RectI2 item, int x, int y, VectorI2 cell_size)
        {
            return new RectI2(item.min + new VectorI2(x * cell_size.x, y * cell_size.y), cell_size);
        }
        static public IEnumerable<Tuple<int, int, RectI2>> GetOverflownGridChunkInfos(this RectI2 item, VectorI2 cell_size)
        {
            int width_in_cells = item.GetWidth() / cell_size.x;
            int height_in_cells = item.GetHeight() / cell_size.y;

            for (int y = 0; y < height_in_cells; y++)
            {
                for (int x = 0; x < width_in_cells; x++)
                    yield return Tuple.New(x, y, item.GetOverflownGridChunk(x, y, cell_size));
            }
        }
        static public IEnumerable<RectI2> GetOverflownGridChunks(this RectI2 item, VectorI2 cell_size)
        {
            return item.GetOverflownGridChunkInfos(cell_size).Convert(t => t.item3);
        }

        static public void ProcessOverflownGrid(this RectI2 item, VectorI2 cell_size, Process<int, int, RectI2> process)
        {
            item.GetOverflownGridChunkInfos(cell_size).Process(t => process(t.item1, t.item2, t.item3));
        }

        static public RectI2 GetCroppedGridChunk(this RectI2 item, int x, int y, VectorI2 cell_size)
        {
            return item.GetIntersection(item.GetOverflownGridChunk(x, y, cell_size));
        }
        static public IEnumerable<Tuple<int, int, RectI2>> GetCroppedGridChunkInfos(this RectI2 item, VectorI2 cell_size)
        {
            int width_in_cells = item.GetWidth() / cell_size.x;
            int height_in_cells = item.GetHeight() / cell_size.y;

            for (int y = 0; y < height_in_cells; y++)
            {
                for (int x = 0; x < width_in_cells; x++)
                    yield return Tuple.New(x, y, item.GetCroppedGridChunk(x, y, cell_size));
            }
        }
        static public IEnumerable<RectI2> GetCroppedGridChunks(this RectI2 item, VectorI2 cell_size)
        {
            return item.GetCroppedGridChunkInfos(cell_size).Convert(t => t.item3);
        }

        static public void ProcessCroppedGrid(this RectI2 item, VectorI2 cell_size, Process<int, int, RectI2> process)
        {
            item.GetCroppedGridChunkInfos(cell_size).Process(t => process(t.item1, t.item2, t.item3));
        }
    }
}