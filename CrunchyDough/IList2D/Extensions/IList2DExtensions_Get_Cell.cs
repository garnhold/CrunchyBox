using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IList2DExtensions_Get_Cell
    {
        static public bool TryGetCell<T>(this IList2D<T> item, int x, int y, out IList2DCell<T> cell)
        {
            if (item.IsIndexValid(x, y))
            {
                cell = new IList2DCell<T>(item, x, y);
                return true;
            }

            cell = default(IList2DCell<T>);
            return false;
        }
        static public bool TryGetCell<T>(this IList2D<T> item, IList2DIndex index, out IList2DCell<T> cell)
        {
            return item.TryGetCell<T>(index.GetX(), index.GetY(), out cell);
        }

        static public IList2DCell<T> GetCell<T>(this IList2D<T> item, int x, int y)
        {
            IList2DCell<T> cell;

            item.TryGetCell<T>(x, y, out cell);
            return cell;
        }
        static public IList2DCell<T> GetCell<T>(this IList2D<T> item, IList2DIndex index)
        {
            return item.GetCell<T>(index.GetX(), index.GetY());
        }
    }
}