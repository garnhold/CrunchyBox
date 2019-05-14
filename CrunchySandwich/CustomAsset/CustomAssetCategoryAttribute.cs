using System;

using CrunchyDough;

namespace CrunchySandwich
{
    [AttributeUsage(AttributeTargets.Class)]
    public class CustomAssetCategoryAttribute : LabeledAttribute
    {
        public CustomAssetCategoryAttribute(string l) : base(l) { }
    }
}