using System;
using System.Collections;

using OpenTK.Input;

namespace Crunchy.Bread
{
    using Dough;
    using Bun;

    public class CursorLooper
    {
        private PeriodicProcess periodic_process;

        static private CursorLooper INSTANCE = new CursorLooper(16);
        static public void Enable()
        {
            INSTANCE.Start();
        }

        static public void Disable()
        {
            INSTANCE.StopClear();
        }

        private CursorLooper(long pm)
        {
            periodic_process = new PeriodicProcess_Timer(pm, delegate () {
                MouseState state = Mouse.GetCursorState();

                int left = 0;
                int right = OpenTK.DisplayDevice.Default.Width - 1;
                int bottom = 0;
                int top = OpenTK.DisplayDevice.Default.Height - 1;

                if (state.X >= right)
                    Mouse.SetPosition(left + 1, state.Y);
                else if (state.X <= left)
                    Mouse.SetPosition(right - 1, state.Y);
                else if (state.Y >= top)
                    Mouse.SetPosition(state.X, bottom + 1);
                else if (state.Y <= bottom)
                    Mouse.SetPosition(state.X, top - 1);
            });
        }

        public void Start()
        {
            periodic_process.Start();
        }

        public void StopClear()
        {
            periodic_process.StopClear();
        }
    }
}