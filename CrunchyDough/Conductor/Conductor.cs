using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class Conductor : IDisposable
    {
        private bool is_running;
        private IEnumerator<ConductorOrder> iter;

        public Conductor(IEnumerator<ConductorOrder> i)
        {
            is_running = true;
            iter = i;

            iter.MoveNext();
        }

        public Conductor(IEnumerable<ConductorOrder> e) : this(e.GetEnumerator()) { }
        public Conductor(params ConductorOrder[] e) : this((IEnumerable<ConductorOrder>)e) { }

        public Conductor(Operation<IEnumerator<ConductorOrder>> o) : this(o()) { }
        public Conductor(Operation<IEnumerable<ConductorOrder>> o) : this(o()) { }

        public void Dispose()
        {
            iter.Dispose();
        }

        public void Reset()
        {
            iter.Reset();
        }

        public bool Update()
        {
            if (is_running)
            {
                if (iter.Current.Fulfill())
                {
                    if (iter.MoveNext() == false)
                        is_running = false;
                }
            }

            return is_running;
        }
    }
}
