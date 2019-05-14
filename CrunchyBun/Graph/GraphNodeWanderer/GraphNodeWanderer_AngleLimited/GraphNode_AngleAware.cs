using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyBun
{
    public interface GraphNode_AngleAware<T> : GraphNode<T> where T : GraphNode_AngleAware<T>
    {
    }
}