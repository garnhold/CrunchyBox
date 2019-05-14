using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class Grid<T> : IEnumerable<GridCell<T>>
    {
        private int width;
        private int height;
        private List<GridCell<T>> cells;

        private GridCell<T> GetCellInternal(int x, int y)
        {
            return cells[x + y * width];
        }

        public Grid(int w, int h)
        {
            width = w.BindAbove(0);
            height = h.BindAbove(0);

            cells = new List<GridCell<T>>(width * height);
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                    cells.Add(new GridCell<T>(x, y));
            }
        }

        public Grid(int w, int h, Operation<T, int, int> o) : this(w, h)
        {
            this.SetData(o);
        }

        public Grid(int w, int h, IEnumerable<T> data) : this(w, h)
        {
            this.SetData(data);
        }

        public Grid(T[,] data) : this(data.GetWidth(), data.GetHeight())
        {
            this.SetData(data);
        }

        public Grid(Grid<T> g) : this(g.GetWidth(), g.GetHeight(), g.GetData())
        {
        }

        public bool SetData(int x, int y, T value)
        {
            if (IsIndexValid(x, y))
            {
                GetCellInternal(x, y).SetData(value);
                return true;
            }

            return false;
        }

        public bool ModifyData(int x, int y, Operation<T, T> operation)
        {
            if (IsIndexValid(x, y))
            {
                GetCellInternal(x, y).ModifyData(operation);
                return true;
            }

            return false;
        }

        public bool ModifyData(int x, int y, T dst, Operation<T, T, T> operation)
        {
            if (IsIndexValid(x, y))
            {
                GetCellInternal(x, y).ModifyData(dst, operation);
                return true;
            }

            return false;
        }

        public bool TryGetCell(int x, int y, out GridCell<T> cell)
        {
            if (IsIndexValid(x, y))
            {
                cell = GetCellInternal(x, y);
                return true;
            }

            cell = null;
            return false;
        }

        public bool TryGetData(int x, int y, out T data)
        {
            GridCell<T> cell;

            if (TryGetCell(x, y, out cell))
            {
                data = cell.GetData();
                return true;
            }

            data = default(T);
            return false;
        }

        public int GetWidth()
        {
            return width;
        }

        public int GetHeight()
        {
            return height;
        }

        public bool IsIndexValid(int x, int y)
        {
            if (x >= 0 && x < width)
            {
                if (y >= 0 && y < height)
                    return true;
            }

            return false;
        }

        public IEnumerable<GridCell<T>> GetCellsBetween(int x1, int y1, int x2, int y2)
        {
            x1 = x1.BindBetween(0, width);
            x2 = x2.BindBetween(0, width);

            y1 = y1.BindBetween(0, height);
            y2 = y2.BindBetween(0, height);

            int block_width = x2 - x1;
            int block_height = y2 - y1;

            for (int yd = 0; yd < block_height; yd++)
            {
                for (int xd = 0; xd < block_width; xd++)
                    yield return GetCellInternal(x1 + xd, y1 + yd);
            }
        }

        public IEnumerator<GridCell<T>> GetEnumerator()
        {
            return cells.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}