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

        private List<IGridBoundLogging<Color>> sprite_datas;

        public SpriteGeneratorSheet(float time_step, VectorI2 frame_size)
        {
            this.time_step = time_step;
            this.frame_size = frame_size;

            sprite_datas = new List<IGridBoundLogging<Color>>();
        }

        public IGrid<Color> CreateNewFrame()
        {
            return sprite_datas.AddAndGet(new IGridBoundLogging<Color>(new Grid<Color>(frame_size)));
        }

        public IEnumerable<SpriteGeneratorSheetFrame> Generate(out Texture2D texture, int quality = 1)
        {
            List<SpriteGeneratorSheetFrame> frames = sprite_datas
                .Convert(d => new SpriteGeneratorSheetFrame(d))
                .ToList();

            VectorF2 full_size;
            RectF2Packer<SpriteGeneratorSheetFrame>.ExpandPack(
                frames,
                VectorI2s.POTDimensionSequence(13).Convert(v => v.GetVectorF2()),
                f => f.GetSize(),
                out full_size,
                quality
            ).Process(p => p.Key.SetRect(p.Value));

            IGrid<Color> grid = new Grid<Color>(full_size.GetVectorI2());

            frames.Process(f => f.Render(grid));

            texture = grid.CreateTexture2D();
            return frames;
        }

        public float GetTimeStep()
        {
            return time_step;
        }

        public int GetNumberFrames()
        {
            return sprite_datas.Count;
        }

        public Duration GetDuration()
        {
            return Duration.Seconds(GetTimeStep() * GetNumberFrames());
        }

        public IEnumerable<IGrid<Color>> GetFrames()
        {
            return sprite_datas;
        }
    }
}