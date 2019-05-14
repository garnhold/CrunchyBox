using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public abstract class PathGraphInfo2D : CustomAsset
    {
        public abstract PathNode2D CreatePathNode();
    }
}