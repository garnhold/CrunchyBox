using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public struct RelativePoint
    {
        private Transform transform;
        private Vector3 local_point;

        static public RelativePoint FromLocalPoint(Transform transform, Vector3 local_point)
        {
            return new RelativePoint(transform, local_point);
        }

        static public RelativePoint FromWorldPoint(Transform transform, Vector3 world_point)
        {
            if(transform.IsNotNull())
                return FromLocalPoint(transform, transform.InverseTransformPoint(world_point));

            return FromPoint(world_point);
        }

        static public RelativePoint FromPoint(Vector3 point)
        {
            return FromLocalPoint(null, point);
        }

        private RelativePoint(Transform t, Vector3 p)
        {
            transform = t;
            local_point = p;
        }

        public Transform GetTransform()
        {
            return transform;
        }

        public Vector3 GetTransformPoint()
        {
            if (transform.IsNotNull())
                return transform.position;

            return Vector3.zero;
        }

        public Vector3 GetLocalPoint()
        {
            return local_point;
        }

        public Vector3 GetWorldPoint()
        {
            if(transform.IsNotNull())
                return transform.TransformPoint(local_point);

            return local_point;
        }

        public Vector3 GetWorldOffset()
        {
            return GetWorldPoint() - GetTransformPoint();
        }
    }
}