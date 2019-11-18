using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    [Serializable]
    public struct OctoMask
    {
        [SerializeField]private byte bits;

        static public bool operator ==(OctoMask m1, OctoMask m2)
        {
            if (m1.bits == m2.bits)
                return true;

            return false;
        }
        static public bool operator !=(OctoMask m1, OctoMask m2)
        {
            if (m1.bits != m2.bits)
                return true;

            return false;
        }

        static public IEnumerable<OctoMask> GetAll()
        {
            return Ints.Range(0, ByteBits.ALL_BITS, true).Convert(b => new OctoMask((byte)b));
        }

        public OctoMask(byte b)
        {
            bits = b;
        }

        public byte GetBits()
        {
            return bits;
        }

        public override int GetHashCode()
        {
            return bits.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            OctoMask mask;

            if (obj.Convert<OctoMask>(out mask))
            {
                if (mask.bits == bits)
                    return true;
            }

            return false;
        }
    }
}