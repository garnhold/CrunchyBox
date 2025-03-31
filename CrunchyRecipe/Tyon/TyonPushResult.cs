using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;

    public enum TyonPushResult
    {
        Done,
        Deferred
    }

    static public class TyonPushResultExtensions
    {
        static public TyonPushResult Absorb(this TyonPushResult item, TyonPushResult other)
        {
            if (item == TyonPushResult.Done && other == TyonPushResult.Done)
                return TyonPushResult.Done;

            return TyonPushResult.Deferred;
        }
    }
}
