using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Salt;
    using Sauce;

    public class SpriteGeneratorSheetFrame
    {
        private VectorF2 origin;
        private IGrid<Color> data;

        private RectF2 rect;

        public SpriteGeneratorSheetFrame(VectorF2 o, IGrid<Color> d)
        {
            origin = o;
            data = d;
        }

        public void Render(IGrid<Color> grid)
        {
            grid.SetSection(rect.GetLowerLeftPoint().GetVectorI2(), data);
        }

        public void SetRect(RectF2 rect)
        {
            this.rect = rect;
        }

        public VectorI2 GetSize()
        {
            return data.GetSize();
        }

        public VectorF2 GetOrigin()
        {
            return origin;
        }

        public RectF2 GetRect()
        {
            return rect;
        }
    }
}