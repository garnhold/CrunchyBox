﻿using System;
using System.IO;

using System.Windows.Forms;

namespace Crunchy.Sack.WinForms
{
    using Dough;
    using Sack;
    
    [BasicWinFormsEngineInitilizer]
    static public class BasicWinFormsEngineInitilizer_Window
    {
        [BasicWinFormsEngineInitilizer]
        static public void Initilize(WinFormsEngine engine)
        {
            engine.Add(
                WinFormsInstancers.Simple("Window", () => new Form())
            );
        }
    }
}