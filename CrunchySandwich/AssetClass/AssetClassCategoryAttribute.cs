using System;

using CrunchyDough;

namespace CrunchySandwich
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AssetClassCategoryAttribute : LabeledAttribute
    {
        public AssetClassCategoryAttribute(string l) : base(l) { }
    }
}