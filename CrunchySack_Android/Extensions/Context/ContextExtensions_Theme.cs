using System;
using System.IO;

using Android;
using Android.App;
using Android.Views;
using Android.Content;
using Android.Content.Res;
using Android.Util;
using Android.Graphics;

namespace Crunchy.Sack_Android
{
    using Dough;
    using Sack;
    
    static public class ContextExtensions_Theme
    {
        static public Color GetThemeColor(this Context item, int attribute_id)
        {
            return new Color(item.GetAttribute(attribute_id).Data);
        }

        static public Color GetThemeColorText(this Context item)
        {
            return item.GetThemeColor(Android.Resource.Attribute.EditTextColor);
        }

        static public Color GetThemeColorAccent(this Context item)
        {
            return item.GetThemeColor(Android.Resource.Attribute.ColorAccent);
        }

        static public Color GetThemeColorPrimary(this Context item)
        {
            return item.GetThemeColor(Android.Resource.Attribute.ColorPrimary);
        }

        static public Color GetThemeColorPrimaryDark(this Context item)
        {
            return item.GetThemeColor(Android.Resource.Attribute.ColorPrimaryDark);
        }
    }
}