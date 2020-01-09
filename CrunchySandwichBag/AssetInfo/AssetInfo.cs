using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;
    using Sandwich;
    
    public class AssetInfo
    {
        private string guid;

        private UnityEngine.Object obj;

        static public bool operator ==(AssetInfo a1, AssetInfo a2)
        {
            if (a1.guid == a2.guid)
                return true;

            return false;
        }
        static public bool operator !=(AssetInfo a1, AssetInfo a2)
        {
            if (a1.guid != a2.guid)
                return true;

            return false;
        }

        public AssetInfo(string g)
        {
            guid = g;
        }

        public AssetInfo(UnityEngine.Object o)
        {
            guid = o.GetAssetGUID();
            obj = o;
        }

        public UnityEngine.Object Resolve()
        {
            if (obj == null)
                obj = AssetDatabase.LoadMainAssetAtPath(this.GetPath());

            return obj;
        }

        public string GetGUID()
        {
            return guid;
        }

        public override int GetHashCode()
        {
            return guid.GetHashCodeEX();
        }

        public override bool Equals(object obj)
        {
            AssetInfo cast;

            if (obj.Convert<AssetInfo>(out cast))
            {
                if (cast == this)
                    return true;
            }

            return false;
        }

        public override string ToString()
        {
            return this.GetName();
        }
    }
}