using System;
using System.IO;

using System.Windows;
using System.Windows.Controls;

namespace Crunchy.Sack_WPF
{
    using Dough;
    using Sack;
    
    [BasicWPFEngineInitilizer]
    static public class BasicWPFEngineInitilizer_ScrollViewer
    {
        [BasicWPFEngineInitilizer]
        static public void Initilize(WPFEngine engine)
        {
            engine.AddSimpleInstancer<ScrollViewer>();

            engine.AddChildren<ScrollViewer, UIElement>(v => v.Content = null, (v, e) => v.Content = e);
        }
    }
}