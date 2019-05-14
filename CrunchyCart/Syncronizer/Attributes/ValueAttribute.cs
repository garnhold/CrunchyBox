using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchySodium;

namespace CrunchyCart
{
    public partial class Syncronizer
    {
        [AttributeUsage(AttributeTargets.Field | AttributeTargets.Method)]
        public class ValueAttribute : Attribute
        {
            private int importance;
            private bool is_send_on_dirty;

            public ValueAttribute(int i, bool isod)
            {
                importance = i;
                is_send_on_dirty = isod;
            }

            public int GetImportance()
            {
                return importance;
            }

            public bool IsSendOnDirty()
            {
                return is_send_on_dirty;
            }
        }
    }
}