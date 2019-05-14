using System;
using System.Reflection;

namespace CrunchyDough
{
    static public class TimePieceExtensions_General
    {
        static public void Reset(this TimePiece item)
        {
            item.SetElapsedTimeInMilliseconds(0);
        }

        static public void Restart(this TimePiece item)
        {
            item.StopClear();
            item.Start();
        }

        static public void StopClear(this TimePiece item)
        {
            item.Pause();
            item.Reset();
        }

        static public bool IsStopped(this TimePiece item)
        {
            if (item.IsRunning() == false)
                return true;

            return false;
        }
    }
}