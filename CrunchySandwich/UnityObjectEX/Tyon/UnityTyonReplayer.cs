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
    
    public class UnityTyonReplayer
    {
        private Type type;
        private string data;

        private TyonContext context;

        public UnityTyonReplayer(object obj)
        {
            type = obj.GetTypeEX();
            context = UnityTyonSettings.INSTANCE.CreateContext();

            data = context.SerializeValue(type, obj);
        }

        public object CreateInstance()
        {
            return context.DeserializeValue(type, data, TyonHydrationMode.Permissive);
        }

        public string GetData()
        {
            return data;
        }
    }
}