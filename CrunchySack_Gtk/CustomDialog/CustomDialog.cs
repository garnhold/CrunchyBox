using System;
using System.Collections;
using System.Collections.Generic;

using Gtk;

namespace Crunchy.Sack_Gtk
{
    using Dough;
    using Noodle;
    using Sack;

    public class CustomDialog : Window
    {
        private object result;

        public CustomDialog() : base(WindowType.Toplevel) { }

        public void DoDialog<T>(Process<T> process)
        {
            Destroyed += delegate {
                process(result.ConvertEX<T>());
            };

            ShowAll();
        }

        public void Close(object r)
        {
            result = r;

            Close();
        }

        public void CloseOk()
        {
            Close(true);
        }

        public void CloseCancel()
        {
            Close(false);
        }
    }
}