using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class PolygonCollider2DExtensions_Paths
    {
        static public IEnumerable<Vector2[]> GetPaths(this PolygonCollider2D item)
        {
            for (int i = 0; i < item.pathCount; i++)
                yield return item.GetPath(i);
        }

        static public void SetPaths(this PolygonCollider2D item, IList<Vector2[]> paths)
        {
            item.pathCount = paths.Count;

            paths.ProcessWithIndex((i, p) => item.SetPath(i, p));
        }
        static public void SetPaths(this PolygonCollider2D item, IEnumerable<Vector2[]> paths)
        {
            item.SetPaths(paths.ToList());
        }
        static public void SetPaths<F>(this PolygonCollider2D item, IEnumerable<F> paths) where F : IEnumerable<Vector2>
        {
            item.SetPaths(paths.Convert(p => p.ToArray()));
        }
    }
}