using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class Conductor : IDisposable
    {
        private bool is_running;
        private bool has_started;

        private IEnumerator<ConductorOrder> iter;

        public Conductor(IEnumerator<ConductorOrder> i)
        {
            is_running = true;
            has_started = false;

            iter = i;
        }

        public Conductor(IEnumerable<ConductorOrder> e) : this(e.GetEnumerator()) { }
        public Conductor(params ConductorOrder[] e) : this((IEnumerable<ConductorOrder>)e) { }

        public Conductor(Operation<IEnumerator<ConductorOrder>> o) : this(o()) { }
        public Conductor(Operation<IEnumerable<ConductorOrder>> o) : this(o()) { }

        public void Dispose()
        {
            iter.Dispose();
        }

        public bool Update()
        {
            if (is_running)
            {
                if (has_started == false || iter.Current.Fulfill())
                {
                    if (iter.MoveNext())
                    {
                        iter.Current.Start();

                        has_started = true;
                    }
                    else
                    {
                        is_running = false;
                    }
                }
            }

            return is_running;
        }

        public bool IsRunning()
        {
            return is_running;
        }
    }
}
