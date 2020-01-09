using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

using UnityEngine;

namespace Crunchy.Sandwich
{
    public struct Frame
    {
        private readonly int frame;

        static public Frame GetCurrentFrame()
        {
            return new Frame(Time.frameCount);
        }

        private Frame(int f)
        {
            frame = f;
        }

        public bool IsCurrent()
        {
            if (GetNumberFramesPast() <= 0)
                return true;

            return false;
        }

        public bool IsRecent()
        {
            if (GetNumberFramesPast() <= 3)
                return true;

            return false;
        }

        public int GetNumberFramesPast()
        {
            return Time.frameCount - frame;
        }
    }
}