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
        private IGrid<Color> data;
        private RectI2 frame_rect;
        private RectI2 sub_frame_rect;

        private Rect rect;

        public SpriteGeneratorSheetFrame(IGridBoundLogging<Color> d)
        {
            data = d.GetBoundSubSection();

            frame_rect = d.GetRect();
            sub_frame_rect = d.GetBoundRect();
        }

        public void Render(IGrid<Color> grid)
        {
            grid.SetSection(rect.GetLowerLeftPoint().GetVectorI2(), data);
        }

        public void SetRect(RectF2 rect)
        {
            this.rect = rect.GetRect();
        }

        public Rect GetRect()
        {
            return rect;
        }

        public VectorI2 GetSize()
        {
            return data.GetSize();
        }

        public Vector2 GetPivot()
        {
            return sub_frame_rect.ConvertRangePointToPercentPoint(
                frame_rect.ConvertPercentPointToRangePoint(VectorF2.HALF)
            ).GetVector2();
        }
    }
}