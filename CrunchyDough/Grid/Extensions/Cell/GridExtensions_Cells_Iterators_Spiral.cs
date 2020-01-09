using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class GridExtensions_Cells_Iterators_Spiral
    {
        static public IEnumerable<GridCell<T>> GetCellSpiral<T>(this Grid<T> item, int x, int y, int spiral_width)
        {
            GridCell<T> cell;

            int step = -1;
            int current_side_length = 1;

            int left = x;
            int right = item.GetWidth() - x;

            int bottom = y;
            int top = item.GetHeight() - y;

            int largest_x = left.Max(right);
            int largest_y = bottom.Max(top);

            int largest = largest_x.Max(largest_y);
            int width = largest.Min(spiral_width);

            int maximum_side_length = width * 2;

            while(current_side_length <= maximum_side_length)
            {
                for(int i = 0; i < current_side_length; i++)
                {
                    x += step;

                    if(item.TryGetCell(x, y, out cell))
                        yield return cell;
                }

                for(int i = 0; i < current_side_length; i++)
                {
                    y += step;

                    if(item.TryGetCell(x, y, out cell))
                        yield return cell;
                }

                current_side_length++;
                step = -step;
            }
        }

        static public IEnumerable<GridCell<T>> GetCellSpiral<T>(this Grid<T> item, int x, int y)
        {
            return item.GetCellSpiral(x, y, int.MaxValue);
        }
    }
}