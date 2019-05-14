using System;
using System.Reflection;

namespace CrunchyDough
{
    static public class TimePieceExtensions_Milliseconds
    {
        static public long ResetGetMilliseconds(this TimePiece item)
        {
            long milliseconds = item.GetElapsedTimeInMilliseconds();

            item.Reset();
            return milliseconds;
        }

        static public long RestartGetMilliseconds(this TimePiece item)
        {
            long milliseconds = item.GetElapsedTimeInMilliseconds();

            item.Restart();
            return milliseconds;
        }
    }
}