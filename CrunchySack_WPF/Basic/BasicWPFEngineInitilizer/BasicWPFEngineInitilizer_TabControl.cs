﻿using System;
using System.IO;

using System.Windows;
using System.Windows.Controls;

namespace Crunchy.Sack_WPF
{
    using Dough;
    using Sack;
    
    [BasicWPFEngineInitilizer]
    static public class BasicWPFEngineInitilizer_TabControl
    {
        [BasicWPFEngineInitilizer]
        static public void Initilize(WPFEngine engine)
        {
            engine.AddSimpleInstancer<TabControl>();
            engine.AddSimpleInstancer<TabItem>();
        }
    }
}