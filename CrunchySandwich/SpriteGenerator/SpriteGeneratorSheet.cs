using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Salt;
    using Sauce;

    public class SpriteGeneratorSheet
    {
        private float time_step;
        private VectorI2 frame_size;

        private List<IGrid<Color>> sprite_datas;

        public SpriteGeneratorSheet(float time_step, VectorI2 frame_size)
        {
            this.time_step = time_step;
            this.frame_size = frame_size;

            sprite_datas = new List<IGrid<Color>>();
        }

        public IGrid<Color> CreateNewFrame()
        {
            return sprite_datas.AddAndGet(new Grid<Color>(frame_size));
        }

        public IGrid<Color> GenerateColorGrid()
        {
            IGrid<Color> grid = new Grid<Color>(CalculateTotalSize());

            CalculateSpriteCoords()
                .PairStrict(sprite_datas)
                .Process(p => grid.SetSection(p.item1, p.item2));

            return grid;
        }

        public Texture2D GenerateTexture()
        {
            return GenerateColorGrid().CreateTexture2D();
        }

        public IEnumerable<Sprite> GenerateSprites()
        {
            return GenerateTexture().CreateCenterSprites(
                CalculateSpriteRects().Convert(r => r.GetRect())
            );
        }

        public float GetTimeStep()
        {
            return time_step;
        }

        public float GetFrameAspect()
        {
            return (float)frame_size.x / (float)frame_size.y;
        }

        public int GetNumberFrames()
        {
            return sprite_datas.Count;
        }

        public Duration GetDuration()
        {
            return Duration.Seconds(GetTimeStep() * GetNumberFrames());
        }

        public VectorI2 CalculateGridSize()
        {
            int width = Mathq.CeilToInt(Mathq.Sqrt(GetNumberFrames()) / GetFrameAspect());
            int height = Mathq.CeilToInt((float)GetNumberFrames() / (float)width);

            return new VectorI2(width, height);
        }

        public VectorI2 CalculateTotalSize()
        {
            return CalculateGridSize().GetComponentMultiply(frame_size);
        }

        public IEnumerable<VectorI2> CalculateSpriteCoords()
        {
            VectorI2 grid_size = CalculateGridSize();

            return GetNumberFrames()
                .RepeatOperationWithIndex(i => new VectorI2(i % grid_size.x, i / grid_size.x).GetComponentMultiply(frame_size))
                .ToList();
        }

        public IEnumerable<RectI2> CalculateSpriteRects()
        {
            return CalculateSpriteCoords()
                .Convert(c => RectI2Extensions.CreateLowerLeftRectI2(c, frame_size));
        }

        public IEnumerable<IGrid<Color>> GetFrames()
        {
            return sprite_datas;
        }
    }
}