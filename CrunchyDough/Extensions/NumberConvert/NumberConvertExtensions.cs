using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
	static public class NumberConvertExtensions
    {
			static public byte GetBytePercent(this float item)
		{
			return (byte)(item * byte.MaxValue).BindBetween(0, byte.MaxValue);
		}
			static public short GetShortPercent(this float item)
		{
			return (short)(item * short.MaxValue).BindBetween(0, short.MaxValue);
		}
			static public int GetIntPercent(this float item)
		{
			return (int)(item * int.MaxValue).BindBetween(0, int.MaxValue);
		}
			static public uint GetUIntPercent(this float item)
		{
			return (uint)(item * uint.MaxValue).BindBetween(0, uint.MaxValue);
		}
			static public long GetLongPercent(this float item)
		{
			return (long)(item * long.MaxValue).BindBetween(0, long.MaxValue);
		}
				static public byte GetBytePercent(this double item)
		{
			return (byte)(item * byte.MaxValue).BindBetween(0, byte.MaxValue);
		}
			static public short GetShortPercent(this double item)
		{
			return (short)(item * short.MaxValue).BindBetween(0, short.MaxValue);
		}
			static public int GetIntPercent(this double item)
		{
			return (int)(item * int.MaxValue).BindBetween(0, int.MaxValue);
		}
			static public uint GetUIntPercent(this double item)
		{
			return (uint)(item * uint.MaxValue).BindBetween(0, uint.MaxValue);
		}
			static public long GetLongPercent(this double item)
		{
			return (long)(item * long.MaxValue).BindBetween(0, long.MaxValue);
		}
				static public byte GetBytePercent(this decimal item)
		{
			return (byte)(item * byte.MaxValue).BindBetween(0, byte.MaxValue);
		}
			static public short GetShortPercent(this decimal item)
		{
			return (short)(item * short.MaxValue).BindBetween(0, short.MaxValue);
		}
			static public int GetIntPercent(this decimal item)
		{
			return (int)(item * int.MaxValue).BindBetween(0, int.MaxValue);
		}
			static public uint GetUIntPercent(this decimal item)
		{
			return (uint)(item * uint.MaxValue).BindBetween(0, uint.MaxValue);
		}
			static public long GetLongPercent(this decimal item)
		{
			return (long)(item * long.MaxValue).BindBetween(0, long.MaxValue);
		}
	
			static public float GetFloatPercent(this byte item)
		{
			return (float)item / byte.MaxValue;

		}
			static public double GetDoublePercent(this byte item)
		{
			return (double)item / byte.MaxValue;

		}
			static public decimal GetDecimalPercent(this byte item)
		{
			return (decimal)item / byte.MaxValue;

		}
				static public float GetFloatPercent(this short item)
		{
			return (float)item / short.MaxValue;

		}
			static public double GetDoublePercent(this short item)
		{
			return (double)item / short.MaxValue;

		}
			static public decimal GetDecimalPercent(this short item)
		{
			return (decimal)item / short.MaxValue;

		}
				static public float GetFloatPercent(this int item)
		{
			return (float)item / int.MaxValue;

		}
			static public double GetDoublePercent(this int item)
		{
			return (double)item / int.MaxValue;

		}
			static public decimal GetDecimalPercent(this int item)
		{
			return (decimal)item / int.MaxValue;

		}
				static public float GetFloatPercent(this uint item)
		{
			return (float)item / uint.MaxValue;

		}
			static public double GetDoublePercent(this uint item)
		{
			return (double)item / uint.MaxValue;

		}
			static public decimal GetDecimalPercent(this uint item)
		{
			return (decimal)item / uint.MaxValue;

		}
				static public float GetFloatPercent(this long item)
		{
			return (float)item / long.MaxValue;

		}
			static public double GetDoublePercent(this long item)
		{
			return (double)item / long.MaxValue;

		}
			static public decimal GetDecimalPercent(this long item)
		{
			return (decimal)item / long.MaxValue;

		}
	

                                                static public IEnumerable<byte> GetCompositeBytes(this short item)
            {
                                    yield return (byte)(item >> 0);
                                    yield return (byte)(item >> 8);
                            }
        
            static public short GetCompositeShort(this byte item0, byte item1 )
            {
                short dst = 0;
            
                                    dst |= (short)((short)item0 << 0);
                                    dst |= (short)((short)item1 << 8);
                                
                return dst;
            }
            
            static public short GetCompositeShort(this IEnumerable<byte> item)
            {
                                    byte src0;
                                    byte src1;
                                
                item.PartOut(out src0, out src1);
                
                return src0.GetCompositeShort(src1);
            }
                                                        static public IEnumerable<byte> GetCompositeBytes(this int item)
            {
                                    yield return (byte)(item >> 0);
                                    yield return (byte)(item >> 8);
                                    yield return (byte)(item >> 16);
                                    yield return (byte)(item >> 24);
                            }
        
            static public int GetCompositeInt(this byte item0, byte item1 , byte item2 , byte item3 )
            {
                int dst = 0;
            
                                    dst |= (int)((int)item0 << 0);
                                    dst |= (int)((int)item1 << 8);
                                    dst |= (int)((int)item2 << 16);
                                    dst |= (int)((int)item3 << 24);
                                
                return dst;
            }
            
            static public int GetCompositeInt(this IEnumerable<byte> item)
            {
                                    byte src0;
                                    byte src1;
                                    byte src2;
                                    byte src3;
                                
                item.PartOut(out src0, out src1, out src2, out src3);
                
                return src0.GetCompositeInt(src1, src2, src3);
            }
                                                        static public IEnumerable<byte> GetCompositeBytes(this uint item)
            {
                                    yield return (byte)(item >> 0);
                                    yield return (byte)(item >> 8);
                                    yield return (byte)(item >> 16);
                                    yield return (byte)(item >> 24);
                            }
        
            static public uint GetCompositeUInt(this byte item0, byte item1 , byte item2 , byte item3 )
            {
                uint dst = 0;
            
                                    dst |= (uint)((uint)item0 << 0);
                                    dst |= (uint)((uint)item1 << 8);
                                    dst |= (uint)((uint)item2 << 16);
                                    dst |= (uint)((uint)item3 << 24);
                                
                return dst;
            }
            
            static public uint GetCompositeUInt(this IEnumerable<byte> item)
            {
                                    byte src0;
                                    byte src1;
                                    byte src2;
                                    byte src3;
                                
                item.PartOut(out src0, out src1, out src2, out src3);
                
                return src0.GetCompositeUInt(src1, src2, src3);
            }
                                                        static public IEnumerable<byte> GetCompositeBytes(this long item)
            {
                                    yield return (byte)(item >> 0);
                                    yield return (byte)(item >> 8);
                                    yield return (byte)(item >> 16);
                                    yield return (byte)(item >> 24);
                                    yield return (byte)(item >> 32);
                                    yield return (byte)(item >> 40);
                                    yield return (byte)(item >> 48);
                                    yield return (byte)(item >> 56);
                            }
        
            static public long GetCompositeLong(this byte item0, byte item1 , byte item2 , byte item3 , byte item4 , byte item5 , byte item6 , byte item7 )
            {
                long dst = 0;
            
                                    dst |= (long)((long)item0 << 0);
                                    dst |= (long)((long)item1 << 8);
                                    dst |= (long)((long)item2 << 16);
                                    dst |= (long)((long)item3 << 24);
                                    dst |= (long)((long)item4 << 32);
                                    dst |= (long)((long)item5 << 40);
                                    dst |= (long)((long)item6 << 48);
                                    dst |= (long)((long)item7 << 56);
                                
                return dst;
            }
            
            static public long GetCompositeLong(this IEnumerable<byte> item)
            {
                                    byte src0;
                                    byte src1;
                                    byte src2;
                                    byte src3;
                                    byte src4;
                                    byte src5;
                                    byte src6;
                                    byte src7;
                                
                item.PartOut(out src0, out src1, out src2, out src3, out src4, out src5, out src6, out src7);
                
                return src0.GetCompositeLong(src1, src2, src3, src4, src5, src6, src7);
            }
                                                            static public IEnumerable<short> GetCompositeShorts(this int item)
            {
                                    yield return (short)(item >> 0);
                                    yield return (short)(item >> 16);
                            }
        
            static public int GetCompositeInt(this short item0, short item1 )
            {
                int dst = 0;
            
                                    dst |= (int)((int)item0 << 0);
                                    dst |= (int)((int)item1 << 16);
                                
                return dst;
            }
            
            static public int GetCompositeInt(this IEnumerable<short> item)
            {
                                    short src0;
                                    short src1;
                                
                item.PartOut(out src0, out src1);
                
                return src0.GetCompositeInt(src1);
            }
                                                        static public IEnumerable<short> GetCompositeShorts(this uint item)
            {
                                    yield return (short)(item >> 0);
                                    yield return (short)(item >> 16);
                            }
        
            static public uint GetCompositeUInt(this short item0, short item1 )
            {
                uint dst = 0;
            
                                    dst |= (uint)((uint)item0 << 0);
                                    dst |= (uint)((uint)item1 << 16);
                                
                return dst;
            }
            
            static public uint GetCompositeUInt(this IEnumerable<short> item)
            {
                                    short src0;
                                    short src1;
                                
                item.PartOut(out src0, out src1);
                
                return src0.GetCompositeUInt(src1);
            }
                                                        static public IEnumerable<short> GetCompositeShorts(this long item)
            {
                                    yield return (short)(item >> 0);
                                    yield return (short)(item >> 16);
                                    yield return (short)(item >> 32);
                                    yield return (short)(item >> 48);
                            }
        
            static public long GetCompositeLong(this short item0, short item1 , short item2 , short item3 )
            {
                long dst = 0;
            
                                    dst |= (long)((long)item0 << 0);
                                    dst |= (long)((long)item1 << 16);
                                    dst |= (long)((long)item2 << 32);
                                    dst |= (long)((long)item3 << 48);
                                
                return dst;
            }
            
            static public long GetCompositeLong(this IEnumerable<short> item)
            {
                                    short src0;
                                    short src1;
                                    short src2;
                                    short src3;
                                
                item.PartOut(out src0, out src1, out src2, out src3);
                
                return src0.GetCompositeLong(src1, src2, src3);
            }
                                                                                                static public IEnumerable<int> GetCompositeInts(this long item)
            {
                                    yield return (int)(item >> 0);
                                    yield return (int)(item >> 32);
                            }
        
            static public long GetCompositeLong(this int item0, int item1 )
            {
                long dst = 0;
            
                                    dst |= (long)((long)item0 << 0);
                                    dst |= (long)((long)item1 << 32);
                                
                return dst;
            }
            
            static public long GetCompositeLong(this IEnumerable<int> item)
            {
                                    int src0;
                                    int src1;
                                
                item.PartOut(out src0, out src1);
                
                return src0.GetCompositeLong(src1);
            }
                                                            static public IEnumerable<uint> GetCompositeUInts(this long item)
            {
                                    yield return (uint)(item >> 0);
                                    yield return (uint)(item >> 32);
                            }
        
            static public long GetCompositeLong(this uint item0, uint item1 )
            {
                long dst = 0;
            
                                    dst |= (long)((long)item0 << 0);
                                    dst |= (long)((long)item1 << 32);
                                
                return dst;
            }
            
            static public long GetCompositeLong(this IEnumerable<uint> item)
            {
                                    uint src0;
                                    uint src1;
                                
                item.PartOut(out src0, out src1);
                
                return src0.GetCompositeLong(src1);
            }
                	}
}
