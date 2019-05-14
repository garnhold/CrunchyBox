using System;
using System.Reflection;
using System.Reflection.Emit;

using CrunchyDough;
using CrunchySalt;

namespace CrunchySalt
{
	public enum BinaryOperatorType
	{
		Multiply,
		Divide,
		Modulo,
		Add,
		Subtract,
		And,
		Or,
		EqualTo,
		NotEqualTo,
		LessThan,
		LessThanOrEqualTo,
		GreaterThan,
		GreaterThanOrEqualTo,
	}

	static public class BinaryOperatorTypeExtensions
	{
		static public string GetSymbol(this BinaryOperatorType item)
		{
			switch(item)
			{
				case BinaryOperatorType.Multiply: return "*";
				case BinaryOperatorType.Divide: return "/";
				case BinaryOperatorType.Modulo: return "%";
				case BinaryOperatorType.Add: return "+";
				case BinaryOperatorType.Subtract: return "-";
				case BinaryOperatorType.And: return "&";
				case BinaryOperatorType.Or: return "|";
				case BinaryOperatorType.EqualTo: return "==";
				case BinaryOperatorType.NotEqualTo: return "!=";
				case BinaryOperatorType.LessThan: return "<";
				case BinaryOperatorType.LessThanOrEqualTo: return "<=";
				case BinaryOperatorType.GreaterThan: return ">";
				case BinaryOperatorType.GreaterThanOrEqualTo: return ">=";
			}

			throw new UnaccountedBranchException("item", item);
		}

		static public string GetSpecialName(this BinaryOperatorType item)
		{
			switch(item)
			{
				case BinaryOperatorType.Multiply: return "op_Multiply";
				case BinaryOperatorType.Divide: return "op_Divide";
				case BinaryOperatorType.Modulo: return "op_Modulo";
				case BinaryOperatorType.Add: return "op_Addition";
				case BinaryOperatorType.Subtract: return "op_Subtraction";
				case BinaryOperatorType.And: return "op_BitwiseAnd";
				case BinaryOperatorType.Or: return "op_BitwiseOr";
				case BinaryOperatorType.EqualTo: return "op_Equality";
				case BinaryOperatorType.NotEqualTo: return "op_Inequality";
				case BinaryOperatorType.LessThan: return "op_LessThan";
				case BinaryOperatorType.LessThanOrEqualTo: return "op_LessThanOrEqualTo";
				case BinaryOperatorType.GreaterThan: return "op_GreaterThan";
				case BinaryOperatorType.GreaterThanOrEqualTo: return "op_GreaterThanOrEqualTo";
			}

			throw new UnaccountedBranchException("item", item);
		}

		static public BinaryOperatorType GetBinaryOperatorTypeBySymbol(string symbol)
		{
			switch(symbol)
			{
				case "*": return BinaryOperatorType.Multiply;
				case "/": return BinaryOperatorType.Divide;
				case "%": return BinaryOperatorType.Modulo;
				case "+": return BinaryOperatorType.Add;
				case "-": return BinaryOperatorType.Subtract;
				case "&": return BinaryOperatorType.And;
				case "|": return BinaryOperatorType.Or;
				case "==": return BinaryOperatorType.EqualTo;
				case "!=": return BinaryOperatorType.NotEqualTo;
				case "<": return BinaryOperatorType.LessThan;
				case "<=": return BinaryOperatorType.LessThanOrEqualTo;
				case ">": return BinaryOperatorType.GreaterThan;
				case ">=": return BinaryOperatorType.GreaterThanOrEqualTo;
			}

			throw new UnaccountedBranchException("symbol", symbol);
		}

		static public BinaryOperatorType GetBinaryOperatorTypeByName(string name)
		{
			switch(name)
			{
				case "Multiply": return BinaryOperatorType.Multiply;
				case "Divide": return BinaryOperatorType.Divide;
				case "Modulo": return BinaryOperatorType.Modulo;
				case "Add": return BinaryOperatorType.Add;
				case "Subtract": return BinaryOperatorType.Subtract;
				case "And": return BinaryOperatorType.And;
				case "Or": return BinaryOperatorType.Or;
				case "EqualTo": return BinaryOperatorType.EqualTo;
				case "NotEqualTo": return BinaryOperatorType.NotEqualTo;
				case "LessThan": return BinaryOperatorType.LessThan;
				case "LessThanOrEqualTo": return BinaryOperatorType.LessThanOrEqualTo;
				case "GreaterThan": return BinaryOperatorType.GreaterThan;
				case "GreaterThanOrEqualTo": return BinaryOperatorType.GreaterThanOrEqualTo;
			}

			throw new UnaccountedBranchException("name", name);
		}
	}

	static public class TypeExtensions_BinaryOperatorInfo
	{
		static public BinaryOperatorInfoEX GetBinaryOperator(this Type item, Type right_type, BinaryOperatorType operator_type)
		{
			switch(operator_type)
			{
				case BinaryOperatorType.Multiply: return item.GetMultiplyBinaryOperator(right_type);
				case BinaryOperatorType.Divide: return item.GetDivideBinaryOperator(right_type);
				case BinaryOperatorType.Modulo: return item.GetModuloBinaryOperator(right_type);
				case BinaryOperatorType.Add: return item.GetAddBinaryOperator(right_type);
				case BinaryOperatorType.Subtract: return item.GetSubtractBinaryOperator(right_type);
				case BinaryOperatorType.And: return item.GetAndBinaryOperator(right_type);
				case BinaryOperatorType.Or: return item.GetOrBinaryOperator(right_type);
				case BinaryOperatorType.EqualTo: return item.GetEqualToBinaryOperator(right_type);
				case BinaryOperatorType.NotEqualTo: return item.GetNotEqualToBinaryOperator(right_type);
				case BinaryOperatorType.LessThan: return item.GetLessThanBinaryOperator(right_type);
				case BinaryOperatorType.LessThanOrEqualTo: return item.GetLessThanOrEqualToBinaryOperator(right_type);
				case BinaryOperatorType.GreaterThan: return item.GetGreaterThanBinaryOperator(right_type);
				case BinaryOperatorType.GreaterThanOrEqualTo: return item.GetGreaterThanOrEqualToBinaryOperator(right_type);
				
			}

			throw new UnaccountedBranchException("operator_type", operator_type);
		}

		static public BinaryOperatorInfoEX GetBinaryOperatorByName(this Type item, Type right_type, string name)
		{
			return item.GetBinaryOperator(right_type, BinaryOperatorTypeExtensions.GetBinaryOperatorTypeByName(name));
		}

		static public BinaryOperatorInfoEX GetBinaryOperatorBySymbol(this Type item, Type right_type, string symbol)
		{
			return item.GetBinaryOperator(right_type, BinaryOperatorTypeExtensions.GetBinaryOperatorTypeBySymbol(symbol));
		}

		static private OperationCache<BinaryOperatorInfoEX, Type, Type, BinaryOperatorType> GET_OVERLOADED_OPERATOR = ReflectionCache.Get().NewOperationCache(delegate(Type item, Type right, BinaryOperatorType operator_type) {
			string special_name = operator_type.GetSpecialName();
			Type[] parameter_types = new Type[] { item, right };

			return (item.GetStaticMethod(special_name, parameter_types) ?? 
				right.GetStaticMethod(special_name, parameter_types)
			)
			.IfNotNull(m => (BinaryOperatorInfoEX)new BinaryOperatorInfoEX_Method(operator_type, m));
		});
		static public BinaryOperatorInfoEX GetOverloadedBinaryOperator(this Type item, Type right_type, BinaryOperatorType operator_type)
		{
			return GET_OVERLOADED_OPERATOR.Fetch(item, right_type, operator_type);
		}

		static private OperationCache<BinaryOperatorInfoEX, Type, Type> GET_Multiply_OPERATOR = ReflectionCache.Get().NewOperationCache(delegate(Type item, Type right) {
	
			if(item.IsNumeric() && right.IsNumeric())
				return new BinaryOperatorInfoEX_Internal_Numeric_Multiply(item, right);
	
			BinaryOperatorInfoEX overloaded_operator = item.GetOverloadedBinaryOperator(right, BinaryOperatorType.Multiply);
			if(overloaded_operator != null)
				return overloaded_operator;
	
			throw new InvalidOperationException("No binary operator exists for the types " + item + " and " + right + ".");
		});
		static public BinaryOperatorInfoEX GetMultiplyBinaryOperator(this Type item, Type right)
		{
			return GET_Multiply_OPERATOR.Fetch(item, right);
		}

		static private OperationCache<BinaryOperatorInfoEX, Type, Type> GET_Divide_OPERATOR = ReflectionCache.Get().NewOperationCache(delegate(Type item, Type right) {
	
			if(item.IsNumeric() && right.IsNumeric())
				return new BinaryOperatorInfoEX_Internal_Numeric_Divide(item, right);
	
			BinaryOperatorInfoEX overloaded_operator = item.GetOverloadedBinaryOperator(right, BinaryOperatorType.Divide);
			if(overloaded_operator != null)
				return overloaded_operator;
	
			throw new InvalidOperationException("No binary operator exists for the types " + item + " and " + right + ".");
		});
		static public BinaryOperatorInfoEX GetDivideBinaryOperator(this Type item, Type right)
		{
			return GET_Divide_OPERATOR.Fetch(item, right);
		}

		static private OperationCache<BinaryOperatorInfoEX, Type, Type> GET_Modulo_OPERATOR = ReflectionCache.Get().NewOperationCache(delegate(Type item, Type right) {
	
			if(item.IsNumeric() && right.IsNumeric())
				return new BinaryOperatorInfoEX_Internal_Numeric_Modulo(item, right);
	
			BinaryOperatorInfoEX overloaded_operator = item.GetOverloadedBinaryOperator(right, BinaryOperatorType.Modulo);
			if(overloaded_operator != null)
				return overloaded_operator;
	
			throw new InvalidOperationException("No binary operator exists for the types " + item + " and " + right + ".");
		});
		static public BinaryOperatorInfoEX GetModuloBinaryOperator(this Type item, Type right)
		{
			return GET_Modulo_OPERATOR.Fetch(item, right);
		}

		static private OperationCache<BinaryOperatorInfoEX, Type, Type> GET_Add_OPERATOR = ReflectionCache.Get().NewOperationCache(delegate(Type item, Type right) {
	
			if(item.IsNumeric() && right.IsNumeric())
				return new BinaryOperatorInfoEX_Internal_Numeric_Add(item, right);
	
			if(item.IsString() || right.IsString())
				return new BinaryOperatorInfoEX_Internal_String_Add(item, right);
	
			BinaryOperatorInfoEX overloaded_operator = item.GetOverloadedBinaryOperator(right, BinaryOperatorType.Add);
			if(overloaded_operator != null)
				return overloaded_operator;
	
			throw new InvalidOperationException("No binary operator exists for the types " + item + " and " + right + ".");
		});
		static public BinaryOperatorInfoEX GetAddBinaryOperator(this Type item, Type right)
		{
			return GET_Add_OPERATOR.Fetch(item, right);
		}

		static private OperationCache<BinaryOperatorInfoEX, Type, Type> GET_Subtract_OPERATOR = ReflectionCache.Get().NewOperationCache(delegate(Type item, Type right) {
	
			if(item.IsNumeric() && right.IsNumeric())
				return new BinaryOperatorInfoEX_Internal_Numeric_Subtract(item, right);
	
			BinaryOperatorInfoEX overloaded_operator = item.GetOverloadedBinaryOperator(right, BinaryOperatorType.Subtract);
			if(overloaded_operator != null)
				return overloaded_operator;
	
			throw new InvalidOperationException("No binary operator exists for the types " + item + " and " + right + ".");
		});
		static public BinaryOperatorInfoEX GetSubtractBinaryOperator(this Type item, Type right)
		{
			return GET_Subtract_OPERATOR.Fetch(item, right);
		}

		static private OperationCache<BinaryOperatorInfoEX, Type, Type> GET_And_OPERATOR = ReflectionCache.Get().NewOperationCache(delegate(Type item, Type right) {
	
			if(item.IsBool() && right.IsBool())
				return new BinaryOperatorInfoEX_Internal_Bool_And(item, right);
	
			if(item.IsInteger() && right.IsInteger())
				return new BinaryOperatorInfoEX_Internal_Integer_And(item, right);
	
			BinaryOperatorInfoEX overloaded_operator = item.GetOverloadedBinaryOperator(right, BinaryOperatorType.And);
			if(overloaded_operator != null)
				return overloaded_operator;
	
			throw new InvalidOperationException("No binary operator exists for the types " + item + " and " + right + ".");
		});
		static public BinaryOperatorInfoEX GetAndBinaryOperator(this Type item, Type right)
		{
			return GET_And_OPERATOR.Fetch(item, right);
		}

		static private OperationCache<BinaryOperatorInfoEX, Type, Type> GET_Or_OPERATOR = ReflectionCache.Get().NewOperationCache(delegate(Type item, Type right) {
	
			if(item.IsBool() && right.IsBool())
				return new BinaryOperatorInfoEX_Internal_Bool_Or(item, right);
	
			if(item.IsInteger() && right.IsInteger())
				return new BinaryOperatorInfoEX_Internal_Integer_Or(item, right);
	
			BinaryOperatorInfoEX overloaded_operator = item.GetOverloadedBinaryOperator(right, BinaryOperatorType.Or);
			if(overloaded_operator != null)
				return overloaded_operator;
	
			throw new InvalidOperationException("No binary operator exists for the types " + item + " and " + right + ".");
		});
		static public BinaryOperatorInfoEX GetOrBinaryOperator(this Type item, Type right)
		{
			return GET_Or_OPERATOR.Fetch(item, right);
		}

		static private OperationCache<BinaryOperatorInfoEX, Type, Type> GET_EqualTo_OPERATOR = ReflectionCache.Get().NewOperationCache(delegate(Type item, Type right) {
	
			if(item.IsBool() && right.IsBool())
				return new BinaryOperatorInfoEX_Internal_Bool_EqualTo(item, right);
	
			if(item.IsNumeric() && right.IsNumeric())
				return new BinaryOperatorInfoEX_Internal_Numeric_EqualTo(item, right);
	
			BinaryOperatorInfoEX overloaded_operator = item.GetOverloadedBinaryOperator(right, BinaryOperatorType.EqualTo);
			if(overloaded_operator != null)
				return overloaded_operator;
	
			if(item.IsReferenceType() && right.IsReferenceType())
				return new BinaryOperatorInfoEX_Internal_Object_EqualTo(item, right);
	
			throw new InvalidOperationException("No binary operator exists for the types " + item + " and " + right + ".");
		});
		static public BinaryOperatorInfoEX GetEqualToBinaryOperator(this Type item, Type right)
		{
			return GET_EqualTo_OPERATOR.Fetch(item, right);
		}

		static private OperationCache<BinaryOperatorInfoEX, Type, Type> GET_NotEqualTo_OPERATOR = ReflectionCache.Get().NewOperationCache(delegate(Type item, Type right) {
	
			if(item.IsBool() && right.IsBool())
				return new BinaryOperatorInfoEX_Internal_Bool_NotEqualTo(item, right);
	
			if(item.IsNumeric() && right.IsNumeric())
				return new BinaryOperatorInfoEX_Internal_Numeric_NotEqualTo(item, right);
	
			BinaryOperatorInfoEX overloaded_operator = item.GetOverloadedBinaryOperator(right, BinaryOperatorType.NotEqualTo);
			if(overloaded_operator != null)
				return overloaded_operator;
	
			if(item.IsReferenceType() && right.IsReferenceType())
				return new BinaryOperatorInfoEX_Internal_Object_NotEqualTo(item, right);
	
			throw new InvalidOperationException("No binary operator exists for the types " + item + " and " + right + ".");
		});
		static public BinaryOperatorInfoEX GetNotEqualToBinaryOperator(this Type item, Type right)
		{
			return GET_NotEqualTo_OPERATOR.Fetch(item, right);
		}

		static private OperationCache<BinaryOperatorInfoEX, Type, Type> GET_LessThan_OPERATOR = ReflectionCache.Get().NewOperationCache(delegate(Type item, Type right) {
	
			if(item.IsNumeric() && right.IsNumeric())
				return new BinaryOperatorInfoEX_Internal_Numeric_LessThan(item, right);
	
			BinaryOperatorInfoEX overloaded_operator = item.GetOverloadedBinaryOperator(right, BinaryOperatorType.LessThan);
			if(overloaded_operator != null)
				return overloaded_operator;
	
			throw new InvalidOperationException("No binary operator exists for the types " + item + " and " + right + ".");
		});
		static public BinaryOperatorInfoEX GetLessThanBinaryOperator(this Type item, Type right)
		{
			return GET_LessThan_OPERATOR.Fetch(item, right);
		}

		static private OperationCache<BinaryOperatorInfoEX, Type, Type> GET_LessThanOrEqualTo_OPERATOR = ReflectionCache.Get().NewOperationCache(delegate(Type item, Type right) {
	
			if(item.IsNumeric() && right.IsNumeric())
				return new BinaryOperatorInfoEX_Internal_Numeric_LessThanOrEqualTo(item, right);
	
			BinaryOperatorInfoEX overloaded_operator = item.GetOverloadedBinaryOperator(right, BinaryOperatorType.LessThanOrEqualTo);
			if(overloaded_operator != null)
				return overloaded_operator;
	
			throw new InvalidOperationException("No binary operator exists for the types " + item + " and " + right + ".");
		});
		static public BinaryOperatorInfoEX GetLessThanOrEqualToBinaryOperator(this Type item, Type right)
		{
			return GET_LessThanOrEqualTo_OPERATOR.Fetch(item, right);
		}

		static private OperationCache<BinaryOperatorInfoEX, Type, Type> GET_GreaterThan_OPERATOR = ReflectionCache.Get().NewOperationCache(delegate(Type item, Type right) {
	
			if(item.IsNumeric() && right.IsNumeric())
				return new BinaryOperatorInfoEX_Internal_Numeric_GreaterThan(item, right);
	
			BinaryOperatorInfoEX overloaded_operator = item.GetOverloadedBinaryOperator(right, BinaryOperatorType.GreaterThan);
			if(overloaded_operator != null)
				return overloaded_operator;
	
			throw new InvalidOperationException("No binary operator exists for the types " + item + " and " + right + ".");
		});
		static public BinaryOperatorInfoEX GetGreaterThanBinaryOperator(this Type item, Type right)
		{
			return GET_GreaterThan_OPERATOR.Fetch(item, right);
		}

		static private OperationCache<BinaryOperatorInfoEX, Type, Type> GET_GreaterThanOrEqualTo_OPERATOR = ReflectionCache.Get().NewOperationCache(delegate(Type item, Type right) {
	
			if(item.IsNumeric() && right.IsNumeric())
				return new BinaryOperatorInfoEX_Internal_Numeric_GreaterThanOrEqualTo(item, right);
	
			BinaryOperatorInfoEX overloaded_operator = item.GetOverloadedBinaryOperator(right, BinaryOperatorType.GreaterThanOrEqualTo);
			if(overloaded_operator != null)
				return overloaded_operator;
	
			throw new InvalidOperationException("No binary operator exists for the types " + item + " and " + right + ".");
		});
		static public BinaryOperatorInfoEX GetGreaterThanOrEqualToBinaryOperator(this Type item, Type right)
		{
			return GET_GreaterThanOrEqualTo_OPERATOR.Fetch(item, right);
		}

	}


	public class BinaryOperatorInfoEX_Internal_Bool_And : BinaryOperatorInfoEX_Internal
	{
		public BinaryOperatorInfoEX_Internal_Bool_And(Type l, Type r) : base(BinaryOperatorType.And, typeof(bool), l, r, typeof(bool)) { }

		public override void RenderIL_Operate(ILCanvas canvas, ILValue left, ILValue right)
		{
			LoadValues(canvas, left, right); canvas.Emit_And();
		}
	}
	public class BinaryOperatorInfoEX_Internal_Bool_Or : BinaryOperatorInfoEX_Internal
	{
		public BinaryOperatorInfoEX_Internal_Bool_Or(Type l, Type r) : base(BinaryOperatorType.Or, typeof(bool), l, r, typeof(bool)) { }

		public override void RenderIL_Operate(ILCanvas canvas, ILValue left, ILValue right)
		{
			LoadValues(canvas, left, right); canvas.Emit_Or();
		}
	}
	public class BinaryOperatorInfoEX_Internal_Bool_EqualTo : BinaryOperatorInfoEX_Internal
	{
		public BinaryOperatorInfoEX_Internal_Bool_EqualTo(Type l, Type r) : base(BinaryOperatorType.EqualTo, typeof(bool), l, r, typeof(bool)) { }

		public override void RenderIL_Operate(ILCanvas canvas, ILValue left, ILValue right)
		{
			LoadValues(canvas, left, right); canvas.Emit_Ceq();
		}
	}
	public class BinaryOperatorInfoEX_Internal_Bool_NotEqualTo : BinaryOperatorInfoEX_Internal
	{
		public BinaryOperatorInfoEX_Internal_Bool_NotEqualTo(Type l, Type r) : base(BinaryOperatorType.NotEqualTo, typeof(bool), l, r, typeof(bool)) { }

		public override void RenderIL_Operate(ILCanvas canvas, ILValue left, ILValue right)
		{
			LoadValues(canvas, left, right); canvas.Emit_Ceq(); canvas.Emit_Not();
		}
	}

	public class BinaryOperatorInfoEX_Internal_Integer_And : BinaryOperatorInfoEX_Internal
	{
		public BinaryOperatorInfoEX_Internal_Integer_And(Type l, Type r) : base(BinaryOperatorType.And, Numeric.GetMostPrecedentType(l, r), l, r, Numeric.GetMostPrecedentType(l, r)) { }

		public override void RenderIL_Operate(ILCanvas canvas, ILValue left, ILValue right)
		{
			LoadValues(canvas, left, right); canvas.Emit_And();
		}
	}
	public class BinaryOperatorInfoEX_Internal_Integer_Or : BinaryOperatorInfoEX_Internal
	{
		public BinaryOperatorInfoEX_Internal_Integer_Or(Type l, Type r) : base(BinaryOperatorType.Or, Numeric.GetMostPrecedentType(l, r), l, r, Numeric.GetMostPrecedentType(l, r)) { }

		public override void RenderIL_Operate(ILCanvas canvas, ILValue left, ILValue right)
		{
			LoadValues(canvas, left, right); canvas.Emit_Or();
		}
	}

	public class BinaryOperatorInfoEX_Internal_Numeric_Multiply : BinaryOperatorInfoEX_Internal
	{
		public BinaryOperatorInfoEX_Internal_Numeric_Multiply(Type l, Type r) : base(BinaryOperatorType.Multiply, Numeric.GetMostPrecedentType(l, r), l, r, Numeric.GetMostPrecedentType(l, r)) { }

		public override void RenderIL_Operate(ILCanvas canvas, ILValue left, ILValue right)
		{
			LoadValues(canvas, left, right); canvas.Emit_Mul();
		}
	}
	public class BinaryOperatorInfoEX_Internal_Numeric_Divide : BinaryOperatorInfoEX_Internal
	{
		public BinaryOperatorInfoEX_Internal_Numeric_Divide(Type l, Type r) : base(BinaryOperatorType.Divide, Numeric.GetMostPrecedentType(l, r), l, r, Numeric.GetMostPrecedentType(l, r)) { }

		public override void RenderIL_Operate(ILCanvas canvas, ILValue left, ILValue right)
		{
			LoadValues(canvas, left, right); canvas.Emit_Div();
		}
	}
	public class BinaryOperatorInfoEX_Internal_Numeric_Modulo : BinaryOperatorInfoEX_Internal
	{
		public BinaryOperatorInfoEX_Internal_Numeric_Modulo(Type l, Type r) : base(BinaryOperatorType.Modulo, Numeric.GetMostPrecedentType(l, r), l, r, Numeric.GetMostPrecedentType(l, r)) { }

		public override void RenderIL_Operate(ILCanvas canvas, ILValue left, ILValue right)
		{
			LoadValues(canvas, left, right); canvas.Emit_Rem();
		}
	}
	public class BinaryOperatorInfoEX_Internal_Numeric_Add : BinaryOperatorInfoEX_Internal
	{
		public BinaryOperatorInfoEX_Internal_Numeric_Add(Type l, Type r) : base(BinaryOperatorType.Add, Numeric.GetMostPrecedentType(l, r), l, r, Numeric.GetMostPrecedentType(l, r)) { }

		public override void RenderIL_Operate(ILCanvas canvas, ILValue left, ILValue right)
		{
			LoadValues(canvas, left, right); canvas.Emit_Add();
		}
	}
	public class BinaryOperatorInfoEX_Internal_Numeric_Subtract : BinaryOperatorInfoEX_Internal
	{
		public BinaryOperatorInfoEX_Internal_Numeric_Subtract(Type l, Type r) : base(BinaryOperatorType.Subtract, Numeric.GetMostPrecedentType(l, r), l, r, Numeric.GetMostPrecedentType(l, r)) { }

		public override void RenderIL_Operate(ILCanvas canvas, ILValue left, ILValue right)
		{
			LoadValues(canvas, left, right); canvas.Emit_Sub();
		}
	}
	public class BinaryOperatorInfoEX_Internal_Numeric_EqualTo : BinaryOperatorInfoEX_Internal
	{
		public BinaryOperatorInfoEX_Internal_Numeric_EqualTo(Type l, Type r) : base(BinaryOperatorType.EqualTo, Numeric.GetMostPrecedentType(l, r), l, r, typeof(bool)) { }

		public override void RenderIL_Operate(ILCanvas canvas, ILValue left, ILValue right)
		{
			LoadValues(canvas, left, right); canvas.Emit_Ceq();
		}
	}
	public class BinaryOperatorInfoEX_Internal_Numeric_NotEqualTo : BinaryOperatorInfoEX_Internal
	{
		public BinaryOperatorInfoEX_Internal_Numeric_NotEqualTo(Type l, Type r) : base(BinaryOperatorType.NotEqualTo, Numeric.GetMostPrecedentType(l, r), l, r, typeof(bool)) { }

		public override void RenderIL_Operate(ILCanvas canvas, ILValue left, ILValue right)
		{
			LoadValues(canvas, left, right); canvas.Emit_Ceq(); canvas.Emit_Not();
		}
	}
	public class BinaryOperatorInfoEX_Internal_Numeric_LessThan : BinaryOperatorInfoEX_Internal
	{
		public BinaryOperatorInfoEX_Internal_Numeric_LessThan(Type l, Type r) : base(BinaryOperatorType.LessThan, Numeric.GetMostPrecedentType(l, r), l, r, typeof(bool)) { }

		public override void RenderIL_Operate(ILCanvas canvas, ILValue left, ILValue right)
		{
			LoadValues(canvas, left, right); canvas.Emit_Clt();
		}
	}
	public class BinaryOperatorInfoEX_Internal_Numeric_LessThanOrEqualTo : BinaryOperatorInfoEX_Internal
	{
		public BinaryOperatorInfoEX_Internal_Numeric_LessThanOrEqualTo(Type l, Type r) : base(BinaryOperatorType.LessThanOrEqualTo, Numeric.GetMostPrecedentType(l, r), l, r, typeof(bool)) { }

		public override void RenderIL_Operate(ILCanvas canvas, ILValue left, ILValue right)
		{
			LoadValues(canvas, left, right); canvas.Emit_Cgt(); canvas.Emit_Not();
		}
	}
	public class BinaryOperatorInfoEX_Internal_Numeric_GreaterThan : BinaryOperatorInfoEX_Internal
	{
		public BinaryOperatorInfoEX_Internal_Numeric_GreaterThan(Type l, Type r) : base(BinaryOperatorType.GreaterThan, Numeric.GetMostPrecedentType(l, r), l, r, typeof(bool)) { }

		public override void RenderIL_Operate(ILCanvas canvas, ILValue left, ILValue right)
		{
			LoadValues(canvas, left, right); canvas.Emit_Cgt();
		}
	}
	public class BinaryOperatorInfoEX_Internal_Numeric_GreaterThanOrEqualTo : BinaryOperatorInfoEX_Internal
	{
		public BinaryOperatorInfoEX_Internal_Numeric_GreaterThanOrEqualTo(Type l, Type r) : base(BinaryOperatorType.GreaterThanOrEqualTo, Numeric.GetMostPrecedentType(l, r), l, r, typeof(bool)) { }

		public override void RenderIL_Operate(ILCanvas canvas, ILValue left, ILValue right)
		{
			LoadValues(canvas, left, right); canvas.Emit_Clt(); canvas.Emit_Not();
		}
	}

	public class BinaryOperatorInfoEX_Internal_String_Add : BinaryOperatorInfoEX_Internal
	{
		public BinaryOperatorInfoEX_Internal_String_Add(Type l, Type r) : base(BinaryOperatorType.Add, typeof(string), l, r, typeof(string)) { }

		public override void RenderIL_Operate(ILCanvas canvas, ILValue left, ILValue right)
		{
			typeof(string).GetStaticILMethodInvokation("Concat", left, right).RenderIL_Load(canvas);
		}
	}

	public class BinaryOperatorInfoEX_Internal_Object_EqualTo : BinaryOperatorInfoEX_Internal
	{
		public BinaryOperatorInfoEX_Internal_Object_EqualTo(Type l, Type r) : base(BinaryOperatorType.EqualTo, typeof(object), l, r, typeof(bool)) { }

		public override void RenderIL_Operate(ILCanvas canvas, ILValue left, ILValue right)
		{
			typeof(ObjectExtensions_Compare).GetStaticILMethodInvokation("EqualsEX", left, right).RenderIL_Load(canvas);
		}
	}
	public class BinaryOperatorInfoEX_Internal_Object_NotEqualTo : BinaryOperatorInfoEX_Internal
	{
		public BinaryOperatorInfoEX_Internal_Object_NotEqualTo(Type l, Type r) : base(BinaryOperatorType.NotEqualTo, typeof(object), l, r, typeof(bool)) { }

		public override void RenderIL_Operate(ILCanvas canvas, ILValue left, ILValue right)
		{
			typeof(ObjectExtensions_Compare).GetStaticILMethodInvokation("NotEqualsEX", left, right).RenderIL_Load(canvas);
		}
	}
}

