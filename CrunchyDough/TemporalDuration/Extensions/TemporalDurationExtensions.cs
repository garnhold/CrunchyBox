using System;

namespace CrunchyDough
{
    static public class TemporalDurationExtensions
    {
        static public T StartExpireAndGet<T>(this T item) where T : TemporalDuration
        {
            item.Start();
            item.Expire();

            return item;
        }

        static public void Restart(this TemporalDuration item)
        {
            item.StopClear();
            item.Start();
        }

        static public void StopClear(this TemporalDuration item)
        {
            item.Pause();
            item.Reset();
        }

        static public bool Repeat(this TemporalDuration item)
        {
            if (item.IsTimeOver() || item.IsStopped())
            {
                item.Restart();
                return true;
            }

            return false;
        }

        static public bool RepeatIfRunning(this TemporalDuration item)
        {
            if (item.IsRunning())
                return item.Repeat();

            return false;
        }

        static public bool RepeatIfStopped(this TemporalDuration item)
        {
            if (item.IsStopped())
                return item.Repeat();

            return false;
        }

        static public void Expire(this TemporalDuration item)
        {
            if (item.IsTimeUnder())
                item.SetElapsedTimeInMilliseconds(item.GetDurationInMilliseconds() + 1);
        }
    }
}