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
    
    public abstract class DragHandler
    {
        private UIElement element;
        private DragDropEffects effects;

        private Point start_point;
        private bool is_dragging;

        protected abstract DataObject OnStartDrag();

        private void element_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            start_point = e.GetPosition(element);
            is_dragging = false;
        }

        private void element_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (is_dragging == false)
            {
                if (e.LeftButton == MouseButtonState.Pressed)
                {
                    Point difference = start_point.GetSubtract(e.GetPosition(element)).GetAbs();

                    if (difference.X >= SystemParameters.MinimumHorizontalDragDistance ||
                        difference.Y >= SystemParameters.MinimumVerticalDragDistance)
                    {
                        is_dragging = true;

                        DragDrop.DoDragDrop(
                            element,
                            OnStartDrag(),
                            effects
                        );
                    }
                }
            }
        }

        public void Attach(UIElement e)
        {
            Detach();

            element = e;

            if (element != null)
            {
                element.PreviewMouseLeftButtonDown += element_PreviewMouseLeftButtonDown;
                element.PreviewMouseMove += element_PreviewMouseMove;
            }
        }

        public void Detach()
        {
            if (element != null)
            {
                element.PreviewMouseLeftButtonDown -= element_PreviewMouseLeftButtonDown;
                element.PreviewMouseMove -= element_PreviewMouseMove;

                element = null;
            }
        }

        public void SetDragDropEffects(DragDropEffects e)
        {
            effects = e;
        }

        public DragDropEffects GetDragDropEffects()
        {
            return effects;
        }
    }
}