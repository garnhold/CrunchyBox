﻿using System;
using System.IO;

using System.Windows.Forms;

namespace Crunchy.Sack_WinForms
{
    using Dough;
    using Sack;
    
    [BasicWinFormsEngineInitilizer]
    static public class BasicWinFormsEngineInitilizer_Slider
    {
        [BasicWinFormsEngineInitilizer]
        static public void Initilize(WinFormsEngine engine)
        {
            engine.AddSimpleInstancer<TrackBar>("Slider");
            engine.AddPublicPropertyAttributeLinksForType<TrackBar>();
        }
    }
}