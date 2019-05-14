
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 13 2018 22:31:32 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
	public class CmlEntry_Class_Entity : CmlEntry_Class
	{
        private CmlEntity entity;

        protected override void SolidifyIntoInternalClass(CmlExecution execution, CmlContainer container)
        {
            if (entity != null)
                entity.SolidifyInto(execution, container);
            else
            {
                container.Insert(
                    execution,
                    new CmlValue_SystemValue(null)
                );
            }
        }

        public CmlEntry_Class_Entity(Type t, string l, CmlEntity e) : base(t, l)
        {
            entity = e;
        }
	}
	
}
