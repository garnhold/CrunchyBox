using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
	static public class NumberFitExtensions
    {
                    
    		static public object ShrinkFit(this byte item)
    		{
                    			return item;
    		}

                                            
        		static public bool CanFitInSignedByte(this byte item)
        		{
                                        
                                            if(item > 127)
                            return false;
                    
        			return true;
        		}
                
                static public sbyte FitInCappedSignedByte(this byte item)
                {
                                        
                                            if(item > 127)
                            return 127;
                                            
                    return (sbyte)item;
                }

                                            
        		static public bool CanFitInShort(this byte item)
        		{
                                        
                    
        			return true;
        		}
                
                static public short FitInCappedShort(this byte item)
                {
                                        
                                            
                    return (short)item;
                }

                                            
        		static public bool CanFitInUnsignedShort(this byte item)
        		{
                                        
                    
        			return true;
        		}
                
                static public ushort FitInCappedUnsignedShort(this byte item)
                {
                                        
                                            
                    return (ushort)item;
                }

                                            
        		static public bool CanFitInInt(this byte item)
        		{
                                        
                    
        			return true;
        		}
                
                static public int FitInCappedInt(this byte item)
                {
                                        
                                            
                    return (int)item;
                }

                                            
        		static public bool CanFitInUnsignedInt(this byte item)
        		{
                                        
                    
        			return true;
        		}
                
                static public uint FitInCappedUnsignedInt(this byte item)
                {
                                        
                                            
                    return (uint)item;
                }

                                            
        		static public bool CanFitInLong(this byte item)
        		{
                                        
                    
        			return true;
        		}
                
                static public long FitInCappedLong(this byte item)
                {
                                        
                                            
                    return (long)item;
                }

                                            
        		static public bool CanFitInUnsignedLong(this byte item)
        		{
                                        
                    
        			return true;
        		}
                
                static public ulong FitInCappedUnsignedLong(this byte item)
                {
                                        
                                            
                    return (ulong)item;
                }

                                
    		static public object ShrinkFit(this sbyte item)
    		{
                                                    
        			if(item.CanFitInByte())
        				return (byte)item;

                    			return item;
    		}

                                            
        		static public bool CanFitInByte(this sbyte item)
        		{
                                            if(item < 0)
                            return false;
                                        
                    
        			return true;
        		}
                
                static public byte FitInCappedByte(this sbyte item)
                {
                                            if(item < 0)
                            return 0;
                                        
                                            
                    return (byte)item;
                }

                                            
        		static public bool CanFitInShort(this sbyte item)
        		{
                                        
                    
        			return true;
        		}
                
                static public short FitInCappedShort(this sbyte item)
                {
                                        
                                            
                    return (short)item;
                }

                                            
        		static public bool CanFitInUnsignedShort(this sbyte item)
        		{
                                            if(item < 0)
                            return false;
                                        
                    
        			return true;
        		}
                
                static public ushort FitInCappedUnsignedShort(this sbyte item)
                {
                                            if(item < 0)
                            return 0;
                                        
                                            
                    return (ushort)item;
                }

                                            
        		static public bool CanFitInInt(this sbyte item)
        		{
                                        
                    
        			return true;
        		}
                
                static public int FitInCappedInt(this sbyte item)
                {
                                        
                                            
                    return (int)item;
                }

                                            
        		static public bool CanFitInUnsignedInt(this sbyte item)
        		{
                                            if(item < 0)
                            return false;
                                        
                    
        			return true;
        		}
                
                static public uint FitInCappedUnsignedInt(this sbyte item)
                {
                                            if(item < 0)
                            return 0;
                                        
                                            
                    return (uint)item;
                }

                                            
        		static public bool CanFitInLong(this sbyte item)
        		{
                                        
                    
        			return true;
        		}
                
                static public long FitInCappedLong(this sbyte item)
                {
                                        
                                            
                    return (long)item;
                }

                                            
        		static public bool CanFitInUnsignedLong(this sbyte item)
        		{
                                            if(item < 0)
                            return false;
                                        
                    
        			return true;
        		}
                
                static public ulong FitInCappedUnsignedLong(this sbyte item)
                {
                                            if(item < 0)
                            return 0;
                                        
                                            
                    return (ulong)item;
                }

                                
    		static public object ShrinkFit(this short item)
    		{
                                                    
        			if(item.CanFitInByte())
        				return (byte)item;

                                                    
        			if(item.CanFitInSignedByte())
        				return (sbyte)item;

                    			return item;
    		}

                                            
        		static public bool CanFitInByte(this short item)
        		{
                                            if(item < 0)
                            return false;
                                        
                                            if(item > 255)
                            return false;
                    
        			return true;
        		}
                
                static public byte FitInCappedByte(this short item)
                {
                                            if(item < 0)
                            return 0;
                                        
                                            if(item > 255)
                            return 255;
                                            
                    return (byte)item;
                }

                                            
        		static public bool CanFitInSignedByte(this short item)
        		{
                                            if(item < -128)
                            return false;
                                        
                                            if(item > 127)
                            return false;
                    
        			return true;
        		}
                
                static public sbyte FitInCappedSignedByte(this short item)
                {
                                            if(item < -128)
                            return -128;
                                        
                                            if(item > 127)
                            return 127;
                                            
                    return (sbyte)item;
                }

                                            
        		static public bool CanFitInUnsignedShort(this short item)
        		{
                                            if(item < 0)
                            return false;
                                        
                    
        			return true;
        		}
                
                static public ushort FitInCappedUnsignedShort(this short item)
                {
                                            if(item < 0)
                            return 0;
                                        
                                            
                    return (ushort)item;
                }

                                            
        		static public bool CanFitInInt(this short item)
        		{
                                        
                    
        			return true;
        		}
                
                static public int FitInCappedInt(this short item)
                {
                                        
                                            
                    return (int)item;
                }

                                            
        		static public bool CanFitInUnsignedInt(this short item)
        		{
                                            if(item < 0)
                            return false;
                                        
                    
        			return true;
        		}
                
                static public uint FitInCappedUnsignedInt(this short item)
                {
                                            if(item < 0)
                            return 0;
                                        
                                            
                    return (uint)item;
                }

                                            
        		static public bool CanFitInLong(this short item)
        		{
                                        
                    
        			return true;
        		}
                
                static public long FitInCappedLong(this short item)
                {
                                        
                                            
                    return (long)item;
                }

                                            
        		static public bool CanFitInUnsignedLong(this short item)
        		{
                                            if(item < 0)
                            return false;
                                        
                    
        			return true;
        		}
                
                static public ulong FitInCappedUnsignedLong(this short item)
                {
                                            if(item < 0)
                            return 0;
                                        
                                            
                    return (ulong)item;
                }

                                
    		static public object ShrinkFit(this ushort item)
    		{
                                                    
        			if(item.CanFitInByte())
        				return (byte)item;

                                                    
        			if(item.CanFitInSignedByte())
        				return (sbyte)item;

                                                    
        			if(item.CanFitInShort())
        				return (short)item;

                    			return item;
    		}

                                            
        		static public bool CanFitInByte(this ushort item)
        		{
                                        
                                            if(item > 255)
                            return false;
                    
        			return true;
        		}
                
                static public byte FitInCappedByte(this ushort item)
                {
                                        
                                            if(item > 255)
                            return 255;
                                            
                    return (byte)item;
                }

                                            
        		static public bool CanFitInSignedByte(this ushort item)
        		{
                                        
                                            if(item > 127)
                            return false;
                    
        			return true;
        		}
                
                static public sbyte FitInCappedSignedByte(this ushort item)
                {
                                        
                                            if(item > 127)
                            return 127;
                                            
                    return (sbyte)item;
                }

                                            
        		static public bool CanFitInShort(this ushort item)
        		{
                                        
                                            if(item > 32767)
                            return false;
                    
        			return true;
        		}
                
                static public short FitInCappedShort(this ushort item)
                {
                                        
                                            if(item > 32767)
                            return 32767;
                                            
                    return (short)item;
                }

                                            
        		static public bool CanFitInInt(this ushort item)
        		{
                                        
                    
        			return true;
        		}
                
                static public int FitInCappedInt(this ushort item)
                {
                                        
                                            
                    return (int)item;
                }

                                            
        		static public bool CanFitInUnsignedInt(this ushort item)
        		{
                                        
                    
        			return true;
        		}
                
                static public uint FitInCappedUnsignedInt(this ushort item)
                {
                                        
                                            
                    return (uint)item;
                }

                                            
        		static public bool CanFitInLong(this ushort item)
        		{
                                        
                    
        			return true;
        		}
                
                static public long FitInCappedLong(this ushort item)
                {
                                        
                                            
                    return (long)item;
                }

                                            
        		static public bool CanFitInUnsignedLong(this ushort item)
        		{
                                        
                    
        			return true;
        		}
                
                static public ulong FitInCappedUnsignedLong(this ushort item)
                {
                                        
                                            
                    return (ulong)item;
                }

                                
    		static public object ShrinkFit(this int item)
    		{
                                                    
        			if(item.CanFitInByte())
        				return (byte)item;

                                                    
        			if(item.CanFitInSignedByte())
        				return (sbyte)item;

                                                    
        			if(item.CanFitInShort())
        				return (short)item;

                                                    
        			if(item.CanFitInUnsignedShort())
        				return (ushort)item;

                    			return item;
    		}

                                            
        		static public bool CanFitInByte(this int item)
        		{
                                            if(item < 0)
                            return false;
                                        
                                            if(item > 255)
                            return false;
                    
        			return true;
        		}
                
                static public byte FitInCappedByte(this int item)
                {
                                            if(item < 0)
                            return 0;
                                        
                                            if(item > 255)
                            return 255;
                                            
                    return (byte)item;
                }

                                            
        		static public bool CanFitInSignedByte(this int item)
        		{
                                            if(item < -128)
                            return false;
                                        
                                            if(item > 127)
                            return false;
                    
        			return true;
        		}
                
                static public sbyte FitInCappedSignedByte(this int item)
                {
                                            if(item < -128)
                            return -128;
                                        
                                            if(item > 127)
                            return 127;
                                            
                    return (sbyte)item;
                }

                                            
        		static public bool CanFitInShort(this int item)
        		{
                                            if(item < -32768)
                            return false;
                                        
                                            if(item > 32767)
                            return false;
                    
        			return true;
        		}
                
                static public short FitInCappedShort(this int item)
                {
                                            if(item < -32768)
                            return -32768;
                                        
                                            if(item > 32767)
                            return 32767;
                                            
                    return (short)item;
                }

                                            
        		static public bool CanFitInUnsignedShort(this int item)
        		{
                                            if(item < 0)
                            return false;
                                        
                                            if(item > 65535)
                            return false;
                    
        			return true;
        		}
                
                static public ushort FitInCappedUnsignedShort(this int item)
                {
                                            if(item < 0)
                            return 0;
                                        
                                            if(item > 65535)
                            return 65535;
                                            
                    return (ushort)item;
                }

                                            
        		static public bool CanFitInUnsignedInt(this int item)
        		{
                                            if(item < 0)
                            return false;
                                        
                    
        			return true;
        		}
                
                static public uint FitInCappedUnsignedInt(this int item)
                {
                                            if(item < 0)
                            return 0;
                                        
                                            
                    return (uint)item;
                }

                                            
        		static public bool CanFitInLong(this int item)
        		{
                                        
                    
        			return true;
        		}
                
                static public long FitInCappedLong(this int item)
                {
                                        
                                            
                    return (long)item;
                }

                                            
        		static public bool CanFitInUnsignedLong(this int item)
        		{
                                            if(item < 0)
                            return false;
                                        
                    
        			return true;
        		}
                
                static public ulong FitInCappedUnsignedLong(this int item)
                {
                                            if(item < 0)
                            return 0;
                                        
                                            
                    return (ulong)item;
                }

                                
    		static public object ShrinkFit(this uint item)
    		{
                                                    
        			if(item.CanFitInByte())
        				return (byte)item;

                                                    
        			if(item.CanFitInSignedByte())
        				return (sbyte)item;

                                                    
        			if(item.CanFitInShort())
        				return (short)item;

                                                    
        			if(item.CanFitInUnsignedShort())
        				return (ushort)item;

                                                    
        			if(item.CanFitInInt())
        				return (int)item;

                    			return item;
    		}

                                            
        		static public bool CanFitInByte(this uint item)
        		{
                                        
                                            if(item > 255)
                            return false;
                    
        			return true;
        		}
                
                static public byte FitInCappedByte(this uint item)
                {
                                        
                                            if(item > 255)
                            return 255;
                                            
                    return (byte)item;
                }

                                            
        		static public bool CanFitInSignedByte(this uint item)
        		{
                                        
                                            if(item > 127)
                            return false;
                    
        			return true;
        		}
                
                static public sbyte FitInCappedSignedByte(this uint item)
                {
                                        
                                            if(item > 127)
                            return 127;
                                            
                    return (sbyte)item;
                }

                                            
        		static public bool CanFitInShort(this uint item)
        		{
                                        
                                            if(item > 32767)
                            return false;
                    
        			return true;
        		}
                
                static public short FitInCappedShort(this uint item)
                {
                                        
                                            if(item > 32767)
                            return 32767;
                                            
                    return (short)item;
                }

                                            
        		static public bool CanFitInUnsignedShort(this uint item)
        		{
                                        
                                            if(item > 65535)
                            return false;
                    
        			return true;
        		}
                
                static public ushort FitInCappedUnsignedShort(this uint item)
                {
                                        
                                            if(item > 65535)
                            return 65535;
                                            
                    return (ushort)item;
                }

                                            
        		static public bool CanFitInInt(this uint item)
        		{
                                        
                                            if(item > 2147483647)
                            return false;
                    
        			return true;
        		}
                
                static public int FitInCappedInt(this uint item)
                {
                                        
                                            if(item > 2147483647)
                            return 2147483647;
                                            
                    return (int)item;
                }

                                            
        		static public bool CanFitInLong(this uint item)
        		{
                                        
                    
        			return true;
        		}
                
                static public long FitInCappedLong(this uint item)
                {
                                        
                                            
                    return (long)item;
                }

                                            
        		static public bool CanFitInUnsignedLong(this uint item)
        		{
                                        
                    
        			return true;
        		}
                
                static public ulong FitInCappedUnsignedLong(this uint item)
                {
                                        
                                            
                    return (ulong)item;
                }

                                
    		static public object ShrinkFit(this long item)
    		{
                                                    
        			if(item.CanFitInByte())
        				return (byte)item;

                                                    
        			if(item.CanFitInSignedByte())
        				return (sbyte)item;

                                                    
        			if(item.CanFitInShort())
        				return (short)item;

                                                    
        			if(item.CanFitInUnsignedShort())
        				return (ushort)item;

                                                    
        			if(item.CanFitInInt())
        				return (int)item;

                                                    
        			if(item.CanFitInUnsignedInt())
        				return (uint)item;

                    			return item;
    		}

                                            
        		static public bool CanFitInByte(this long item)
        		{
                                            if(item < 0)
                            return false;
                                        
                                            if(item > 255)
                            return false;
                    
        			return true;
        		}
                
                static public byte FitInCappedByte(this long item)
                {
                                            if(item < 0)
                            return 0;
                                        
                                            if(item > 255)
                            return 255;
                                            
                    return (byte)item;
                }

                                            
        		static public bool CanFitInSignedByte(this long item)
        		{
                                            if(item < -128)
                            return false;
                                        
                                            if(item > 127)
                            return false;
                    
        			return true;
        		}
                
                static public sbyte FitInCappedSignedByte(this long item)
                {
                                            if(item < -128)
                            return -128;
                                        
                                            if(item > 127)
                            return 127;
                                            
                    return (sbyte)item;
                }

                                            
        		static public bool CanFitInShort(this long item)
        		{
                                            if(item < -32768)
                            return false;
                                        
                                            if(item > 32767)
                            return false;
                    
        			return true;
        		}
                
                static public short FitInCappedShort(this long item)
                {
                                            if(item < -32768)
                            return -32768;
                                        
                                            if(item > 32767)
                            return 32767;
                                            
                    return (short)item;
                }

                                            
        		static public bool CanFitInUnsignedShort(this long item)
        		{
                                            if(item < 0)
                            return false;
                                        
                                            if(item > 65535)
                            return false;
                    
        			return true;
        		}
                
                static public ushort FitInCappedUnsignedShort(this long item)
                {
                                            if(item < 0)
                            return 0;
                                        
                                            if(item > 65535)
                            return 65535;
                                            
                    return (ushort)item;
                }

                                            
        		static public bool CanFitInInt(this long item)
        		{
                                            if(item < -2147483648)
                            return false;
                                        
                                            if(item > 2147483647)
                            return false;
                    
        			return true;
        		}
                
                static public int FitInCappedInt(this long item)
                {
                                            if(item < -2147483648)
                            return -2147483648;
                                        
                                            if(item > 2147483647)
                            return 2147483647;
                                            
                    return (int)item;
                }

                                            
        		static public bool CanFitInUnsignedInt(this long item)
        		{
                                            if(item < 0)
                            return false;
                                        
                                            if(item > 4294967295)
                            return false;
                    
        			return true;
        		}
                
                static public uint FitInCappedUnsignedInt(this long item)
                {
                                            if(item < 0)
                            return 0;
                                        
                                            if(item > 4294967295)
                            return 4294967295;
                                            
                    return (uint)item;
                }

                                            
        		static public bool CanFitInUnsignedLong(this long item)
        		{
                                            if(item < 0)
                            return false;
                                        
                    
        			return true;
        		}
                
                static public ulong FitInCappedUnsignedLong(this long item)
                {
                                            if(item < 0)
                            return 0;
                                        
                                            
                    return (ulong)item;
                }

                                
    		static public object ShrinkFit(this ulong item)
    		{
                                                    
        			if(item.CanFitInByte())
        				return (byte)item;

                                                    
        			if(item.CanFitInSignedByte())
        				return (sbyte)item;

                                                    
        			if(item.CanFitInShort())
        				return (short)item;

                                                    
        			if(item.CanFitInUnsignedShort())
        				return (ushort)item;

                                                    
        			if(item.CanFitInInt())
        				return (int)item;

                                                    
        			if(item.CanFitInUnsignedInt())
        				return (uint)item;

                                                    
        			if(item.CanFitInLong())
        				return (long)item;

                    			return item;
    		}

                                            
        		static public bool CanFitInByte(this ulong item)
        		{
                                        
                                            if(item > 255)
                            return false;
                    
        			return true;
        		}
                
                static public byte FitInCappedByte(this ulong item)
                {
                                        
                                            if(item > 255)
                            return 255;
                                            
                    return (byte)item;
                }

                                            
        		static public bool CanFitInSignedByte(this ulong item)
        		{
                                        
                                            if(item > 127)
                            return false;
                    
        			return true;
        		}
                
                static public sbyte FitInCappedSignedByte(this ulong item)
                {
                                        
                                            if(item > 127)
                            return 127;
                                            
                    return (sbyte)item;
                }

                                            
        		static public bool CanFitInShort(this ulong item)
        		{
                                        
                                            if(item > 32767)
                            return false;
                    
        			return true;
        		}
                
                static public short FitInCappedShort(this ulong item)
                {
                                        
                                            if(item > 32767)
                            return 32767;
                                            
                    return (short)item;
                }

                                            
        		static public bool CanFitInUnsignedShort(this ulong item)
        		{
                                        
                                            if(item > 65535)
                            return false;
                    
        			return true;
        		}
                
                static public ushort FitInCappedUnsignedShort(this ulong item)
                {
                                        
                                            if(item > 65535)
                            return 65535;
                                            
                    return (ushort)item;
                }

                                            
        		static public bool CanFitInInt(this ulong item)
        		{
                                        
                                            if(item > 2147483647)
                            return false;
                    
        			return true;
        		}
                
                static public int FitInCappedInt(this ulong item)
                {
                                        
                                            if(item > 2147483647)
                            return 2147483647;
                                            
                    return (int)item;
                }

                                            
        		static public bool CanFitInUnsignedInt(this ulong item)
        		{
                                        
                                            if(item > 4294967295)
                            return false;
                    
        			return true;
        		}
                
                static public uint FitInCappedUnsignedInt(this ulong item)
                {
                                        
                                            if(item > 4294967295)
                            return 4294967295;
                                            
                    return (uint)item;
                }

                                            
        		static public bool CanFitInLong(this ulong item)
        		{
                                        
                                            if(item > 9223372036854775807)
                            return false;
                    
        			return true;
        		}
                
                static public long FitInCappedLong(this ulong item)
                {
                                        
                                            if(item > 9223372036854775807)
                            return 9223372036854775807;
                                            
                    return (long)item;
                }

                    	}
}
