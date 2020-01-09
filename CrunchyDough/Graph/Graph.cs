using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public interface Graph<T> where T : GraphNode<T>
    {
        IEnumerable<T> GetGraphNodes();
    }
}