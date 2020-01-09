using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    public class Polygon
    {
        private List<PolygonTriangle> triangles;

        public Polygon(IEnumerable<PolygonTriangle> t)
        {
            triangles = t.ToList();
        }

        public IEnumerable<PolygonTriangle> GetTriangles()
        {
            return triangles;
        }
    }
}