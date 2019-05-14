using System;
using System.IO;

using System.Windows;
using System.Windows.Controls;

using CrunchyDough;
using CrunchySack;

namespace CrunchySack_WPF
{
    [BasicWPFEngineInitilizer]
    static public class BasicWPFEngineInitilizer_Layouts
    {
        [BasicWPFEngineInitilizer]
        static public void Initilize(WPFEngine engine)
        {
            engine.Add(
                WPFInstancers.Simple("HorizontalLayout", () => new StackPanel() { Orientation = Orientation.Horizontal }),
                WPFInstancers.Simple("VerticalLayout", () => new StackPanel() { Orientation = Orientation.Vertical })
            );
        }
    }
}