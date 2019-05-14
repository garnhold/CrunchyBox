using System;

using CrunchyDough;

namespace CrunchyBun
{
    static public class SimulatableProcess
    {
        static public PeriodicProcess Create(long milliseconds, Process<float> process)
        {
            Timer timer = new Timer();

            return new PeriodicProcess_Timer(milliseconds, delegate() {
                process(timer.GetElapsedTimeInSeconds());
                timer.Restart();
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