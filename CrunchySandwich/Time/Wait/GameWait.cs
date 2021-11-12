using System;
using System.Threading.Tasks;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class GameWait
    {
        static public async Task ForFrame()
        {
            await Wait.ForFrame();
        }

        static public async Task Until(TryProcess process, bool allow_instant)
        {
            await Wait.ForEvent(process, allow_instant);
        }
        static public async Task<T> Until<T>(TryOperation<T> operation, bool allow_instant)
        {
            return await Wait.ForEvent<T>(operation, allow_instant);
        }

        static public async Task ForDuration(Duration duration, TimeType time_type)
        {
            if (duration > Duration.Nothing)
            {
                GameTimer timer = new GameTimer(duration.GetSeconds(), time_type);

                timer.Start();
                await GameWait.Until(() => timer.IsTimeOver(), false);
            }
        }
        static public async Task ForMilliseconds(long milliseconds, TimeType time_type)
        {
            await GameWait.ForDuration(Duration.Milliseconds(milliseconds), time_type);
        }
        static public async Task ForSeconds(float seconds, TimeType time_type)
        {
            await GameWait.ForDuration(Duration.Seconds(seconds), time_type);
        }
    }
}