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

        static public async Task ForUpdate()
        {
            await Wait.ForCondition(() => true, false);
        }

        static public Task<T> ForCondition<T>(TryOperation<T> operation, bool allow_instant = true)
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
        static public Task ForCondition(TryProcess process, bool allow_instant = true)
        {
            return Wait.ForCondition<bool>((out bool output) => {
                output = true;
                return process();
            }, allow_instant);
        }
    }
}