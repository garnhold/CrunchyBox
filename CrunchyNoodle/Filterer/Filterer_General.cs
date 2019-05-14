using System;
using System.Reflection;

using CrunchyDough;

namespace CrunchyNoodle
{
    public abstract class Filterer_General<T, P1, P2, P3, P4> : Filterer_General<T, IdentifiableTuple<P1, P2, P3, P4>>
        where P1 : Identifiable
        where P2 : Identifiable
        where P3 : Identifiable
        where P4 : Identifiable
    {
        public Filterer_General(P1 p1, P2 p2, P3 p3, P4 p4) : base(IdentifiableTuple.New(p1, p2, p3, p4)) { }

        public P1 GetId1()
        {
            return GetId().item1;
        }

        public P2 GetId2()
        {
            return GetId().item2;
        }

        public P3 GetId3()
        {
            return GetId().item3;
        }

        public P4 GetId4()
        {
            return GetId().item4;
        }
    }

    public abstract class Filterer_General<T, P1, P2, P3> : Filterer_General<T, IdentifiableTuple<P1, P2, P3>>
        where P1 : Identifiable
        where P2 : Identifiable
        where P3 : Identifiable
    {
        public Filterer_General(P1 p1, P2 p2, P3 p3) : base(IdentifiableTuple.New(p1, p2, p3)) { }

        public P1 GetId1()
        {
            return GetId().item1;
        }

        public P2 GetId2()
        {
            return GetId().item2;
        }

        public P3 GetId3()
        {
            return GetId().item3;
        }
    }

    public abstract class Filterer_General<T, P1, P2> : Filterer_General<T, IdentifiableTuple<P1, P2>>
        where P1 : Identifiable
        where P2 : Identifiable
    {
        public Filterer_General(P1 p1, P2 p2) : base(IdentifiableTuple.New(p1, p2)) { }

        public P1 GetId1()
        {
            return GetId().item1;
        }

        public P2 GetId2()
        {
            return GetId().item2;
        }
    }

    public abstract class Filterer_General<T, P> : Filterer<T> where P : Identifiable
    {
        private P id;

        protected override bool EqualsInternal(object obj)
        {
            Filterer_General<T, P> cast = obj as Filterer_General<T, P>;

            if (id.EqualsEX(cast.id))
                return true;

            return false;
        }

        protected override int GetHashCodeInternal()
        {
            return id.GetHashCodeEX();
        }

        protected override string GetIdentityInternal()
        {
            return id.GetIdentityEX();
        }

        public Filterer_General(P i)
        {
            id = i;
        }

        public P GetId()
        {
            return id;
        }
    }
}