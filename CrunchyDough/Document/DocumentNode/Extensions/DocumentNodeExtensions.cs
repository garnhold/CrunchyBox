using System;
using System.Text;

using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class DocumentNodeExtensions
    {
        static public CANVAS_TYPE Render<CANVAS_TYPE>(this DocumentNode<CANVAS_TYPE> item) where CANVAS_TYPE : new()
        {
            CANVAS_TYPE canvas = new CANVAS_TYPE();

            item.Render(canvas);
            return canvas;
        }
    }
}