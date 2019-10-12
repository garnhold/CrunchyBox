using System;

using CrunchyDough;
using UnityEngine;

namespace CrunchySandwich
{
    static public class EventTypeExtensions_Compare
    {
        static public bool IsMouseRelated(this EventType item)
        {
            switch (item)
            {
                case EventType.MouseDown: return true;
                case EventType.MouseUp: return true;
                case EventType.MouseMove: return true;
                case EventType.MouseDrag: return true;

                case EventType.ContextClick: return true;
                case EventType.MouseEnterWindow: return true;
                case EventType.MouseLeaveWindow: return true;

                case EventType.DragUpdated: return true;
                case EventType.DragPerform: return true;
                case EventType.DragExited: return true;

                case EventType.ScrollWheel: return false;

                case EventType.KeyDown: return false;
                case EventType.KeyUp: return false;
                case EventType.Repaint: return false;
                case EventType.Layout: return false;
                case EventType.Ignore: return false;
                case EventType.Used: return false;
                case EventType.ValidateCommand: return false;
                case EventType.ExecuteCommand: return false;
            }

            throw new UnaccountedBranchException("item", item);
        }
    }
}