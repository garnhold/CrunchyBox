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

        static public bool TriggerStopClear(this TemporalDuration item)
        {
            if (item.IsTimeOver())
            {
                item.StopClear();

                return true;
            }

            return false;
        }
        static public bool Fire(this TemporalDuration item)
        {
            item.Start();

            return item.TriggerStopClear();
        }

        static public bool TriggerRestart(this TemporalDuration item)
        {
            if (item.IsTimeOver())
            {
                item.Restart();

                return true;
            }

            return false;
        }
        static public bool Repeat(this TemporalDuration item)
        {
            item.Start();

            return item.TriggerRestart();
        }

        static public void Expire(this TemporalDuration item)
        {
            if (item.IsTimeUnder())
                item.SetElapsedTimeInMilliseconds(item.GetDurationInMilliseconds() + 1);
        }
    }
}