using System;
using System.IO;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Crunchy.Sack_WPF
{
    using Dough;
    using Noodle;
    using Sack;
    using System;
    
    public class DragHandler_Internal_Value : DragHandler_Internal
    {
        private object value;

        protected override object GetObjectToDrag()
        {
            return value;
        }

        public DragHandler_Internal_Value(object o)
        {
            value = o;
        }

        public DragHandler_Internal_Value() : this(null) { }

        public void SetValue(object v)
        {
            value = v;
        }

        public object GetValue()
        {
            return value;
        }
    }
}