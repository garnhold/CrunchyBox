using System;
using System.IO;

using System.Windows;
using System.Windows.Controls;

namespace Crunchy.Sack_WPF
{
    using Dough;
    using Sack;
    
    [BasicWPFEngineInitilizer]
    static public class BasicWPFEngineInitilizer_Button
    {
        [BasicWPFEngineInitilizer]
        static public void Initilize(WPFEngine engine)
        {
            engine.AddSimpleInstancer<Button>();
            engine.AddAttributeLink<Button, string>("text", Button.ContentProperty);
            engine.AddAttributeFunction<Button>("action", (b, a) => b.Click += a.GetRoutedEventHandler());
            engine.AddAttributeFunction<Button>("preview_mouse_left_button_down", (b, a) => b.PreviewMouseLeftButtonDown += a.GetMouseButtonEventHandler());
        }
    }
}