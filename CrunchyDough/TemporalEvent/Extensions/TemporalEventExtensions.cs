using System;

namespace Crunchy.Dough
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

        static public bool TriggerStopClear(this TemporalEvent item)
        {
            if (item.IsTimeOver())
            {
                item.StopClear();

                return true;
            }

            return false;
        }
        static public bool Fire(this TemporalEvent item)
        {
            item.Start();

            return item.TriggerStopClear();
        }

        static public bool TriggerRestart(this TemporalEvent item)
        {
            if (item.IsTimeOver())
            {
                item.Restart();

                return true;
            }

            return false;
        }
        static public bool Repeat(this TemporalEvent item)
        {
            item.Start();

            return item.TriggerRestart();
        }
    }
}