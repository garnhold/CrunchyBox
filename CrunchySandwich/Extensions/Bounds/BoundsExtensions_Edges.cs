using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class BoundsExtensions_Edges
    {
        static public IEnumerable<Tuple<Vector3, Vector3>> GetEdges(this Bounds item)
        {
            return item.GetLeftFaceEdges()
                .Append(item.GetRightFaceEdges())

                .Append(item.GetBottomFaceEdges())
                .Append(item.GetTopFaceEdges())

                .Append(item.GetNearFaceEdges())
                .Append(item.GetFarFaceEdges());
        }

        static public IEnumerable<Tuple<Vector3, Vector3>> GetLeftFaceEdges(this Bounds item)
        {
            return item.GetLeftFacePoints().CloseLoop().ConvertConnections();
        }
        static public IEnumerable<Tuple<Vector3, Vector3>> GetRightFaceEdges(this Bounds item)
        {
            return item.GetRightFacePoints().CloseLoop().ConvertConnections();
        }

        static public IEnumerable<Tuple<Vector3, Vector3>> GetBottomFaceEdges(this Bounds item)
        {
            return item.GetBottomFacePoints().CloseLoop().ConvertConnections();
        }
        static public IEnumerable<Tuple<Vector3, Vector3>> GetTopFaceEdges(this Bounds item)
        {
            return item.GetTopFacePoints().CloseLoop().ConvertConnections();
        }

        static public IEnumerable<Tuple<Vector3, Vector3>> GetNearFaceEdges(this Bounds item)
        {
            return item.GetNearFacePoints().CloseLoop().ConvertConnections();
        }
        static public IEnumerable<Tuple<Vector3, Vector3>> GetFarFaceEdges(this Bounds item)
        {
            return item.GetFarFacePoints().CloseLoop().ConvertConnections();
        }
    }
}