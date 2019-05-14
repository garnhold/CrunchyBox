using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public abstract class PathGraphInfo2D_Simple<T> : PathGraphInfo2D where T : PathNode2D
    {
        protected virtual void InitializePathNodeInternal(T path_node) { }

        public override PathNode2D CreatePathNode()
        {
            GameObject game_object = new GameObject();

            return game_object.AddComponent<T>()
                .Chain(z => InitializePathNodeInternal(z));
        }
    }
}