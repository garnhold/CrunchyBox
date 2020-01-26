using System;

namespace Crunchy.Dough
{    
    static public class SimulatableProcess
    {
        static public PeriodicProcess Create(long milliseconds, Process<float> process)
        {
            Stopwatch stopwatch = new Stopwatch();

            return new PeriodicProcess_Timer(milliseconds, delegate() {
                process(stopwatch.GetElapsedTimeInSeconds());
                stopwatch.Restart();
            });
        }

        static public PeriodicProcess CreateAndStart(long milliseconds, Process<float> process)
        {
            PeriodicProcess periodic_process = Create(milliseconds, process);

            periodic_process.Start();
            return periodic_process;
        }
    }
}