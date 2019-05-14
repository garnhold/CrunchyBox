﻿using System;
using System.IO;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

using CrunchyDough;
using CrunchySack;

namespace CrunchySack_WPF
{
    [BasicWPFEngineInitilizer]
    static public class BasicWPFEngineInitilizer_HeaderedItemsControl
    {
        [BasicWPFEngineInitilizer]
        static public void Initilize(WPFEngine engine)
        {
            engine.Add(
                WPFInfos.AttributeLink<HeaderedItemsControl, object>("header", HeaderedItemsControl.HeaderProperty)
            );
        }
    }
}