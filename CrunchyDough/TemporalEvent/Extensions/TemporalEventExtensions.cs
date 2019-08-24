using System;

namespace CrunchyDough
{
    static public class TemporalEventExtensions
    {
        static public T StartPrimeAndGet<T>(this T item) where T : TemporalEvent
        {
            item.Start();
            item.Prime();

            return item;
        }

        static public void Restart(this TemporalEvent item)
        {
            item.StopClear();
            item.Start();
        }

        static public void StopClear(this TemporalEvent item)
        {
            item.Pause();
            item.Reset();
        }

        static public bool Repeat(this TemporalEvent item)
        {
            if (item.IsTimeOver() || item.IsStopped())
            {
                item.Restart();
                return true;
            }

            return false;
        }

        static public bool RepeatIfRunning(this TemporalEvent item)
        {
            if (item.IsRunning())
                return item.Repeat();

            return false;
        }

        static public bool RepeatIfStopped(this TemporalEvent item)
        {
            if (item.IsStopped())
                return item.Repeat();

            return false;
        }
    }
}