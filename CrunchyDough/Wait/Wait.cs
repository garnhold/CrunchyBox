using System;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class Wait
    {
        static public async Task ForDuration(Duration duration)
        {
            await Task.Delay((int)duration.GetWholeMilliseconds());
        }
        static public async Task ForMilliseconds(long milliseconds)
        {
            await Wait.ForDuration(Duration.Milliseconds(milliseconds));
        }
        static public async Task ForSeconds(float seconds)
        {
            await Wait.ForDuration(Duration.Seconds(seconds));
        }

        static public Task<T> ForEvent<T>(TryOperation<T> operation, bool allow_instant)
        {
            T output;
            TaskCompletionSource<T> source = new TaskCompletionSource<T>();

            if (allow_instant && operation(out output))
                source.SetResult(output);
            else
            {
                WaitEventManager.GetInstance().RegisterWaitEvent(() => {
                    if (operation(out output))
                    {
                        source.SetResult(output);
                        return true;
                    }

                    return false;
                });
            }

            return source.Task;
        }
        static public Task ForEvent(TryProcess process, bool allow_instant)
        {
            return Wait.ForEvent<bool>((out bool output) => {
                output = true;
                return process();
            }, allow_instant);
        }
    }
}