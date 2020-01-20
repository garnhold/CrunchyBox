
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: January 19 2020 23:05:45 -08:00

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Noodle;

using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace Crunchy.Cheese
{
	public partial class MExpEntry : MExpElement
	{
		[RelatableChild]private HoldingSingle<MExpElement, MExpExpression> m_exp_expression;
		static public MExpEntry DOMify(MExpParser.MExpEntryContext context)
		{
			if(context != null)
			{
				return new MExpEntry(context);
			}
			
			return null;
		}
		
		static public MExpEntry DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as MExpParser.MExpEntryContext);
		}
		
		static public MExpEntry DOMify(Stream stream)
		{
			return DOMify(MExpDOMinatorUtilities.CreateParser(stream).mExpEntry());
		}
		
		static public MExpEntry DOMify(string text)
		{
			return DOMify(MExpDOMinatorUtilities.CreateParser(text).mExpEntry());
		}
		
		static public MExpEntry DOMifyFile(string filename)
		{
			return DOMify(MExpDOMinatorUtilities.CreateFileParser(filename).mExpEntry());
		}
		
		public MExpEntry()
		{
			m_exp_expression = new HoldingSingle<MExpElement, MExpExpression>(this);
			OnConstructor();
		}
		
		partial void OnConstructor();
		public MExpEntry(MExpParser.MExpEntryContext context) : this()
		{
			SetMExpExpression(MExpExpression.DOMify(context.mExpExpression()));
		}
		
		public MExpEntry Duplicate()
		{
			MExpEntry instance = new MExpEntry();
			instance.SetMExpExpression(GetMExpExpression().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetMExpExpression(MExpExpression input)
		{
			m_exp_expression.Set(input);
		}
		
		public MExpExpression GetMExpExpression()
		{
			return m_exp_expression.Get();
		}
		
	}
	
	public abstract partial class MExpExpression : MExpElement
	{
		public abstract MExpExpression Duplicate();
		static public MExpExpression DOMify(MExpParser.MExpExpressionContext context)
		{
			return MExpResolver.Resolve<MExpExpression>(context);
		}
		
		static public MExpExpression DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as MExpParser.MExpExpressionContext);
		}
		
		static public MExpExpression DOMify(Stream stream)
		{
			return DOMify(MExpDOMinatorUtilities.CreateParser(stream).mExpExpression());
		}
		
		static public MExpExpression DOMify(string text)
		{
			return DOMify(MExpDOMinatorUtilities.CreateParser(text).mExpExpression());
		}
		
		static public MExpExpression DOMifyFile(string filename)
		{
			return DOMify(MExpDOMinatorUtilities.CreateFileParser(filename).mExpExpression());
		}
		
	}
	
	public partial class MExpExpression_Constant : MExpExpression
	{
		private float number;
		static public MExpExpression_Constant DOMify(MExpParser.MExpExpression_ConstantContext context)
		{
			if(context != null)
			{
				return new MExpExpression_Constant(context);
			}
			
			return null;
		}
		
		static new public MExpExpression_Constant DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as MExpParser.MExpExpression_ConstantContext);
		}
		
		static new public MExpExpression_Constant DOMify(Stream stream)
		{
			return DOMify(MExpDOMinatorUtilities.CreateParser(stream).mExpExpression());
		}
		
		static new public MExpExpression_Constant DOMify(string text)
		{
			return DOMify(MExpDOMinatorUtilities.CreateParser(text).mExpExpression());
		}
		
		static new public MExpExpression_Constant DOMifyFile(string filename)
		{
			return DOMify(MExpDOMinatorUtilities.CreateFileParser(filename).mExpExpression());
		}
		
		public MExpExpression_Constant()
		{
			number = 0.0f;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public MExpExpression_Constant(MExpParser.MExpExpression_ConstantContext context) : this()
		{
			SetNumber(context.NUMBER().GetTextEX().ParseFloat());
		}
		
		public override MExpExpression Duplicate()
		{
			MExpExpression_Constant instance = new MExpExpression_Constant();
			instance.SetNumber(GetNumber());
			return instance;
		}
		
		private void SetNumber(float input)
		{
			number = input;
		}
		
		public float GetNumber()
		{
			return number;
		}
		
	}
	
	public partial class MExpExpression_Term : MExpExpression
	{
		private string id;
		static public MExpExpression_Term DOMify(MExpParser.MExpExpression_TermContext context)
		{
			if(context != null)
			{
				return new MExpExpression_Term(context);
			}
			
			return null;
		}
		
		static new public MExpExpression_Term DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as MExpParser.MExpExpression_TermContext);
		}
		
		static new public MExpExpression_Term DOMify(Stream stream)
		{
			return DOMify(MExpDOMinatorUtilities.CreateParser(stream).mExpExpression());
		}
		
		static new public MExpExpression_Term DOMify(string text)
		{
			return DOMify(MExpDOMinatorUtilities.CreateParser(text).mExpExpression());
		}
		
		static new public MExpExpression_Term DOMifyFile(string filename)
		{
			return DOMify(MExpDOMinatorUtilities.CreateFileParser(filename).mExpExpression());
		}
		
		public MExpExpression_Term()
		{
			id = "";
			OnConstructor();
		}
		
		partial void OnConstructor();
		public MExpExpression_Term(MExpParser.MExpExpression_TermContext context) : this()
		{
			SetId(context.ID().GetTextEX());
		}
		
		public override MExpExpression Duplicate()
		{
			MExpExpression_Term instance = new MExpExpression_Term();
			instance.SetId(GetId());
			return instance;
		}
		
		private void SetId(string input)
		{
			id = input;
		}
		
		public string GetId()
		{
			return id;
		}
		
	}
	
	public partial class MExpExpression_Function : MExpExpression
	{
		[RelatableChild]private HoldingSingle<MExpElement, MExpFunction> m_exp_function;
		static public MExpExpression_Function DOMify(MExpParser.MExpExpression_FunctionContext context)
		{
			if(context != null)
			{
				return new MExpExpression_Function(context);
			}
			
			return null;
		}
		
		static new public MExpExpression_Function DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as MExpParser.MExpExpression_FunctionContext);
		}
		
		static new public MExpExpression_Function DOMify(Stream stream)
		{
			return DOMify(MExpDOMinatorUtilities.CreateParser(stream).mExpExpression());
		}
		
		static new public MExpExpression_Function DOMify(string text)
		{
			return DOMify(MExpDOMinatorUtilities.CreateParser(text).mExpExpression());
		}
		
		static new public MExpExpression_Function DOMifyFile(string filename)
		{
			return DOMify(MExpDOMinatorUtilities.CreateFileParser(filename).mExpExpression());
		}
		
		public MExpExpression_Function()
		{
			m_exp_function = new HoldingSingle<MExpElement, MExpFunction>(this);
			OnConstructor();
		}
		
		partial void OnConstructor();
		public MExpExpression_Function(MExpParser.MExpExpression_FunctionContext context) : this()
		{
			SetMExpFunction(MExpFunction.DOMify(context.mExpFunction()));
		}
		
		public override MExpExpression Duplicate()
		{
			MExpExpression_Function instance = new MExpExpression_Function();
			instance.SetMExpFunction(GetMExpFunction().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetMExpFunction(MExpFunction input)
		{
			m_exp_function.Set(input);
		}
		
		public MExpFunction GetMExpFunction()
		{
			return m_exp_function.Get();
		}
		
	}
	
	public partial class MExpExpression_Group : MExpExpression
	{
		[RelatableChild]private HoldingSingle<MExpElement, MExpExpression> m_exp_expression;
		static public MExpExpression_Group DOMify(MExpParser.MExpExpression_GroupContext context)
		{
			if(context != null)
			{
				return new MExpExpression_Group(context);
			}
			
			return null;
		}
		
		static new public MExpExpression_Group DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as MExpParser.MExpExpression_GroupContext);
		}
		
		static new public MExpExpression_Group DOMify(Stream stream)
		{
			return DOMify(MExpDOMinatorUtilities.CreateParser(stream).mExpExpression());
		}
		
		static new public MExpExpression_Group DOMify(string text)
		{
			return DOMify(MExpDOMinatorUtilities.CreateParser(text).mExpExpression());
		}
		
		static new public MExpExpression_Group DOMifyFile(string filename)
		{
			return DOMify(MExpDOMinatorUtilities.CreateFileParser(filename).mExpExpression());
		}
		
		public MExpExpression_Group()
		{
			m_exp_expression = new HoldingSingle<MExpElement, MExpExpression>(this);
			OnConstructor();
		}
		
		partial void OnConstructor();
		public MExpExpression_Group(MExpParser.MExpExpression_GroupContext context) : this()
		{
			SetMExpExpression(MExpExpression.DOMify(context.mExpExpression()));
		}
		
		public override MExpExpression Duplicate()
		{
			MExpExpression_Group instance = new MExpExpression_Group();
			instance.SetMExpExpression(GetMExpExpression().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetMExpExpression(MExpExpression input)
		{
			m_exp_expression.Set(input);
		}
		
		public MExpExpression GetMExpExpression()
		{
			return m_exp_expression.Get();
		}
		
	}
	
	public partial class MExpExpression_Sign : MExpExpression
	{
		[RelatableChild]private HoldingSingle<MExpElement, MExpUnaryOperator_Sign> m_exp_unary_sign_operator;
		[RelatableChild]private HoldingSingle<MExpElement, MExpExpression> m_exp_expression;
		static public MExpExpression_Sign DOMify(MExpParser.MExpExpression_SignContext context)
		{
			if(context != null)
			{
				return new MExpExpression_Sign(context);
			}
			
			return null;
		}
		
		static new public MExpExpression_Sign DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as MExpParser.MExpExpression_SignContext);
		}
		
		static new public MExpExpression_Sign DOMify(Stream stream)
		{
			return DOMify(MExpDOMinatorUtilities.CreateParser(stream).mExpExpression());
		}
		
		static new public MExpExpression_Sign DOMify(string text)
		{
			return DOMify(MExpDOMinatorUtilities.CreateParser(text).mExpExpression());
		}
		
		static new public MExpExpression_Sign DOMifyFile(string filename)
		{
			return DOMify(MExpDOMinatorUtilities.CreateFileParser(filename).mExpExpression());
		}
		
		public MExpExpression_Sign()
		{
			m_exp_unary_sign_operator = new HoldingSingle<MExpElement, MExpUnaryOperator_Sign>(this);
			m_exp_expression = new HoldingSingle<MExpElement, MExpExpression>(this);
			OnConstructor();
		}
		
		partial void OnConstructor();
		public MExpExpression_Sign(MExpParser.MExpExpression_SignContext context) : this()
		{
			SetMExpUnarySignOperator(MExpUnaryOperator_Sign.DOMify(context.mExpUnarySignOperator()));
			SetMExpExpression(MExpExpression.DOMify(context.mExpExpression()));
		}
		
		public override MExpExpression Duplicate()
		{
			MExpExpression_Sign instance = new MExpExpression_Sign();
			instance.SetMExpUnarySignOperator(GetMExpUnarySignOperator().IfNotNull(z => z.Duplicate()));
			instance.SetMExpExpression(GetMExpExpression().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetMExpUnarySignOperator(MExpUnaryOperator_Sign input)
		{
			m_exp_unary_sign_operator.Set(input);
		}
		
		public MExpUnaryOperator_Sign GetMExpUnarySignOperator()
		{
			return m_exp_unary_sign_operator.Get();
		}
		
		private void SetMExpExpression(MExpExpression input)
		{
			m_exp_expression.Set(input);
		}
		
		public MExpExpression GetMExpExpression()
		{
			return m_exp_expression.Get();
		}
		
	}
	
	public partial class MExpExpression_Multiplicative : MExpExpression
	{
		[RelatableChild]private HoldingSingle<MExpElement, MExpExpression> m_exp_expression1;
		[RelatableChild]private HoldingSingle<MExpElement, MExpBinaryOperator_Multiplicative> m_exp_binary_multiplicative_operator;
		[RelatableChild]private HoldingSingle<MExpElement, MExpExpression> m_exp_expression2;
		static public MExpExpression_Multiplicative DOMify(MExpParser.MExpExpression_MultiplicativeContext context)
		{
			if(context != null)
			{
				return new MExpExpression_Multiplicative(context);
			}
			
			return null;
		}
		
		static new public MExpExpression_Multiplicative DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as MExpParser.MExpExpression_MultiplicativeContext);
		}
		
		static new public MExpExpression_Multiplicative DOMify(Stream stream)
		{
			return DOMify(MExpDOMinatorUtilities.CreateParser(stream).mExpExpression());
		}
		
		static new public MExpExpression_Multiplicative DOMify(string text)
		{
			return DOMify(MExpDOMinatorUtilities.CreateParser(text).mExpExpression());
		}
		
		static new public MExpExpression_Multiplicative DOMifyFile(string filename)
		{
			return DOMify(MExpDOMinatorUtilities.CreateFileParser(filename).mExpExpression());
		}
		
		public MExpExpression_Multiplicative()
		{
			m_exp_expression1 = new HoldingSingle<MExpElement, MExpExpression>(this);
			m_exp_binary_multiplicative_operator = new HoldingSingle<MExpElement, MExpBinaryOperator_Multiplicative>(this);
			m_exp_expression2 = new HoldingSingle<MExpElement, MExpExpression>(this);
			OnConstructor();
		}
		
		partial void OnConstructor();
		public MExpExpression_Multiplicative(MExpParser.MExpExpression_MultiplicativeContext context) : this()
		{
			SetMExpExpression1(MExpExpression.DOMify(context.mExpExpression(0)));
			SetMExpBinaryMultiplicativeOperator(MExpBinaryOperator_Multiplicative.DOMify(context.mExpBinaryMultiplicativeOperator()));
			SetMExpExpression2(MExpExpression.DOMify(context.mExpExpression(1)));
		}
		
		public override MExpExpression Duplicate()
		{
			MExpExpression_Multiplicative instance = new MExpExpression_Multiplicative();
			instance.SetMExpExpression1(GetMExpExpression1().IfNotNull(z => z.Duplicate()));
			instance.SetMExpBinaryMultiplicativeOperator(GetMExpBinaryMultiplicativeOperator().IfNotNull(z => z.Duplicate()));
			instance.SetMExpExpression2(GetMExpExpression2().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetMExpExpression1(MExpExpression input)
		{
			m_exp_expression1.Set(input);
		}
		
		public MExpExpression GetMExpExpression1()
		{
			return m_exp_expression1.Get();
		}
		
		private void SetMExpBinaryMultiplicativeOperator(MExpBinaryOperator_Multiplicative input)
		{
			m_exp_binary_multiplicative_operator.Set(input);
		}
		
		public MExpBinaryOperator_Multiplicative GetMExpBinaryMultiplicativeOperator()
		{
			return m_exp_binary_multiplicative_operator.Get();
		}
		
		private void SetMExpExpression2(MExpExpression input)
		{
			m_exp_expression2.Set(input);
		}
		
		public MExpExpression GetMExpExpression2()
		{
			return m_exp_expression2.Get();
		}
		
	}
	
	public partial class MExpExpression_Additive : MExpExpression
	{
		[RelatableChild]private HoldingSingle<MExpElement, MExpExpression> m_exp_expression1;
		[RelatableChild]private HoldingSingle<MExpElement, MExpBinaryOperator_Additive> m_exp_binary_additive_operator;
		[RelatableChild]private HoldingSingle<MExpElement, MExpExpression> m_exp_expression2;
		static public MExpExpression_Additive DOMify(MExpParser.MExpExpression_AdditiveContext context)
		{
			if(context != null)
			{
				return new MExpExpression_Additive(context);
			}
			
			return null;
		}
		
		static new public MExpExpression_Additive DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as MExpParser.MExpExpression_AdditiveContext);
		}
		
		static new public MExpExpression_Additive DOMify(Stream stream)
		{
			return DOMify(MExpDOMinatorUtilities.CreateParser(stream).mExpExpression());
		}
		
		static new public MExpExpression_Additive DOMify(string text)
		{
			return DOMify(MExpDOMinatorUtilities.CreateParser(text).mExpExpression());
		}
		
		static new public MExpExpression_Additive DOMifyFile(string filename)
		{
			return DOMify(MExpDOMinatorUtilities.CreateFileParser(filename).mExpExpression());
		}
		
		public MExpExpression_Additive()
		{
			m_exp_expression1 = new HoldingSingle<MExpElement, MExpExpression>(this);
			m_exp_binary_additive_operator = new HoldingSingle<MExpElement, MExpBinaryOperator_Additive>(this);
			m_exp_expression2 = new HoldingSingle<MExpElement, MExpExpression>(this);
			OnConstructor();
		}
		
		partial void OnConstructor();
		public MExpExpression_Additive(MExpParser.MExpExpression_AdditiveContext context) : this()
		{
			SetMExpExpression1(MExpExpression.DOMify(context.mExpExpression(0)));
			SetMExpBinaryAdditiveOperator(MExpBinaryOperator_Additive.DOMify(context.mExpBinaryAdditiveOperator()));
			SetMExpExpression2(MExpExpression.DOMify(context.mExpExpression(1)));
		}
		
		public override MExpExpression Duplicate()
		{
			MExpExpression_Additive instance = new MExpExpression_Additive();
			instance.SetMExpExpression1(GetMExpExpression1().IfNotNull(z => z.Duplicate()));
			instance.SetMExpBinaryAdditiveOperator(GetMExpBinaryAdditiveOperator().IfNotNull(z => z.Duplicate()));
			instance.SetMExpExpression2(GetMExpExpression2().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetMExpExpression1(MExpExpression input)
		{
			m_exp_expression1.Set(input);
		}
		
		public MExpExpression GetMExpExpression1()
		{
			return m_exp_expression1.Get();
		}
		
		private void SetMExpBinaryAdditiveOperator(MExpBinaryOperator_Additive input)
		{
			m_exp_binary_additive_operator.Set(input);
		}
		
		public MExpBinaryOperator_Additive GetMExpBinaryAdditiveOperator()
		{
			return m_exp_binary_additive_operator.Get();
		}
		
		private void SetMExpExpression2(MExpExpression input)
		{
			m_exp_expression2.Set(input);
		}
		
		public MExpExpression GetMExpExpression2()
		{
			return m_exp_expression2.Get();
		}
		
	}
	
	public abstract partial class MExpUnaryOperator_Sign : MExpUnaryOperator
	{
		public abstract MExpUnaryOperator_Sign Duplicate();
		static public MExpUnaryOperator_Sign DOMify(MExpParser.MExpUnarySignOperatorContext context)
		{
			return MExpResolver.Resolve<MExpUnaryOperator_Sign>(context);
		}
		
		static public MExpUnaryOperator_Sign DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as MExpParser.MExpUnarySignOperatorContext);
		}
		
		static public MExpUnaryOperator_Sign DOMify(Stream stream)
		{
			return DOMify(MExpDOMinatorUtilities.CreateParser(stream).mExpUnarySignOperator());
		}
		
		static public MExpUnaryOperator_Sign DOMify(string text)
		{
			return DOMify(MExpDOMinatorUtilities.CreateParser(text).mExpUnarySignOperator());
		}
		
		static public MExpUnaryOperator_Sign DOMifyFile(string filename)
		{
			return DOMify(MExpDOMinatorUtilities.CreateFileParser(filename).mExpUnarySignOperator());
		}
		
	}
	
	public partial class MExpUnaryOperator_Sign_Negate : MExpUnaryOperator_Sign
	{
		static public MExpUnaryOperator_Sign_Negate DOMify(MExpParser.MExpUnaryOperator_NegateContext context)
		{
			if(context != null)
			{
				return new MExpUnaryOperator_Sign_Negate(context);
			}
			
			return null;
		}
		
		static new public MExpUnaryOperator_Sign_Negate DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as MExpParser.MExpUnaryOperator_NegateContext);
		}
		
		static new public MExpUnaryOperator_Sign_Negate DOMify(Stream stream)
		{
			return DOMify(MExpDOMinatorUtilities.CreateParser(stream).mExpUnarySignOperator());
		}
		
		static new public MExpUnaryOperator_Sign_Negate DOMify(string text)
		{
			return DOMify(MExpDOMinatorUtilities.CreateParser(text).mExpUnarySignOperator());
		}
		
		static new public MExpUnaryOperator_Sign_Negate DOMifyFile(string filename)
		{
			return DOMify(MExpDOMinatorUtilities.CreateFileParser(filename).mExpUnarySignOperator());
		}
		
		public MExpUnaryOperator_Sign_Negate()
		{
			OnConstructor();
		}
		
		partial void OnConstructor();
		public MExpUnaryOperator_Sign_Negate(MExpParser.MExpUnaryOperator_NegateContext context) : this()
		{
		}
		
		public override MExpUnaryOperator_Sign Duplicate()
		{
			MExpUnaryOperator_Sign_Negate instance = new MExpUnaryOperator_Sign_Negate();
			return instance;
		}
		
	}
	
	public abstract partial class MExpBinaryOperator_Additive : MExpBinaryOperator
	{
		public abstract MExpBinaryOperator_Additive Duplicate();
		static public MExpBinaryOperator_Additive DOMify(MExpParser.MExpBinaryAdditiveOperatorContext context)
		{
			return MExpResolver.Resolve<MExpBinaryOperator_Additive>(context);
		}
		
		static public MExpBinaryOperator_Additive DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as MExpParser.MExpBinaryAdditiveOperatorContext);
		}
		
		static public MExpBinaryOperator_Additive DOMify(Stream stream)
		{
			return DOMify(MExpDOMinatorUtilities.CreateParser(stream).mExpBinaryAdditiveOperator());
		}
		
		static public MExpBinaryOperator_Additive DOMify(string text)
		{
			return DOMify(MExpDOMinatorUtilities.CreateParser(text).mExpBinaryAdditiveOperator());
		}
		
		static public MExpBinaryOperator_Additive DOMifyFile(string filename)
		{
			return DOMify(MExpDOMinatorUtilities.CreateFileParser(filename).mExpBinaryAdditiveOperator());
		}
		
	}
	
	public partial class MExpBinaryOperator_Additive_Addition : MExpBinaryOperator_Additive
	{
		static public MExpBinaryOperator_Additive_Addition DOMify(MExpParser.MExpBinaryAdditiveOperator_AdditionContext context)
		{
			if(context != null)
			{
				return new MExpBinaryOperator_Additive_Addition(context);
			}
			
			return null;
		}
		
		static new public MExpBinaryOperator_Additive_Addition DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as MExpParser.MExpBinaryAdditiveOperator_AdditionContext);
		}
		
		static new public MExpBinaryOperator_Additive_Addition DOMify(Stream stream)
		{
			return DOMify(MExpDOMinatorUtilities.CreateParser(stream).mExpBinaryAdditiveOperator());
		}
		
		static new public MExpBinaryOperator_Additive_Addition DOMify(string text)
		{
			return DOMify(MExpDOMinatorUtilities.CreateParser(text).mExpBinaryAdditiveOperator());
		}
		
		static new public MExpBinaryOperator_Additive_Addition DOMifyFile(string filename)
		{
			return DOMify(MExpDOMinatorUtilities.CreateFileParser(filename).mExpBinaryAdditiveOperator());
		}
		
		public MExpBinaryOperator_Additive_Addition()
		{
			OnConstructor();
		}
		
		partial void OnConstructor();
		public MExpBinaryOperator_Additive_Addition(MExpParser.MExpBinaryAdditiveOperator_AdditionContext context) : this()
		{
		}
		
		public override MExpBinaryOperator_Additive Duplicate()
		{
			MExpBinaryOperator_Additive_Addition instance = new MExpBinaryOperator_Additive_Addition();
			return instance;
		}
		
	}
	
	public partial class MExpBinaryOperator_Additive_Subtraction : MExpBinaryOperator_Additive
	{
		static public MExpBinaryOperator_Additive_Subtraction DOMify(MExpParser.MExpBinaryAdditiveOperator_SubtractionContext context)
		{
			if(context != null)
			{
				return new MExpBinaryOperator_Additive_Subtraction(context);
			}
			
			return null;
		}
		
		static new public MExpBinaryOperator_Additive_Subtraction DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as MExpParser.MExpBinaryAdditiveOperator_SubtractionContext);
		}
		
		static new public MExpBinaryOperator_Additive_Subtraction DOMify(Stream stream)
		{
			return DOMify(MExpDOMinatorUtilities.CreateParser(stream).mExpBinaryAdditiveOperator());
		}
		
		static new public MExpBinaryOperator_Additive_Subtraction DOMify(string text)
		{
			return DOMify(MExpDOMinatorUtilities.CreateParser(text).mExpBinaryAdditiveOperator());
		}
		
		static new public MExpBinaryOperator_Additive_Subtraction DOMifyFile(string filename)
		{
			return DOMify(MExpDOMinatorUtilities.CreateFileParser(filename).mExpBinaryAdditiveOperator());
		}
		
		public MExpBinaryOperator_Additive_Subtraction()
		{
			OnConstructor();
		}
		
		partial void OnConstructor();
		public MExpBinaryOperator_Additive_Subtraction(MExpParser.MExpBinaryAdditiveOperator_SubtractionContext context) : this()
		{
		}
		
		public override MExpBinaryOperator_Additive Duplicate()
		{
			MExpBinaryOperator_Additive_Subtraction instance = new MExpBinaryOperator_Additive_Subtraction();
			return instance;
		}
		
	}
	
	public abstract partial class MExpBinaryOperator_Multiplicative : MExpBinaryOperator
	{
		public abstract MExpBinaryOperator_Multiplicative Duplicate();
		static public MExpBinaryOperator_Multiplicative DOMify(MExpParser.MExpBinaryMultiplicativeOperatorContext context)
		{
			return MExpResolver.Resolve<MExpBinaryOperator_Multiplicative>(context);
		}
		
		static public MExpBinaryOperator_Multiplicative DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as MExpParser.MExpBinaryMultiplicativeOperatorContext);
		}
		
		static public MExpBinaryOperator_Multiplicative DOMify(Stream stream)
		{
			return DOMify(MExpDOMinatorUtilities.CreateParser(stream).mExpBinaryMultiplicativeOperator());
		}
		
		static public MExpBinaryOperator_Multiplicative DOMify(string text)
		{
			return DOMify(MExpDOMinatorUtilities.CreateParser(text).mExpBinaryMultiplicativeOperator());
		}
		
		static public MExpBinaryOperator_Multiplicative DOMifyFile(string filename)
		{
			return DOMify(MExpDOMinatorUtilities.CreateFileParser(filename).mExpBinaryMultiplicativeOperator());
		}
		
	}
	
	public partial class MExpBinaryOperator_Multiplicative_Multiplication : MExpBinaryOperator_Multiplicative
	{
		static public MExpBinaryOperator_Multiplicative_Multiplication DOMify(MExpParser.MExpBinaryMultiplicativeOperator_MultiplicationContext context)
		{
			if(context != null)
			{
				return new MExpBinaryOperator_Multiplicative_Multiplication(context);
			}
			
			return null;
		}
		
		static new public MExpBinaryOperator_Multiplicative_Multiplication DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as MExpParser.MExpBinaryMultiplicativeOperator_MultiplicationContext);
		}
		
		static new public MExpBinaryOperator_Multiplicative_Multiplication DOMify(Stream stream)
		{
			return DOMify(MExpDOMinatorUtilities.CreateParser(stream).mExpBinaryMultiplicativeOperator());
		}
		
		static new public MExpBinaryOperator_Multiplicative_Multiplication DOMify(string text)
		{
			return DOMify(MExpDOMinatorUtilities.CreateParser(text).mExpBinaryMultiplicativeOperator());
		}
		
		static new public MExpBinaryOperator_Multiplicative_Multiplication DOMifyFile(string filename)
		{
			return DOMify(MExpDOMinatorUtilities.CreateFileParser(filename).mExpBinaryMultiplicativeOperator());
		}
		
		public MExpBinaryOperator_Multiplicative_Multiplication()
		{
			OnConstructor();
		}
		
		partial void OnConstructor();
		public MExpBinaryOperator_Multiplicative_Multiplication(MExpParser.MExpBinaryMultiplicativeOperator_MultiplicationContext context) : this()
		{
		}
		
		public override MExpBinaryOperator_Multiplicative Duplicate()
		{
			MExpBinaryOperator_Multiplicative_Multiplication instance = new MExpBinaryOperator_Multiplicative_Multiplication();
			return instance;
		}
		
	}
	
	public partial class MExpBinaryOperator_Multiplicative_Division : MExpBinaryOperator_Multiplicative
	{
		static public MExpBinaryOperator_Multiplicative_Division DOMify(MExpParser.MExpBinaryMultiplicativeOperator_DivisionContext context)
		{
			if(context != null)
			{
				return new MExpBinaryOperator_Multiplicative_Division(context);
			}
			
			return null;
		}
		
		static new public MExpBinaryOperator_Multiplicative_Division DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as MExpParser.MExpBinaryMultiplicativeOperator_DivisionContext);
		}
		
		static new public MExpBinaryOperator_Multiplicative_Division DOMify(Stream stream)
		{
			return DOMify(MExpDOMinatorUtilities.CreateParser(stream).mExpBinaryMultiplicativeOperator());
		}
		
		static new public MExpBinaryOperator_Multiplicative_Division DOMify(string text)
		{
			return DOMify(MExpDOMinatorUtilities.CreateParser(text).mExpBinaryMultiplicativeOperator());
		}
		
		static new public MExpBinaryOperator_Multiplicative_Division DOMifyFile(string filename)
		{
			return DOMify(MExpDOMinatorUtilities.CreateFileParser(filename).mExpBinaryMultiplicativeOperator());
		}
		
		public MExpBinaryOperator_Multiplicative_Division()
		{
			OnConstructor();
		}
		
		partial void OnConstructor();
		public MExpBinaryOperator_Multiplicative_Division(MExpParser.MExpBinaryMultiplicativeOperator_DivisionContext context) : this()
		{
		}
		
		public override MExpBinaryOperator_Multiplicative Duplicate()
		{
			MExpBinaryOperator_Multiplicative_Division instance = new MExpBinaryOperator_Multiplicative_Division();
			return instance;
		}
		
	}
	
	public partial class MExpBinaryOperator_Multiplicative_Modulo : MExpBinaryOperator_Multiplicative
	{
		static public MExpBinaryOperator_Multiplicative_Modulo DOMify(MExpParser.MExpBinaryMultiplicativeOperator_ModuloContext context)
		{
			if(context != null)
			{
				return new MExpBinaryOperator_Multiplicative_Modulo(context);
			}
			
			return null;
		}
		
		static new public MExpBinaryOperator_Multiplicative_Modulo DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as MExpParser.MExpBinaryMultiplicativeOperator_ModuloContext);
		}
		
		static new public MExpBinaryOperator_Multiplicative_Modulo DOMify(Stream stream)
		{
			return DOMify(MExpDOMinatorUtilities.CreateParser(stream).mExpBinaryMultiplicativeOperator());
		}
		
		static new public MExpBinaryOperator_Multiplicative_Modulo DOMify(string text)
		{
			return DOMify(MExpDOMinatorUtilities.CreateParser(text).mExpBinaryMultiplicativeOperator());
		}
		
		static new public MExpBinaryOperator_Multiplicative_Modulo DOMifyFile(string filename)
		{
			return DOMify(MExpDOMinatorUtilities.CreateFileParser(filename).mExpBinaryMultiplicativeOperator());
		}
		
		public MExpBinaryOperator_Multiplicative_Modulo()
		{
			OnConstructor();
		}
		
		partial void OnConstructor();
		public MExpBinaryOperator_Multiplicative_Modulo(MExpParser.MExpBinaryMultiplicativeOperator_ModuloContext context) : this()
		{
		}
		
		public override MExpBinaryOperator_Multiplicative Duplicate()
		{
			MExpBinaryOperator_Multiplicative_Modulo instance = new MExpBinaryOperator_Multiplicative_Modulo();
			return instance;
		}
		
	}
	
	public partial class MExpFunction : MExpElement
	{
		private string id;
		[RelatableChild]private HoldingList<MExpElement, MExpExpression> m_exp_expressions;
		static public MExpFunction DOMify(MExpParser.MExpFunctionContext context)
		{
			if(context != null)
			{
				return new MExpFunction(context);
			}
			
			return null;
		}
		
		static public MExpFunction DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as MExpParser.MExpFunctionContext);
		}
		
		static public MExpFunction DOMify(Stream stream)
		{
			return DOMify(MExpDOMinatorUtilities.CreateParser(stream).mExpFunction());
		}
		
		static public MExpFunction DOMify(string text)
		{
			return DOMify(MExpDOMinatorUtilities.CreateParser(text).mExpFunction());
		}
		
		static public MExpFunction DOMifyFile(string filename)
		{
			return DOMify(MExpDOMinatorUtilities.CreateFileParser(filename).mExpFunction());
		}
		
		public MExpFunction()
		{
			id = "";
			m_exp_expressions = new HoldingList<MExpElement, MExpExpression>(this);
			OnConstructor();
		}
		
		partial void OnConstructor();
		public MExpFunction(MExpParser.MExpFunctionContext context) : this()
		{
			SetId(context.ID().GetTextEX());
			AddMExpExpressions(context.mExpExpression().Convert(c => MExpExpression.DOMify(c)));
		}
		
		public MExpFunction Duplicate()
		{
			MExpFunction instance = new MExpFunction();
			instance.SetId(GetId());
			instance.SetMExpExpressions(GetMExpExpressions().Convert(i => i.IfNotNull(z => z.Duplicate())));
			return instance;
		}
		
		private void SetId(string input)
		{
			id = input;
		}
		
		public string GetId()
		{
			return id;
		}
		
		private void ClearMExpExpressions()
		{
			m_exp_expressions.Clear();
		}
		
		private void SetMExpExpressions(IEnumerable<MExpExpression> input)
		{
			ClearMExpExpressions();
			AddMExpExpressions(input);
		}
		
		private void SetMExpExpressions(params MExpExpression[] input)
		{
			SetMExpExpressions((IEnumerable<MExpExpression>)input);
		}
		
		private void AddMExpExpression(MExpExpression input)
		{
			m_exp_expressions.Add(input);
		}
		
		private void AddMExpExpressions(IEnumerable<MExpExpression> input)
		{
			input.ProcessCopy(i => AddMExpExpression(i));
		}
		
		private void AddMExpExpressions(params MExpExpression[] input)
		{
			AddMExpExpressions((IEnumerable<MExpExpression>)input);
		}
		
		public IEnumerable<MExpExpression> GetMExpExpressions()
		{
			return m_exp_expressions;
		}
		
	}
	
	public abstract partial class MExpElement : Object, Relatable, Holdable<MExpElement>
	{
		[HoldingContainer]private HoldingContainer<MExpElement> holding_container;
		public MExpElement()
		{
			holding_container = null;
			OnConstruct();
		}
		
		partial void OnConstruct();
		[RelatableParent]
		public MExpElement GetParent()
		{
			if(holding_container != null)
			{
				return holding_container.GetParent();
			}
			
			return null;
		}
		
	}
	
	static public class MExpDOMinatorUtilities
	{
		static public MExpParser CreateParser(ICharStream stream)
		{
			MExpParser parser = new MExpParser(new CommonTokenStream(new MExpLexer(stream)));
			parser.RemoveErrorListeners();
			parser.AddErrorListener(MExpSyntaxExceptionThrower.INSTANCE);
			return parser;
		}
		
		static public MExpParser CreateParser(Stream stream)
		{
			return CreateParser(new AntlrInputStream(stream));
		}
		
		static public MExpParser CreateParser(TextReader text_reader)
		{
			return CreateParser(new AntlrInputStream(text_reader));
		}
		
		static public MExpParser CreateParser(string text)
		{
			return CreateParser(new StringReader(text));
		}
		
		static public MExpParser CreateFileParser(string filename)
		{
			return CreateParser(new AntlrFileStream(filename));
		}
		
	}
	
	static public class MExpIParseTreeExtensions
	{
		static public string GetTextEX(this IParseTree item)
		{
			if(item != null)
			{
				return item.GetText();
			}
			
			return "";
		}
		
	}
	
	public partial class MExpResolver : MExpBaseVisitor<MExpElement>
	{
		static private MExpResolver instance;
		static public MExpResolver GetInstance()
		{
			if(instance == null)
			{
				instance = new MExpResolver();
			}
			
			return instance;
		}
		
		static public MExpElement Resolve(IParseTree parse_tree)
		{
			if(parse_tree != null)
			{
				return GetInstance().Visit(parse_tree);
			}
			
			return null;
		}
		
		static public T Resolve<T>(IParseTree parse_tree) where T : MExpElement
		{
			return Resolve(parse_tree) as T;
		}
		
		private MExpResolver()
		{
		}
		
		public override MExpElement VisitMExpEntry(MExpParser.MExpEntryContext context)
		{
			return MExpEntry.DOMify(context);
		}
		
		public override MExpElement VisitMExpExpression_Constant(MExpParser.MExpExpression_ConstantContext context)
		{
			return MExpExpression_Constant.DOMify(context);
		}
		
		public override MExpElement VisitMExpExpression_Term(MExpParser.MExpExpression_TermContext context)
		{
			return MExpExpression_Term.DOMify(context);
		}
		
		public override MExpElement VisitMExpExpression_Function(MExpParser.MExpExpression_FunctionContext context)
		{
			return MExpExpression_Function.DOMify(context);
		}
		
		public override MExpElement VisitMExpExpression_Group(MExpParser.MExpExpression_GroupContext context)
		{
			return MExpExpression_Group.DOMify(context);
		}
		
		public override MExpElement VisitMExpExpression_Sign(MExpParser.MExpExpression_SignContext context)
		{
			return MExpExpression_Sign.DOMify(context);
		}
		
		public override MExpElement VisitMExpExpression_Multiplicative(MExpParser.MExpExpression_MultiplicativeContext context)
		{
			return MExpExpression_Multiplicative.DOMify(context);
		}
		
		public override MExpElement VisitMExpExpression_Additive(MExpParser.MExpExpression_AdditiveContext context)
		{
			return MExpExpression_Additive.DOMify(context);
		}
		
		public override MExpElement VisitMExpUnaryOperator_Negate(MExpParser.MExpUnaryOperator_NegateContext context)
		{
			return MExpUnaryOperator_Sign_Negate.DOMify(context);
		}
		
		public override MExpElement VisitMExpBinaryAdditiveOperator_Addition(MExpParser.MExpBinaryAdditiveOperator_AdditionContext context)
		{
			return MExpBinaryOperator_Additive_Addition.DOMify(context);
		}
		
		public override MExpElement VisitMExpBinaryAdditiveOperator_Subtraction(MExpParser.MExpBinaryAdditiveOperator_SubtractionContext context)
		{
			return MExpBinaryOperator_Additive_Subtraction.DOMify(context);
		}
		
		public override MExpElement VisitMExpBinaryMultiplicativeOperator_Multiplication(MExpParser.MExpBinaryMultiplicativeOperator_MultiplicationContext context)
		{
			return MExpBinaryOperator_Multiplicative_Multiplication.DOMify(context);
		}
		
		public override MExpElement VisitMExpBinaryMultiplicativeOperator_Division(MExpParser.MExpBinaryMultiplicativeOperator_DivisionContext context)
		{
			return MExpBinaryOperator_Multiplicative_Division.DOMify(context);
		}
		
		public override MExpElement VisitMExpBinaryMultiplicativeOperator_Modulo(MExpParser.MExpBinaryMultiplicativeOperator_ModuloContext context)
		{
			return MExpBinaryOperator_Multiplicative_Modulo.DOMify(context);
		}
		
		public override MExpElement VisitMExpFunction(MExpParser.MExpFunctionContext context)
		{
			return MExpFunction.DOMify(context);
		}
		
	}
	
	public partial class MExpSyntaxException : Exception
	{
		private int line;
		private string base_message;
		public override string Message { get{ return GetMessage(); } }
		public MExpSyntaxException(int l, string m) : base()
		{
			line = l;
			base_message = m;
		}
		
		public int GetLine()
		{
			return line;
		}
		
		public string GetBaseMessage()
		{
			return base_message;
		}
		
		public string GetMessage()
		{
			return "(" + line + ")" +  base_message;
		}
		
	}
	
	public class MExpSyntaxExceptionThrower : BaseErrorListener
	{
		static public readonly MExpSyntaxExceptionThrower INSTANCE = new MExpSyntaxExceptionThrower();
		private MExpSyntaxExceptionThrower()
		{
		}
		
		public override void SyntaxError(TextWriter output, IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
		{
			throw new MExpSyntaxException(line, msg);
		}
		
	}
	
}
