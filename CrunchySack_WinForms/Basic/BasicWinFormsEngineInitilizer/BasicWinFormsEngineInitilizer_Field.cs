using System;
using System.IO;

using System.Windows.Forms;

namespace Crunchy.Sack.WinForms
{
    using Dough;
    using Sack;
    using WinCommon;
    
    [BasicWinFormsEngineInitilizer]
    static public class BasicWinFormsEngineInitilizer_Field
    {
        [BasicWinFormsEngineInitilizer]
        static public void Initilize(WinFormsEngine engine)
        {
            engine.AddPublicPropertyAttributeLinksForType<TextBox>();
            engine.Add(
                WinFormsInstancers.Simple("TextField", () => new TextBox())
            );

            engine.AddPublicPropertyAttributeLinksForType<NumericUpDown>();
            engine.Add(
                WinFormsInstancers.Simple("NumericField", () => new NumericUpDown())
            );
        }
    }
}