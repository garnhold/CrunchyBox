using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyBun;

namespace CrunchySandwich
{
    public abstract class PreditoidComparer
    {
        public abstract bool Compare(Invoketoid invoketoid, GameObject target);
    }

    public class PreditoidComparer<T> : PreditoidComparer
    {
        [SerializeFieldEX]private EqualityRelation relation;
        [SerializeFieldEX]private T value;

        public override bool Compare(Invoketoid invoketoid, GameObject target)
        {
            if (relation.IsSatisifed(invoketoid.Invoke<T>(target), value))
                return true;

            return false;
        }
    }
}