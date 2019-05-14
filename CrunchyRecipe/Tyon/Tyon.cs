using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyRecipe
{
    static public class Tyon
    {
        static public string Serialize(object obj, TyonSerializationSettings settings)
        {
            return new TyonContext_Dehydration(settings).Dehydrate(obj).Render();
        }
        static public string Serialize(object obj, TyonSerializationSettings settings, IList<object> output_registered_external_objects)
        {
            string output;
            TyonContext_Dehydration context = new TyonContext_Dehydration(settings);

            output = context.Dehydrate(obj).Render();
            output_registered_external_objects.Set(context.GetRegisteredExternalObjects());

            return output;
        }

        static public void DeserializeInto(string text, object obj, TyonSerializationSettings settings)
        {
            new TyonContext_Hydration(settings).HydrateInto(obj, TyonObject.DOMify(text));
        }
        static public void DeserializeInto(string text, object obj, TyonSerializationSettings settings, IEnumerable<object> external_objects)
        {
            TyonContext_Hydration context = new TyonContext_Hydration(settings);

            context.RegisterExternalObjects(external_objects);
            context.HydrateInto(obj, TyonObject.DOMify(text));
        }

        static public object Deserialize(string text, TyonSerializationSettings settings)
        {
            return new TyonContext_Hydration(settings).Hydrate(TyonObject.DOMify(text));
        }
        static public object Deserialize(string text, TyonSerializationSettings settings, IEnumerable<object> external_objects)
        {
            TyonContext_Hydration context = new TyonContext_Hydration(settings);

            context.RegisterExternalObjects(external_objects);
            return context.Hydrate(TyonObject.DOMify(text));
        }

        static public T Deserialize<T>(string text, TyonSerializationSettings settings)
        {
            return Deserialize(text, settings).Convert<T>();
        }
        static public T Deserialize<T>(string text, TyonSerializationSettings settings, IEnumerable<object> external_objects)
        {
            return Deserialize(text, settings, external_objects).Convert<T>();
        }
    }
}