using System;
using System.IO;

using System.Windows.Forms;

namespace Crunchy.Sack_WinForms
{
    using Dough;
    using Sack;
    using Sack_WinCommon;
    
    [BasicWinFormsEngineInitilizer]
    static public class BasicWinFormsEngineInitilizer_Field
    {
        [BasicWinFormsEngineInitilizer]
        static public void Initilize(WinFormsEngine engine)
        {
            engine.AddSimpleInstancer<TextBox>("TextField");
            engine.AddPublicPropertyAttributeLinksForType<TextBox>();

            engine.AddSimpleInstancer<NumericUpDown>("NumericField");
            engine.AddPublicPropertyAttributeLinksForType<NumericUpDown>();
        }
    }
}