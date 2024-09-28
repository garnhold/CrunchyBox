using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
	static public class NumberExtensions_LEB128
    {
        public const int FLAG = ByteBits.BIT7;
        public const int MASK = ByteBits.BYTE0 ^ FLAG;
        

		static public IEnumerable<byte> GetUnsignedLEB128Bytes(this byte item)
        {
            bool done = false;
        
			while(done == false)
            {
                byte current_byte = (byte)(item & MASK);
                
                item = (byte)(item >> 7);
                if(item == 0)
                    done = true;
                else
                    current_byte |= FLAG;
                
                yield return current_byte;
            }
		}

		static public IEnumerable<byte> GetUnsignedLEB128Bytes(this short item)
        {
            bool done = false;
        
			while(done == false)
            {
                byte current_byte = (byte)(item & MASK);
                
                item = (short)(item >> 7);
                if(item == 0)
                    done = true;
                else
                    current_byte |= FLAG;
                
                yield return current_byte;
            }
		}

		static public IEnumerable<byte> GetUnsignedLEB128Bytes(this int item)
        {
            bool done = false;
        
			while(done == false)
            {
                byte current_byte = (byte)(item & MASK);
                
                item = (int)(item >> 7);
                if(item == 0)
                    done = true;
                else
                    current_byte |= FLAG;
                
                yield return current_byte;
            }
		}

		static public IEnumerable<byte> GetUnsignedLEB128Bytes(this long item)
        {
            bool done = false;
        
			while(done == false)
            {
                byte current_byte = (byte)(item & MASK);
                
                item = (long)(item >> 7);
                if(item == 0)
                    done = true;
                else
                    current_byte |= FLAG;
                
                yield return current_byte;
            }
		}
	}
}