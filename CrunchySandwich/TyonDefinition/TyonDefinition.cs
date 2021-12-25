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
    
    public class TyonDefinition
    {
        [SerializeField] private TextAsset text;

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