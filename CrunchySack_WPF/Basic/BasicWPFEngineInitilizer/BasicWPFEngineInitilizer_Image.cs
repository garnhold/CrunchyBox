using System;
using System.IO;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Crunchy.Sack_WPF
{
    using Dough;
    using Sack;
    
    [BasicWPFEngineInitilizer]
    static public class BasicWPFEngineInitilizer_Image
    {
        [BasicWPFEngineInitilizer]
        static public void Initilize(WPFEngine engine)
        {
            engine.Add(
                WPFInstancers.Simple("Image", () => new Image()),

                WPFInfos.AttributeLink<Image, ImageSource>("source", Image.SourceProperty)
            );
        }
    }
}