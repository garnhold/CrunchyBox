using System;
using System.IO;

using System.Windows;
using System.Windows.Controls;

namespace Crunchy.Sack_WPF
{
    using Dough;
    using Sack;
    
    [BasicWPFEngineInitilizer]
    static public class BasicWPFEngineInitilizer_Decorator
    {
        [BasicWPFEngineInitilizer]
        static public void Initilize(WPFEngine engine)
        {
            engine.AddAttributeValue<Decorator, UIElement>("child", (d, e) => d.Child = e);
            engine.AddChildren<Decorator, UIElement>(d => d.Child = null, (d, e) => d.Child = e);
        }
    }
}