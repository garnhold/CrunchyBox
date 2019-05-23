using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

using CrunchyDough;

namespace CrunchySalt
{
	public abstract partial class ILLiteral : ILValue
	{
		public abstract object GetLiteralValue();

		static public ILLiteral New(Type type, object value)
		{
			if(value == null)
				return ILNull.INSTANCE;

			if(type.IsEnumType())
				return new ILEnum((Enum)value);

		
			if(type == typeof(bool))
				return new ILBool((bool)value);
		
			if(type == typeof(byte))
				return new ILByte((byte)value);
		
			if(type == typeof(short))
				return new ILShort((short)value);
		
			if(type == typeof(int))
				return new ILInt((int)value);
		
			if(type == typeof(long))
				return new ILLong((long)value);
		
			if(type == typeof(float))
				return new ILFloat((float)value);
		
			if(type == typeof(double))
				return new ILDouble((double)value);
		
			if(type == typeof(string))
				return new ILString((string)value);
		
			if(type == typeof(Type))
				return new ILTypeOf((Type)value);
		
			throw new UnaccountedBranchException("type", type);
		}
		static public ILLiteral New(object value)
		{
			return New(value.GetTypeEX(), value);
		}

		public override void RenderIL_Store(ILCanvas canvas, ILValue value)
        {
            throw new InvalidOperationException(GetType() + " doesn't support storing.");
        }

		public override bool IsILCostTrivial()
		{
			return true;
		}

		public override bool CanLoad()
		{
			return true;
		}

		public override bool CanStore()
		{
			return false;
		}
	}


	public class ILBool : ILLiteral
	{
		private bool constant;

		public ILBool(bool c)
		{
			constant = c;
		}

		public override void RenderIL_Load(ILCanvas canvas)
		{
			canvas.Emit_Ldc_I4(constant.ConvertBool(1, 0));
		}

		public override void RenderText_Value(ILTextCanvas canvas)
		{
			canvas.AppendToLine(constant.ToStringEX());
		}

		public override Type GetValueType()
		{
			return typeof(bool);
		}

		public override object GetLiteralValue()
		{
			return constant;
		}
	}
	public abstract partial class ILValue
	{
		static public implicit operator ILValue(bool item)
		{
			return new ILBool(item);
		}
	}
	public abstract partial class ILLiteral
	{
		static public implicit operator ILLiteral(bool item)
		{
			return new ILBool(item);
		}
	}

	public class ILByte : ILLiteral
	{
		private byte constant;

		public ILByte(byte c)
		{
			constant = c;
		}

		public override void RenderIL_Load(ILCanvas canvas)
		{
			canvas.Emit_Ldc_I4(constant);
		}

		public override void RenderText_Value(ILTextCanvas canvas)
		{
			canvas.AppendToLine(constant.ToStringEX());
		}

		public override Type GetValueType()
		{
			return typeof(byte);
		}

		public override object GetLiteralValue()
		{
			return constant;
		}
	}
	public abstract partial class ILValue
	{
		static public implicit operator ILValue(byte item)
		{
			return new ILByte(item);
		}
	}
	public abstract partial class ILLiteral
	{
		static public implicit operator ILLiteral(byte item)
		{
			return new ILByte(item);
		}
	}

	public class ILShort : ILLiteral
	{
		private short constant;

		public ILShort(short c)
		{
			constant = c;
		}

		public override void RenderIL_Load(ILCanvas canvas)
		{
			canvas.Emit_Ldc_I4(constant);
		}

		public override void RenderText_Value(ILTextCanvas canvas)
		{
			canvas.AppendToLine(constant.ToStringEX());
		}

		public override Type GetValueType()
		{
			return typeof(short);
		}

		public override object GetLiteralValue()
		{
			return constant;
		}
	}
	public abstract partial class ILValue
	{
		static public implicit operator ILValue(short item)
		{
			return new ILShort(item);
		}
	}
	public abstract partial class ILLiteral
	{
		static public implicit operator ILLiteral(short item)
		{
			return new ILShort(item);
		}
	}

	public class ILInt : ILLiteral
	{
		private int constant;

		public ILInt(int c)
		{
			constant = c;
		}

		public override void RenderIL_Load(ILCanvas canvas)
		{
			canvas.Emit_Ldc_I4(constant);
		}

		public override void RenderText_Value(ILTextCanvas canvas)
		{
			canvas.AppendToLine(constant.ToStringEX());
		}

		public override Type GetValueType()
		{
			return typeof(int);
		}

		public override object GetLiteralValue()
		{
			return constant;
		}
	}
	public abstract partial class ILValue
	{
		static public implicit operator ILValue(int item)
		{
			return new ILInt(item);
		}
	}
	public abstract partial class ILLiteral
	{
		static public implicit operator ILLiteral(int item)
		{
			return new ILInt(item);
		}
	}

	public class ILLong : ILLiteral
	{
		private long constant;

		public ILLong(long c)
		{
			constant = c;
		}

		public override void RenderIL_Load(ILCanvas canvas)
		{
			canvas.Emit_Ldc_I8(constant);
		}

		public override void RenderText_Value(ILTextCanvas canvas)
		{
			canvas.AppendToLine(constant.ToStringEX());
		}

		public override Type GetValueType()
		{
			return typeof(long);
		}

		public override object GetLiteralValue()
		{
			return constant;
		}
	}
	public abstract partial class ILValue
	{
		static public implicit operator ILValue(long item)
		{
			return new ILLong(item);
		}
	}
	public abstract partial class ILLiteral
	{
		static public implicit operator ILLiteral(long item)
		{
			return new ILLong(item);
		}
	}

	public class ILFloat : ILLiteral
	{
		private float constant;

		public ILFloat(float c)
		{
			constant = c;
		}

		public override void RenderIL_Load(ILCanvas canvas)
		{
			canvas.Emit_Ldc_R4(constant);
		}

		public override void RenderText_Value(ILTextCanvas canvas)
		{
			canvas.AppendToLine(constant.ToStringEX());
		}

		public override Type GetValueType()
		{
			return typeof(float);
		}

		public override object GetLiteralValue()
		{
			return constant;
		}
	}
	public abstract partial class ILValue
	{
		static public implicit operator ILValue(float item)
		{
			return new ILFloat(item);
		}
	}
	public abstract partial class ILLiteral
	{
		static public implicit operator ILLiteral(float item)
		{
			return new ILFloat(item);
		}
	}

	public class ILDouble : ILLiteral
	{
		private double constant;

		public ILDouble(double c)
		{
			constant = c;
		}

		public override void RenderIL_Load(ILCanvas canvas)
		{
			canvas.Emit_Ldc_R8(constant);
		}

		public override void RenderText_Value(ILTextCanvas canvas)
		{
			canvas.AppendToLine(constant.ToStringEX());
		}

		public override Type GetValueType()
		{
			return typeof(double);
		}

		public override object GetLiteralValue()
		{
			return constant;
		}
	}
	public abstract partial class ILValue
	{
		static public implicit operator ILValue(double item)
		{
			return new ILDouble(item);
		}
	}
	public abstract partial class ILLiteral
	{
		static public implicit operator ILLiteral(double item)
		{
			return new ILDouble(item);
		}
	}

	public class ILString : ILLiteral
	{
		private string constant;

		public ILString(string c)
		{
			constant = c;
		}

		public override void RenderIL_Load(ILCanvas canvas)
		{
			canvas.Emit_Ldstr(constant);
		}

		public override void RenderText_Value(ILTextCanvas canvas)
		{
			canvas.AppendToLine(constant.StyleAsLiteralString());
		}

		public override Type GetValueType()
		{
			return typeof(string);
		}

		public override object GetLiteralValue()
		{
			return constant;
		}
	}
	public abstract partial class ILValue
	{
		static public implicit operator ILValue(string item)
		{
			return new ILString(item);
		}
	}
	public abstract partial class ILLiteral
	{
		static public implicit operator ILLiteral(string item)
		{
			return new ILString(item);
		}
	}

	public class ILTypeOf : ILLiteral
	{
		private Type constant;

		public ILTypeOf(Type c)
		{
			constant = c;
		}

		public override void RenderIL_Load(ILCanvas canvas)
		{
			canvas.Emit_Ldtoken(constant); canvas.Emit_Call(typeof(Type).GetStaticMethod<RuntimeTypeHandle>("GetTypeFromHandle"));
		}

		public override void RenderText_Value(ILTextCanvas canvas)
		{
			canvas.AppendToLine("typeof(" + constant.ToStringEX() + ")");
		}

		public override Type GetValueType()
		{
			return typeof(Type);
		}

		public override object GetLiteralValue()
		{
			return constant;
		}
	}
	public abstract partial class ILValue
	{
		static public implicit operator ILValue(Type item)
		{
			return new ILTypeOf(item);
		}
	}
	public abstract partial class ILLiteral
	{
		static public implicit operator ILLiteral(Type item)
		{
			return new ILTypeOf(item);
		}
	}
}
