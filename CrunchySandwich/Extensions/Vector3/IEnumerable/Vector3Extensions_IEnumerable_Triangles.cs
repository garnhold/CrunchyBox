using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class Vector3Extensions_IEnumerable_Triangles
    {
        static public IEnumerable<Triangle3> MakeTriangles(this IEnumerable<Vector3> item)
        {
            using (IEnumerator<Vector3> iterator = item.GetEnumerator())
            {
                while (iterator.MoveNext())
                {
                    Vector3 v0 = iterator.Current;

                    if (iterator.MoveNext())
                    {
                        Vector3 v1 = iterator.Current;

                        if (iterator.MoveNext())
                        {
                            Vector3 v2 = iterator.Current;

                            yield return new Triangle3(v0, v1, v2);
                        }
                        else
                        {
                            yield break;
                        }
                    }
                    else
                    {
                        yield break;
                    }
                }
            }
        }

        static public IEnumerator<Triangle3> MakeTriangleStrip(this IEnumerable<Vector3> item)
        {
            Vector3 previous_point;

            using (IEnumerator<Vector3> iterator = item.GetEnumerator())
            {
                if (iterator.MoveNext())
                {
                    previous_point = iterator.Current;

                    while (iterator.MoveNext())
                    {
                        Vector3 v0 = iterator.Current;

                        if (iterator.MoveNext())
                        {
                            Vector3 v1 = iterator.Current;

                            yield return new Triangle3(previous_point, v0, v1);
                            previous_point = v1;
                        }
                        else
                        {
                            yield break;
                        }
                    }
                }
            }
        }

        static public IEnumerable<Triangle3> MakeTriangleFan(this IEnumerable<Vector3> item)
        {
            Vector3 first_point;
            Vector3 previous_point;

            using (IEnumerator<Vector3> iterator = item.GetEnumerator())
            {
                if (iterator.MoveNext())
                {
                    first_point = iterator.Current;

                    if (iterator.MoveNext())
                    {
                        previous_point = iterator.Current;

                        while (iterator.MoveNext())
                        {
                            Vector3 v0 = iterator.Current;
                           
                            yield return new Triangle3(first_point, previous_point, v0);
                        }
                    }
                }
            }
        }

        static public IEnumerable<Triangle3> MakeIndexedTriangles(this IList<Vector3> item, IEnumerable<int> indexs)
        {
            return item.AtIndexs(indexs).MakeTriangles();
        }
    }
}