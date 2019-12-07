using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class Texture2DExtensions_Grids
    {
        static public Grid<Color> CreateColorGrid(this Texture2D item)
        {
            return item.CreateGrid<Color>(c => c);
        }

        static public Grid<float> CreateAlphaGrid(this Texture2D item)
        {
            return item.CreateGrid<float>(c => c.a);
        }

        static public Grid<float> CreateGrayscaleGrid(this Texture2D item)
        {
            return item.CreateGrid<float>(c => c.grayscale);
        }

        static public Grid<Vector2> CreateVector2Grid(this Texture2D item)
        {
            return item.CreateGrid(c => c.GetVector2());
        }

        static public Grid<Vector3> CreateVector3Grid(this Texture2D item)
        {
            return item.CreateGrid(c => c.GetVector3());
        }

        static public Grid<bool> CreateSolidGrid(this Texture2D item, float alpha_threshold)
        {
            return item.CreateGrid<bool>(c => c.a >= alpha_threshold);
        }
    }
}