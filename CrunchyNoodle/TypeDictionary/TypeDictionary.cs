using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    public class TypeDictionary<T> : EquivolenceDictionary<Type, T>
    {
        public TypeDictionary()
            : base(delegate(Type key, IDictionary<Type, T> dictionary) {
                return dictionary
                    .Narrow(p => key.CanBeTreatedAs(p.Key))
                    .FindLowestRated(p => key.GetTypeDistance(p.Key));
            })
        { }

        public TypeDictionary(IEnumerable<KeyValuePair<Type, T>> v) : this()
        {
            this.AddRange(v);
        }

        public TypeDictionary(params KeyValuePair<Type, T>[] v) : this((IEnumerable<KeyValuePair<Type, T>>)v) { }
    }
}