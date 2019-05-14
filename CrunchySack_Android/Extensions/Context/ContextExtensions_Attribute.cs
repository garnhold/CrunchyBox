using System;
using System.IO;

using Android;
using Android.App;
using Android.Views;
using Android.Content;
using Android.Content.Res;
using Android.Util;
using Android.Graphics;

using CrunchyDough;
using CrunchySack;

namespace CrunchySack_Android
{
    static public class ContextExtensions_Attribute
    {
        static public TypedValue GetAttribute(this Context item, int attribute_id)
        {
            TypedValue value = new TypedValue();

            item.Theme.ResolveAttribute(attribute_id, value, true);
            return value;
        }
    }
}