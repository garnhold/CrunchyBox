using System;
using System.Reflection;

namespace Crunchy.Dough
{
    public class Instance<T>
    {
        private T instance;

        public void Clear()
        {
            instance = default(T);
        }

        public T Get()
        {
            if (instance == null)
                instance = typeof(T).CreateInstance<T>();

            return instance;
        }
    }
}