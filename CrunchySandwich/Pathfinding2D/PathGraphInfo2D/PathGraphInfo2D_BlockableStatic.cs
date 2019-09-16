using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class PathGraphInfo2D_BlockableStatic : PathGraphInfo2D_Simple<PathNode2D_BlockableStatic>
    {
        [SerializeField]private float check_interval;

        protected override void InitializePathNodeInternal(PathNode2D_BlockableStatic path_node)
        {
            path_node.InitializePathNodeBlockableStatic(check_interval);
        }
    }
}