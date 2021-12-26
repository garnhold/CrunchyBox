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

    public class TyonAsset : ScriptableObject
    {
        [SerializeField] private string tyon;

        public object Instance()
        {
            return UnityTyonSettings.INSTANCE.Deserialize(GetTyon(), TyonHydrationMode.Permissive);
        }
        public T Instance<T>()
        {
            return Instance().ConvertEX<T>();
        }

        public void SetTyon(string t)
        {
            tyon = t;
        }

        public string GetTyon()
        {
            return tyon;
        }
    }
}