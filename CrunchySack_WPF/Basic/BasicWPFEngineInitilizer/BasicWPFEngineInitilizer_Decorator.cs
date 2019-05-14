using System;
using System.IO;

using System.Windows;
using System.Windows.Controls;

using CrunchyDough;
using CrunchySack;

namespace CrunchySack_WPF
{
    [BasicWPFEngineInitilizer]
    static public class BasicWPFEngineInitilizer_Decorator
    {
        [BasicWPFEngineInitilizer]
        static public void Initilize(WPFEngine engine)
        {
            engine.Add(
                WPFInfos.AttributeValue<Decorator, UIElement>("child", (d, e) => d.Child = e),
                WPFInfos.Children<Decorator, UIElement>(d => d.Child = null, (d, e) => d.Child = e)
            );
        }
    }
}