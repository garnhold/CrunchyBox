using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bun
{
    using Dough;
    
    public interface GraphNode_AngleAware<T> : GraphNode<T> where T : GraphNode_AngleAware<T>
    {
    }
}