using System;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
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
        private string id;
        private Operation<T, P> operation;

        private Dictionary<P, T> data;

        public CompileTimeCache(string i, Husker<T> h, Operation<T, P> o) : base(h)
        {
            id = i;
            operation = o;

            data = new Dictionary<P, T>();
        }

        public override void Clear()
        {
            data.Clear();
        }

        public T Fetch(P parameter)
        {
            if (IsActive())
            {
                T item;

                if (data.TryGetValue(parameter, out item) == false)
                {
                    item = FetchInternal(GetFilename(parameter), () => operation(parameter));

                    data.Add(parameter, item);
                }

                return item;
            }

            return operation(parameter);
        }

        public string GetFilename(P parameter)
        {
            return Filename.MakeObfuscatedDataFilename("Cache", id + parameter.GetIdentityEX(), "data");
        }
    }

    public class CompileTimeCache<T> : CompileTimeCacheBase<T>
    {
        private string id;
        private Operation<T> operation;

        private T item;
        private bool has_item;

        public CompileTimeCache(string i, Husker<T> h, Operation<T> o) : base(h)
        {
            id = i;
            operation = o;
        }

        public override void Clear()
        {
            has_item = false;
        }

        public T Fetch()
        {
            if (IsActive())
            {
                if (has_item == false)
                    item = FetchInternal(GetFilename(), operation);

                return item;
            }

            return operation();
        }

        public string GetFilename()
        {
            return Filename.MakeObfuscatedDataFilename("Cache", id, "data");
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
                    long operation_time = TimeSource_Stopwatch.INSTANCE.TimeProcessInMilliseconds(delegate() {
                        data = operation();
                    });

                    if (operation_time > 10)
                        Write(filename, data);
                }

                return data;
            }

            return operation();
        }

        public CompileTimeCacheBase(Husker<T> h)
        {
            husker = h;
        }
    }
}