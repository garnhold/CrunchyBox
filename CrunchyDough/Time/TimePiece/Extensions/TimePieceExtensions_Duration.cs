using System;
using System.Reflection;

namespace CrunchyDough
{
    static public class TimePieceExtensions_Duration
    {
        static public Duration ResetGetTime(this TimePiece item)
        {
            return Duration.Milliseconds(item.ResetGetMilliseconds());
        }

        static public Duration RestartGetTime(this TimePiece item)
        {
            return Duration.Milliseconds(item.RestartGetMilliseconds());
        }

        static public void AddElapsedTime(this TimePiece item, Duration duration)
        {
            item.AddElapsedTimeInMilliseconds(duration.GetWholeMilliseconds());
        }

        static public void SetElapsedTime(this TimePiece item, Duration duration)
        {
            item.SetElapsedTimeInMilliseconds(duration.GetWholeMilliseconds());
        }

        static public Duration GetElapsedTime(this TimePiece item)
        {
            return Duration.Milliseconds(item.GetElapsedTimeInMilliseconds());
        }
    }
}