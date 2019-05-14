using System;
using System.IO;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

using CrunchyDough;
using CrunchyNoodle;
using CrunchySack;
using CrunchySystem;

namespace CrunchySack_WPF
{
    public abstract class DragHandler_Internal : DragHandler
    {
        protected abstract object GetObjectToDrag();

        static private object DRAGGED_OBJECT;
        static public object GetDraggedObject()
        {
            return DRAGGED_OBJECT;
        }
        static public void ClearDraggedObject()
        {
            DRAGGED_OBJECT = null;
        }

        protected override DataObject OnStartDrag()
        {
            DRAGGED_OBJECT = GetObjectToDrag();

            return new DataObject(DataFormats.Text, "Internal");
        }
    }
}