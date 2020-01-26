using System;

namespace Crunchy.Dough
{
    public class GridCell<T>
    {
        private int x;
        private int y;

        private T data;

        public GridCell(int nx, int ny, T d)
        {
            x = nx;
            y = ny;

            data = d;
        }

        public GridCell(int nx, int ny) : this(nx, ny, default(T))
        {
        }

        public void SetData(T d)
        {
            data = d;
        }

        public void ModifyData(Operation<T, T> operation)
        {
            SetData(operation.Execute(data));
        }

        public void ModifyData(T dst, Operation<T, T, T> operation)
        {
            SetData(operation.Execute(data, dst));
        }

        public T GetData()
        {
            return data;
        }

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }
    }
}