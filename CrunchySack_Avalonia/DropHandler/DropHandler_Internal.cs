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
    
    public abstract class DropHandler_Internal : DropHandler
    {
        protected abstract bool OnEnterInternal(Point point, object obj);
        protected abstract bool OnOverInternal(Point point, object obj);
        protected abstract bool OnLeaveInternal(Point point, object obj);

        protected abstract bool OnDropInternal(Point point, object obj);

        protected override bool OnEnter(Point point, IDataObject data)
        {
            return DragHandler_Internal.GetDraggedObject().IfNotNull(o => OnEnterInternal(point, o));
        }

        protected override bool OnOver(Point point, IDataObject data)
        {
            return DragHandler_Internal.GetDraggedObject().IfNotNull(o => OnOverInternal(point, o));
        }

        protected override bool OnLeave(Point point, IDataObject data)
        {
            return DragHandler_Internal.GetDraggedObject().IfNotNull(o => OnLeaveInternal(point, o));
        }

        protected override bool OnDrop(Point point, IDataObject data)
        {
            if (DragHandler_Internal.GetDraggedObject().IfNotNull(o => OnDropInternal(point, o)))
            {
                DragHandler_Internal.ClearDraggedObject();
                return true;
            }

            return false;
        }
    }
}