using System;
using System.IO;

using System.Drawing;
using System.Windows.Forms;

namespace Crunchy.Sack_WinForms
{
    using Dough;
    using Sack;
    
    [BasicWinFormsEngineInitilizer]
    static public class BasicWinFormsEngineInitilizer_TabControl
    {
        [BasicWinFormsEngineInitilizer]
        static public void Initilize(WinFormsEngine engine)
        {
            engine.AddSimpleInstancer<TabControl>();
            engine.AddPublicPropertyAttributeLinksForType<TabControl>();

            engine.AddSimpleInstancer<TabPage>();
            engine.AddPublicPropertyAttributeLinksForType<TabPage>();
        }
    }
}