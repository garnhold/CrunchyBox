using System;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    public class CompileTimeCache<T, P1, P2, P3, P4> : CompileTimeCache<T, IdentifiableTuple<P1, P2, P3, P4>>
        where P1 : Identifiable
        where P2 : Identifiable
        where P3 : Identifiable
        where P4 : Identifiable
    {
        public CompileTimeCache(string i, Husker<T> h, Operation<T, P1, P2, P3, P4> o) : base(i, h, p => o(p.item1, p.item2, p.item3, p.item4)) { }

        public T Fetch(P1 p1, P2 p2, P3 p3, P4 p4)
        {
            return base.Fetch(IdentifiableTuple.New(p1, p2, p3, p4));
        }
    }

    public class CompileTimeCache<T, P1, P2, P3> : CompileTimeCache<T, IdentifiableTuple<P1, P2, P3>>
        where P1 : Identifiable
        where P2 : Identifiable
        where P3 : Identifiable
    {
        public CompileTimeCache(string i, Husker<T> h, Operation<T, P1, P2, P3> o) : base(i, h, p => o(p.item1, p.item2, p.item3)) { }

        public T Fetch(P1 p1, P2 p2, P3 p3)
        {
            return base.Fetch(IdentifiableTuple.New(p1, p2, p3));
        }
    }

    public class CompileTimeCache<T, P1, P2> : CompileTimeCache<T, IdentifiableTuple<P1, P2>>
        where P1 : Identifiable
        where P2 : Identifiable
    {
        public CompileTimeCache(string i, Husker<T> h, Operation<T, P1, P2> o) : base(i, h, p => o(p.item1, p.item2)) { }

        public T Fetch(P1 p1, P2 p2)
        {
            return base.Fetch(IdentifiableTuple.New(p1, p2));
        }
    }

    public class CompileTimeCache<T, P> : CompileTimeCacheBase<T> where P : Identifiable
    {
        private Operation<T, P> operation;

        private Dictionary<P, T> data;

        public CompileTimeCache(string i, Husker<T> h, Operation<T, P> o) : base(i, h)
        {
            operation = o;

            data = new Dictionary<P, T>();
        }

        public override void Clear()
        {
            data.Clear();
        }

        public T Fetch(P parameter)
        {
            try
            {
                if (IsActive())
                {
                    T item;

                    if (data.TryGetValue(parameter, out item) == false)
                    {
                        item = data.AddAndGet(
                            parameter,
                            FetchInternal(GetFilename(parameter), () => operation(parameter))
                        );
                    }

                    return item;
                }

                return operation(parameter);
            }
            catch (Exception exception)
            {
                throw new Exception("An exception occured during a " + GetId().ToDebugString() + " cache calculation for " + parameter.ToDebugString(), exception);
            }
        }

        public string GetFilename(P parameter)
        {
            return Filename.MakeObfuscatedDataFilename("Cache", GetId() + parameter.GetIdentityEX(), "data");
        }
    }

    public class CompileTimeCache<T> : CompileTimeCacheBase<T>
    {
        private Operation<T> operation;

        private T item;
        private bool has_item;

        public CompileTimeCache(string i, Husker<T> h, Operation<T> o) : base(i, h)
        {
            operation = o;
        }

        public override void Clear()
        {
            has_item = false;
        }

        public T Fetch()
        {
            try
            {
                if (IsActive())
                {
                    if (has_item == false)
                    {
                        item = FetchInternal(GetFilename(), operation);
                        has_item = true;
                    }

                    return item;
                }

                return operation();
            }
            catch (Exception exception)
            {
                throw new Exception("An exception occured during a " + GetId().ToDebugString() + " cache calculation", exception);
            }
        }

        public string GetFilename()
        {
            return Filename.MakeObfuscatedDataFilename("Cache", GetId(), "data");
        }
    }

    public abstract class CompileTimeCacheBase<T> : Cache
    {
        private Husker<T> husker;

        static private readonly StreamSystem STREAM_SYSTEM = Files.GetStreamSystem();

        private AttemptResult Read(string filename, out T data)
        {
            return STREAM_SYSTEM.AttemptRead(filename, delegate(Stream stream, out T inner_data) {
                HuskReader reader = new HuskReader(stream);

                if(reader.VerifyVersionHeader())
                {
                    inner_data = husker.Hydrate(reader);
                    return true;
                }

                inner_data = default(T);
                return false;
            }, out data, 0);
        }

        private void Write(string filename, T data)
        {
            STREAM_SYSTEM.Write(filename, delegate(Stream stream) {
                HuskWriter writer = new HuskWriter(stream);

                writer.WriteVersionHeader();
                husker.Dehydrate(writer, data);
            }, 0);
        }

        protected T FetchInternal(string filename, Operation<T> operation)
        {
            if (ShouldUseDisk())
            {
                T data;

                if (Read(filename, out data).IsUndesired())
                {
                    long operation_time = TimeSource_System.INSTANCE.TimeProcessInMilliseconds(delegate() {
                        data = operation();
                    });
                    
                    if (operation_time > 10)
                        Write(filename, data);
                }

                return data;
            }

            return operation();
        }

        public CompileTimeCacheBase(string i, Husker<T> h) : base(i)
        {
            husker = h;
        }
    }
}