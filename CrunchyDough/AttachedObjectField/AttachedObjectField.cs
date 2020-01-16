using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class AttachedObjectField<DECLARING_TYPE, FIELD_TYPE> where DECLARING_TYPE : class
    {
        private ObjectTable<DECLARING_TYPE, FIELD_TYPE> table;
        private Operation<FIELD_TYPE, DECLARING_TYPE> operation;

        public AttachedObjectField(Operation<FIELD_TYPE, DECLARING_TYPE> o)
        {
            table = new ObjectTable<DECLARING_TYPE, FIELD_TYPE>();
            operation = o;
        }

        public void SetValue(DECLARING_TYPE obj, FIELD_TYPE value)
        {
            table.Set(obj, value);
        }

        public FIELD_TYPE GetValue(DECLARING_TYPE obj)
        {
            FIELD_TYPE value;

            if (table.TryLookup(obj, out value) == false)
            {
                if (operation != null)
                {
                    value = operation(obj);
                    table.Set(obj, value);
                }
            }

            return value;
        }
    }
}