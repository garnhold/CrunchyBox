using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    public interface GraphNode_AngleAware_Radians<T> : GraphNode_AngleAware<T> where T : GraphNode_AngleAware_Radians<T>
    {
        float GetAngleInRadiansToGraphNode(T node);
    }
}