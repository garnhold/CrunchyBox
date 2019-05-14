using System;
using System.Reflection;

namespace CrunchyDough
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
                instance = typeof(T).CreateForcedInstance<T>();

            return instance;
        }
    }
}