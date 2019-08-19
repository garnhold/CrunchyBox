using System;
using System.Reflection;
using System.Reflection.Emit;

using CrunchyDough;
using CrunchySalt;

namespace CrunchySalt
{
	public enum UnaryOperatorType
	{
		NumericNegate,
		LogicalNegate,
		OnesComplement,
	}

	static public class UnaryOperatorTypeExtensions
	{
		static public string GetSymbol(this UnaryOperatorType item)
		{
			switch(item)
			{
				case UnaryOperatorType.NumericNegate: return "-";
				case UnaryOperatorType.LogicalNegate: return "!";
				case UnaryOperatorType.OnesComplement: return "~";
			}

			throw new UnaccountedBranchException("item", item);
		}

		static public string GetSpecialName(this UnaryOperatorType item)
		{
			switch(item)
			{
				case UnaryOperatorType.NumericNegate: return "op_UnaryNegation";
				case UnaryOperatorType.LogicalNegate: return "op_LogicalUnaryNegation";
				case UnaryOperatorType.OnesComplement: return "op_OnesComplement";
			}

			throw new UnaccountedBranchException("item", item);
		}

		static public UnaryOperatorType GetUnaryOperatorTypeBySymbol(string symbol)
		{
			switch(symbol)
			{
				case "-": return UnaryOperatorType.NumericNegate;
				case "!": return UnaryOperatorType.LogicalNegate;
				case "~": return UnaryOperatorType.OnesComplement;
			}

			throw new UnaccountedBranchException("symbol", symbol);
		}

		static public UnaryOperatorType GetUnaryOperatorTypeByName(string name)
		{
			switch(name)
			{
				case "NumericNegate": return UnaryOperatorType.NumericNegate;
				case "LogicalNegate": return UnaryOperatorType.LogicalNegate;
				case "OnesComplement": return UnaryOperatorType.OnesComplement;
			}

			throw new UnaccountedBranchException("name", name);
		}
	}

	static public class TypeExtensions_UnaryOperatorInfo
	{
		static public UnaryOperatorInfoEX GetUnaryOperator(this Type item, UnaryOperatorType operator_type)
		{
			switch(operator_type)
			{
				case UnaryOperatorType.NumericNegate: return item.GetNumericNegateUnaryOperator();
				case UnaryOperatorType.LogicalNegate: return item.GetLogicalNegateUnaryOperator();
				case UnaryOperatorType.OnesComplement: return item.GetOnesComplementUnaryOperator();
				
			}

			throw new UnaccountedBranchException("operator_type", operator_type);
		}

		static public UnaryOperatorInfoEX GetUnaryOperatorByName(this Type item, string name)
		{
			return item.GetUnaryOperator(UnaryOperatorTypeExtensions.GetUnaryOperatorTypeByName(name));
		}

		static public UnaryOperatorInfoEX GetUnaryOperatorBySymbol(this Type item, string symbol)
		{
			return item.GetUnaryOperator(UnaryOperatorTypeExtensions.GetUnaryOperatorTypeBySymbol(symbol));
		}

		static private OperationCache<UnaryOperatorInfoEX, Type, UnaryOperatorType> GET_OVERLOADED_OPERATOR = ReflectionCache.Get().NewOperationCache("GET_OVERLOADED_OPERATOR", delegate(Type item, UnaryOperatorType operator_type) {
			string special_name = operator_type.GetSpecialName();
			Type[] parameter_types = new Type[] { item };

			return item.GetStaticMethod(special_name, parameter_types)
				.IfNotNull(m => (UnaryOperatorInfoEX)new UnaryOperatorInfoEX_Method(operator_type, m));
		});
		static public UnaryOperatorInfoEX GetOverloadedUnaryOperator(this Type item, UnaryOperatorType operator_type)
		{
			return GET_OVERLOADED_OPERATOR.Fetch(item, operator_type);
		}

		static private OperationCache<UnaryOperatorInfoEX, Type> GET_NumericNegate_OPERATOR = ReflectionCache.Get().NewOperationCache("GET_NumericNegate_OPERATOR", delegate(Type item) {
	
			if(item.IsNumeric())
				return new UnaryOperatorInfoEX_Internal_Numeric_NumericNegate(item);
	
			UnaryOperatorInfoEX overloaded_operator = item.GetOverloadedUnaryOperator(UnaryOperatorType.NumericNegate);
			if(overloaded_operator != null)
				return overloaded_operator;
	
			throw new InvalidOperationException("No unary operator exists for the type " + item + ".");
		});
		static public UnaryOperatorInfoEX GetNumericNegateUnaryOperator(this Type item)
		{
			return GET_NumericNegate_OPERATOR.Fetch(item);
		}

		static private OperationCache<UnaryOperatorInfoEX, Type> GET_LogicalNegate_OPERATOR = ReflectionCache.Get().NewOperationCache("GET_LogicalNegate_OPERATOR", delegate(Type item) {
	
			if(item.IsBool())
				return new UnaryOperatorInfoEX_Internal_Bool_LogicalNegate(item);
	
			UnaryOperatorInfoEX overloaded_operator = item.GetOverloadedUnaryOperator(UnaryOperatorType.LogicalNegate);
			if(overloaded_operator != null)
				return overloaded_operator;
	
			throw new InvalidOperationException("No unary operator exists for the type " + item + ".");
		});
		static public UnaryOperatorInfoEX GetLogicalNegateUnaryOperator(this Type item)
		{
			return GET_LogicalNegate_OPERATOR.Fetch(item);
		}

		static private OperationCache<UnaryOperatorInfoEX, Type> GET_OnesComplement_OPERATOR = ReflectionCache.Get().NewOperationCache("GET_OnesComplement_OPERATOR", delegate(Type item) {
	
			if(item.IsInteger())
				return new UnaryOperatorInfoEX_Internal_Integer_OnesComplement(item);
	
			UnaryOperatorInfoEX overloaded_operator = item.GetOverloadedUnaryOperator(UnaryOperatorType.OnesComplement);
			if(overloaded_operator != null)
				return overloaded_operator;
	
			throw new InvalidOperationException("No unary operator exists for the type " + item + ".");
		});
		static public UnaryOperatorInfoEX GetOnesComplementUnaryOperator(this Type item)
		{
			return GET_OnesComplement_OPERATOR.Fetch(item);
		}

	}


	public class UnaryOperatorInfoEX_Internal_Bool_LogicalNegate : UnaryOperatorInfoEX_Internal
	{
		public UnaryOperatorInfoEX_Internal_Bool_LogicalNegate(Type i) : base(UnaryOperatorType.LogicalNegate, i, typeof(bool)) { }

		public override void RenderIL_Operate(ILCanvas canvas, ILValue input)
		{
			LoadValue(canvas, input); canvas.Emit_LNot();
		}
	}

	public class UnaryOperatorInfoEX_Internal_Integer_OnesComplement : UnaryOperatorInfoEX_Internal
	{
		public UnaryOperatorInfoEX_Internal_Integer_OnesComplement(Type i) : base(UnaryOperatorType.OnesComplement, i, i) { }

		public override void RenderIL_Operate(ILCanvas canvas, ILValue input)
		{
			LoadValue(canvas, input); canvas.Emit_Not();
		}
	}

	public class UnaryOperatorInfoEX_Internal_Numeric_NumericNegate : UnaryOperatorInfoEX_Internal
	{
		public UnaryOperatorInfoEX_Internal_Numeric_NumericNegate(Type i) : base(UnaryOperatorType.NumericNegate, i, i) { }

		public override void RenderIL_Operate(ILCanvas canvas, ILValue input)
		{
			LoadValue(canvas, input); canvas.Emit_Neg();
		}
	}
}

