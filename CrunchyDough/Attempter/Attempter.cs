using System;
using System.Threading;

namespace CrunchyDough
{
    static public class Attempter
    {
        static public AttemptResult Attempt(AttemptProcess process, long milliseconds)
        {
            if (milliseconds > 0)
            {
                Timer timer = new Timer(milliseconds).StartAndGet();

                do
                {
                    AttemptResult result = process();
                    if (result.IsComplete())
                        return result;

                    if (timer.GetTimeLeftInMilliseconds() > 50)
                        Thread.Sleep(1);
                }
                while (timer.IsTimeUnder());

                return AttemptResult.Tried;
            }

            return process();
        }
        static public AttemptResult Attempt<T>(AttemptOperation<T> operation, out T output, long milliseconds)
        {
            T temp = default(T);

            AttemptResult result = Attempt(delegate() {
                return operation(out temp);
            }, milliseconds);

            output = temp;
            return result;
        }

        static public AttemptResult AttemptFailOnException(AttemptProcess process, long milliseconds)
        {
            return Attempt(delegate() {
                try
                {
                    return process();
                }
                catch (Exception)
                {
                    return AttemptResult.Failed;
                }
            }, milliseconds);
        }
        static public AttemptResult AttemptFailOnException<T>(AttemptOperation<T> operation, out T output, long milliseconds)
        {
            T temp = default(T);    

            AttemptResult result = AttemptFailOnException(delegate() {
                return operation(out temp);
            }, milliseconds);

            output = temp;
            return result;
        }
    }
}