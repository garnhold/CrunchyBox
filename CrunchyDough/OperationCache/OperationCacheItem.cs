using System;

namespace CrunchyDough
{
    public class OperationCacheItem<T>
    {
        private T data;

        public OperationCacheItem(T d)
        {
            data = d;
        }

        public T GetData()
        {
            return data;
        }
    }
}