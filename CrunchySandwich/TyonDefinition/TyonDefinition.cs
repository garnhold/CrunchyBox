using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Salt;
    using Noodle;
    using Recipe;

    [Serializable]
    public class TyonDefinition
    {
        [SerializeField] private TextAsset text;

        static public implicit operator TextAsset(TyonDefinition item)
        {
            return item.text;
        }
        static public implicit operator TyonDefinition(TextAsset item)
        {
            return new TyonDefinition(item);
        }

        public TyonDefinition(TextAsset t)
        {
            text = t;
        }

        public TyonDefinition() : this(null) { }

        public object Instance()
        {
            return UnityTyonSettings.INSTANCE.Deserialize(GetTyon(), TyonHydrationMode.Permissive);
        }
        public T Instance<T>()
        {
            return Instance().ConvertEX<T>();
        }

        public string GetTyon()
        {
            return text.IfNotNull(t => t.text);
        }
    }
}