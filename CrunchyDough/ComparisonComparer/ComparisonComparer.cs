using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class ComparisonComparer<T> : IComparer<T>
    {
        private Comparison<T> comparison;

        public ComparisonComparer(Comparison<T> c)
        {
            comparison = c;
        }

        public int Compare(T x, T y)
        {
            return comparison(x, y);
        }
    }
}