using System;
using System.IO;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;

namespace Crunchy.Sack_Avalonia
{
    using Dough;
    using Noodle;
    using Sack;
    using System;
    
    public abstract class DropHandler
    {
        private Control element;

        private Point point;
        private IDataObject data;

        protected abstract bool OnEnter(Point point, IDataObject data);
        protected abstract bool OnOver(Point point, IDataObject data);
        protected abstract bool OnLeave(Point point, IDataObject data);

        protected abstract bool OnDrop(Point point, IDataObject data);

        private void element_DragEnter(object sender, DragEventArgs e)
        {
            Update(e);

            if (OnEnter(point, data))
                e.Handled = true;
        }

        private void element_DragOver(object sender, DragEventArgs e)
        {
            Update(e);

            if (OnOver(point, data))
                e.Handled = true;
        }

        private void element_DragLeave(object sender, RoutedEventArgs e)
        {
            if (OnLeave(point, data))
                e.Handled = true;
        }

        private void element_Drop(object sender, DragEventArgs e)
        {
            Update(e);

            if (OnDrop(point, data))
                e.Handled = true;
        }

        private void Update(DragEventArgs e)
        {
            point = e.GetPosition(element);
            data = e.Data;
        }

        public DropHandler()
        {
        }

        public void Attach(Control e)
        {
            Detach();

            element = e;

            if (element != null)
            {
                DragDrop.SetAllowDrop(element, true);

                element.AddHandler(DragDrop.DropEvent, element_Drop);

                element.AddHandler(DragDrop.DragEnterEvent, element_DragEnter);
                element.AddHandler(DragDrop.DragOverEvent, element_DragOver);
                element.AddHandler(DragDrop.DragLeaveEvent, element_DragLeave);
            }
        }

        public void Detach()
        {
            if (element != null)
            {
                element.RemoveHandler(DragDrop.DropEvent, element_Drop);

                element.RemoveHandler(DragDrop.DragEnterEvent, element_DragEnter);
                element.RemoveHandler(DragDrop.DragOverEvent, element_DragOver);
                element.RemoveHandler(DragDrop.DragLeaveEvent, element_DragLeave);

                element = null;
            }
        }
    }
}