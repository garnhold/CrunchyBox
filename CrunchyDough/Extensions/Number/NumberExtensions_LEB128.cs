using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
	static public class NumberExtensions_LEB128
    {
        public const int EXTEND_FLAG = ByteBits.BIT7;
        public const int EXTEND_MASK = ByteBits.BYTE0 ^ EXTEND_FLAG;
        
        public const int SIGN_FLAG = ByteBits.BIT6;
        public const int SIGN_MASK = ByteBits.BYTE0 ^ SIGN_FLAG;
        

		static public IEnumerable<byte> GetUnsignedLEB128Bytes(this byte item)
        {
            bool done = false;
        
			while(done == false)
            {
                byte current_byte = (byte)(item & EXTEND_MASK);
                
                item = (byte)(item >> 7);
                if(item == 0)
                    done = true;
                else
                    current_byte |= EXTEND_FLAG;
                
                yield return current_byte;
            }
		}
        
        static public IEnumerable<byte> GetSignedLEB128Bytes(this byte item)
        {
            bool done = false;
        
            while(done == false)
            {
                byte current_byte = (byte)(item & EXTEND_MASK);
                
                item = (byte)(item >> 7);
                
                if((current_byte & SIGN_MASK) != 0)
                {
                    if(item == -1)
                        done = true;
                    else
                        current_byte |= EXTEND_FLAG;
                }
                else
                {
                    if(item == 0)
                        done = true;
                    else
                        current_byte |= EXTEND_FLAG;
                }
                
                yield return current_byte;
            }   
        }

		static public IEnumerable<byte> GetUnsignedLEB128Bytes(this short item)
        {
            bool done = false;
        
			while(done == false)
            {
                byte current_byte = (byte)(item & EXTEND_MASK);
                
                item = (short)(item >> 7);
                if(item == 0)
                    done = true;
                else
                    current_byte |= EXTEND_FLAG;
                
                yield return current_byte;
            }
		}
        
        static public IEnumerable<byte> GetSignedLEB128Bytes(this short item)
        {
            bool done = false;
        
            while(done == false)
            {
                byte current_byte = (byte)(item & EXTEND_MASK);
                
                item = (short)(item >> 7);
                
                if((current_byte & SIGN_MASK) != 0)
                {
                    if(item == -1)
                        done = true;
                    else
                        current_byte |= EXTEND_FLAG;
                }
                else
                {
                    if(item == 0)
                        done = true;
                    else
                        current_byte |= EXTEND_FLAG;
                }
                
                yield return current_byte;
            }   
        }

		static public IEnumerable<byte> GetUnsignedLEB128Bytes(this int item)
        {
            bool done = false;
        
			while(done == false)
            {
                byte current_byte = (byte)(item & EXTEND_MASK);
                
                item = (int)(item >> 7);
                if(item == 0)
                    done = true;
                else
                    current_byte |= EXTEND_FLAG;
                
                yield return current_byte;
            }
		}
        
        static public IEnumerable<byte> GetSignedLEB128Bytes(this int item)
        {
            bool done = false;
        
            while(done == false)
            {
                byte current_byte = (byte)(item & EXTEND_MASK);
                
                item = (int)(item >> 7);
                
                if((current_byte & SIGN_MASK) != 0)
                {
                    if(item == -1)
                        done = true;
                    else
                        current_byte |= EXTEND_FLAG;
                }
                else
                {
                    if(item == 0)
                        done = true;
                    else
                        current_byte |= EXTEND_FLAG;
                }
                
                yield return current_byte;
            }   
        }

		static public IEnumerable<byte> GetUnsignedLEB128Bytes(this long item)
        {
            bool done = false;
        
			while(done == false)
            {
                byte current_byte = (byte)(item & EXTEND_MASK);
                
                item = (long)(item >> 7);
                if(item == 0)
                    done = true;
                else
                    current_byte |= EXTEND_FLAG;
                
                yield return current_byte;
            }
		}
        
        static public IEnumerable<byte> GetSignedLEB128Bytes(this long item)
        {
            bool done = false;
        
            while(done == false)
            {
                byte current_byte = (byte)(item & EXTEND_MASK);
                
                item = (long)(item >> 7);
                
                if((current_byte & SIGN_MASK) != 0)
                {
                    if(item == -1)
                        done = true;
                    else
                        current_byte |= EXTEND_FLAG;
                }
                else
                {
                    if(item == 0)
                        done = true;
                    else
                        current_byte |= EXTEND_FLAG;
                }
                
                yield return current_byte;
            }   
        }
	}
}