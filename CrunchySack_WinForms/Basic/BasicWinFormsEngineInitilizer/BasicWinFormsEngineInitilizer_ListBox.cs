using System;
using System.IO;

using System.Windows.Forms;

namespace Crunchy.Sack_WinForms
{
    using Dough;
    using Sack;
    
    [BasicWinFormsEngineInitilizer]
    static public class BasicWinFormsEngineInitilizer_ListBox
    {
        [BasicWinFormsEngineInitilizer]
        static public void Initilize(WinFormsEngine engine)
        {
            engine.AddSimpleInstancer<ListBox>();
            engine.AddPublicPropertyAttributeLinksForType<ListBox>();
            engine.AddDynamicChildrenInfo<ListBox>(b => b.Items);
        }
    }
}