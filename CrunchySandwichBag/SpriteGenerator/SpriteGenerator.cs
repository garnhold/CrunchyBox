using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Sauce;
    using Sandwich;

    public abstract class SpriteGenerator : CustomAsset
    {
        [SerializeField] private int frame_width;
        [SerializeField] private int frame_height;

        [SerializeField] private int number_frames;
        [SerializeFieldEX] private Duration duration;

        protected abstract void GenerateInternal(IEnumerable<IGrid<Color>> frames, float time_step);

        [InspectorAction]
        private void Generate()
        {
            float aspect = (float)frame_width / (float)frame_height;
            int grid_width = (int)(Mathq.Sqrt(number_frames) / aspect);
            int grid_height = number_frames / grid_width;

            string final_filename = Filename.SetFilenameWithExtension(this.GetAssetPath(), name + ".png");

            Texture2D final_texture = Texture2DExtensions.CreateClear(
                grid_width * frame_width,
                grid_height * frame_height
            );

            IGrid<Color> final_grid = final_texture.CreateColorGrid();

            List<VectorI2> frame_coords = number_frames
                .RepeatOperationWithIndex(i => new VectorI2((i % grid_width) * frame_width, (i / grid_width) * frame_height))
                .ToList();

            VectorI2 frame_size = new VectorI2(frame_width, frame_height);

            List<IGrid<Color>> frames = frame_coords
                .Convert(c => final_grid.BoundSub(c, frame_size))
                .ToList();
                
            GenerateInternal(frames, (duration / number_frames).GetSeconds());

            final_texture.Apply();
            final_texture.SaveAsPNG(final_filename);
        }
    }
}