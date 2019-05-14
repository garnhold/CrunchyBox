using System;

using CrunchyDough;

namespace CrunchyLunch
{
    public class Terminal_Console : Terminal
    {
        static private Terminal_Console INSTANCE;
        static public Terminal_Console GetInstance()
        {
            if (INSTANCE == null)
                INSTANCE = new Terminal_Console();

            return INSTANCE;
        }

        protected override void RasterInternal(int x, int y, string text)
        {
            if (x >= 0 && y >= 0)
            {
                if (x < Console.BufferWidth && y < Console.BufferHeight)
                {
                    int left = Console.CursorLeft;
                    int top = Console.CursorTop;

                    Console.CursorLeft = x;
                    Console.CursorTop = y;
                        Console.Write(text);
                    Console.CursorLeft = left;
                    Console.CursorTop = top;
                }
            }
        }

        protected override void ClearInternal()
        {
            Console.Clear();
        }

        private Terminal_Console() : base(Console.BufferWidth)
        {
            SetCursor(Console.CursorLeft, Console.CursorTop);
        }
    }
}