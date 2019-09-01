using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
	static public class NumberFitExtensions
    {

		static public object ShrinkFit(this long item)
		{
			if(item.CanFitInInt())
				return (int)item;

			if(item.CanFitInShort())
				return (short)item;

			if(item.CanFitInUnsignedShort())
				return (ushort)item;

			if(item.CanFitInByte())
				return (byte)item;

			if(item.CanFitInSignedByte())
				return (sbyte)item;

			return item;
		}

		static public bool CanFitInInt(this long item)
		{
			if(item >= int.MinValue && item <= int.MaxValue)
				return true;

			return false;
		}

		static public bool CanFitInShort(this long item)
		{
			if(item >= short.MinValue && item <= short.MaxValue)
				return true;

			return false;
		}

		static public bool CanFitInUnsignedShort(this long item)
		{
			if(item >= ushort.MinValue && item <= ushort.MaxValue)
				return true;

			return false;
		}

		static public bool CanFitInByte(this long item)
		{
			if(item >= byte.MinValue && item <= byte.MaxValue)
				return true;

			return false;
		}

		static public bool CanFitInSignedByte(this long item)
		{
			if(item >= sbyte.MinValue && item <= sbyte.MaxValue)
				return true;

			return false;
		}


		static public object ShrinkFit(this int item)
		{
			if(item.CanFitInShort())
				return (short)item;

			if(item.CanFitInUnsignedShort())
				return (ushort)item;

			if(item.CanFitInByte())
				return (byte)item;

			if(item.CanFitInSignedByte())
				return (sbyte)item;

			return item;
		}

		static public bool CanFitInShort(this int item)
		{
			if(item >= short.MinValue && item <= short.MaxValue)
				return true;

			return false;
		}

		static public bool CanFitInUnsignedShort(this int item)
		{
			if(item >= ushort.MinValue && item <= ushort.MaxValue)
				return true;

			return false;
		}

		static public bool CanFitInByte(this int item)
		{
			if(item >= byte.MinValue && item <= byte.MaxValue)
				return true;

			return false;
		}

		static public bool CanFitInSignedByte(this int item)
		{
			if(item >= sbyte.MinValue && item <= sbyte.MaxValue)
				return true;

			return false;
		}


		static public object ShrinkFit(this short item)
		{
			if(item.CanFitInUnsignedShort())
				return (ushort)item;

			if(item.CanFitInByte())
				return (byte)item;

			if(item.CanFitInSignedByte())
				return (sbyte)item;

			return item;
		}

		static public bool CanFitInUnsignedShort(this short item)
		{
			if(item >= ushort.MinValue && item <= ushort.MaxValue)
				return true;

			return false;
		}

		static public bool CanFitInByte(this short item)
		{
			if(item >= byte.MinValue && item <= byte.MaxValue)
				return true;

			return false;
		}

		static public bool CanFitInSignedByte(this short item)
		{
			if(item >= sbyte.MinValue && item <= sbyte.MaxValue)
				return true;

			return false;
		}


		static public object ShrinkFit(this ushort item)
		{
			if(item.CanFitInByte())
				return (byte)item;

			if(item.CanFitInSignedByte())
				return (sbyte)item;

			return item;
		}

		static public bool CanFitInByte(this ushort item)
		{
			if(item >= byte.MinValue && item <= byte.MaxValue)
				return true;

			return false;
		}

		static public bool CanFitInSignedByte(this ushort item)
		{
			if(item >= sbyte.MinValue && item <= sbyte.MaxValue)
				return true;

			return false;
		}


		static public object ShrinkFit(this byte item)
		{
			if(item.CanFitInSignedByte())
				return (sbyte)item;

			return item;
		}

		static public bool CanFitInSignedByte(this byte item)
		{
			if(item >= sbyte.MinValue && item <= sbyte.MaxValue)
				return true;

			return false;
		}


		static public object ShrinkFit(this sbyte item)
		{
			return item;
		}

	}
}
