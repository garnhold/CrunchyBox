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
                static public sbyte ToSignedByte(this byte item)
                {
                    return item.FitInCappedSignedByte();
                }

                                            
                [Conversion]
                static public short ToShort(this byte item)
                {
                    return item.FitInCappedShort();
                }

                                            
                [Conversion]
                static public ushort ToUnsignedShort(this byte item)
                {
                    return item.FitInCappedUnsignedShort();
                }

                                            
                [Conversion]
                static public int ToInt(this byte item)
                {
                    return item.FitInCappedInt();
                }

                                            
                [Conversion]
                static public uint ToUnsignedInt(this byte item)
                {
                    return item.FitInCappedUnsignedInt();
                }

                                            
                [Conversion]
                static public long ToLong(this byte item)
                {
                    return item.FitInCappedLong();
                }

                                            
                [Conversion]
                static public ulong ToUnsignedLong(this byte item)
                {
                    return item.FitInCappedUnsignedLong();
                }

                        
            [Conversion]
            static public bool ToBool(this byte item)
            {
                if(item == 0)
                    return false;
                    
                return true;
            }
            
            [Conversion]
            static public float ToFloat(this byte item)
            {
                return item;
            }
            
            [Conversion]
            static public double ToDouble(this byte item)
            {
                return item;
            }
            
            [Conversion]
            static public decimal ToDecimal(this byte item)
            {
                return item;
            }
            
            [Conversion]
            static public string ToString(this byte item)
            {
                return item.ToStringEX();
            }
              
                        
                                            
                [Conversion]
                static public byte ToByte(this sbyte item)
                {
                    return item.FitInCappedByte();
                }

                                            
                [Conversion]
                static public short ToShort(this sbyte item)
                {
                    return item.FitInCappedShort();
                }

                                            
                [Conversion]
                static public ushort ToUnsignedShort(this sbyte item)
                {
                    return item.FitInCappedUnsignedShort();
                }

                                            
                [Conversion]
                static public int ToInt(this sbyte item)
                {
                    return item.FitInCappedInt();
                }

                                            
                [Conversion]
                static public uint ToUnsignedInt(this sbyte item)
                {
                    return item.FitInCappedUnsignedInt();
                }

                                            
                [Conversion]
                static public long ToLong(this sbyte item)
                {
                    return item.FitInCappedLong();
                }

                                            
                [Conversion]
                static public ulong ToUnsignedLong(this sbyte item)
                {
                    return item.FitInCappedUnsignedLong();
                }

                        
            [Conversion]
            static public bool ToBool(this sbyte item)
            {
                if(item == 0)
                    return false;
                    
                return true;
            }
            
            [Conversion]
            static public float ToFloat(this sbyte item)
            {
                return item;
            }
            
            [Conversion]
            static public double ToDouble(this sbyte item)
            {
                return item;
            }
            
            [Conversion]
            static public decimal ToDecimal(this sbyte item)
            {
                return item;
            }
            
            [Conversion]
            static public string ToString(this sbyte item)
            {
                return item.ToStringEX();
            }
              
                        
                                            
                [Conversion]
                static public byte ToByte(this short item)
                {
                    return item.FitInCappedByte();
                }

                                            
                [Conversion]
                static public sbyte ToSignedByte(this short item)
                {
                    return item.FitInCappedSignedByte();
                }

                                            
                [Conversion]
                static public ushort ToUnsignedShort(this short item)
                {
                    return item.FitInCappedUnsignedShort();
                }

                                            
                [Conversion]
                static public int ToInt(this short item)
                {
                    return item.FitInCappedInt();
                }

                                            
                [Conversion]
                static public uint ToUnsignedInt(this short item)
                {
                    return item.FitInCappedUnsignedInt();
                }

                                            
                [Conversion]
                static public long ToLong(this short item)
                {
                    return item.FitInCappedLong();
                }

                                            
                [Conversion]
                static public ulong ToUnsignedLong(this short item)
                {
                    return item.FitInCappedUnsignedLong();
                }

                        
            [Conversion]
            static public bool ToBool(this short item)
            {
                if(item == 0)
                    return false;
                    
                return true;
            }
            
            [Conversion]
            static public float ToFloat(this short item)
            {
                return item;
            }
            
            [Conversion]
            static public double ToDouble(this short item)
            {
                return item;
            }
            
            [Conversion]
            static public decimal ToDecimal(this short item)
            {
                return item;
            }
            
            [Conversion]
            static public string ToString(this short item)
            {
                return item.ToStringEX();
            }
              
                        
                                            
                [Conversion]
                static public byte ToByte(this ushort item)
                {
                    return item.FitInCappedByte();
                }

                                            
                [Conversion]
                static public sbyte ToSignedByte(this ushort item)
                {
                    return item.FitInCappedSignedByte();
                }

                                            
                [Conversion]
                static public short ToShort(this ushort item)
                {
                    return item.FitInCappedShort();
                }

                                            
                [Conversion]
                static public int ToInt(this ushort item)
                {
                    return item.FitInCappedInt();
                }

                                            
                [Conversion]
                static public uint ToUnsignedInt(this ushort item)
                {
                    return item.FitInCappedUnsignedInt();
                }

                                            
                [Conversion]
                static public long ToLong(this ushort item)
                {
                    return item.FitInCappedLong();
                }

                                            
                [Conversion]
                static public ulong ToUnsignedLong(this ushort item)
                {
                    return item.FitInCappedUnsignedLong();
                }

                        
            [Conversion]
            static public bool ToBool(this ushort item)
            {
                if(item == 0)
                    return false;
                    
                return true;
            }
            
            [Conversion]
            static public float ToFloat(this ushort item)
            {
                return item;
            }
            
            [Conversion]
            static public double ToDouble(this ushort item)
            {
                return item;
            }
            
            [Conversion]
            static public decimal ToDecimal(this ushort item)
            {
                return item;
            }
            
            [Conversion]
            static public string ToString(this ushort item)
            {
                return item.ToStringEX();
            }
              
                        
                                            
                [Conversion]
                static public byte ToByte(this int item)
                {
                    return item.FitInCappedByte();
                }

                                            
                [Conversion]
                static public sbyte ToSignedByte(this int item)
                {
                    return item.FitInCappedSignedByte();
                }

                                            
                [Conversion]
                static public short ToShort(this int item)
                {
                    return item.FitInCappedShort();
                }

                                            
                [Conversion]
                static public ushort ToUnsignedShort(this int item)
                {
                    return item.FitInCappedUnsignedShort();
                }

                                            
                [Conversion]
                static public uint ToUnsignedInt(this int item)
                {
                    return item.FitInCappedUnsignedInt();
                }

                                            
                [Conversion]
                static public long ToLong(this int item)
                {
                    return item.FitInCappedLong();
                }

                                            
                [Conversion]
                static public ulong ToUnsignedLong(this int item)
                {
                    return item.FitInCappedUnsignedLong();
                }

                        
            [Conversion]
            static public bool ToBool(this int item)
            {
                if(item == 0)
                    return false;
                    
                return true;
            }
            
            [Conversion]
            static public float ToFloat(this int item)
            {
                return item;
            }
            
            [Conversion]
            static public double ToDouble(this int item)
            {
                return item;
            }
            
            [Conversion]
            static public decimal ToDecimal(this int item)
            {
                return item;
            }
            
            [Conversion]
            static public string ToString(this int item)
            {
                return item.ToStringEX();
            }
              
                        
                                            
                [Conversion]
                static public byte ToByte(this uint item)
                {
                    return item.FitInCappedByte();
                }

                                            
                [Conversion]
                static public sbyte ToSignedByte(this uint item)
                {
                    return item.FitInCappedSignedByte();
                }

                                            
                [Conversion]
                static public short ToShort(this uint item)
                {
                    return item.FitInCappedShort();
                }

                                            
                [Conversion]
                static public ushort ToUnsignedShort(this uint item)
                {
                    return item.FitInCappedUnsignedShort();
                }

                                            
                [Conversion]
                static public int ToInt(this uint item)
                {
                    return item.FitInCappedInt();
                }

                                            
                [Conversion]
                static public long ToLong(this uint item)
                {
                    return item.FitInCappedLong();
                }

                                            
                [Conversion]
                static public ulong ToUnsignedLong(this uint item)
                {
                    return item.FitInCappedUnsignedLong();
                }

                        
            [Conversion]
            static public bool ToBool(this uint item)
            {
                if(item == 0)
                    return false;
                    
                return true;
            }
            
            [Conversion]
            static public float ToFloat(this uint item)
            {
                return item;
            }
            
            [Conversion]
            static public double ToDouble(this uint item)
            {
                return item;
            }
            
            [Conversion]
            static public decimal ToDecimal(this uint item)
            {
                return item;
            }
            
            [Conversion]
            static public string ToString(this uint item)
            {
                return item.ToStringEX();
            }
              
                        
                                            
                [Conversion]
                static public byte ToByte(this long item)
                {
                    return item.FitInCappedByte();
                }

                                            
                [Conversion]
                static public sbyte ToSignedByte(this long item)
                {
                    return item.FitInCappedSignedByte();
                }

                                            
                [Conversion]
                static public short ToShort(this long item)
                {
                    return item.FitInCappedShort();
                }

                                            
                [Conversion]
                static public ushort ToUnsignedShort(this long item)
                {
                    return item.FitInCappedUnsignedShort();
                }

                                            
                [Conversion]
                static public int ToInt(this long item)
                {
                    return item.FitInCappedInt();
                }

                                            
                [Conversion]
                static public uint ToUnsignedInt(this long item)
                {
                    return item.FitInCappedUnsignedInt();
                }

                                            
                [Conversion]
                static public ulong ToUnsignedLong(this long item)
                {
                    return item.FitInCappedUnsignedLong();
                }

                        
            [Conversion]
            static public bool ToBool(this long item)
            {
                if(item == 0)
                    return false;
                    
                return true;
            }
            
            [Conversion]
            static public float ToFloat(this long item)
            {
                return item;
            }
            
            [Conversion]
            static public double ToDouble(this long item)
            {
                return item;
            }
            
            [Conversion]
            static public decimal ToDecimal(this long item)
            {
                return item;
            }
            
            [Conversion]
            static public string ToString(this long item)
            {
                return item.ToStringEX();
            }
              
                        
                                            
                [Conversion]
                static public byte ToByte(this ulong item)
                {
                    return item.FitInCappedByte();
                }

                                            
                [Conversion]
                static public sbyte ToSignedByte(this ulong item)
                {
                    return item.FitInCappedSignedByte();
                }

                                            
                [Conversion]
                static public short ToShort(this ulong item)
                {
                    return item.FitInCappedShort();
                }

                                            
                [Conversion]
                static public ushort ToUnsignedShort(this ulong item)
                {
                    return item.FitInCappedUnsignedShort();
                }

                                            
                [Conversion]
                static public int ToInt(this ulong item)
                {
                    return item.FitInCappedInt();
                }

                                            
                [Conversion]
                static public uint ToUnsignedInt(this ulong item)
                {
                    return item.FitInCappedUnsignedInt();
                }

                                            
                [Conversion]
                static public long ToLong(this ulong item)
                {
                    return item.FitInCappedLong();
                }

                        
            [Conversion]
            static public bool ToBool(this ulong item)
            {
                if(item == 0)
                    return false;
                    
                return true;
            }
            
            [Conversion]
            static public float ToFloat(this ulong item)
            {
                return item;
            }
            
            [Conversion]
            static public double ToDouble(this ulong item)
            {
                return item;
            }
            
            [Conversion]
            static public decimal ToDecimal(this ulong item)
            {
                return item;
            }
            
            [Conversion]
            static public string ToString(this ulong item)
            {
                return item.ToStringEX();
            }
        	}
}
