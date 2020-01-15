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
    
    public abstract class DropHandler
    {
        private UIElement element;

        protected abstract bool OnEnter(Point point, IDataObject data);
        protected abstract bool OnOver(Point point, IDataObject data);
        protected abstract bool OnLeave(Point point, IDataObject data);

        protected abstract bool OnDrop(Point point, IDataObject data);

        private void element_DragEnter(object sender, DragEventArgs e)
        {
            if (OnEnter(e.GetPosition(element), e.Data))
                e.Handled = true;
        }

        private void element_DragOver(object sender, DragEventArgs e)
        {
            if (OnOver(e.GetPosition(element), e.Data))
                e.Handled = true;
        }

        private void element_DragLeave(object sender, DragEventArgs e)
        {
            if (OnLeave(e.GetPosition(element), e.Data))
                e.Handled = true;
        }

        private void element_Drop(object sender, DragEventArgs e)
        {
            if (OnDrop(e.GetPosition(element), e.Data))
                e.Handled = true;
        }

        public DropHandler()
        {
        }

        public void Attach(UIElement e)
        {
            Detach();

            element = e;

            if (element != null)
            {
                element.AllowDrop = true;

                element.Drop += element_Drop;

                element.DragEnter += element_DragEnter;
                element.DragOver += element_DragOver;
                element.DragLeave += element_DragLeave;
            }
        }

        public void Detach()
        {
            if (element != null)
            {
                element.Drop -= element_Drop;

                element.DragEnter -= element_DragEnter;
                element.DragOver -= element_DragOver;
                element.DragLeave -= element_DragLeave;

                element = null;
            }
        }
    }
}