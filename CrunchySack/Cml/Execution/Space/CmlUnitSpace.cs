
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 13 2018 18:20:51 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class CmlUnitSpace
	{
        private Dictionary<string, object> representations;

        public CmlUnitSpace()
        {
            representations = new Dictionary<string, object>();
        }

        public void AddRepresentation(string id, object representation)
        {
            representations.Add(id, representation);
        }

        public object GetRepresentation(string id)
        {
            return representations.GetValue(id);
        }
	}
	
}
