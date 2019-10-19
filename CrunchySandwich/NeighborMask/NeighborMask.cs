using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    [Serializable]
    public struct NeighborMask
    {
        [SerializeField]private byte bits;

        static public bool operator ==(NeighborMask m1, NeighborMask m2)
        {
            if (m1.bits == m2.bits)
                return true;

            return false;
        }
        static public bool operator !=(NeighborMask m1, NeighborMask m2)
        {
            if (m1.bits != m2.bits)
                return true;

            return false;
        }

        static public IEnumerable<NeighborMask> GetAllNeighborMasks()
        {
            return Ints.Range(0, byte.MaxValue, true).Convert(b => new NeighborMask((byte)b));
        }

        public NeighborMask(byte b)
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
            NeighborMask mask;

            if (obj.Convert<NeighborMask>(out mask))
            {
                if (mask.bits == bits)
                    return true;
            }

            return false;
        }
    }
}