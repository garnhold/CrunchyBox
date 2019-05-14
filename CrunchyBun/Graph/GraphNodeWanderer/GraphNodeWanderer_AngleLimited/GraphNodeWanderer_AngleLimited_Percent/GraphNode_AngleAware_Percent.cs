using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyBun
{
    public interface GraphNode_AngleAware_Percent<T> : GraphNode_AngleAware<T> where T : GraphNode_AngleAware_Percent<T>
    {
        float GetAngleInPercentToGraphNode(T node);
    }
}