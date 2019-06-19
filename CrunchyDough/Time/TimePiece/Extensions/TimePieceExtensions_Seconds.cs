using System;
using System.Reflection;

namespace CrunchyDough
{
    static public class TimePieceExtensions_Seconds
    {
        static public float ResetGetSeconds(this TimePiece item)
        {
            return item.ResetGetTime().GetSeconds();
        }

        static public float RestartGetSeconds(this TimePiece item)
        {
            return item.RestartGetTime().GetSeconds();
        }

        static public void AddElapsedTimeInSeconds(this TimePiece item, float seconds)
        {
            item.AddElapsedTime(Duration.Seconds(seconds));
        }

        static public void SetElapsedTimeInSeconds(this TimePiece item, float seconds)
        {
            item.SetElapsedTime(Duration.Seconds(seconds));
        }

        static public float GetElapsedTimeInSeconds(this TimePiece item)
        {
            return item.GetElapsedTime().GetSeconds();
        }
    }
}