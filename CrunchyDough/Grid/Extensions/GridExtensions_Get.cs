using System;

namespace Crunchy.Dough
{    
    static public class GridExtensions_Get
    {
        static public GridCell<T> GetCell<T>(this Grid<T> item, VectorI2 point)
        {
            return item.GetCell(point.x, point.y);
        }

        static public GridCell<T> GetCellLooped<T>(this Grid<T> item, VectorI2 point)
        {
            return item.GetCellLooped(point.x, point.y);
        }

        static public T GetData<T>(this Grid<T> item, VectorI2 point)
        {
            return item.GetData(point.x, point.y);
        }

        static public T GetDataLooped<T>(this Grid<T> item, VectorI2 point)
        {
            return item.GetDataLooped(point.x, point.y);
        }
    }
}