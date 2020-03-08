using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public struct RadiatingPoint
    {
        private VectorI2 point;
        private float distance;

        public RadiatingPoint(VectorI2 p)
        {
            point = p;
            distance = point.GetMagnitude();
        }

        public VectorI2 GetPoint()
        {
            return point;
        }

        public float GetDistance()
        {
            return distance;
        }
    }
}