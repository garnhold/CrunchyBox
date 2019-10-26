using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

using UnityEngine;

namespace CrunchySandwich
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

        public int GetNumberFramesPast()
        {
            return Time.frameCount - frame;
        }

        public bool IsRecent()
        {
            if (GetNumberFramesPast() <= 3)
                return true;

            return false;
        }
    }
}