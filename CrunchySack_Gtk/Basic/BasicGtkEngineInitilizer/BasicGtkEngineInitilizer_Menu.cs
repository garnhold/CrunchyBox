using System;
using System.IO;

using Gtk;

namespace Crunchy.Sack_Gtk
{
    using Dough;
    using Sack;
    
    [BasicGtkEngineInitilizer]
    static public class BasicGtkEngineInitilizer_Menu
    {
        [BasicGtkEngineInitilizer]
        static public void Initilize(GtkEngine engine)
        {
            engine.AddSimpleInstancer<MenuBar>("Menu");
            engine.AddPublicPropertyAttributeLinksForType<MenuBar>();

            engine.AddSimpleInstancer<MenuItem>("MenuItem");
            engine.AddPublicPropertyAttributeLinksForType<MenuItem>();

            engine.AddLinkInfo<MenuItem, string>("label", (i, s) => 
                i.Child = new AccelLabel(s).Chain(l => l.AccelWidget = i)
            );

            engine.AddFunctionInfo<MenuItem>("action", (i, s) => i.Activated += s.GetEventHandler());
            engine.AddSingleDynamicChildInfo<MenuItem, Widget>("contents", (i, w) => i.Child = w);

            engine.AddDynamicChildrenInfo<MenuItem, MenuItem>(
                (i, p) => i.RemoveSubmenuChildAt(p),
                (i, c) => i.AddSubmenuChild(c),
                (i, p, c) => i.InsertSubmenuChild(p, c)
            );
        }
    }
}