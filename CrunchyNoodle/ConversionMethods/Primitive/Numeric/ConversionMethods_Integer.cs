using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    [Conversion]
	static public class ConversionMethods_Integer
    {
                                
                                            
                [Conversion]
                static public sbyte ToSignedByte(byte item)
                {
                    return item.FitInCappedSignedByte();
                }

                                            
                [Conversion]
                static public short ToShort(byte item)
                {
                    return item.FitInCappedShort();
                }

                                            
                [Conversion]
                static public ushort ToUnsignedShort(byte item)
                {
                    return item.FitInCappedUnsignedShort();
                }

                                            
                [Conversion]
                static public int ToInt(byte item)
                {
                    return item.FitInCappedInt();
                }

                                            
                [Conversion]
                static public uint ToUnsignedInt(byte item)
                {
                    return item.FitInCappedUnsignedInt();
                }

                                            
                [Conversion]
                static public long ToLong(byte item)
                {
                    return item.FitInCappedLong();
                }

                                            
                [Conversion]
                static public ulong ToUnsignedLong(byte item)
                {
                    return item.FitInCappedUnsignedLong();
                }

                        
            [Conversion]
            static public bool ToBool(byte item)
            {
                if(item == 0)
                    return false;
                    
                return true;
            }
            
            [Conversion]
            static public float ToFloat(byte item)
            {
                return item;
            }
            
            [Conversion]
            static public double ToDouble(byte item)
            {
                return item;
            }
            
            [Conversion]
            static public decimal ToDecimal(byte item)
            {
                return item;
            }
            
            [Conversion]
            static public string ToString(byte item)
            {
                return item.ToStringEX();
            }
                                
                                            
                [Conversion]
                static public byte ToByte(sbyte item)
                {
                    return item.FitInCappedByte();
                }

                                            
                [Conversion]
                static public short ToShort(sbyte item)
                {
                    return item.FitInCappedShort();
                }

                                            
                [Conversion]
                static public ushort ToUnsignedShort(sbyte item)
                {
                    return item.FitInCappedUnsignedShort();
                }

                                            
                [Conversion]
                static public int ToInt(sbyte item)
                {
                    return item.FitInCappedInt();
                }

                                            
                [Conversion]
                static public uint ToUnsignedInt(sbyte item)
                {
                    return item.FitInCappedUnsignedInt();
                }

                                            
                [Conversion]
                static public long ToLong(sbyte item)
                {
                    return item.FitInCappedLong();
                }

                                            
                [Conversion]
                static public ulong ToUnsignedLong(sbyte item)
                {
                    return item.FitInCappedUnsignedLong();
                }

                        
            [Conversion]
            static public bool ToBool(sbyte item)
            {
                if(item == 0)
                    return false;
                    
                return true;
            }
            
            [Conversion]
            static public float ToFloat(sbyte item)
            {
                return item;
            }
            
            [Conversion]
            static public double ToDouble(sbyte item)
            {
                return item;
            }
            
            [Conversion]
            static public decimal ToDecimal(sbyte item)
            {
                return item;
            }
            
            [Conversion]
            static public string ToString(sbyte item)
            {
                return item.ToStringEX();
            }
                                
                                            
                [Conversion]
                static public byte ToByte(short item)
                {
                    return item.FitInCappedByte();
                }

                                            
                [Conversion]
                static public sbyte ToSignedByte(short item)
                {
                    return item.FitInCappedSignedByte();
                }

                                            
                [Conversion]
                static public ushort ToUnsignedShort(short item)
                {
                    return item.FitInCappedUnsignedShort();
                }

                                            
                [Conversion]
                static public int ToInt(short item)
                {
                    return item.FitInCappedInt();
                }

                                            
                [Conversion]
                static public uint ToUnsignedInt(short item)
                {
                    return item.FitInCappedUnsignedInt();
                }

                                            
                [Conversion]
                static public long ToLong(short item)
                {
                    return item.FitInCappedLong();
                }

                                            
                [Conversion]
                static public ulong ToUnsignedLong(short item)
                {
                    return item.FitInCappedUnsignedLong();
                }

                        
            [Conversion]
            static public bool ToBool(short item)
            {
                if(item == 0)
                    return false;
                    
                return true;
            }
            
            [Conversion]
            static public float ToFloat(short item)
            {
                return item;
            }
            
            [Conversion]
            static public double ToDouble(short item)
            {
                return item;
            }
            
            [Conversion]
            static public decimal ToDecimal(short item)
            {
                return item;
            }
            
            [Conversion]
            static public string ToString(short item)
            {
                return item.ToStringEX();
            }
                                
                                            
                [Conversion]
                static public byte ToByte(ushort item)
                {
                    return item.FitInCappedByte();
                }

                                            
                [Conversion]
                static public sbyte ToSignedByte(ushort item)
                {
                    return item.FitInCappedSignedByte();
                }

                                            
                [Conversion]
                static public short ToShort(ushort item)
                {
                    return item.FitInCappedShort();
                }

                                            
                [Conversion]
                static public int ToInt(ushort item)
                {
                    return item.FitInCappedInt();
                }

                                            
                [Conversion]
                static public uint ToUnsignedInt(ushort item)
                {
                    return item.FitInCappedUnsignedInt();
                }

                                            
                [Conversion]
                static public long ToLong(ushort item)
                {
                    return item.FitInCappedLong();
                }

                                            
                [Conversion]
                static public ulong ToUnsignedLong(ushort item)
                {
                    return item.FitInCappedUnsignedLong();
                }

                        
            [Conversion]
            static public bool ToBool(ushort item)
            {
                if(item == 0)
                    return false;
                    
                return true;
            }
            
            [Conversion]
            static public float ToFloat(ushort item)
            {
                return item;
            }
            
            [Conversion]
            static public double ToDouble(ushort item)
            {
                return item;
            }
            
            [Conversion]
            static public decimal ToDecimal(ushort item)
            {
                return item;
            }
            
            [Conversion]
            static public string ToString(ushort item)
            {
                return item.ToStringEX();
            }
                                
                                            
                [Conversion]
                static public byte ToByte(int item)
                {
                    return item.FitInCappedByte();
                }

                                            
                [Conversion]
                static public sbyte ToSignedByte(int item)
                {
                    return item.FitInCappedSignedByte();
                }

                                            
                [Conversion]
                static public short ToShort(int item)
                {
                    return item.FitInCappedShort();
                }

                                            
                [Conversion]
                static public ushort ToUnsignedShort(int item)
                {
                    return item.FitInCappedUnsignedShort();
                }

                                            
                [Conversion]
                static public uint ToUnsignedInt(int item)
                {
                    return item.FitInCappedUnsignedInt();
                }

                                            
                [Conversion]
                static public long ToLong(int item)
                {
                    return item.FitInCappedLong();
                }

                                            
                [Conversion]
                static public ulong ToUnsignedLong(int item)
                {
                    return item.FitInCappedUnsignedLong();
                }

                        
            [Conversion]
            static public bool ToBool(int item)
            {
                if(item == 0)
                    return false;
                    
                return true;
            }
            
            [Conversion]
            static public float ToFloat(int item)
            {
                return item;
            }
            
            [Conversion]
            static public double ToDouble(int item)
            {
                return item;
            }
            
            [Conversion]
            static public decimal ToDecimal(int item)
            {
                return item;
            }
            
            [Conversion]
            static public string ToString(int item)
            {
                return item.ToStringEX();
            }
                                
                                            
                [Conversion]
                static public byte ToByte(uint item)
                {
                    return item.FitInCappedByte();
                }

                                            
                [Conversion]
                static public sbyte ToSignedByte(uint item)
                {
                    return item.FitInCappedSignedByte();
                }

                                            
                [Conversion]
                static public short ToShort(uint item)
                {
                    return item.FitInCappedShort();
                }

                                            
                [Conversion]
                static public ushort ToUnsignedShort(uint item)
                {
                    return item.FitInCappedUnsignedShort();
                }

                                            
                [Conversion]
                static public int ToInt(uint item)
                {
                    return item.FitInCappedInt();
                }

                                            
                [Conversion]
                static public long ToLong(uint item)
                {
                    return item.FitInCappedLong();
                }

                                            
                [Conversion]
                static public ulong ToUnsignedLong(uint item)
                {
                    return item.FitInCappedUnsignedLong();
                }

                        
            [Conversion]
            static public bool ToBool(uint item)
            {
                if(item == 0)
                    return false;
                    
                return true;
            }
            
            [Conversion]
            static public float ToFloat(uint item)
            {
                return item;
            }
            
            [Conversion]
            static public double ToDouble(uint item)
            {
                return item;
            }
            
            [Conversion]
            static public decimal ToDecimal(uint item)
            {
                return item;
            }
            
            [Conversion]
            static public string ToString(uint item)
            {
                return item.ToStringEX();
            }
                                
                                            
                [Conversion]
                static public byte ToByte(long item)
                {
                    return item.FitInCappedByte();
                }

                                            
                [Conversion]
                static public sbyte ToSignedByte(long item)
                {
                    return item.FitInCappedSignedByte();
                }

                                            
                [Conversion]
                static public short ToShort(long item)
                {
                    return item.FitInCappedShort();
                }

                                            
                [Conversion]
                static public ushort ToUnsignedShort(long item)
                {
                    return item.FitInCappedUnsignedShort();
                }

                                            
                [Conversion]
                static public int ToInt(long item)
                {
                    return item.FitInCappedInt();
                }

                                            
                [Conversion]
                static public uint ToUnsignedInt(long item)
                {
                    return item.FitInCappedUnsignedInt();
                }

                                            
                [Conversion]
                static public ulong ToUnsignedLong(long item)
                {
                    return item.FitInCappedUnsignedLong();
                }

                        
            [Conversion]
            static public bool ToBool(long item)
            {
                if(item == 0)
                    return false;
                    
                return true;
            }
            
            [Conversion]
            static public float ToFloat(long item)
            {
                return item;
            }
            
            [Conversion]
            static public double ToDouble(long item)
            {
                return item;
            }
            
            [Conversion]
            static public decimal ToDecimal(long item)
            {
                return item;
            }
            
            [Conversion]
            static public string ToString(long item)
            {
                return item.ToStringEX();
            }
                                
                                            
                [Conversion]
                static public byte ToByte(ulong item)
                {
                    return item.FitInCappedByte();
                }

                                            
                [Conversion]
                static public sbyte ToSignedByte(ulong item)
                {
                    return item.FitInCappedSignedByte();
                }

                                            
                [Conversion]
                static public short ToShort(ulong item)
                {
                    return item.FitInCappedShort();
                }

                                            
                [Conversion]
                static public ushort ToUnsignedShort(ulong item)
                {
                    return item.FitInCappedUnsignedShort();
                }

                                            
                [Conversion]
                static public int ToInt(ulong item)
                {
                    return item.FitInCappedInt();
                }

                                            
                [Conversion]
                static public uint ToUnsignedInt(ulong item)
                {
                    return item.FitInCappedUnsignedInt();
                }

                                            
                [Conversion]
                static public long ToLong(ulong item)
                {
                    return item.FitInCappedLong();
                }

                        
            [Conversion]
            static public bool ToBool(ulong item)
            {
                if(item == 0)
                    return false;
                    
                return true;
            }
            
            [Conversion]
            static public float ToFloat(ulong item)
            {
                return item;
            }
            
            [Conversion]
            static public double ToDouble(ulong item)
            {
                return item;
            }
            
            [Conversion]
            static public decimal ToDecimal(ulong item)
            {
                return item;
            }
            
            [Conversion]
            static public string ToString(ulong item)
            {
                return item.ToStringEX();
            }
        	}
}
