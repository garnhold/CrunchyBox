using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    [Serializable]
    public struct SortingLayerEX
    {
        [SerializeField]private int id;

        public SortingLayerEX(int i)
        {
            id = i;
        }

        public SortingLayerEX(SortingLayer l) : this(l.id) { }
        public SortingLayerEX(string n) : this(SortingLayer.NameToID(n)) { }

        public int GetId()
        {
            return id;
        }

        public string GetName()
        {
            return SortingLayer.IDToName(id);
        }

        public int GetValue()
        {
            return SortingLayer.GetLayerValueFromID(id);
        }

        public int GetOrder()
        {
            return GetValue() - SortingLayerEXExtensions.GetLowestSortingLayer().GetValue();
        }

        public override bool Equals(object obj)
        {
            SortingLayerEX cast;

            if (obj.Convert<SortingLayerEX>(out cast))
            {
                if (cast.id == id)
                    return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return id.GetHashCode();
        }

        public override string ToString()
        {
            return GetName();
        }
    }
}