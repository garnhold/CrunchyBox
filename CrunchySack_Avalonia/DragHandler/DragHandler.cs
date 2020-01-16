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
    using Winsys;
    
    public abstract class DragHandler
    {
        private Control element;
        private DragDropEffects effects;

        private Point start_point;
        private bool is_dragging;

        public const double MinimumDragDistance = 15.0;

        protected abstract DataObject OnStartDrag();

        private void element_PointerPressedEvent(object sender, PointerPressedEventArgs e)
        {
            if(e.GetPointerUpdateKind() == PointerUpdateKind.LeftButtonPressed)
            {
                start_point = e.GetPosition(element);
                is_dragging = false;
            }
        }

        private void element_PointerMovedEvent(object sender, PointerEventArgs e)
        {
            if (is_dragging == false)
            {
                if (e.GetPointerUpdateKind() == PointerUpdateKind.LeftButtonPressed)
                {
                    if(start_point.IsOutsideDistance(e.GetPosition(element), MinimumDragDistance))
                    {
                        is_dragging = true;

                        DragDrop.DoDragDrop(e, OnStartDrag(), effects);
                    }
                }
            }
        }

        public void Attach(Control e)
        {
            Detach();

            element = e;

            if (element != null)
            {
                element.AddHandler(Control.PointerPressedEvent, element_PointerPressedEvent, RoutingStrategies.Tunnel);
                element.AddHandler(Control.PointerMovedEvent, element_PointerMovedEvent, RoutingStrategies.Tunnel);
            }
        }

        public void Detach()
        {
            if (element != null)
            {
                element.RemoveHandler(Control.PointerPressedEvent, element_PointerPressedEvent);
                element.RemoveHandler(Control.PointerMovedEvent, element_PointerMovedEvent);

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