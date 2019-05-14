using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class AttachedObjectField<DECLARING_TYPE, FIELD_TYPE> where DECLARING_TYPE : class
    {
        private ObjectTable<DECLARING_TYPE, FIELD_TYPE> table;

        public AttachedObjectField()
        {
            table = new ObjectTable<DECLARING_TYPE, FIELD_TYPE>();
        }

        public void SetValue(DECLARING_TYPE obj, FIELD_TYPE value)
        {
            table.Set(obj, value);
        }

        public FIELD_TYPE GetValue(DECLARING_TYPE obj)
        {
            return table.Lookup(obj);
        }
    }
}