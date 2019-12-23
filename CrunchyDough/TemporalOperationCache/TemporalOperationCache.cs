using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class TemporalOperationCache<T, P1, P2, P3, P4, P5> : TemporalOperationCache<T, Tuple<P1, P2, P3, P4, P5>>
    {
        public TemporalOperationCache(string i, Operation<T, P1, P2, P3, P4, P5> o, TemporalEvent e) : base(i, p => o(p.item1, p.item2, p.item3, p.item4, p.item5), e) { }

        public TemporalOperationCache(string i, Operation<T, P1, P2, P3, P4, P5> o, TemporalDuration d) : this(i, o, new TemporalEvent_Duration(d)) { }

        public TemporalOperationCache(string i, Operation<T, P1, P2, P3, P4, P5> o, long d, TimeSource t) : this(i, o, new Timer(d, t)) { }
        public TemporalOperationCache(string i, Operation<T, P1, P2, P3, P4, P5> o, long d) : this(i, o, d, TimeSource_System.INSTANCE) { }

        public TemporalOperationCache(string i, Operation<T, P1, P2, P3, P4, P5> o, Duration d, TimeSource t) : this(i, o, new Timer(d, t)) { }
        public TemporalOperationCache(string i, Operation<T, P1, P2, P3, P4, P5> o, Duration d) : this(i, o, d, TimeSource_System.INSTANCE) { }

        public T Fetch(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5)
        {
            return base.Fetch(Tuple.New(p1, p2, p3, p4, p5));
        }
    }

    public class TemporalOperationCache<T, P1, P2, P3, P4> : TemporalOperationCache<T, Tuple<P1, P2, P3, P4>>
    {
        public TemporalOperationCache(string i, Operation<T, P1, P2, P3, P4> o, TemporalEvent e) : base(i, p => o(p.item1, p.item2, p.item3, p.item4), e) { }

        public TemporalOperationCache(string i, Operation<T, P1, P2, P3, P4> o, TemporalDuration d) : this(i, o, new TemporalEvent_Duration(d)) { }

        public TemporalOperationCache(string i, Operation<T, P1, P2, P3, P4> o, long d, TimeSource t) : this(i, o, new Timer(d, t)) { }
        public TemporalOperationCache(string i, Operation<T, P1, P2, P3, P4> o, long d) : this(i, o, d, TimeSource_System.INSTANCE) { }

        public TemporalOperationCache(string i, Operation<T, P1, P2, P3, P4> o, Duration d, TimeSource t) : this(i, o, new Timer(d, t)) { }
        public TemporalOperationCache(string i, Operation<T, P1, P2, P3, P4> o, Duration d) : this(i, o, d, TimeSource_System.INSTANCE) { }

        public T Fetch(P1 p1, P2 p2, P3 p3, P4 p4)
        {
            return base.Fetch(Tuple.New(p1, p2, p3, p4));
        }
    }

    public class TemporalOperationCache<T, P1, P2, P3> : TemporalOperationCache<T, Tuple<P1, P2, P3>>
    {
        public TemporalOperationCache(string i, Operation<T, P1, P2, P3> o, TemporalEvent e) : base(i, p => o(p.item1, p.item2, p.item3), e) { }

        public TemporalOperationCache(string i, Operation<T, P1, P2, P3> o, TemporalDuration d) : this(i, o, new TemporalEvent_Duration(d)) { }

        public TemporalOperationCache(string i, Operation<T, P1, P2, P3> o, long d, TimeSource t) : this(i, o, new Timer(d, t)) { }
        public TemporalOperationCache(string i, Operation<T, P1, P2, P3> o, long d) : this(i, o, d, TimeSource_System.INSTANCE) { }

        public TemporalOperationCache(string i, Operation<T, P1, P2, P3> o, Duration d, TimeSource t) : this(i, o, new Timer(d, t)) { }
        public TemporalOperationCache(string i, Operation<T, P1, P2, P3> o, Duration d) : this(i, o, d, TimeSource_System.INSTANCE) { }

        public T Fetch(P1 p1, P2 p2, P3 p3)
        {
            return base.Fetch(Tuple.New(p1, p2, p3));
        }
    }

    public class TemporalOperationCache<T, P1, P2> : TemporalOperationCache<T, Tuple<P1, P2>>
    {
        public TemporalOperationCache(string i, Operation<T, P1, P2> o, TemporalEvent e) : base(i, p => o(p.item1, p.item2), e) { }

        public TemporalOperationCache(string i, Operation<T, P1, P2> o, TemporalDuration d) : this(i, o, new TemporalEvent_Duration(d)) { }

        public TemporalOperationCache(string i, Operation<T, P1, P2> o, long d, TimeSource t) : this(i, o, new Timer(d, t)) { }
        public TemporalOperationCache(string i, Operation<T, P1, P2> o, long d) : this(i, o, d, TimeSource_System.INSTANCE) { }

        public TemporalOperationCache(string i, Operation<T, P1, P2> o, Duration d, TimeSource t) : this(i, o, new Timer(d, t)) { }
        public TemporalOperationCache(string i, Operation<T, P1, P2> o, Duration d) : this(i, o, d, TimeSource_System.INSTANCE) { }

        public T Fetch(P1 p1, P2 p2)
        {
            return base.Fetch(Tuple.New(p1, p2));
        }
    }

    public class TemporalOperationCache<T, P> : TemporalOperationCache
    {
        private OperationCache<T, P> cache;

        public TemporalOperationCache(OperationCache<T, P> c, TemporalEvent e) : base(c, e)
        {
            cache = c;
        }

        public TemporalOperationCache(string i, Operation<T, P> o, TemporalEvent e) : this(new OperationCache<T, P>(i, o), e) { }
        public TemporalOperationCache(string i, Operation<T, P> o, TemporalDuration d) : this(i, o, new TemporalEvent_Duration(d)) { }

        public TemporalOperationCache(string i, Operation<T, P> o, long d, TimeSource t) : this(i, o, new Timer(d, t)) { }
        public TemporalOperationCache(string i, Operation<T, P> o, long d) : this(i, o, d, TimeSource_System.INSTANCE) { }

        public TemporalOperationCache(string i, Operation<T, P> o, Duration d, TimeSource t) : this(i, o, new Timer(d, t)) { }
        public TemporalOperationCache(string i, Operation<T, P> o, Duration d) : this(i, o, d, TimeSource_System.INSTANCE) { }

        public override void Clear()
        {
            cache.Clear();
        }

        public T Fetch(P parameter)
        {
            if (Repeat())
                cache.Clear();

            return cache.Fetch(parameter);
        }
    }

    public class TemporalOperationCache<T> : TemporalOperationCache
    {
        private OperationCache<T> cache;

        public TemporalOperationCache(OperationCache<T> c, TemporalEvent e) : base(c, e)
        {
            cache = c;
        }

        public TemporalOperationCache(string i, Operation<T> o, TemporalEvent e) : this(new OperationCache<T>(i, o), e) { }

        public TemporalOperationCache(string i, Operation<T> o, TemporalDuration d) : this(i, o, new TemporalEvent_Duration(d)) { }

        public TemporalOperationCache(string i, Operation<T> o, long d, TimeSource t) : this(i, o, new Timer(d, t)) { }
        public TemporalOperationCache(string i, Operation<T> o, long d) : this(i, o, d, TimeSource_System.INSTANCE) { }

        public TemporalOperationCache(string i, Operation<T> o, Duration d, TimeSource t) : this(i, o, new Timer(d, t)) { }
        public TemporalOperationCache(string i, Operation<T> o, Duration d) : this(i, o, d, TimeSource_System.INSTANCE) { }

        public override void Clear()
        {
            cache.Clear();
        }

        public T Fetch()
        {
            if (Repeat())
                cache.Clear();

            return cache.Fetch();
        }
    }

    public abstract class TemporalOperationCache : Cache
    {
        private OperationCache cache;
        private TemporalEvent temporal_event;

        protected bool Repeat()
        {
            return temporal_event.Repeat();
        }

        public TemporalOperationCache(OperationCache c, TemporalEvent e) : base(c.GetId())
        {
            cache = c;
            temporal_event = e;
        }
    }
}