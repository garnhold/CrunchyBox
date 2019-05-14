using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public abstract class GraphNodeTraverser<T> where T : GraphNode<T>
    {
        protected abstract bool WorkInternal();

        protected abstract bool IsCompleteInternal();
        protected abstract IEnumerable<T> GetPathInternal();

        public bool Work()
        {
            if (IsComplete() == false)
                return WorkInternal();

            return false;
        }

        public bool Complete()
        {
            while (Work()) ;
            return IsComplete();
        }

        public bool IsComplete()
        {
            return IsCompleteInternal();
        }

        public IEnumerable<T> GetPath()
        {
            if (Complete())
                return GetPathInternal();

            return Empty.IEnumerable<T>();
        }

        public IEnumerable<T> GetPathPermissive()
        {
            Complete();

            return GetPathInternal();
        }
    }
}