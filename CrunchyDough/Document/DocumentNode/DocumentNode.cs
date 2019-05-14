﻿using System;
using System.Text;

using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public abstract class DocumentNode<CANVAS_TYPE>
    {
        public abstract bool IsVisible();
        public abstract void Render(CANVAS_TYPE canvas);
    }
}