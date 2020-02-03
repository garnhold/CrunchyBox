using System;
using System.Collections;
using System.Collections.Generic;

using Gtk;

namespace Crunchy.Sack_Gtk
{
    using Dough;
    using Noodle;
    using Sack;

    public abstract partial class GtkEngine : ApplicationRepresentationEngine<Window, PeriodicProcess_Gtk>
    {
        protected override void AttachLinkSyncroDaemon(Window window, LinkSyncroDaemon daemon)
        {
            window.AttachLinkSyncroDaemon(daemon);
        }

        protected override void StartApplicationInternal(Operation<Window> operation)
        {
            Application.Init();

            Window window = operation();

            window.DeleteEvent += delegate(object obj, DeleteEventArgs args) {
                Application.Quit();
                args.RetVal = true;
            };

            window.ShowAll();

            Application.Run();
        }

        public void AddAttributeLink<REPRESENTATION_TYPE, VALUE_TYPE>(string n, Process<REPRESENTATION_TYPE, VALUE_TYPE> a, Operation<VALUE_TYPE, REPRESENTATION_TYPE> r) where REPRESENTATION_TYPE : Widget
        {
            this.AddAttributeLink<REPRESENTATION_TYPE, VALUE_TYPE>(n, a, r, s => s.IsFocus == false);
        }

        public void AddAttributeLink<REPRESENTATION_TYPE, VALUE_TYPE>(string n, string property_name) where REPRESENTATION_TYPE : Widget
        {
            this.AddAttributeLink<REPRESENTATION_TYPE, VALUE_TYPE>(n,
                (w, v) => w.SetProperty(property_name, v.ConvertEX<GLib.Value>()),
                w => w.GetProperty(property_name).ConvertEX<VALUE_TYPE>()
            );
        }

        public void AddChildPropertyOfParentAttributeLink<PARENT_TYPE, REPRESENTATION_TYPE, VALUE_TYPE>(string n, string property_name) where PARENT_TYPE : Container where REPRESENTATION_TYPE : Widget
        {
            this.AddAttributeLink<REPRESENTATION_TYPE, VALUE_TYPE>(n,
                (w, v) => w.SetChildPropertyOfParent<PARENT_TYPE>(property_name, v),
                w => w.GetChildPropertyOfParent<PARENT_TYPE>(property_name).ConvertEX<VALUE_TYPE>()
            );
        }
    }
}