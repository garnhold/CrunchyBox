using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Sauce;
    using Sandwich;

    public class SpriteGeneratorSheet
    {
        private float time_step;
        private Texture2D texture;
        private IGrid<Color> grid;

        private List<VectorI2> sprite_coords;
        private List<IGrid<Color>> sprite_datas;

        static public SpriteGeneratorSheet CreateNumberFrames(VectorI2 frame_size, int number_frame, float time_step)
        {
            return new SpriteGeneratorSheet(frame_size, number_frame, time_step);
        }
        static public SpriteGeneratorSheet CreateDuration(VectorI2 frame_size, float seconds, float frames_per_second)
        {
            return CreateNumberFrames(frame_size, (int)(seconds * frames_per_second), 1.0f / frames_per_second);
        }

        private SpriteGeneratorSheet(VectorI2 frame_size, int number_frames, float time_step)
        {
            float aspect = (float)frame_size.x / (float)frame_size.y;
            int grid_width = (int)(Mathq.Sqrt(number_frames) / aspect);
            int grid_height = number_frames / grid_width;

            this.time_step = time_step;
            this.texture = Texture2DExtensions.CreateClear(grid_width * frame_size.x, grid_height * frame_size.y);
            this.grid = this.texture.CreateColorGrid();

            this.sprite_coords = number_frames
                .RepeatOperationWithIndex(i => new VectorI2(i % grid_width, i / grid_width).GetComponentMultiply(frame_size))
                .ToList();

            this.sprite_datas = this.sprite_coords
                .Convert(c => this.grid.BoundSub(c, frame_size))
                .ToList();
        }

        public float GetTimeStep()
        {
            return time_step;
        }

        public Texture2D GetTexture()
        {
            return texture;
        }

        public IEnumerable<VectorI2> GetSpriteCoords()
        {
            return sprite_coords;
        }

        public IEnumerable<IGrid<Color>> GetSpriteDatas()
        {
            return sprite_datas;
        }
    }
}