using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public partial class GizmosExtensions
    {
        static public void UseMatrix(Matrix4x4 matrix, Process process)
        {
            Matrix4x4 old_matrix = Gizmos.matrix;

            Gizmos.matrix = matrix;
                process();
            Gizmos.matrix = old_matrix;
        }
    }
}