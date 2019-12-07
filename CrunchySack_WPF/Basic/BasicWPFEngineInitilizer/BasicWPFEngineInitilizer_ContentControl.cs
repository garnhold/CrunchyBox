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
            engine.Add(
                WPFInfos.AttributeLink<ContentControl, object>("content", ContentControl.ContentProperty),
                WPFInfos.Children<ContentControl, UIElement>(c => c.Content = null, (c, e) => c.Content = e)
            );
        }
    }
}