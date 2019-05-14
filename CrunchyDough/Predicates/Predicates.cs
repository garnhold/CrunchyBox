using System;

namespace CrunchyDough
{
    static public class Predicates<T>
    {
        static public readonly Predicate<T> TRUE = p => true;
        static public readonly Predicate<T> FALSE = p => false;

        static public readonly Predicate<T> EVERYTHING = TRUE;
        static public readonly Predicate<T> NOTHING = FALSE;

        static public Predicate<T> AndIs<J>(Predicate<J> predicate)
        {
            return delegate(T to_check) {
                J cast;

                if (to_check.Convert<J>(out cast))
                    return predicate.DoesDescribe(cast);

                return false;
            };
        }
    }
}