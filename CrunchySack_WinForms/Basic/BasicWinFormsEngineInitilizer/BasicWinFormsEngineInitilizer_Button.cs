using System;
using System.IO;

using System.Windows.Forms;

namespace Crunchy.Sack_WinForms
{
    using Dough;
    using Sack;
    
    [BasicWinFormsEngineInitilizer]
    static public class BasicWinFormsEngineInitilizer_Button
    {
        [BasicWinFormsEngineInitilizer]
        static public void Initilize(WinFormsEngine engine)
        {
            engine.AddSimpleInstancer<Button>();
            engine.AddPublicPropertyAttributeLinksForType<Button>();

            engine.AddAttributeFunction<Button>("click", (b, s) => b.Click += s.GetEventHandler());
        }
    }
}