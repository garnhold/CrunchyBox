using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class IGridBoundLogging<T> : IGrid<T>
    {
        private int lowest_x;
        private int highest_x;

        private int lowest_y;
        private int highest_y;

        private IGrid<T> grid;

        public T this[int x, int y]
        {
            get 
            { 
                return grid[x, y]; 
            }

            set 
            {
                if (x < lowest_x)
                    lowest_x = x;

                if (x > highest_x)
                    highest_x = x;

                if (y < lowest_y)
                    lowest_y = y;

                if (y > highest_y)
                    highest_y = y;

                grid[x, y] = value;
            }
        }

        public IGridBoundLogging(IGrid<T> g)
        {
            grid = g;

            ResetBoundsLogging();
        }

        public void ResetBoundsLogging()
        {
            lowest_x = int.MaxValue;
            highest_x = int.MinValue;

            lowest_y = int.MaxValue;
            highest_y = int.MinValue;
        }

        public IGrid<T> GetBoundSubSection()
        {
            return this.BoundSubSection(lowest_x, lowest_y, highest_x, highest_y);
        }

        public int GetWidth()
        {
            return grid.GetWidth();
        }

        public int GetHeight()
        {
            return grid.GetHeight();
        }

        public int GetLowestX()
        {
            return lowest_x;
        }
        public int GetHighestX()
        {
            return highest_x;
        }

        public int GetLowestY()
        {
            return lowest_y;
        }
        public int GetHighestY()
        {
            return highest_y;
        }
    }
}