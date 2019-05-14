using System;
using System.IO;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Controls.Primitives;

using CrunchyDough;
using CrunchySack;

namespace CrunchySack_WPF
{
    [BasicWPFEngineInitilizer]
    static public class BasicWPFEngineInitilizer_Selector
    {
        [BasicWPFEngineInitilizer]
        static public void Initilize(WPFEngine engine)
        {
            engine.Add(
                WPFInfos.AttributeLink<Selector, object>("selected_item", Selector.SelectedItemProperty)
            );
        }
    }
}