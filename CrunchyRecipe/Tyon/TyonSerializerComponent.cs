using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
    public abstract class TyonSerializerComponent
    {
        private TyonSerializer serializer;

        public void SetSerializer(TyonSerializer s)
        {
            serializer = s;
        }

        public TyonSerializer GetSerializer()
        {
            return serializer;
        }
    }
}
