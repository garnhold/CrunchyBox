﻿using System;
using System.IO;

using Gtk;

namespace Crunchy.Sack_Gtk
{
    using Dough;
    using Sack;
    
    [BasicGtkEngineInitilizer]
    static public class BasicGtkEngineInitilizer_TabControl
    {
        [BasicGtkEngineInitilizer]
        static public void Initilize(GtkEngine engine)
        {
            engine.AddSimpleInstancer<Notebook>("TabControl");
            engine.AddPublicPropertyAttributeLinksForType<Notebook>();

            engine.AddChildren<Notebook, NotebookItem>(
                (n, i) => n.RemoveNotebookItemAt(i),
                (n, i) => n.AddNotebookItem(i),
                (n, p, i) => n.InsertNotebookItem(p, i)
            );
                
            engine.AddSimpleConstructor<NotebookItem, Widget, Widget>("TabItem", (t, p) => new NotebookItem(t, p));
            engine.AddSimpleConstructor<NotebookItem, string, Widget>("TabItem", (t, p) => new NotebookItem(t, p));
        }
    }
}