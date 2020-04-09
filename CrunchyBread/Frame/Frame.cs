using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public struct Frame
    {
        private int frame_number;

        static private int CURRENT_FRAME_NUMBER;
        static public Frame GetCurrentFrame()
        {
            return new Frame(CURRENT_FRAME_NUMBER);
        }

        static public void AdvanceFrame()
        {
            CURRENT_FRAME_NUMBER++;
        }

        public Frame(int f)
        {
            frame_number = f;
        }

        public bool IsCurrent()
        {
            if (GetNumberFramesPast() <= 0)
                return true;

            return false;
        }
        public bool IsNotCurrent()
        {
            if (IsCurrent() == false)
                return true;

            return false;
        }

        public bool IsRecent()
        {
            if (GetNumberFramesPast() <= 3)
                return true;

            return false;
        }
        public bool IsNotRecent()
        {
            if (IsRecent() == false)
                return true;

            return false;
        }

        public int GetNumberFramesPast()
        {
            return CURRENT_FRAME_NUMBER - frame_number;
        }
    }
}