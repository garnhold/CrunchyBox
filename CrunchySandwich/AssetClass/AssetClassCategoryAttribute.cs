using System;

namespace Crunchy.Sandwich
{
    using Dough;
    
    [AttributeUsage(AttributeTargets.Class)]
    public class AssetClassCategoryAttribute : LabeledAttribute
    {
        public AssetClassCategoryAttribute(string l) : base(l) { }
    }
}