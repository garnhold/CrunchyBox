using System;
using System.IO;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Crunchy.Sack_WPF
{
    using Dough;
    using Sack;
    
    [BasicWPFEngineInitilizer]
    static public class BasicWPFEngineInitilizer_ContentControl
    {
        [BasicWPFEngineInitilizer]
        static public void Initilize(WPFEngine engine)
        {
            engine.AddAttributeLink<ContentControl, object>("content", ContentControl.ContentProperty);
            engine.AddChildren<ContentControl, UIElement>(c => c.Content = null, (c, e) => c.Content = e);
        }
    }
}