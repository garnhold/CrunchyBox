using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class Conductor : TemporalEvent, IDisposable
    {
        private bool is_done;
        private bool is_running;
        private bool has_started;

        private IEnumerator<ConductorOrder> iter;

        public Conductor(IEnumerator<ConductorOrder> i)
        {
            is_done = false;
            is_running = false;
            has_started = false;

            iter = i;
        }

        public Conductor(IEnumerable<ConductorOrder> e) : this(e.GetEnumerator()) { }
        public Conductor(params ConductorOrder[] e) : this((IEnumerable<ConductorOrder>)e) { }

        public Conductor(Operation<IEnumerable<ConductorOrder>> o) : this(o()) { }

        public void Dispose()
        {
            iter.Dispose();
        }

        public bool Start()
        {
            if (is_running == false)
            {
                if (has_started && is_done == false)
                    iter.Current.StartFulfill();

                is_running = true;
                return true;
            }

            return false;
        }

        public bool Pause()
        {
            if (is_running)
            {
                if (has_started && is_done == false)
                    iter.Current.PauseFulfill();

                is_running = false;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            is_done = false;
            has_started = false;

            iter.Reset();
        }

        public void Prime()
        {
            is_done = true;
            has_started = true;
        }

        public bool UpdateFulfill()
        {
            while (is_running && is_done == false)
            {
                if (has_started == false || iter.Current.UpdateFulfill())
                {
                    if (iter.MoveNext())
                    {
                        iter.Current.InitializeFulfill();
                        iter.Current.StartFulfill();
                    }
                    else
                    {
                        is_done = true;
                    }

                    has_started = true;
                }
                else
                {
                    break;
                }
            }

            return is_done;
        }

        public bool IsRunning()
        {
            return is_running;
        }

        public bool IsTimeOver()
        {
            return is_done;
        }
    }
}
