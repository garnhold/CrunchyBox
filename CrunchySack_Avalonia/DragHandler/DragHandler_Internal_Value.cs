using System;
using System.IO;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;

namespace Crunchy.Sack_Avalonia
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