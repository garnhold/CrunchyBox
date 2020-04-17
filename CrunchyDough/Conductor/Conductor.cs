using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class Conductor : TemporalEvent, IDisposable
    {
        private bool is_running;
        private ConductorScore score;

        public Conductor(ConductorScore s)
        {
            is_running = false;
            score = s;
        }

        public Conductor(IEnumerable<ConductorOrder> e) : this(new ConductorScore(e)) { }
        public Conductor(params ConductorOrder[] e) : this((IEnumerable<ConductorOrder>)e) { }
        public Conductor(Operation<IEnumerable<ConductorOrder>> o) : this(o()) { }

        public Conductor() : this((ConductorScore)null) { }

        public void Dispose()
        {
            score.IfNotNull(s => s.Dispose());
        }

        public void SetScore(ConductorScore s)
        {
            score = s;
        }

        public bool Start()
        {
            if (is_running == false)
            {
                score.IfNotNull(s => s.StartFulfill());

                is_running = true;
                return true;
            }

            return false;
        }

        public bool Pause()
        {
            if (is_running)
            {
                score.IfNotNull(s => s.PauseFulfill());

                is_running = false;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            score.IfNotNull(s => s.Reset());
        }

        public void Prime()
        {
            score.IfNotNull(s => s.Prime());
        }

        public bool UpdateFulfill()
        {
            if (is_running && score != null)
            {
                while (score.StepFulfill());
                return score.IsDone();
            }

            return true;
        }

        public bool IsRunning()
        {
            return is_running;
        }

        public bool IsTimeOver()
        {
            return score.IsDone();
        }
    }
}
