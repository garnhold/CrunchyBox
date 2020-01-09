using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class ArrayExtensions_Index
    {
        private const int INDEX_MARGIN = 0;
        private const int TERMINAL_INDEX_MARGIN = 1;

        static private bool IsIndexValid<T>(this T[] item, int index, int margin)
        {
            if (item != null)
            {
                int low = 0 - margin;
                int high = item.Length + margin;

                if (index >= low && index < high)
                    return true;
            }

            return false;
        }
        static public bool IsIndexValid<T>(this T[] item, int index)
        {
            return item.IsIndexValid(index, INDEX_MARGIN);
        }
        static public bool IsTerminalIndexValid<T>(this T[] item, int index)
        {
            return item.IsIndexValid(index, TERMINAL_INDEX_MARGIN);
        }

        static private bool PullIndexValid<T>(this T[] item, ref int index, int margin)
        {
            if (item != null)
            {
                int low = 0 - margin;
                int high = item.Length + margin;

                if (index < low)
                    index = low;

                if (index >= high)
                    index = high - 1;

                return item.IsIndexValid(index, margin);
            }

            return false;
        }
        static public bool PullIndexValid<T>(this T[] item, ref int index)
        {
            return item.PullIndexValid(ref index, INDEX_MARGIN);
        }
        static public bool PullTerminalIndexValid<T>(this T[] item, ref int index)
        {
            return item.PullIndexValid(ref index, TERMINAL_INDEX_MARGIN);
        }

        static private bool PullIndexUp<T>(this T[] item, ref int index, int margin)
        {
            if (item != null)
            {
                int low = 0 - margin;

                if (index < low)
                    index = low;

                return item.IsIndexValid(index, margin);
            }

            return false;
        }
        static public bool PullIndexUp<T>(this T[] item, ref int index)
        {
            return item.PullIndexUp(ref index, INDEX_MARGIN);
        }
        static public bool PullTerminalIndexUp<T>(this T[] item, ref int index)
        {
            return item.PullIndexUp(ref index, TERMINAL_INDEX_MARGIN);
        }

        static private bool PullIndexDown<T>(this T[] item, ref int index, int margin)
        {
            if (item != null)
            {
                int high = item.Length + margin;

                if (index >= high)
                    index = high - 1;

                return item.IsIndexValid(index, margin);
            }

            return false;
        }
        static public bool PullIndexDown<T>(this T[] item, ref int index)
        {
            return item.PullIndexDown(ref index, INDEX_MARGIN);
        }
        static public bool PullTerminalIndexDown<T>(this T[] item, ref int index)
        {
            return item.PullIndexDown(ref index, TERMINAL_INDEX_MARGIN);
        }

        static public bool IsSubSectionValid<T>(this T[] item, int start, int end)
        {
            if (item.IsIndexValid(start) && item.IsTerminalIndexValid(end))
            {
                if (end > start)
                    return true;
            }

            return false;
        }

        static public bool IsSubValid<T>(this T[] item, int start, int length)
        {
            return item.IsSubSectionValid(start, start + length);
        }

        static public bool PullSubSectionValid<T>(this T[] item, ref int start, ref int end)
        {
            if (item.PullIndexUp(ref start) && item.PullTerminalIndexDown(ref end))
                return item.IsSubSectionValid(start, end);

            return false;
        }

        static public int GetFinalIndex<T>(this T[] item)
        {
            return item.GetLength() - 1;
        }
    }
}