using System;
using System.IO;

using System.Windows.Forms;

namespace Crunchy.Sack_WinForms
{
    using Dough;
    using Sack;
    
    [BasicWinFormsEngineInitilizer]
    static public class BasicWinFormsEngineInitilizer_Menu
    {
        [BasicWinFormsEngineInitilizer]
        static public void Initilize(WinFormsEngine engine)
        {
            engine.AddSimpleInstancer<MenuStrip>("Menu");
            engine.AddPublicPropertyAttributeLinksForType<MenuStrip>();
            engine.AddDynamicChildrenInfo<MenuStrip>(m => m.Items);

            engine.AddSimpleInstancer<ToolStripMenuItem>("MenuItem");
            engine.AddPublicPropertyAttributeLinksForType<ToolStripMenuItem>();
            engine.AddDynamicChildrenInfo<ToolStripMenuItem>(i => i.DropDownItems);
            engine.AddFunctionInfo<ToolStripMenuItem>("click", (i, s) => i.Click += s.GetEventHandler());
        }
    }
}