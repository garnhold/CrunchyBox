using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bun
{
    using Dough;
    
    public interface GraphNode_AngleAware_Degrees<T> : GraphNode_AngleAware<T> where T : GraphNode_AngleAware_Degrees<T>
    {
        float GetAngleInDegreesToGraphNode(T node);
    }
}