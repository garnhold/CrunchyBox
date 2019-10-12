using System;

using CrunchyDough;

namespace CrunchyNoodle
{
    public abstract class Variable_Static : Variable
    {
        protected abstract void SetStaticContentsInternal(object value);
        protected abstract object GetStaticContentsInternal();

        static public readonly object TARGET_INSTANCE = new object();

        protected override bool SetContentsInternal(object target, object value)
        {
            SetStaticContentsInternal(value);

            return true;
        }

        protected override object GetContentsInternal(object target)
        {
            return GetStaticContentsInternal();
        }

        public Variable_Static(Type t) : base(typeof(object), t) { }

        public bool SetContents(object value)
        {
            return SetContents(TARGET_INSTANCE, value);
        }

        public object GetContents()
        {
            return GetContents(TARGET_INSTANCE);
        }
    }
}