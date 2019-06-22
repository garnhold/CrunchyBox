using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    [Serializable]
    public class LayerEX
    {
        [SerializeField]private int id;

        static public int operator |(LayerEX l1, LayerEX l2)
        {
            return l1.GetMask() | l2.GetMask();
        }

        static public implicit operator int(LayerEX layer)
        {
            return layer.GetMask();
        }

        public LayerEX(int i)
        {
            id = i;
        }

        public LayerEX(string n) : this(LayerMask.NameToLayer(n)) { }

        public int GetId()
        {
            return id;
        }

        public int GetMask()
        {
            return LayerMask.GetMask(GetName());
        }

        public string GetName()
        {
            return LayerMask.LayerToName(id);
        }

        public override bool Equals(object obj)
        {
            LayerEX cast;

            if (obj.Convert<LayerEX>(out cast))
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