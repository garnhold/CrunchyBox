
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 13 2018 18:20:51 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
	public class CmlRepresentationSpace
	{
        private List<object> representation_stack;
        private Dictionary<string, object> representations;

        public CmlRepresentationSpace()
        {
            representation_stack = new List<object>();
            representations = new Dictionary<string, object>();
        }

        public void PushRepresentation(CmlEntity entity, object representation)
        {
            representation_stack.Add(representation);

            if (entity.HasId())
                representations.Add(entity.GetId(), representation);
        }

        public void PopRepresentation(object representation)
        {
            representation_stack.RemoveAll(representation);
        }

        public object GetThisRepresentation()
        {
            return representation_stack.GetLast();
        }

        public object GetRepresentation(string id)
        {
            return representations.GetValue(id);
        }
	}
	
}
