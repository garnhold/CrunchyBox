using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Salt;
    using Noodle;
    using Recipe;

    public class TiledMapAsset : ScriptableObject, IGrid<int>
    {
        [SerializeField] private int width;
        [SerializeField] private int height;

        [SerializeField] private int[] tile_ids;

        public void Initialize(int w, int h, IEnumerable<int> ids)
        {
            width = w;
            height = h;

            tile_ids = ids.ToArray();
        }

        public int GetWidth()
        {
            return width;
        }

        public int GetHeight()
        {
            return height;
        }

        public int this[int x, int y]
        {
            get { return tile_ids.GetDropped(width * y + x); }
            set { tile_ids.SetDropped(width * y + x, value); }
        }
    }
}