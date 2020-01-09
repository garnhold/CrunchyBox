using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class MipMask
    {
        private int index;
        private int size;
        private int bin_size;

        private long mask;
        private MipMask[] layers;

        public MipMask(int i, int s)
        {
            index = i;
            size = s;
            bin_size = (size / LongBits.NUMBER_BITS).BindAbove(1);

            mask = LongBits.NO_BITS;

            if (bin_size > 1)
            {
                layers = new MipMask[LongBits.NUMBER_BITS];
                for (int j = 0; j < layers.Length; j++)
                    layers[j] = new MipMask(index + j * bin_size, bin_size);
            }
        }

        public MipMask(int s) : this(0, s) { }

        public bool SetNthBit(int n, bool state)
        {
            int local_n = (n - index) / bin_size;
            long bit_value = LongBits.GetNthBitValue(local_n);

            if (layers != null)
            {
                if (layers[local_n].SetNthBit(n, state))
                    mask |= bit_value;
                else
                    mask &= ~bit_value;
            }
            else
            {
                if(state)
                    mask |= bit_value;
                else
                    mask &= ~bit_value;
            }

            if (mask != LongBits.NO_BITS)
                return true;

            return false;
        }
    }
}