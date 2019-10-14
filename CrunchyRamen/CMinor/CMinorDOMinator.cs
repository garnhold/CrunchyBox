
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: October 14 2019 1:47:36 -07:00

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace CrunchyRamen
{
	public abstract partial class CMinorType : CMinorElement
	{
		public abstract CMinorType Duplicate();
		static public CMinorType DOMify(CMinorParser.CMinorTypeContext context)
		{
			return CMinorResolver.Resolve<CMinorType>(context);
		}
		
		static public CMinorType DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorTypeContext);
		}
		
		static public CMinorType DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorType());
		}
		
		static public CMinorType DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorType());
		}
		
		static public CMinorType DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorType());
		}
		
	}
	
	public partial class CMinorType_Normal : CMinorType
	{
		private string id;
		static public CMinorType_Normal DOMify(CMinorParser.CMinorType_NormalContext context)
		{
			if(context != null)
			{
				return new CMinorType_Normal(context);
			}
			
			return null;
		}
		
		static new public CMinorType_Normal DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorType_NormalContext);
		}
		
		static new public CMinorType_Normal DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorType());
		}
		
		static new public CMinorType_Normal DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorType());
		}
		
		static new public CMinorType_Normal DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorType());
		}
		
		public CMinorType_Normal()
		{
			id = "";
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorType_Normal(CMinorParser.CMinorType_NormalContext context) : this()
		{
			SetId(context.ID().GetTextEX());
		}
		
		public override CMinorType Duplicate()
		{
			CMinorType_Normal instance = new CMinorType_Normal();
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
	
	public partial class CMinorType_Templated : CMinorType
	{
		private string id;
		[RelatableChild]private CMinorTypeList c_minor_type_list;
		static public CMinorType_Templated DOMify(CMinorParser.CMinorType_TemplatedContext context)
		{
			if(context != null)
			{
				return new CMinorType_Templated(context);
			}
			
			return null;
		}
		
		static new public CMinorType_Templated DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorType_TemplatedContext);
		}
		
		static new public CMinorType_Templated DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorType());
		}
		
		static new public CMinorType_Templated DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorType());
		}
		
		static new public CMinorType_Templated DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorType());
		}
		
		public CMinorType_Templated()
		{
			id = "";
			c_minor_type_list = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorType_Templated(CMinorParser.CMinorType_TemplatedContext context) : this()
		{
			SetId(context.ID().GetTextEX());
			SetCMinorTypeList(CMinorTypeList.DOMify(context.cMinorTypeList()));
		}
		
		public override CMinorType Duplicate()
		{
			CMinorType_Templated instance = new CMinorType_Templated();
			instance.SetId(GetId());
			instance.SetCMinorTypeList(GetCMinorTypeList().IfNotNull(z => z.Duplicate()));
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
		
		private void SetCMinorTypeList(CMinorTypeList input)
		{
			c_minor_type_list = input;
		}
		
		public CMinorTypeList GetCMinorTypeList()
		{
			return c_minor_type_list;
		}
		
	}
	
	public partial class CMinorType_Array : CMinorType
	{
		[RelatableChild]private CMinorType c_minor_type;
		static public CMinorType_Array DOMify(CMinorParser.CMinorType_ArrayContext context)
		{
			if(context != null)
			{
				return new CMinorType_Array(context);
			}
			
			return null;
		}
		
		static new public CMinorType_Array DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorType_ArrayContext);
		}
		
		static new public CMinorType_Array DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorType());
		}
		
		static new public CMinorType_Array DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorType());
		}
		
		static new public CMinorType_Array DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorType());
		}
		
		public CMinorType_Array()
		{
			c_minor_type = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorType_Array(CMinorParser.CMinorType_ArrayContext context) : this()
		{
			SetCMinorType(CMinorType.DOMify(context.cMinorType()));
		}
		
		public override CMinorType Duplicate()
		{
			CMinorType_Array instance = new CMinorType_Array();
			instance.SetCMinorType(GetCMinorType().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetCMinorType(CMinorType input)
		{
			c_minor_type = input;
		}
		
		public CMinorType GetCMinorType()
		{
			return c_minor_type;
		}
		
	}
	
	public partial class CMinorTypeList : CMinorElement
	{
		[RelatableChild]private List<CMinorType> c_minor_types;
		static public CMinorTypeList DOMify(CMinorParser.CMinorTypeListContext context)
		{
			if(context != null)
			{
				return new CMinorTypeList(context);
			}
			
			return null;
		}
		
		static public CMinorTypeList DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorTypeListContext);
		}
		
		static public CMinorTypeList DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorTypeList());
		}
		
		static public CMinorTypeList DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorTypeList());
		}
		
		static public CMinorTypeList DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorTypeList());
		}
		
		public CMinorTypeList()
		{
			c_minor_types = new List<CMinorType>();
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorTypeList(CMinorParser.CMinorTypeListContext context) : this()
		{
			AddCMinorTypes(context.cMinorType().Convert(c => CMinorType.DOMify(c)));
		}
		
		public CMinorTypeList Duplicate()
		{
			CMinorTypeList instance = new CMinorTypeList();
			instance.SetCMinorTypes(GetCMinorTypes().Convert(i => i.IfNotNull(z => z.Duplicate())));
			return instance;
		}
		
		private void ClearCMinorTypes()
		{
			c_minor_types.Clear();
		}
		
		private void SetCMinorTypes(IEnumerable<CMinorType> input)
		{
			ClearCMinorTypes();
			AddCMinorTypes(input);
		}
		
		private void SetCMinorTypes(params CMinorType[] input)
		{
			SetCMinorTypes((IEnumerable<CMinorType>)input);
		}
		
		private void AddCMinorType(CMinorType input)
		{
			c_minor_types.Add(input);
		}
		
		private void AddCMinorTypes(IEnumerable<CMinorType> input)
		{
			input.Process(i => AddCMinorType(i));
		}
		
		private void AddCMinorTypes(params CMinorType[] input)
		{
			AddCMinorTypes((IEnumerable<CMinorType>)input);
		}
		
		public IEnumerable<CMinorType> GetCMinorTypes()
		{
			return c_minor_types;
		}
		
	}
	
	public abstract partial class CMinorLiteral : CMinorElement
	{
		public abstract CMinorLiteral Duplicate();
		static public CMinorLiteral DOMify(CMinorParser.CMinorLiteralContext context)
		{
			return CMinorResolver.Resolve<CMinorLiteral>(context);
		}
		
		static public CMinorLiteral DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorLiteralContext);
		}
		
		static public CMinorLiteral DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorLiteral());
		}
		
		static public CMinorLiteral DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorLiteral());
		}
		
		static public CMinorLiteral DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorLiteral());
		}
		
	}
	
	public partial class CMinorLiteral_Null : CMinorLiteral
	{
		static public CMinorLiteral_Null DOMify(CMinorParser.CMinorLiteral_NullContext context)
		{
			if(context != null)
			{
				return new CMinorLiteral_Null(context);
			}
			
			return null;
		}
		
		static new public CMinorLiteral_Null DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorLiteral_NullContext);
		}
		
		static new public CMinorLiteral_Null DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorLiteral());
		}
		
		static new public CMinorLiteral_Null DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorLiteral());
		}
		
		static new public CMinorLiteral_Null DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorLiteral());
		}
		
		public CMinorLiteral_Null()
		{
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorLiteral_Null(CMinorParser.CMinorLiteral_NullContext context) : this()
		{
		}
		
		public override CMinorLiteral Duplicate()
		{
			CMinorLiteral_Null instance = new CMinorLiteral_Null();
			return instance;
		}
		
	}
	
	public partial class CMinorLiteral_Bool : CMinorLiteral
	{
		private bool @bool;
		static public CMinorLiteral_Bool DOMify(CMinorParser.CMinorLiteral_BoolContext context)
		{
			if(context != null)
			{
				return new CMinorLiteral_Bool(context);
			}
			
			return null;
		}
		
		static new public CMinorLiteral_Bool DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorLiteral_BoolContext);
		}
		
		static new public CMinorLiteral_Bool DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorLiteral());
		}
		
		static new public CMinorLiteral_Bool DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorLiteral());
		}
		
		static new public CMinorLiteral_Bool DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorLiteral());
		}
		
		public CMinorLiteral_Bool()
		{
			@bool = false;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorLiteral_Bool(CMinorParser.CMinorLiteral_BoolContext context) : this()
		{
			SetBool(context.BOOL().GetTextEX().ParseBool());
		}
		
		public override CMinorLiteral Duplicate()
		{
			CMinorLiteral_Bool instance = new CMinorLiteral_Bool();
			instance.SetBool(GetBool());
			return instance;
		}
		
		private void SetBool(bool input)
		{
			@bool = input;
		}
		
		public bool GetBool()
		{
			return @bool;
		}
		
	}
	
	public partial class CMinorLiteral_Int : CMinorLiteral
	{
		private int @int;
		static public CMinorLiteral_Int DOMify(CMinorParser.CMinorLiteral_IntContext context)
		{
			if(context != null)
			{
				return new CMinorLiteral_Int(context);
			}
			
			return null;
		}
		
		static new public CMinorLiteral_Int DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorLiteral_IntContext);
		}
		
		static new public CMinorLiteral_Int DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorLiteral());
		}
		
		static new public CMinorLiteral_Int DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorLiteral());
		}
		
		static new public CMinorLiteral_Int DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorLiteral());
		}
		
		public CMinorLiteral_Int()
		{
			@int = 0;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorLiteral_Int(CMinorParser.CMinorLiteral_IntContext context) : this()
		{
			SetInt(context.INT().GetTextEX().ParseInt());
		}
		
		public override CMinorLiteral Duplicate()
		{
			CMinorLiteral_Int instance = new CMinorLiteral_Int();
			instance.SetInt(GetInt());
			return instance;
		}
		
		private void SetInt(int input)
		{
			@int = input;
		}
		
		public int GetInt()
		{
			return @int;
		}
		
	}
	
	public partial class CMinorLiteral_Float : CMinorLiteral
	{
		private float @float;
		static public CMinorLiteral_Float DOMify(CMinorParser.CMinorLiteral_FloatContext context)
		{
			if(context != null)
			{
				return new CMinorLiteral_Float(context);
			}
			
			return null;
		}
		
		static new public CMinorLiteral_Float DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorLiteral_FloatContext);
		}
		
		static new public CMinorLiteral_Float DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorLiteral());
		}
		
		static new public CMinorLiteral_Float DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorLiteral());
		}
		
		static new public CMinorLiteral_Float DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorLiteral());
		}
		
		public CMinorLiteral_Float()
		{
			@float = 0.0f;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorLiteral_Float(CMinorParser.CMinorLiteral_FloatContext context) : this()
		{
			SetFloat(context.FLOAT().GetTextEX().ParseFloat());
		}
		
		public override CMinorLiteral Duplicate()
		{
			CMinorLiteral_Float instance = new CMinorLiteral_Float();
			instance.SetFloat(GetFloat());
			return instance;
		}
		
		private void SetFloat(float input)
		{
			@float = input;
		}
		
		public float GetFloat()
		{
			return @float;
		}
		
	}
	
	public partial class CMinorLiteral_Double : CMinorLiteral
	{
		private double @double;
		static public CMinorLiteral_Double DOMify(CMinorParser.CMinorLiteral_DoubleContext context)
		{
			if(context != null)
			{
				return new CMinorLiteral_Double(context);
			}
			
			return null;
		}
		
		static new public CMinorLiteral_Double DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorLiteral_DoubleContext);
		}
		
		static new public CMinorLiteral_Double DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorLiteral());
		}
		
		static new public CMinorLiteral_Double DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorLiteral());
		}
		
		static new public CMinorLiteral_Double DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorLiteral());
		}
		
		public CMinorLiteral_Double()
		{
			@double = 0.0;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorLiteral_Double(CMinorParser.CMinorLiteral_DoubleContext context) : this()
		{
			SetDouble(context.DOUBLE().GetTextEX().ParseDouble());
		}
		
		public override CMinorLiteral Duplicate()
		{
			CMinorLiteral_Double instance = new CMinorLiteral_Double();
			instance.SetDouble(GetDouble());
			return instance;
		}
		
		private void SetDouble(double input)
		{
			@double = input;
		}
		
		public double GetDouble()
		{
			return @double;
		}
		
	}
	
	public partial class CMinorLiteral_String : CMinorLiteral
	{
		private string @string;
		static public CMinorLiteral_String DOMify(CMinorParser.CMinorLiteral_StringContext context)
		{
			if(context != null)
			{
				return new CMinorLiteral_String(context);
			}
			
			return null;
		}
		
		static new public CMinorLiteral_String DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorLiteral_StringContext);
		}
		
		static new public CMinorLiteral_String DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorLiteral());
		}
		
		static new public CMinorLiteral_String DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorLiteral());
		}
		
		static new public CMinorLiteral_String DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorLiteral());
		}
		
		public CMinorLiteral_String()
		{
			@string = "";
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorLiteral_String(CMinorParser.CMinorLiteral_StringContext context) : this()
		{
			LoadContextIntermediateString(context.STRING().GetTextEX());
		}
		
		public override CMinorLiteral Duplicate()
		{
			CMinorLiteral_String instance = new CMinorLiteral_String();
			instance.SetString(GetString());
			return instance;
		}
		
		private void SetString(string input)
		{
			@string = input;
		}
		
		public string GetString()
		{
			return @string;
		}
		
	}
	
	public abstract partial class CMinorExpression : CMinorElement
	{
		public abstract CMinorExpression Duplicate();
		static public CMinorExpression DOMify(CMinorParser.CMinorExpressionContext context)
		{
			return CMinorResolver.Resolve<CMinorExpression>(context);
		}
		
		static public CMinorExpression DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorExpressionContext);
		}
		
		static public CMinorExpression DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorExpression());
		}
		
		static public CMinorExpression DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorExpression());
		}
		
		static public CMinorExpression DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorExpression());
		}
		
	}
	
	public partial class CMinorExpression_Literal : CMinorExpression
	{
		[RelatableChild]private CMinorLiteral c_minor_literal;
		static public CMinorExpression_Literal DOMify(CMinorParser.CMinorExpression_LiteralContext context)
		{
			if(context != null)
			{
				return new CMinorExpression_Literal(context);
			}
			
			return null;
		}
		
		static new public CMinorExpression_Literal DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorExpression_LiteralContext);
		}
		
		static new public CMinorExpression_Literal DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorExpression());
		}
		
		static new public CMinorExpression_Literal DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorExpression());
		}
		
		static new public CMinorExpression_Literal DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorExpression());
		}
		
		public CMinorExpression_Literal()
		{
			c_minor_literal = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorExpression_Literal(CMinorParser.CMinorExpression_LiteralContext context) : this()
		{
			SetCMinorLiteral(CMinorLiteral.DOMify(context.cMinorLiteral()));
		}
		
		public override CMinorExpression Duplicate()
		{
			CMinorExpression_Literal instance = new CMinorExpression_Literal();
			instance.SetCMinorLiteral(GetCMinorLiteral().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetCMinorLiteral(CMinorLiteral input)
		{
			c_minor_literal = input;
		}
		
		public CMinorLiteral GetCMinorLiteral()
		{
			return c_minor_literal;
		}
		
	}
	
	public partial class CMinorExpression_This : CMinorExpression
	{
		static public CMinorExpression_This DOMify(CMinorParser.CMinorExpression_ThisContext context)
		{
			if(context != null)
			{
				return new CMinorExpression_This(context);
			}
			
			return null;
		}
		
		static new public CMinorExpression_This DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorExpression_ThisContext);
		}
		
		static new public CMinorExpression_This DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorExpression());
		}
		
		static new public CMinorExpression_This DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorExpression());
		}
		
		static new public CMinorExpression_This DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorExpression());
		}
		
		public CMinorExpression_This()
		{
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorExpression_This(CMinorParser.CMinorExpression_ThisContext context) : this()
		{
		}
		
		public override CMinorExpression Duplicate()
		{
			CMinorExpression_This instance = new CMinorExpression_This();
			return instance;
		}
		
	}
	
	public partial class CMinorExpression_DirectIdentifier : CMinorExpression
	{
		private string id;
		static public CMinorExpression_DirectIdentifier DOMify(CMinorParser.CMinorExpression_DirectIdentifierContext context)
		{
			if(context != null)
			{
				return new CMinorExpression_DirectIdentifier(context);
			}
			
			return null;
		}
		
		static new public CMinorExpression_DirectIdentifier DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorExpression_DirectIdentifierContext);
		}
		
		static new public CMinorExpression_DirectIdentifier DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorExpression());
		}
		
		static new public CMinorExpression_DirectIdentifier DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorExpression());
		}
		
		static new public CMinorExpression_DirectIdentifier DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorExpression());
		}
		
		public CMinorExpression_DirectIdentifier()
		{
			id = "";
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorExpression_DirectIdentifier(CMinorParser.CMinorExpression_DirectIdentifierContext context) : this()
		{
			SetId(context.ID().GetTextEX());
		}
		
		public override CMinorExpression Duplicate()
		{
			CMinorExpression_DirectIdentifier instance = new CMinorExpression_DirectIdentifier();
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
	
	public partial class CMinorExpression_IndirectIdentifier : CMinorExpression
	{
		[RelatableChild]private CMinorExpression c_minor_expression;
		private string id;
		static public CMinorExpression_IndirectIdentifier DOMify(CMinorParser.CMinorExpression_IndirectIdentifierContext context)
		{
			if(context != null)
			{
				return new CMinorExpression_IndirectIdentifier(context);
			}
			
			return null;
		}
		
		static new public CMinorExpression_IndirectIdentifier DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorExpression_IndirectIdentifierContext);
		}
		
		static new public CMinorExpression_IndirectIdentifier DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorExpression());
		}
		
		static new public CMinorExpression_IndirectIdentifier DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorExpression());
		}
		
		static new public CMinorExpression_IndirectIdentifier DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorExpression());
		}
		
		public CMinorExpression_IndirectIdentifier()
		{
			c_minor_expression = null;
			id = "";
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorExpression_IndirectIdentifier(CMinorParser.CMinorExpression_IndirectIdentifierContext context) : this()
		{
			SetCMinorExpression(CMinorExpression.DOMify(context.cMinorExpression()));
			SetId(context.ID().GetTextEX());
		}
		
		public override CMinorExpression Duplicate()
		{
			CMinorExpression_IndirectIdentifier instance = new CMinorExpression_IndirectIdentifier();
			instance.SetCMinorExpression(GetCMinorExpression().IfNotNull(z => z.Duplicate()));
			instance.SetId(GetId());
			return instance;
		}
		
		private void SetCMinorExpression(CMinorExpression input)
		{
			c_minor_expression = input;
		}
		
		public CMinorExpression GetCMinorExpression()
		{
			return c_minor_expression;
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
	
	public partial class CMinorExpression_InvokeGeneric : CMinorExpression
	{
		[RelatableChild]private CMinorExpression c_minor_expression;
		[RelatableChild]private CMinorTypeList c_minor_type_list;
		[RelatableChild]private CMinorExpressionList c_minor_expression_list;
		static public CMinorExpression_InvokeGeneric DOMify(CMinorParser.CMinorExpression_InvokeGenericContext context)
		{
			if(context != null)
			{
				return new CMinorExpression_InvokeGeneric(context);
			}
			
			return null;
		}
		
		static new public CMinorExpression_InvokeGeneric DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorExpression_InvokeGenericContext);
		}
		
		static new public CMinorExpression_InvokeGeneric DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorExpression());
		}
		
		static new public CMinorExpression_InvokeGeneric DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorExpression());
		}
		
		static new public CMinorExpression_InvokeGeneric DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorExpression());
		}
		
		public CMinorExpression_InvokeGeneric()
		{
			c_minor_expression = null;
			c_minor_type_list = null;
			c_minor_expression_list = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorExpression_InvokeGeneric(CMinorParser.CMinorExpression_InvokeGenericContext context) : this()
		{
			SetCMinorExpression(CMinorExpression.DOMify(context.cMinorExpression()));
			SetCMinorTypeList(CMinorTypeList.DOMify(context.cMinorTypeList()));
			SetCMinorExpressionList(CMinorExpressionList.DOMify(context.cMinorExpressionList()));
		}
		
		public override CMinorExpression Duplicate()
		{
			CMinorExpression_InvokeGeneric instance = new CMinorExpression_InvokeGeneric();
			instance.SetCMinorExpression(GetCMinorExpression().IfNotNull(z => z.Duplicate()));
			instance.SetCMinorTypeList(GetCMinorTypeList().IfNotNull(z => z.Duplicate()));
			instance.SetCMinorExpressionList(GetCMinorExpressionList().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetCMinorExpression(CMinorExpression input)
		{
			c_minor_expression = input;
		}
		
		public CMinorExpression GetCMinorExpression()
		{
			return c_minor_expression;
		}
		
		private void SetCMinorTypeList(CMinorTypeList input)
		{
			c_minor_type_list = input;
		}
		
		public CMinorTypeList GetCMinorTypeList()
		{
			return c_minor_type_list;
		}
		
		private void SetCMinorExpressionList(CMinorExpressionList input)
		{
			c_minor_expression_list = input;
		}
		
		public CMinorExpressionList GetCMinorExpressionList()
		{
			return c_minor_expression_list;
		}
		
	}
	
	public partial class CMinorExpression_Invoke : CMinorExpression
	{
		[RelatableChild]private CMinorExpression c_minor_expression;
		[RelatableChild]private CMinorExpressionList c_minor_expression_list;
		static public CMinorExpression_Invoke DOMify(CMinorParser.CMinorExpression_InvokeContext context)
		{
			if(context != null)
			{
				return new CMinorExpression_Invoke(context);
			}
			
			return null;
		}
		
		static new public CMinorExpression_Invoke DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorExpression_InvokeContext);
		}
		
		static new public CMinorExpression_Invoke DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorExpression());
		}
		
		static new public CMinorExpression_Invoke DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorExpression());
		}
		
		static new public CMinorExpression_Invoke DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorExpression());
		}
		
		public CMinorExpression_Invoke()
		{
			c_minor_expression = null;
			c_minor_expression_list = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorExpression_Invoke(CMinorParser.CMinorExpression_InvokeContext context) : this()
		{
			SetCMinorExpression(CMinorExpression.DOMify(context.cMinorExpression()));
			SetCMinorExpressionList(CMinorExpressionList.DOMify(context.cMinorExpressionList()));
		}
		
		public override CMinorExpression Duplicate()
		{
			CMinorExpression_Invoke instance = new CMinorExpression_Invoke();
			instance.SetCMinorExpression(GetCMinorExpression().IfNotNull(z => z.Duplicate()));
			instance.SetCMinorExpressionList(GetCMinorExpressionList().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetCMinorExpression(CMinorExpression input)
		{
			c_minor_expression = input;
		}
		
		public CMinorExpression GetCMinorExpression()
		{
			return c_minor_expression;
		}
		
		private void SetCMinorExpressionList(CMinorExpressionList input)
		{
			c_minor_expression_list = input;
		}
		
		public CMinorExpressionList GetCMinorExpressionList()
		{
			return c_minor_expression_list;
		}
		
	}
	
	public partial class CMinorExpression_Index : CMinorExpression
	{
		[RelatableChild]private CMinorExpression c_minor_expression1;
		[RelatableChild]private CMinorExpression c_minor_expression2;
		static public CMinorExpression_Index DOMify(CMinorParser.CMinorExpression_IndexContext context)
		{
			if(context != null)
			{
				return new CMinorExpression_Index(context);
			}
			
			return null;
		}
		
		static new public CMinorExpression_Index DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorExpression_IndexContext);
		}
		
		static new public CMinorExpression_Index DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorExpression());
		}
		
		static new public CMinorExpression_Index DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorExpression());
		}
		
		static new public CMinorExpression_Index DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorExpression());
		}
		
		public CMinorExpression_Index()
		{
			c_minor_expression1 = null;
			c_minor_expression2 = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorExpression_Index(CMinorParser.CMinorExpression_IndexContext context) : this()
		{
			SetCMinorExpression1(CMinorExpression.DOMify(context.cMinorExpression(0)));
			SetCMinorExpression2(CMinorExpression.DOMify(context.cMinorExpression(1)));
		}
		
		public override CMinorExpression Duplicate()
		{
			CMinorExpression_Index instance = new CMinorExpression_Index();
			instance.SetCMinorExpression1(GetCMinorExpression1().IfNotNull(z => z.Duplicate()));
			instance.SetCMinorExpression2(GetCMinorExpression2().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetCMinorExpression1(CMinorExpression input)
		{
			c_minor_expression1 = input;
		}
		
		public CMinorExpression GetCMinorExpression1()
		{
			return c_minor_expression1;
		}
		
		private void SetCMinorExpression2(CMinorExpression input)
		{
			c_minor_expression2 = input;
		}
		
		public CMinorExpression GetCMinorExpression2()
		{
			return c_minor_expression2;
		}
		
	}
	
	public partial class CMinorExpression_Group : CMinorExpression
	{
		[RelatableChild]private CMinorExpression c_minor_expression;
		static public CMinorExpression_Group DOMify(CMinorParser.CMinorExpression_GroupContext context)
		{
			if(context != null)
			{
				return new CMinorExpression_Group(context);
			}
			
			return null;
		}
		
		static new public CMinorExpression_Group DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorExpression_GroupContext);
		}
		
		static new public CMinorExpression_Group DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorExpression());
		}
		
		static new public CMinorExpression_Group DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorExpression());
		}
		
		static new public CMinorExpression_Group DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorExpression());
		}
		
		public CMinorExpression_Group()
		{
			c_minor_expression = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorExpression_Group(CMinorParser.CMinorExpression_GroupContext context) : this()
		{
			SetCMinorExpression(CMinorExpression.DOMify(context.cMinorExpression()));
		}
		
		public override CMinorExpression Duplicate()
		{
			CMinorExpression_Group instance = new CMinorExpression_Group();
			instance.SetCMinorExpression(GetCMinorExpression().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetCMinorExpression(CMinorExpression input)
		{
			c_minor_expression = input;
		}
		
		public CMinorExpression GetCMinorExpression()
		{
			return c_minor_expression;
		}
		
	}
	
	public partial class CMinorExpression_BinaryOperation_Multiplicative : CMinorExpression_BinaryOperation
	{
		[RelatableChild]private CMinorExpression c_minor_expression1;
		[RelatableChild]private CMinorBinaryOperator_Multiplicative c_minor_binary_operator_multiplicative;
		[RelatableChild]private CMinorExpression c_minor_expression2;
		static public CMinorExpression_BinaryOperation_Multiplicative DOMify(CMinorParser.CMinorExpression_BinaryOperation_MultiplicativeContext context)
		{
			if(context != null)
			{
				return new CMinorExpression_BinaryOperation_Multiplicative(context);
			}
			
			return null;
		}
		
		static new public CMinorExpression_BinaryOperation_Multiplicative DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorExpression_BinaryOperation_MultiplicativeContext);
		}
		
		static new public CMinorExpression_BinaryOperation_Multiplicative DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorExpression());
		}
		
		static new public CMinorExpression_BinaryOperation_Multiplicative DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorExpression());
		}
		
		static new public CMinorExpression_BinaryOperation_Multiplicative DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorExpression());
		}
		
		public CMinorExpression_BinaryOperation_Multiplicative()
		{
			c_minor_expression1 = null;
			c_minor_binary_operator_multiplicative = null;
			c_minor_expression2 = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorExpression_BinaryOperation_Multiplicative(CMinorParser.CMinorExpression_BinaryOperation_MultiplicativeContext context) : this()
		{
			SetCMinorExpression1(CMinorExpression.DOMify(context.cMinorExpression(0)));
			SetCMinorBinaryOperatorMultiplicative(CMinorBinaryOperator_Multiplicative.DOMify(context.cMinorBinaryOperator_Multiplicative()));
			SetCMinorExpression2(CMinorExpression.DOMify(context.cMinorExpression(1)));
		}
		
		public override CMinorExpression Duplicate()
		{
			CMinorExpression_BinaryOperation_Multiplicative instance = new CMinorExpression_BinaryOperation_Multiplicative();
			instance.SetCMinorExpression1(GetCMinorExpression1().IfNotNull(z => z.Duplicate()));
			instance.SetCMinorBinaryOperatorMultiplicative(GetCMinorBinaryOperatorMultiplicative().IfNotNull(z => z.Duplicate()));
			instance.SetCMinorExpression2(GetCMinorExpression2().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetCMinorExpression1(CMinorExpression input)
		{
			c_minor_expression1 = input;
		}
		
		public override CMinorExpression GetCMinorExpression1()
		{
			return c_minor_expression1;
		}
		
		private void SetCMinorBinaryOperatorMultiplicative(CMinorBinaryOperator_Multiplicative input)
		{
			c_minor_binary_operator_multiplicative = input;
		}
		
		public CMinorBinaryOperator_Multiplicative GetCMinorBinaryOperatorMultiplicative()
		{
			return c_minor_binary_operator_multiplicative;
		}
		
		private void SetCMinorExpression2(CMinorExpression input)
		{
			c_minor_expression2 = input;
		}
		
		public override CMinorExpression GetCMinorExpression2()
		{
			return c_minor_expression2;
		}
		
	}
	
	public partial class CMinorExpression_BinaryOperation_Additive : CMinorExpression_BinaryOperation
	{
		[RelatableChild]private CMinorExpression c_minor_expression1;
		[RelatableChild]private CMinorBinaryOperator_Additive c_minor_binary_operator_additive;
		[RelatableChild]private CMinorExpression c_minor_expression2;
		static public CMinorExpression_BinaryOperation_Additive DOMify(CMinorParser.CMinorExpression_BinaryOperation_AdditiveContext context)
		{
			if(context != null)
			{
				return new CMinorExpression_BinaryOperation_Additive(context);
			}
			
			return null;
		}
		
		static new public CMinorExpression_BinaryOperation_Additive DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorExpression_BinaryOperation_AdditiveContext);
		}
		
		static new public CMinorExpression_BinaryOperation_Additive DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorExpression());
		}
		
		static new public CMinorExpression_BinaryOperation_Additive DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorExpression());
		}
		
		static new public CMinorExpression_BinaryOperation_Additive DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorExpression());
		}
		
		public CMinorExpression_BinaryOperation_Additive()
		{
			c_minor_expression1 = null;
			c_minor_binary_operator_additive = null;
			c_minor_expression2 = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorExpression_BinaryOperation_Additive(CMinorParser.CMinorExpression_BinaryOperation_AdditiveContext context) : this()
		{
			SetCMinorExpression1(CMinorExpression.DOMify(context.cMinorExpression(0)));
			SetCMinorBinaryOperatorAdditive(CMinorBinaryOperator_Additive.DOMify(context.cMinorBinaryOperator_Additive()));
			SetCMinorExpression2(CMinorExpression.DOMify(context.cMinorExpression(1)));
		}
		
		public override CMinorExpression Duplicate()
		{
			CMinorExpression_BinaryOperation_Additive instance = new CMinorExpression_BinaryOperation_Additive();
			instance.SetCMinorExpression1(GetCMinorExpression1().IfNotNull(z => z.Duplicate()));
			instance.SetCMinorBinaryOperatorAdditive(GetCMinorBinaryOperatorAdditive().IfNotNull(z => z.Duplicate()));
			instance.SetCMinorExpression2(GetCMinorExpression2().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetCMinorExpression1(CMinorExpression input)
		{
			c_minor_expression1 = input;
		}
		
		public override CMinorExpression GetCMinorExpression1()
		{
			return c_minor_expression1;
		}
		
		private void SetCMinorBinaryOperatorAdditive(CMinorBinaryOperator_Additive input)
		{
			c_minor_binary_operator_additive = input;
		}
		
		public CMinorBinaryOperator_Additive GetCMinorBinaryOperatorAdditive()
		{
			return c_minor_binary_operator_additive;
		}
		
		private void SetCMinorExpression2(CMinorExpression input)
		{
			c_minor_expression2 = input;
		}
		
		public override CMinorExpression GetCMinorExpression2()
		{
			return c_minor_expression2;
		}
		
	}
	
	public partial class CMinorExpression_BinaryOperation_Comparative : CMinorExpression_BinaryOperation
	{
		[RelatableChild]private CMinorExpression c_minor_expression1;
		[RelatableChild]private CMinorBinaryOperator_Comparative c_minor_binary_operator_comparative;
		[RelatableChild]private CMinorExpression c_minor_expression2;
		static public CMinorExpression_BinaryOperation_Comparative DOMify(CMinorParser.CMinorExpression_BinaryOperation_ComparativeContext context)
		{
			if(context != null)
			{
				return new CMinorExpression_BinaryOperation_Comparative(context);
			}
			
			return null;
		}
		
		static new public CMinorExpression_BinaryOperation_Comparative DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorExpression_BinaryOperation_ComparativeContext);
		}
		
		static new public CMinorExpression_BinaryOperation_Comparative DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorExpression());
		}
		
		static new public CMinorExpression_BinaryOperation_Comparative DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorExpression());
		}
		
		static new public CMinorExpression_BinaryOperation_Comparative DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorExpression());
		}
		
		public CMinorExpression_BinaryOperation_Comparative()
		{
			c_minor_expression1 = null;
			c_minor_binary_operator_comparative = null;
			c_minor_expression2 = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorExpression_BinaryOperation_Comparative(CMinorParser.CMinorExpression_BinaryOperation_ComparativeContext context) : this()
		{
			SetCMinorExpression1(CMinorExpression.DOMify(context.cMinorExpression(0)));
			SetCMinorBinaryOperatorComparative(CMinorBinaryOperator_Comparative.DOMify(context.cMinorBinaryOperator_Comparative()));
			SetCMinorExpression2(CMinorExpression.DOMify(context.cMinorExpression(1)));
		}
		
		public override CMinorExpression Duplicate()
		{
			CMinorExpression_BinaryOperation_Comparative instance = new CMinorExpression_BinaryOperation_Comparative();
			instance.SetCMinorExpression1(GetCMinorExpression1().IfNotNull(z => z.Duplicate()));
			instance.SetCMinorBinaryOperatorComparative(GetCMinorBinaryOperatorComparative().IfNotNull(z => z.Duplicate()));
			instance.SetCMinorExpression2(GetCMinorExpression2().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetCMinorExpression1(CMinorExpression input)
		{
			c_minor_expression1 = input;
		}
		
		public override CMinorExpression GetCMinorExpression1()
		{
			return c_minor_expression1;
		}
		
		private void SetCMinorBinaryOperatorComparative(CMinorBinaryOperator_Comparative input)
		{
			c_minor_binary_operator_comparative = input;
		}
		
		public CMinorBinaryOperator_Comparative GetCMinorBinaryOperatorComparative()
		{
			return c_minor_binary_operator_comparative;
		}
		
		private void SetCMinorExpression2(CMinorExpression input)
		{
			c_minor_expression2 = input;
		}
		
		public override CMinorExpression GetCMinorExpression2()
		{
			return c_minor_expression2;
		}
		
	}
	
	public partial class CMinorExpression_BinaryOperation_Boolean : CMinorExpression_BinaryOperation
	{
		[RelatableChild]private CMinorExpression c_minor_expression1;
		[RelatableChild]private CMinorBinaryOperator_Boolean c_minor_binary_operator_boolean;
		[RelatableChild]private CMinorExpression c_minor_expression2;
		static public CMinorExpression_BinaryOperation_Boolean DOMify(CMinorParser.CMinorExpression_BinaryOperation_BooleanContext context)
		{
			if(context != null)
			{
				return new CMinorExpression_BinaryOperation_Boolean(context);
			}
			
			return null;
		}
		
		static new public CMinorExpression_BinaryOperation_Boolean DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorExpression_BinaryOperation_BooleanContext);
		}
		
		static new public CMinorExpression_BinaryOperation_Boolean DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorExpression());
		}
		
		static new public CMinorExpression_BinaryOperation_Boolean DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorExpression());
		}
		
		static new public CMinorExpression_BinaryOperation_Boolean DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorExpression());
		}
		
		public CMinorExpression_BinaryOperation_Boolean()
		{
			c_minor_expression1 = null;
			c_minor_binary_operator_boolean = null;
			c_minor_expression2 = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorExpression_BinaryOperation_Boolean(CMinorParser.CMinorExpression_BinaryOperation_BooleanContext context) : this()
		{
			SetCMinorExpression1(CMinorExpression.DOMify(context.cMinorExpression(0)));
			SetCMinorBinaryOperatorBoolean(CMinorBinaryOperator_Boolean.DOMify(context.cMinorBinaryOperator_Boolean()));
			SetCMinorExpression2(CMinorExpression.DOMify(context.cMinorExpression(1)));
		}
		
		public override CMinorExpression Duplicate()
		{
			CMinorExpression_BinaryOperation_Boolean instance = new CMinorExpression_BinaryOperation_Boolean();
			instance.SetCMinorExpression1(GetCMinorExpression1().IfNotNull(z => z.Duplicate()));
			instance.SetCMinorBinaryOperatorBoolean(GetCMinorBinaryOperatorBoolean().IfNotNull(z => z.Duplicate()));
			instance.SetCMinorExpression2(GetCMinorExpression2().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetCMinorExpression1(CMinorExpression input)
		{
			c_minor_expression1 = input;
		}
		
		public override CMinorExpression GetCMinorExpression1()
		{
			return c_minor_expression1;
		}
		
		private void SetCMinorBinaryOperatorBoolean(CMinorBinaryOperator_Boolean input)
		{
			c_minor_binary_operator_boolean = input;
		}
		
		public CMinorBinaryOperator_Boolean GetCMinorBinaryOperatorBoolean()
		{
			return c_minor_binary_operator_boolean;
		}
		
		private void SetCMinorExpression2(CMinorExpression input)
		{
			c_minor_expression2 = input;
		}
		
		public override CMinorExpression GetCMinorExpression2()
		{
			return c_minor_expression2;
		}
		
	}
	
	public abstract partial class CMinorBinaryOperator_Multiplicative : CMinorBinaryOperator
	{
		public abstract CMinorBinaryOperator_Multiplicative Duplicate();
		static public CMinorBinaryOperator_Multiplicative DOMify(CMinorParser.CMinorBinaryOperator_MultiplicativeContext context)
		{
			return CMinorResolver.Resolve<CMinorBinaryOperator_Multiplicative>(context);
		}
		
		static public CMinorBinaryOperator_Multiplicative DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorBinaryOperator_MultiplicativeContext);
		}
		
		static public CMinorBinaryOperator_Multiplicative DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorBinaryOperator_Multiplicative());
		}
		
		static public CMinorBinaryOperator_Multiplicative DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorBinaryOperator_Multiplicative());
		}
		
		static public CMinorBinaryOperator_Multiplicative DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorBinaryOperator_Multiplicative());
		}
		
	}
	
	public partial class CMinorBinaryOperator_Multiplicative_Multiply : CMinorBinaryOperator_Multiplicative
	{
		static public CMinorBinaryOperator_Multiplicative_Multiply DOMify(CMinorParser.CMinorBinaryOperator_Multiplicative_MultiplyContext context)
		{
			if(context != null)
			{
				return new CMinorBinaryOperator_Multiplicative_Multiply(context);
			}
			
			return null;
		}
		
		static new public CMinorBinaryOperator_Multiplicative_Multiply DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorBinaryOperator_Multiplicative_MultiplyContext);
		}
		
		static new public CMinorBinaryOperator_Multiplicative_Multiply DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorBinaryOperator_Multiplicative());
		}
		
		static new public CMinorBinaryOperator_Multiplicative_Multiply DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorBinaryOperator_Multiplicative());
		}
		
		static new public CMinorBinaryOperator_Multiplicative_Multiply DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorBinaryOperator_Multiplicative());
		}
		
		public CMinorBinaryOperator_Multiplicative_Multiply()
		{
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorBinaryOperator_Multiplicative_Multiply(CMinorParser.CMinorBinaryOperator_Multiplicative_MultiplyContext context) : this()
		{
		}
		
		public override CMinorBinaryOperator_Multiplicative Duplicate()
		{
			CMinorBinaryOperator_Multiplicative_Multiply instance = new CMinorBinaryOperator_Multiplicative_Multiply();
			return instance;
		}
		
	}
	
	public partial class CMinorBinaryOperator_Multiplicative_Divide : CMinorBinaryOperator_Multiplicative
	{
		static public CMinorBinaryOperator_Multiplicative_Divide DOMify(CMinorParser.CMinorBinaryOperator_Multiplicative_DivideContext context)
		{
			if(context != null)
			{
				return new CMinorBinaryOperator_Multiplicative_Divide(context);
			}
			
			return null;
		}
		
		static new public CMinorBinaryOperator_Multiplicative_Divide DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorBinaryOperator_Multiplicative_DivideContext);
		}
		
		static new public CMinorBinaryOperator_Multiplicative_Divide DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorBinaryOperator_Multiplicative());
		}
		
		static new public CMinorBinaryOperator_Multiplicative_Divide DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorBinaryOperator_Multiplicative());
		}
		
		static new public CMinorBinaryOperator_Multiplicative_Divide DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorBinaryOperator_Multiplicative());
		}
		
		public CMinorBinaryOperator_Multiplicative_Divide()
		{
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorBinaryOperator_Multiplicative_Divide(CMinorParser.CMinorBinaryOperator_Multiplicative_DivideContext context) : this()
		{
		}
		
		public override CMinorBinaryOperator_Multiplicative Duplicate()
		{
			CMinorBinaryOperator_Multiplicative_Divide instance = new CMinorBinaryOperator_Multiplicative_Divide();
			return instance;
		}
		
	}
	
	public partial class CMinorBinaryOperator_Multiplicative_Modulo : CMinorBinaryOperator_Multiplicative
	{
		static public CMinorBinaryOperator_Multiplicative_Modulo DOMify(CMinorParser.CMinorBinaryOperator_Multiplicative_ModuloContext context)
		{
			if(context != null)
			{
				return new CMinorBinaryOperator_Multiplicative_Modulo(context);
			}
			
			return null;
		}
		
		static new public CMinorBinaryOperator_Multiplicative_Modulo DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorBinaryOperator_Multiplicative_ModuloContext);
		}
		
		static new public CMinorBinaryOperator_Multiplicative_Modulo DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorBinaryOperator_Multiplicative());
		}
		
		static new public CMinorBinaryOperator_Multiplicative_Modulo DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorBinaryOperator_Multiplicative());
		}
		
		static new public CMinorBinaryOperator_Multiplicative_Modulo DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorBinaryOperator_Multiplicative());
		}
		
		public CMinorBinaryOperator_Multiplicative_Modulo()
		{
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorBinaryOperator_Multiplicative_Modulo(CMinorParser.CMinorBinaryOperator_Multiplicative_ModuloContext context) : this()
		{
		}
		
		public override CMinorBinaryOperator_Multiplicative Duplicate()
		{
			CMinorBinaryOperator_Multiplicative_Modulo instance = new CMinorBinaryOperator_Multiplicative_Modulo();
			return instance;
		}
		
	}
	
	public abstract partial class CMinorBinaryOperator_Additive : CMinorBinaryOperator
	{
		public abstract CMinorBinaryOperator_Additive Duplicate();
		static public CMinorBinaryOperator_Additive DOMify(CMinorParser.CMinorBinaryOperator_AdditiveContext context)
		{
			return CMinorResolver.Resolve<CMinorBinaryOperator_Additive>(context);
		}
		
		static public CMinorBinaryOperator_Additive DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorBinaryOperator_AdditiveContext);
		}
		
		static public CMinorBinaryOperator_Additive DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorBinaryOperator_Additive());
		}
		
		static public CMinorBinaryOperator_Additive DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorBinaryOperator_Additive());
		}
		
		static public CMinorBinaryOperator_Additive DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorBinaryOperator_Additive());
		}
		
	}
	
	public partial class CMinorBinaryOperator_Additive_Add : CMinorBinaryOperator_Additive
	{
		static public CMinorBinaryOperator_Additive_Add DOMify(CMinorParser.CMinorBinaryOperator_Additive_AddContext context)
		{
			if(context != null)
			{
				return new CMinorBinaryOperator_Additive_Add(context);
			}
			
			return null;
		}
		
		static new public CMinorBinaryOperator_Additive_Add DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorBinaryOperator_Additive_AddContext);
		}
		
		static new public CMinorBinaryOperator_Additive_Add DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorBinaryOperator_Additive());
		}
		
		static new public CMinorBinaryOperator_Additive_Add DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorBinaryOperator_Additive());
		}
		
		static new public CMinorBinaryOperator_Additive_Add DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorBinaryOperator_Additive());
		}
		
		public CMinorBinaryOperator_Additive_Add()
		{
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorBinaryOperator_Additive_Add(CMinorParser.CMinorBinaryOperator_Additive_AddContext context) : this()
		{
		}
		
		public override CMinorBinaryOperator_Additive Duplicate()
		{
			CMinorBinaryOperator_Additive_Add instance = new CMinorBinaryOperator_Additive_Add();
			return instance;
		}
		
	}
	
	public partial class CMinorBinaryOperator_Additive_Subtract : CMinorBinaryOperator_Additive
	{
		static public CMinorBinaryOperator_Additive_Subtract DOMify(CMinorParser.CMinorBinaryOperator_Additive_SubtractContext context)
		{
			if(context != null)
			{
				return new CMinorBinaryOperator_Additive_Subtract(context);
			}
			
			return null;
		}
		
		static new public CMinorBinaryOperator_Additive_Subtract DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorBinaryOperator_Additive_SubtractContext);
		}
		
		static new public CMinorBinaryOperator_Additive_Subtract DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorBinaryOperator_Additive());
		}
		
		static new public CMinorBinaryOperator_Additive_Subtract DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorBinaryOperator_Additive());
		}
		
		static new public CMinorBinaryOperator_Additive_Subtract DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorBinaryOperator_Additive());
		}
		
		public CMinorBinaryOperator_Additive_Subtract()
		{
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorBinaryOperator_Additive_Subtract(CMinorParser.CMinorBinaryOperator_Additive_SubtractContext context) : this()
		{
		}
		
		public override CMinorBinaryOperator_Additive Duplicate()
		{
			CMinorBinaryOperator_Additive_Subtract instance = new CMinorBinaryOperator_Additive_Subtract();
			return instance;
		}
		
	}
	
	public abstract partial class CMinorBinaryOperator_Comparative : CMinorBinaryOperator
	{
		public abstract CMinorBinaryOperator_Comparative Duplicate();
		static public CMinorBinaryOperator_Comparative DOMify(CMinorParser.CMinorBinaryOperator_ComparativeContext context)
		{
			return CMinorResolver.Resolve<CMinorBinaryOperator_Comparative>(context);
		}
		
		static public CMinorBinaryOperator_Comparative DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorBinaryOperator_ComparativeContext);
		}
		
		static public CMinorBinaryOperator_Comparative DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorBinaryOperator_Comparative());
		}
		
		static public CMinorBinaryOperator_Comparative DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorBinaryOperator_Comparative());
		}
		
		static public CMinorBinaryOperator_Comparative DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorBinaryOperator_Comparative());
		}
		
	}
	
	public partial class CMinorBinaryOperator_Comparative_LessThan : CMinorBinaryOperator_Comparative
	{
		static public CMinorBinaryOperator_Comparative_LessThan DOMify(CMinorParser.CMinorBinaryOperator_Comparative_LessThanContext context)
		{
			if(context != null)
			{
				return new CMinorBinaryOperator_Comparative_LessThan(context);
			}
			
			return null;
		}
		
		static new public CMinorBinaryOperator_Comparative_LessThan DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorBinaryOperator_Comparative_LessThanContext);
		}
		
		static new public CMinorBinaryOperator_Comparative_LessThan DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorBinaryOperator_Comparative());
		}
		
		static new public CMinorBinaryOperator_Comparative_LessThan DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorBinaryOperator_Comparative());
		}
		
		static new public CMinorBinaryOperator_Comparative_LessThan DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorBinaryOperator_Comparative());
		}
		
		public CMinorBinaryOperator_Comparative_LessThan()
		{
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorBinaryOperator_Comparative_LessThan(CMinorParser.CMinorBinaryOperator_Comparative_LessThanContext context) : this()
		{
		}
		
		public override CMinorBinaryOperator_Comparative Duplicate()
		{
			CMinorBinaryOperator_Comparative_LessThan instance = new CMinorBinaryOperator_Comparative_LessThan();
			return instance;
		}
		
	}
	
	public partial class CMinorBinaryOperator_Comparative_LessThanOrEqualTo : CMinorBinaryOperator_Comparative
	{
		static public CMinorBinaryOperator_Comparative_LessThanOrEqualTo DOMify(CMinorParser.CMinorBinaryOperator_Comparative_LessThanOrEqualToContext context)
		{
			if(context != null)
			{
				return new CMinorBinaryOperator_Comparative_LessThanOrEqualTo(context);
			}
			
			return null;
		}
		
		static new public CMinorBinaryOperator_Comparative_LessThanOrEqualTo DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorBinaryOperator_Comparative_LessThanOrEqualToContext);
		}
		
		static new public CMinorBinaryOperator_Comparative_LessThanOrEqualTo DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorBinaryOperator_Comparative());
		}
		
		static new public CMinorBinaryOperator_Comparative_LessThanOrEqualTo DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorBinaryOperator_Comparative());
		}
		
		static new public CMinorBinaryOperator_Comparative_LessThanOrEqualTo DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorBinaryOperator_Comparative());
		}
		
		public CMinorBinaryOperator_Comparative_LessThanOrEqualTo()
		{
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorBinaryOperator_Comparative_LessThanOrEqualTo(CMinorParser.CMinorBinaryOperator_Comparative_LessThanOrEqualToContext context) : this()
		{
		}
		
		public override CMinorBinaryOperator_Comparative Duplicate()
		{
			CMinorBinaryOperator_Comparative_LessThanOrEqualTo instance = new CMinorBinaryOperator_Comparative_LessThanOrEqualTo();
			return instance;
		}
		
	}
	
	public partial class CMinorBinaryOperator_Comparative_GreaterThan : CMinorBinaryOperator_Comparative
	{
		static public CMinorBinaryOperator_Comparative_GreaterThan DOMify(CMinorParser.CMinorBinaryOperator_Comparative_GreaterThanContext context)
		{
			if(context != null)
			{
				return new CMinorBinaryOperator_Comparative_GreaterThan(context);
			}
			
			return null;
		}
		
		static new public CMinorBinaryOperator_Comparative_GreaterThan DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorBinaryOperator_Comparative_GreaterThanContext);
		}
		
		static new public CMinorBinaryOperator_Comparative_GreaterThan DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorBinaryOperator_Comparative());
		}
		
		static new public CMinorBinaryOperator_Comparative_GreaterThan DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorBinaryOperator_Comparative());
		}
		
		static new public CMinorBinaryOperator_Comparative_GreaterThan DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorBinaryOperator_Comparative());
		}
		
		public CMinorBinaryOperator_Comparative_GreaterThan()
		{
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorBinaryOperator_Comparative_GreaterThan(CMinorParser.CMinorBinaryOperator_Comparative_GreaterThanContext context) : this()
		{
		}
		
		public override CMinorBinaryOperator_Comparative Duplicate()
		{
			CMinorBinaryOperator_Comparative_GreaterThan instance = new CMinorBinaryOperator_Comparative_GreaterThan();
			return instance;
		}
		
	}
	
	public partial class CMinorBinaryOperator_Comparative_GreaterThanOrEqualTo : CMinorBinaryOperator_Comparative
	{
		static public CMinorBinaryOperator_Comparative_GreaterThanOrEqualTo DOMify(CMinorParser.CMinorBinaryOperator_Comparative_GreaterThanOrEqualToContext context)
		{
			if(context != null)
			{
				return new CMinorBinaryOperator_Comparative_GreaterThanOrEqualTo(context);
			}
			
			return null;
		}
		
		static new public CMinorBinaryOperator_Comparative_GreaterThanOrEqualTo DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorBinaryOperator_Comparative_GreaterThanOrEqualToContext);
		}
		
		static new public CMinorBinaryOperator_Comparative_GreaterThanOrEqualTo DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorBinaryOperator_Comparative());
		}
		
		static new public CMinorBinaryOperator_Comparative_GreaterThanOrEqualTo DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorBinaryOperator_Comparative());
		}
		
		static new public CMinorBinaryOperator_Comparative_GreaterThanOrEqualTo DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorBinaryOperator_Comparative());
		}
		
		public CMinorBinaryOperator_Comparative_GreaterThanOrEqualTo()
		{
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorBinaryOperator_Comparative_GreaterThanOrEqualTo(CMinorParser.CMinorBinaryOperator_Comparative_GreaterThanOrEqualToContext context) : this()
		{
		}
		
		public override CMinorBinaryOperator_Comparative Duplicate()
		{
			CMinorBinaryOperator_Comparative_GreaterThanOrEqualTo instance = new CMinorBinaryOperator_Comparative_GreaterThanOrEqualTo();
			return instance;
		}
		
	}
	
	public partial class CMinorBinaryOperator_Comparative_EqualTo : CMinorBinaryOperator_Comparative
	{
		static public CMinorBinaryOperator_Comparative_EqualTo DOMify(CMinorParser.CMinorBinaryOperator_Comparative_EqualToContext context)
		{
			if(context != null)
			{
				return new CMinorBinaryOperator_Comparative_EqualTo(context);
			}
			
			return null;
		}
		
		static new public CMinorBinaryOperator_Comparative_EqualTo DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorBinaryOperator_Comparative_EqualToContext);
		}
		
		static new public CMinorBinaryOperator_Comparative_EqualTo DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorBinaryOperator_Comparative());
		}
		
		static new public CMinorBinaryOperator_Comparative_EqualTo DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorBinaryOperator_Comparative());
		}
		
		static new public CMinorBinaryOperator_Comparative_EqualTo DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorBinaryOperator_Comparative());
		}
		
		public CMinorBinaryOperator_Comparative_EqualTo()
		{
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorBinaryOperator_Comparative_EqualTo(CMinorParser.CMinorBinaryOperator_Comparative_EqualToContext context) : this()
		{
		}
		
		public override CMinorBinaryOperator_Comparative Duplicate()
		{
			CMinorBinaryOperator_Comparative_EqualTo instance = new CMinorBinaryOperator_Comparative_EqualTo();
			return instance;
		}
		
	}
	
	public partial class CMinorBinaryOperator_Comparative_NotEqualTo : CMinorBinaryOperator_Comparative
	{
		static public CMinorBinaryOperator_Comparative_NotEqualTo DOMify(CMinorParser.CMinorBinaryOperator_Comparative_NotEqualToContext context)
		{
			if(context != null)
			{
				return new CMinorBinaryOperator_Comparative_NotEqualTo(context);
			}
			
			return null;
		}
		
		static new public CMinorBinaryOperator_Comparative_NotEqualTo DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorBinaryOperator_Comparative_NotEqualToContext);
		}
		
		static new public CMinorBinaryOperator_Comparative_NotEqualTo DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorBinaryOperator_Comparative());
		}
		
		static new public CMinorBinaryOperator_Comparative_NotEqualTo DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorBinaryOperator_Comparative());
		}
		
		static new public CMinorBinaryOperator_Comparative_NotEqualTo DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorBinaryOperator_Comparative());
		}
		
		public CMinorBinaryOperator_Comparative_NotEqualTo()
		{
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorBinaryOperator_Comparative_NotEqualTo(CMinorParser.CMinorBinaryOperator_Comparative_NotEqualToContext context) : this()
		{
		}
		
		public override CMinorBinaryOperator_Comparative Duplicate()
		{
			CMinorBinaryOperator_Comparative_NotEqualTo instance = new CMinorBinaryOperator_Comparative_NotEqualTo();
			return instance;
		}
		
	}
	
	public abstract partial class CMinorBinaryOperator_Boolean : CMinorBinaryOperator
	{
		public abstract CMinorBinaryOperator_Boolean Duplicate();
		static public CMinorBinaryOperator_Boolean DOMify(CMinorParser.CMinorBinaryOperator_BooleanContext context)
		{
			return CMinorResolver.Resolve<CMinorBinaryOperator_Boolean>(context);
		}
		
		static public CMinorBinaryOperator_Boolean DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorBinaryOperator_BooleanContext);
		}
		
		static public CMinorBinaryOperator_Boolean DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorBinaryOperator_Boolean());
		}
		
		static public CMinorBinaryOperator_Boolean DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorBinaryOperator_Boolean());
		}
		
		static public CMinorBinaryOperator_Boolean DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorBinaryOperator_Boolean());
		}
		
	}
	
	public partial class CMinorBinaryOperator_Boolean_And : CMinorBinaryOperator_Boolean
	{
		static public CMinorBinaryOperator_Boolean_And DOMify(CMinorParser.CMinorBinaryOperator_Boolean_AndContext context)
		{
			if(context != null)
			{
				return new CMinorBinaryOperator_Boolean_And(context);
			}
			
			return null;
		}
		
		static new public CMinorBinaryOperator_Boolean_And DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorBinaryOperator_Boolean_AndContext);
		}
		
		static new public CMinorBinaryOperator_Boolean_And DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorBinaryOperator_Boolean());
		}
		
		static new public CMinorBinaryOperator_Boolean_And DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorBinaryOperator_Boolean());
		}
		
		static new public CMinorBinaryOperator_Boolean_And DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorBinaryOperator_Boolean());
		}
		
		public CMinorBinaryOperator_Boolean_And()
		{
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorBinaryOperator_Boolean_And(CMinorParser.CMinorBinaryOperator_Boolean_AndContext context) : this()
		{
		}
		
		public override CMinorBinaryOperator_Boolean Duplicate()
		{
			CMinorBinaryOperator_Boolean_And instance = new CMinorBinaryOperator_Boolean_And();
			return instance;
		}
		
	}
	
	public partial class CMinorBinaryOperator_Boolean_Or : CMinorBinaryOperator_Boolean
	{
		static public CMinorBinaryOperator_Boolean_Or DOMify(CMinorParser.CMinorBinaryOperator_Boolean_OrContext context)
		{
			if(context != null)
			{
				return new CMinorBinaryOperator_Boolean_Or(context);
			}
			
			return null;
		}
		
		static new public CMinorBinaryOperator_Boolean_Or DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorBinaryOperator_Boolean_OrContext);
		}
		
		static new public CMinorBinaryOperator_Boolean_Or DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorBinaryOperator_Boolean());
		}
		
		static new public CMinorBinaryOperator_Boolean_Or DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorBinaryOperator_Boolean());
		}
		
		static new public CMinorBinaryOperator_Boolean_Or DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorBinaryOperator_Boolean());
		}
		
		public CMinorBinaryOperator_Boolean_Or()
		{
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorBinaryOperator_Boolean_Or(CMinorParser.CMinorBinaryOperator_Boolean_OrContext context) : this()
		{
		}
		
		public override CMinorBinaryOperator_Boolean Duplicate()
		{
			CMinorBinaryOperator_Boolean_Or instance = new CMinorBinaryOperator_Boolean_Or();
			return instance;
		}
		
	}
	
	public partial class CMinorExpressionList : CMinorElement
	{
		[RelatableChild]private List<CMinorExpression> c_minor_expressions;
		static public CMinorExpressionList DOMify(CMinorParser.CMinorExpressionListContext context)
		{
			if(context != null)
			{
				return new CMinorExpressionList(context);
			}
			
			return null;
		}
		
		static public CMinorExpressionList DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorExpressionListContext);
		}
		
		static public CMinorExpressionList DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorExpressionList());
		}
		
		static public CMinorExpressionList DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorExpressionList());
		}
		
		static public CMinorExpressionList DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorExpressionList());
		}
		
		public CMinorExpressionList()
		{
			c_minor_expressions = new List<CMinorExpression>();
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorExpressionList(CMinorParser.CMinorExpressionListContext context) : this()
		{
			AddCMinorExpressions(context.cMinorExpression().Convert(c => CMinorExpression.DOMify(c)));
		}
		
		public CMinorExpressionList Duplicate()
		{
			CMinorExpressionList instance = new CMinorExpressionList();
			instance.SetCMinorExpressions(GetCMinorExpressions().Convert(i => i.IfNotNull(z => z.Duplicate())));
			return instance;
		}
		
		private void ClearCMinorExpressions()
		{
			c_minor_expressions.Clear();
		}
		
		private void SetCMinorExpressions(IEnumerable<CMinorExpression> input)
		{
			ClearCMinorExpressions();
			AddCMinorExpressions(input);
		}
		
		private void SetCMinorExpressions(params CMinorExpression[] input)
		{
			SetCMinorExpressions((IEnumerable<CMinorExpression>)input);
		}
		
		private void AddCMinorExpression(CMinorExpression input)
		{
			c_minor_expressions.Add(input);
		}
		
		private void AddCMinorExpressions(IEnumerable<CMinorExpression> input)
		{
			input.Process(i => AddCMinorExpression(i));
		}
		
		private void AddCMinorExpressions(params CMinorExpression[] input)
		{
			AddCMinorExpressions((IEnumerable<CMinorExpression>)input);
		}
		
		public IEnumerable<CMinorExpression> GetCMinorExpressions()
		{
			return c_minor_expressions;
		}
		
	}
	
	public abstract partial class CMinorStatement : CMinorElement
	{
		public abstract CMinorStatement Duplicate();
		static public CMinorStatement DOMify(CMinorParser.CMinorStatementContext context)
		{
			return CMinorResolver.Resolve<CMinorStatement>(context);
		}
		
		static public CMinorStatement DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorStatementContext);
		}
		
		static public CMinorStatement DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorStatement());
		}
		
		static public CMinorStatement DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorStatement());
		}
		
		static public CMinorStatement DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorStatement());
		}
		
	}
	
	public partial class CMinorStatement_DirectAssign : CMinorStatement
	{
		private string id;
		[RelatableChild]private CMinorExpression c_minor_expression;
		static public CMinorStatement_DirectAssign DOMify(CMinorParser.CMinorStatement_DirectAssignContext context)
		{
			if(context != null)
			{
				return new CMinorStatement_DirectAssign(context);
			}
			
			return null;
		}
		
		static new public CMinorStatement_DirectAssign DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorStatement_DirectAssignContext);
		}
		
		static new public CMinorStatement_DirectAssign DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorStatement());
		}
		
		static new public CMinorStatement_DirectAssign DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorStatement());
		}
		
		static new public CMinorStatement_DirectAssign DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorStatement());
		}
		
		public CMinorStatement_DirectAssign()
		{
			id = "";
			c_minor_expression = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorStatement_DirectAssign(CMinorParser.CMinorStatement_DirectAssignContext context) : this()
		{
			SetId(context.ID().GetTextEX());
			SetCMinorExpression(CMinorExpression.DOMify(context.cMinorExpression()));
		}
		
		public override CMinorStatement Duplicate()
		{
			CMinorStatement_DirectAssign instance = new CMinorStatement_DirectAssign();
			instance.SetId(GetId());
			instance.SetCMinorExpression(GetCMinorExpression().IfNotNull(z => z.Duplicate()));
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
		
		private void SetCMinorExpression(CMinorExpression input)
		{
			c_minor_expression = input;
		}
		
		public CMinorExpression GetCMinorExpression()
		{
			return c_minor_expression;
		}
		
	}
	
	public partial class CMinorStatement_IndirectAssign : CMinorStatement
	{
		[RelatableChild]private CMinorExpression c_minor_expression1;
		private string id;
		[RelatableChild]private CMinorExpression c_minor_expression2;
		static public CMinorStatement_IndirectAssign DOMify(CMinorParser.CMinorStatement_IndirectAssignContext context)
		{
			if(context != null)
			{
				return new CMinorStatement_IndirectAssign(context);
			}
			
			return null;
		}
		
		static new public CMinorStatement_IndirectAssign DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorStatement_IndirectAssignContext);
		}
		
		static new public CMinorStatement_IndirectAssign DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorStatement());
		}
		
		static new public CMinorStatement_IndirectAssign DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorStatement());
		}
		
		static new public CMinorStatement_IndirectAssign DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorStatement());
		}
		
		public CMinorStatement_IndirectAssign()
		{
			c_minor_expression1 = null;
			id = "";
			c_minor_expression2 = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorStatement_IndirectAssign(CMinorParser.CMinorStatement_IndirectAssignContext context) : this()
		{
			SetCMinorExpression1(CMinorExpression.DOMify(context.cMinorExpression(0)));
			SetId(context.ID().GetTextEX());
			SetCMinorExpression2(CMinorExpression.DOMify(context.cMinorExpression(1)));
		}
		
		public override CMinorStatement Duplicate()
		{
			CMinorStatement_IndirectAssign instance = new CMinorStatement_IndirectAssign();
			instance.SetCMinorExpression1(GetCMinorExpression1().IfNotNull(z => z.Duplicate()));
			instance.SetId(GetId());
			instance.SetCMinorExpression2(GetCMinorExpression2().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetCMinorExpression1(CMinorExpression input)
		{
			c_minor_expression1 = input;
		}
		
		public CMinorExpression GetCMinorExpression1()
		{
			return c_minor_expression1;
		}
		
		private void SetId(string input)
		{
			id = input;
		}
		
		public string GetId()
		{
			return id;
		}
		
		private void SetCMinorExpression2(CMinorExpression input)
		{
			c_minor_expression2 = input;
		}
		
		public CMinorExpression GetCMinorExpression2()
		{
			return c_minor_expression2;
		}
		
	}
	
	public partial class CMinorStatement_OperationAssign_DirectAdditive : CMinorStatement_OperationAssign
	{
		private string id;
		[RelatableChild]private CMinorBinaryOperator_Additive c_minor_binary_operator_additive;
		[RelatableChild]private CMinorExpression assignment_expression;
		static public CMinorStatement_OperationAssign_DirectAdditive DOMify(CMinorParser.CMinorStatement_OperationAssign_DirectAdditiveContext context)
		{
			if(context != null)
			{
				return new CMinorStatement_OperationAssign_DirectAdditive(context);
			}
			
			return null;
		}
		
		static new public CMinorStatement_OperationAssign_DirectAdditive DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorStatement_OperationAssign_DirectAdditiveContext);
		}
		
		static new public CMinorStatement_OperationAssign_DirectAdditive DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorStatement());
		}
		
		static new public CMinorStatement_OperationAssign_DirectAdditive DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorStatement());
		}
		
		static new public CMinorStatement_OperationAssign_DirectAdditive DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorStatement());
		}
		
		public CMinorStatement_OperationAssign_DirectAdditive()
		{
			id = "";
			c_minor_binary_operator_additive = null;
			assignment_expression = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorStatement_OperationAssign_DirectAdditive(CMinorParser.CMinorStatement_OperationAssign_DirectAdditiveContext context) : this()
		{
			SetId(context.ID().GetTextEX());
			SetCMinorBinaryOperatorAdditive(CMinorBinaryOperator_Additive.DOMify(context.cMinorBinaryOperator_Additive()));
			SetAssignmentExpression(CMinorExpression.DOMify(context.cMinorExpression()));
		}
		
		public override CMinorStatement Duplicate()
		{
			CMinorStatement_OperationAssign_DirectAdditive instance = new CMinorStatement_OperationAssign_DirectAdditive();
			instance.SetId(GetId());
			instance.SetCMinorBinaryOperatorAdditive(GetCMinorBinaryOperatorAdditive().IfNotNull(z => z.Duplicate()));
			instance.SetAssignmentExpression(GetAssignmentExpression().IfNotNull(z => z.Duplicate()));
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
		
		private void SetCMinorBinaryOperatorAdditive(CMinorBinaryOperator_Additive input)
		{
			c_minor_binary_operator_additive = input;
		}
		
		public CMinorBinaryOperator_Additive GetCMinorBinaryOperatorAdditive()
		{
			return c_minor_binary_operator_additive;
		}
		
		private void SetAssignmentExpression(CMinorExpression input)
		{
			assignment_expression = input;
		}
		
		public override CMinorExpression GetAssignmentExpression()
		{
			return assignment_expression;
		}
		
	}
	
	public partial class CMinorStatement_OperationAssign_DirectMultiplicative : CMinorStatement_OperationAssign
	{
		private string id;
		[RelatableChild]private CMinorBinaryOperator_Multiplicative c_minor_binary_operator_multiplicative;
		[RelatableChild]private CMinorExpression assignment_expression;
		static public CMinorStatement_OperationAssign_DirectMultiplicative DOMify(CMinorParser.CMinorStatement_OperationAssign_DirectMultiplicativeContext context)
		{
			if(context != null)
			{
				return new CMinorStatement_OperationAssign_DirectMultiplicative(context);
			}
			
			return null;
		}
		
		static new public CMinorStatement_OperationAssign_DirectMultiplicative DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorStatement_OperationAssign_DirectMultiplicativeContext);
		}
		
		static new public CMinorStatement_OperationAssign_DirectMultiplicative DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorStatement());
		}
		
		static new public CMinorStatement_OperationAssign_DirectMultiplicative DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorStatement());
		}
		
		static new public CMinorStatement_OperationAssign_DirectMultiplicative DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorStatement());
		}
		
		public CMinorStatement_OperationAssign_DirectMultiplicative()
		{
			id = "";
			c_minor_binary_operator_multiplicative = null;
			assignment_expression = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorStatement_OperationAssign_DirectMultiplicative(CMinorParser.CMinorStatement_OperationAssign_DirectMultiplicativeContext context) : this()
		{
			SetId(context.ID().GetTextEX());
			SetCMinorBinaryOperatorMultiplicative(CMinorBinaryOperator_Multiplicative.DOMify(context.cMinorBinaryOperator_Multiplicative()));
			SetAssignmentExpression(CMinorExpression.DOMify(context.cMinorExpression()));
		}
		
		public override CMinorStatement Duplicate()
		{
			CMinorStatement_OperationAssign_DirectMultiplicative instance = new CMinorStatement_OperationAssign_DirectMultiplicative();
			instance.SetId(GetId());
			instance.SetCMinorBinaryOperatorMultiplicative(GetCMinorBinaryOperatorMultiplicative().IfNotNull(z => z.Duplicate()));
			instance.SetAssignmentExpression(GetAssignmentExpression().IfNotNull(z => z.Duplicate()));
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
		
		private void SetCMinorBinaryOperatorMultiplicative(CMinorBinaryOperator_Multiplicative input)
		{
			c_minor_binary_operator_multiplicative = input;
		}
		
		public CMinorBinaryOperator_Multiplicative GetCMinorBinaryOperatorMultiplicative()
		{
			return c_minor_binary_operator_multiplicative;
		}
		
		private void SetAssignmentExpression(CMinorExpression input)
		{
			assignment_expression = input;
		}
		
		public override CMinorExpression GetAssignmentExpression()
		{
			return assignment_expression;
		}
		
	}
	
	public partial class CMinorStatement_OperationAssign_IndirectAdditive : CMinorStatement_OperationAssign
	{
		[RelatableChild]private CMinorExpression c_minor_expression1;
		private string id;
		[RelatableChild]private CMinorBinaryOperator_Additive c_minor_binary_operator_additive;
		[RelatableChild]private CMinorExpression assignment_expression;
		static public CMinorStatement_OperationAssign_IndirectAdditive DOMify(CMinorParser.CMinorStatement_OperationAssign_IndirectAdditiveContext context)
		{
			if(context != null)
			{
				return new CMinorStatement_OperationAssign_IndirectAdditive(context);
			}
			
			return null;
		}
		
		static new public CMinorStatement_OperationAssign_IndirectAdditive DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorStatement_OperationAssign_IndirectAdditiveContext);
		}
		
		static new public CMinorStatement_OperationAssign_IndirectAdditive DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorStatement());
		}
		
		static new public CMinorStatement_OperationAssign_IndirectAdditive DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorStatement());
		}
		
		static new public CMinorStatement_OperationAssign_IndirectAdditive DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorStatement());
		}
		
		public CMinorStatement_OperationAssign_IndirectAdditive()
		{
			c_minor_expression1 = null;
			id = "";
			c_minor_binary_operator_additive = null;
			assignment_expression = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorStatement_OperationAssign_IndirectAdditive(CMinorParser.CMinorStatement_OperationAssign_IndirectAdditiveContext context) : this()
		{
			SetCMinorExpression1(CMinorExpression.DOMify(context.cMinorExpression(0)));
			SetId(context.ID().GetTextEX());
			SetCMinorBinaryOperatorAdditive(CMinorBinaryOperator_Additive.DOMify(context.cMinorBinaryOperator_Additive()));
			SetAssignmentExpression(CMinorExpression.DOMify(context.cMinorExpression(1)));
		}
		
		public override CMinorStatement Duplicate()
		{
			CMinorStatement_OperationAssign_IndirectAdditive instance = new CMinorStatement_OperationAssign_IndirectAdditive();
			instance.SetCMinorExpression1(GetCMinorExpression1().IfNotNull(z => z.Duplicate()));
			instance.SetId(GetId());
			instance.SetCMinorBinaryOperatorAdditive(GetCMinorBinaryOperatorAdditive().IfNotNull(z => z.Duplicate()));
			instance.SetAssignmentExpression(GetAssignmentExpression().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetCMinorExpression1(CMinorExpression input)
		{
			c_minor_expression1 = input;
		}
		
		public CMinorExpression GetCMinorExpression1()
		{
			return c_minor_expression1;
		}
		
		private void SetId(string input)
		{
			id = input;
		}
		
		public string GetId()
		{
			return id;
		}
		
		private void SetCMinorBinaryOperatorAdditive(CMinorBinaryOperator_Additive input)
		{
			c_minor_binary_operator_additive = input;
		}
		
		public CMinorBinaryOperator_Additive GetCMinorBinaryOperatorAdditive()
		{
			return c_minor_binary_operator_additive;
		}
		
		private void SetAssignmentExpression(CMinorExpression input)
		{
			assignment_expression = input;
		}
		
		public override CMinorExpression GetAssignmentExpression()
		{
			return assignment_expression;
		}
		
	}
	
	public partial class CMinorStatement_OperationAssign_IndirectMultiplicative : CMinorStatement_OperationAssign
	{
		[RelatableChild]private CMinorExpression c_minor_expression1;
		private string id;
		[RelatableChild]private CMinorBinaryOperator_Multiplicative c_minor_binary_operator_multiplicative;
		[RelatableChild]private CMinorExpression assignment_expression;
		static public CMinorStatement_OperationAssign_IndirectMultiplicative DOMify(CMinorParser.CMinorStatement_OperationAssign_IndirectMultiplicativeContext context)
		{
			if(context != null)
			{
				return new CMinorStatement_OperationAssign_IndirectMultiplicative(context);
			}
			
			return null;
		}
		
		static new public CMinorStatement_OperationAssign_IndirectMultiplicative DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorStatement_OperationAssign_IndirectMultiplicativeContext);
		}
		
		static new public CMinorStatement_OperationAssign_IndirectMultiplicative DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorStatement());
		}
		
		static new public CMinorStatement_OperationAssign_IndirectMultiplicative DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorStatement());
		}
		
		static new public CMinorStatement_OperationAssign_IndirectMultiplicative DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorStatement());
		}
		
		public CMinorStatement_OperationAssign_IndirectMultiplicative()
		{
			c_minor_expression1 = null;
			id = "";
			c_minor_binary_operator_multiplicative = null;
			assignment_expression = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorStatement_OperationAssign_IndirectMultiplicative(CMinorParser.CMinorStatement_OperationAssign_IndirectMultiplicativeContext context) : this()
		{
			SetCMinorExpression1(CMinorExpression.DOMify(context.cMinorExpression(0)));
			SetId(context.ID().GetTextEX());
			SetCMinorBinaryOperatorMultiplicative(CMinorBinaryOperator_Multiplicative.DOMify(context.cMinorBinaryOperator_Multiplicative()));
			SetAssignmentExpression(CMinorExpression.DOMify(context.cMinorExpression(1)));
		}
		
		public override CMinorStatement Duplicate()
		{
			CMinorStatement_OperationAssign_IndirectMultiplicative instance = new CMinorStatement_OperationAssign_IndirectMultiplicative();
			instance.SetCMinorExpression1(GetCMinorExpression1().IfNotNull(z => z.Duplicate()));
			instance.SetId(GetId());
			instance.SetCMinorBinaryOperatorMultiplicative(GetCMinorBinaryOperatorMultiplicative().IfNotNull(z => z.Duplicate()));
			instance.SetAssignmentExpression(GetAssignmentExpression().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetCMinorExpression1(CMinorExpression input)
		{
			c_minor_expression1 = input;
		}
		
		public CMinorExpression GetCMinorExpression1()
		{
			return c_minor_expression1;
		}
		
		private void SetId(string input)
		{
			id = input;
		}
		
		public string GetId()
		{
			return id;
		}
		
		private void SetCMinorBinaryOperatorMultiplicative(CMinorBinaryOperator_Multiplicative input)
		{
			c_minor_binary_operator_multiplicative = input;
		}
		
		public CMinorBinaryOperator_Multiplicative GetCMinorBinaryOperatorMultiplicative()
		{
			return c_minor_binary_operator_multiplicative;
		}
		
		private void SetAssignmentExpression(CMinorExpression input)
		{
			assignment_expression = input;
		}
		
		public override CMinorExpression GetAssignmentExpression()
		{
			return assignment_expression;
		}
		
	}
	
	public partial class CMinorStatement_InvokeGeneric : CMinorStatement
	{
		[RelatableChild]private CMinorExpression c_minor_expression;
		[RelatableChild]private CMinorTypeList c_minor_type_list;
		[RelatableChild]private CMinorExpressionList c_minor_expression_list;
		static public CMinorStatement_InvokeGeneric DOMify(CMinorParser.CMinorStatement_InvokeGenericContext context)
		{
			if(context != null)
			{
				return new CMinorStatement_InvokeGeneric(context);
			}
			
			return null;
		}
		
		static new public CMinorStatement_InvokeGeneric DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorStatement_InvokeGenericContext);
		}
		
		static new public CMinorStatement_InvokeGeneric DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorStatement());
		}
		
		static new public CMinorStatement_InvokeGeneric DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorStatement());
		}
		
		static new public CMinorStatement_InvokeGeneric DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorStatement());
		}
		
		public CMinorStatement_InvokeGeneric()
		{
			c_minor_expression = null;
			c_minor_type_list = null;
			c_minor_expression_list = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorStatement_InvokeGeneric(CMinorParser.CMinorStatement_InvokeGenericContext context) : this()
		{
			SetCMinorExpression(CMinorExpression.DOMify(context.cMinorExpression()));
			SetCMinorTypeList(CMinorTypeList.DOMify(context.cMinorTypeList()));
			SetCMinorExpressionList(CMinorExpressionList.DOMify(context.cMinorExpressionList()));
		}
		
		public override CMinorStatement Duplicate()
		{
			CMinorStatement_InvokeGeneric instance = new CMinorStatement_InvokeGeneric();
			instance.SetCMinorExpression(GetCMinorExpression().IfNotNull(z => z.Duplicate()));
			instance.SetCMinorTypeList(GetCMinorTypeList().IfNotNull(z => z.Duplicate()));
			instance.SetCMinorExpressionList(GetCMinorExpressionList().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetCMinorExpression(CMinorExpression input)
		{
			c_minor_expression = input;
		}
		
		public CMinorExpression GetCMinorExpression()
		{
			return c_minor_expression;
		}
		
		private void SetCMinorTypeList(CMinorTypeList input)
		{
			c_minor_type_list = input;
		}
		
		public CMinorTypeList GetCMinorTypeList()
		{
			return c_minor_type_list;
		}
		
		private void SetCMinorExpressionList(CMinorExpressionList input)
		{
			c_minor_expression_list = input;
		}
		
		public CMinorExpressionList GetCMinorExpressionList()
		{
			return c_minor_expression_list;
		}
		
	}
	
	public partial class CMinorStatement_Invoke : CMinorStatement
	{
		[RelatableChild]private CMinorExpression c_minor_expression;
		[RelatableChild]private CMinorExpressionList c_minor_expression_list;
		static public CMinorStatement_Invoke DOMify(CMinorParser.CMinorStatement_InvokeContext context)
		{
			if(context != null)
			{
				return new CMinorStatement_Invoke(context);
			}
			
			return null;
		}
		
		static new public CMinorStatement_Invoke DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorStatement_InvokeContext);
		}
		
		static new public CMinorStatement_Invoke DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorStatement());
		}
		
		static new public CMinorStatement_Invoke DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorStatement());
		}
		
		static new public CMinorStatement_Invoke DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorStatement());
		}
		
		public CMinorStatement_Invoke()
		{
			c_minor_expression = null;
			c_minor_expression_list = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorStatement_Invoke(CMinorParser.CMinorStatement_InvokeContext context) : this()
		{
			SetCMinorExpression(CMinorExpression.DOMify(context.cMinorExpression()));
			SetCMinorExpressionList(CMinorExpressionList.DOMify(context.cMinorExpressionList()));
		}
		
		public override CMinorStatement Duplicate()
		{
			CMinorStatement_Invoke instance = new CMinorStatement_Invoke();
			instance.SetCMinorExpression(GetCMinorExpression().IfNotNull(z => z.Duplicate()));
			instance.SetCMinorExpressionList(GetCMinorExpressionList().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetCMinorExpression(CMinorExpression input)
		{
			c_minor_expression = input;
		}
		
		public CMinorExpression GetCMinorExpression()
		{
			return c_minor_expression;
		}
		
		private void SetCMinorExpressionList(CMinorExpressionList input)
		{
			c_minor_expression_list = input;
		}
		
		public CMinorExpressionList GetCMinorExpressionList()
		{
			return c_minor_expression_list;
		}
		
	}
	
	public partial class CMinorStatement_Block : CMinorStatement
	{
		[RelatableChild]private CMinorStatements c_minor_statements;
		static public CMinorStatement_Block DOMify(CMinorParser.CMinorStatement_BlockContext context)
		{
			if(context != null)
			{
				return new CMinorStatement_Block(context);
			}
			
			return null;
		}
		
		static new public CMinorStatement_Block DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorStatement_BlockContext);
		}
		
		static new public CMinorStatement_Block DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorStatement());
		}
		
		static new public CMinorStatement_Block DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorStatement());
		}
		
		static new public CMinorStatement_Block DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorStatement());
		}
		
		public CMinorStatement_Block()
		{
			c_minor_statements = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorStatement_Block(CMinorParser.CMinorStatement_BlockContext context) : this()
		{
			SetCMinorStatements(CMinorStatements.DOMify(context.cMinorStatements()));
		}
		
		public override CMinorStatement Duplicate()
		{
			CMinorStatement_Block instance = new CMinorStatement_Block();
			instance.SetCMinorStatements(GetCMinorStatements().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetCMinorStatements(CMinorStatements input)
		{
			c_minor_statements = input;
		}
		
		public CMinorStatements GetCMinorStatements()
		{
			return c_minor_statements;
		}
		
	}
	
	public partial class CMinorStatement_If : CMinorStatement
	{
		[RelatableChild]private CMinorExpression c_minor_expression;
		[RelatableChild]private CMinorStatement c_minor_statement1;
		[RelatableChild]private CMinorStatement c_minor_statement2;
		static public CMinorStatement_If DOMify(CMinorParser.CMinorStatement_IfContext context)
		{
			if(context != null)
			{
				return new CMinorStatement_If(context);
			}
			
			return null;
		}
		
		static new public CMinorStatement_If DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorStatement_IfContext);
		}
		
		static new public CMinorStatement_If DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorStatement());
		}
		
		static new public CMinorStatement_If DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorStatement());
		}
		
		static new public CMinorStatement_If DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorStatement());
		}
		
		public CMinorStatement_If()
		{
			c_minor_expression = null;
			c_minor_statement1 = null;
			c_minor_statement2 = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorStatement_If(CMinorParser.CMinorStatement_IfContext context) : this()
		{
			SetCMinorExpression(CMinorExpression.DOMify(context.cMinorExpression()));
			SetCMinorStatement1(CMinorStatement.DOMify(context.cMinorStatement(0)));
			SetCMinorStatement2(CMinorStatement.DOMify(context.cMinorStatement(1)));
		}
		
		public override CMinorStatement Duplicate()
		{
			CMinorStatement_If instance = new CMinorStatement_If();
			instance.SetCMinorExpression(GetCMinorExpression().IfNotNull(z => z.Duplicate()));
			instance.SetCMinorStatement1(GetCMinorStatement1().IfNotNull(z => z.Duplicate()));
			instance.SetCMinorStatement2(GetCMinorStatement2().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetCMinorExpression(CMinorExpression input)
		{
			c_minor_expression = input;
		}
		
		public CMinorExpression GetCMinorExpression()
		{
			return c_minor_expression;
		}
		
		private void SetCMinorStatement1(CMinorStatement input)
		{
			c_minor_statement1 = input;
		}
		
		public CMinorStatement GetCMinorStatement1()
		{
			return c_minor_statement1;
		}
		
		private void SetCMinorStatement2(CMinorStatement input)
		{
			c_minor_statement2 = input;
		}
		
		public CMinorStatement GetCMinorStatement2()
		{
			return c_minor_statement2;
		}
		
	}
	
	public partial class CMinorStatement_While : CMinorStatement
	{
		[RelatableChild]private CMinorExpression c_minor_expression;
		[RelatableChild]private CMinorStatement c_minor_statement;
		static public CMinorStatement_While DOMify(CMinorParser.CMinorStatement_WhileContext context)
		{
			if(context != null)
			{
				return new CMinorStatement_While(context);
			}
			
			return null;
		}
		
		static new public CMinorStatement_While DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorStatement_WhileContext);
		}
		
		static new public CMinorStatement_While DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorStatement());
		}
		
		static new public CMinorStatement_While DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorStatement());
		}
		
		static new public CMinorStatement_While DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorStatement());
		}
		
		public CMinorStatement_While()
		{
			c_minor_expression = null;
			c_minor_statement = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorStatement_While(CMinorParser.CMinorStatement_WhileContext context) : this()
		{
			SetCMinorExpression(CMinorExpression.DOMify(context.cMinorExpression()));
			SetCMinorStatement(CMinorStatement.DOMify(context.cMinorStatement()));
		}
		
		public override CMinorStatement Duplicate()
		{
			CMinorStatement_While instance = new CMinorStatement_While();
			instance.SetCMinorExpression(GetCMinorExpression().IfNotNull(z => z.Duplicate()));
			instance.SetCMinorStatement(GetCMinorStatement().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetCMinorExpression(CMinorExpression input)
		{
			c_minor_expression = input;
		}
		
		public CMinorExpression GetCMinorExpression()
		{
			return c_minor_expression;
		}
		
		private void SetCMinorStatement(CMinorStatement input)
		{
			c_minor_statement = input;
		}
		
		public CMinorStatement GetCMinorStatement()
		{
			return c_minor_statement;
		}
		
	}
	
	public partial class CMinorStatements : CMinorElement
	{
		[RelatableChild]private List<CMinorStatement> c_minor_statements;
		static public CMinorStatements DOMify(CMinorParser.CMinorStatementsContext context)
		{
			if(context != null)
			{
				return new CMinorStatements(context);
			}
			
			return null;
		}
		
		static public CMinorStatements DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CMinorParser.CMinorStatementsContext);
		}
		
		static public CMinorStatements DOMify(Stream stream)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(stream).cMinorStatements());
		}
		
		static public CMinorStatements DOMify(string text)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateParser(text).cMinorStatements());
		}
		
		static public CMinorStatements DOMifyFile(string filename)
		{
			return DOMify(CMinorDOMinatorUtilities.CreateFileParser(filename).cMinorStatements());
		}
		
		public CMinorStatements()
		{
			c_minor_statements = new List<CMinorStatement>();
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CMinorStatements(CMinorParser.CMinorStatementsContext context) : this()
		{
			AddCMinorStatements(context.cMinorStatement().Convert(c => CMinorStatement.DOMify(c)));
		}
		
		public CMinorStatements Duplicate()
		{
			CMinorStatements instance = new CMinorStatements();
			instance.SetCMinorStatements(GetCMinorStatements().Convert(i => i.IfNotNull(z => z.Duplicate())));
			return instance;
		}
		
		private void ClearCMinorStatements()
		{
			c_minor_statements.Clear();
		}
		
		private void SetCMinorStatements(IEnumerable<CMinorStatement> input)
		{
			ClearCMinorStatements();
			AddCMinorStatements(input);
		}
		
		private void SetCMinorStatements(params CMinorStatement[] input)
		{
			SetCMinorStatements((IEnumerable<CMinorStatement>)input);
		}
		
		private void AddCMinorStatement(CMinorStatement input)
		{
			c_minor_statements.Add(input);
		}
		
		private void AddCMinorStatements(IEnumerable<CMinorStatement> input)
		{
			input.Process(i => AddCMinorStatement(i));
		}
		
		private void AddCMinorStatements(params CMinorStatement[] input)
		{
			AddCMinorStatements((IEnumerable<CMinorStatement>)input);
		}
		
		public IEnumerable<CMinorStatement> GetCMinorStatements()
		{
			return c_minor_statements;
		}
		
	}
	
	public abstract partial class CMinorElement : Object, Relatable
	{
		public CMinorElement()
		{
			OnConstruct();
		}
		
		partial void OnConstruct();
	}
	
	static public class CMinorDOMinatorUtilities
	{
		static public CMinorParser CreateParser(ICharStream stream)
		{
			CMinorParser parser = new CMinorParser(new CommonTokenStream(new CMinorLexer(stream)));
			parser.RemoveErrorListeners();
			parser.AddErrorListener(CMinorSyntaxExceptionThrower.INSTANCE);
			return parser;
		}
		
		static public CMinorParser CreateParser(Stream stream)
		{
			return CreateParser(new AntlrInputStream(stream));
		}
		
		static public CMinorParser CreateParser(TextReader text_reader)
		{
			return CreateParser(new AntlrInputStream(text_reader));
		}
		
		static public CMinorParser CreateParser(string text)
		{
			return CreateParser(new StringReader(text));
		}
		
		static public CMinorParser CreateFileParser(string filename)
		{
			return CreateParser(new AntlrFileStream(filename));
		}
		
	}
	
	static public class CMinorIParseTreeExtensions
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
	
	public partial class CMinorResolver : CMinorBaseVisitor<CMinorElement>
	{
		static private CMinorResolver instance;
		static public CMinorResolver GetInstance()
		{
			if(instance == null)
			{
				instance = new CMinorResolver();
			}
			
			return instance;
		}
		
		static public CMinorElement Resolve(IParseTree parse_tree)
		{
			if(parse_tree != null)
			{
				return GetInstance().Visit(parse_tree);
			}
			
			return null;
		}
		
		static public T Resolve<T>(IParseTree parse_tree) where T : CMinorElement
		{
			return Resolve(parse_tree) as T;
		}
		
		private CMinorResolver()
		{
		}
		
		public override CMinorElement VisitCMinorType_Normal(CMinorParser.CMinorType_NormalContext context)
		{
			return CMinorType_Normal.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorType_Templated(CMinorParser.CMinorType_TemplatedContext context)
		{
			return CMinorType_Templated.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorType_Array(CMinorParser.CMinorType_ArrayContext context)
		{
			return CMinorType_Array.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorTypeList(CMinorParser.CMinorTypeListContext context)
		{
			return CMinorTypeList.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorLiteral_Null(CMinorParser.CMinorLiteral_NullContext context)
		{
			return CMinorLiteral_Null.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorLiteral_Bool(CMinorParser.CMinorLiteral_BoolContext context)
		{
			return CMinorLiteral_Bool.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorLiteral_Int(CMinorParser.CMinorLiteral_IntContext context)
		{
			return CMinorLiteral_Int.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorLiteral_Float(CMinorParser.CMinorLiteral_FloatContext context)
		{
			return CMinorLiteral_Float.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorLiteral_Double(CMinorParser.CMinorLiteral_DoubleContext context)
		{
			return CMinorLiteral_Double.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorLiteral_String(CMinorParser.CMinorLiteral_StringContext context)
		{
			return CMinorLiteral_String.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorExpression_Literal(CMinorParser.CMinorExpression_LiteralContext context)
		{
			return CMinorExpression_Literal.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorExpression_This(CMinorParser.CMinorExpression_ThisContext context)
		{
			return CMinorExpression_This.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorExpression_DirectIdentifier(CMinorParser.CMinorExpression_DirectIdentifierContext context)
		{
			return CMinorExpression_DirectIdentifier.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorExpression_IndirectIdentifier(CMinorParser.CMinorExpression_IndirectIdentifierContext context)
		{
			return CMinorExpression_IndirectIdentifier.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorExpression_InvokeGeneric(CMinorParser.CMinorExpression_InvokeGenericContext context)
		{
			return CMinorExpression_InvokeGeneric.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorExpression_Invoke(CMinorParser.CMinorExpression_InvokeContext context)
		{
			return CMinorExpression_Invoke.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorExpression_Index(CMinorParser.CMinorExpression_IndexContext context)
		{
			return CMinorExpression_Index.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorExpression_Group(CMinorParser.CMinorExpression_GroupContext context)
		{
			return CMinorExpression_Group.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorExpression_BinaryOperation_Multiplicative(CMinorParser.CMinorExpression_BinaryOperation_MultiplicativeContext context)
		{
			return CMinorExpression_BinaryOperation_Multiplicative.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorExpression_BinaryOperation_Additive(CMinorParser.CMinorExpression_BinaryOperation_AdditiveContext context)
		{
			return CMinorExpression_BinaryOperation_Additive.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorExpression_BinaryOperation_Comparative(CMinorParser.CMinorExpression_BinaryOperation_ComparativeContext context)
		{
			return CMinorExpression_BinaryOperation_Comparative.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorExpression_BinaryOperation_Boolean(CMinorParser.CMinorExpression_BinaryOperation_BooleanContext context)
		{
			return CMinorExpression_BinaryOperation_Boolean.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorBinaryOperator_Multiplicative_Multiply(CMinorParser.CMinorBinaryOperator_Multiplicative_MultiplyContext context)
		{
			return CMinorBinaryOperator_Multiplicative_Multiply.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorBinaryOperator_Multiplicative_Divide(CMinorParser.CMinorBinaryOperator_Multiplicative_DivideContext context)
		{
			return CMinorBinaryOperator_Multiplicative_Divide.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorBinaryOperator_Multiplicative_Modulo(CMinorParser.CMinorBinaryOperator_Multiplicative_ModuloContext context)
		{
			return CMinorBinaryOperator_Multiplicative_Modulo.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorBinaryOperator_Additive_Add(CMinorParser.CMinorBinaryOperator_Additive_AddContext context)
		{
			return CMinorBinaryOperator_Additive_Add.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorBinaryOperator_Additive_Subtract(CMinorParser.CMinorBinaryOperator_Additive_SubtractContext context)
		{
			return CMinorBinaryOperator_Additive_Subtract.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorBinaryOperator_Comparative_LessThan(CMinorParser.CMinorBinaryOperator_Comparative_LessThanContext context)
		{
			return CMinorBinaryOperator_Comparative_LessThan.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorBinaryOperator_Comparative_LessThanOrEqualTo(CMinorParser.CMinorBinaryOperator_Comparative_LessThanOrEqualToContext context)
		{
			return CMinorBinaryOperator_Comparative_LessThanOrEqualTo.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorBinaryOperator_Comparative_GreaterThan(CMinorParser.CMinorBinaryOperator_Comparative_GreaterThanContext context)
		{
			return CMinorBinaryOperator_Comparative_GreaterThan.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorBinaryOperator_Comparative_GreaterThanOrEqualTo(CMinorParser.CMinorBinaryOperator_Comparative_GreaterThanOrEqualToContext context)
		{
			return CMinorBinaryOperator_Comparative_GreaterThanOrEqualTo.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorBinaryOperator_Comparative_EqualTo(CMinorParser.CMinorBinaryOperator_Comparative_EqualToContext context)
		{
			return CMinorBinaryOperator_Comparative_EqualTo.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorBinaryOperator_Comparative_NotEqualTo(CMinorParser.CMinorBinaryOperator_Comparative_NotEqualToContext context)
		{
			return CMinorBinaryOperator_Comparative_NotEqualTo.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorBinaryOperator_Boolean_And(CMinorParser.CMinorBinaryOperator_Boolean_AndContext context)
		{
			return CMinorBinaryOperator_Boolean_And.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorBinaryOperator_Boolean_Or(CMinorParser.CMinorBinaryOperator_Boolean_OrContext context)
		{
			return CMinorBinaryOperator_Boolean_Or.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorExpressionList(CMinorParser.CMinorExpressionListContext context)
		{
			return CMinorExpressionList.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorStatement_DirectAssign(CMinorParser.CMinorStatement_DirectAssignContext context)
		{
			return CMinorStatement_DirectAssign.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorStatement_IndirectAssign(CMinorParser.CMinorStatement_IndirectAssignContext context)
		{
			return CMinorStatement_IndirectAssign.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorStatement_OperationAssign_DirectAdditive(CMinorParser.CMinorStatement_OperationAssign_DirectAdditiveContext context)
		{
			return CMinorStatement_OperationAssign_DirectAdditive.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorStatement_OperationAssign_DirectMultiplicative(CMinorParser.CMinorStatement_OperationAssign_DirectMultiplicativeContext context)
		{
			return CMinorStatement_OperationAssign_DirectMultiplicative.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorStatement_OperationAssign_IndirectAdditive(CMinorParser.CMinorStatement_OperationAssign_IndirectAdditiveContext context)
		{
			return CMinorStatement_OperationAssign_IndirectAdditive.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorStatement_OperationAssign_IndirectMultiplicative(CMinorParser.CMinorStatement_OperationAssign_IndirectMultiplicativeContext context)
		{
			return CMinorStatement_OperationAssign_IndirectMultiplicative.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorStatement_InvokeGeneric(CMinorParser.CMinorStatement_InvokeGenericContext context)
		{
			return CMinorStatement_InvokeGeneric.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorStatement_Invoke(CMinorParser.CMinorStatement_InvokeContext context)
		{
			return CMinorStatement_Invoke.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorStatement_Block(CMinorParser.CMinorStatement_BlockContext context)
		{
			return CMinorStatement_Block.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorStatement_If(CMinorParser.CMinorStatement_IfContext context)
		{
			return CMinorStatement_If.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorStatement_While(CMinorParser.CMinorStatement_WhileContext context)
		{
			return CMinorStatement_While.DOMify(context);
		}
		
		public override CMinorElement VisitCMinorStatements(CMinorParser.CMinorStatementsContext context)
		{
			return CMinorStatements.DOMify(context);
		}
		
	}
	
	public partial class CMinorSyntaxException : Exception
	{
		private int line;
		private int column;
		private string base_message;
		public CMinorSyntaxException(int l, int c, string m) : base()
		{
			line = l;
			column = c;
			base_message = m;
		}
		
		public int GetLine()
		{
			return line;
		}
		
		public int GetColumn()
		{
			return column;
		}
		
		public string GetBaseMessage()
		{
			return base_message;
		}
		
		public string GetMessage()
		{
			return "(" + line + ", " + column + ")" +  base_message;
		}
		
	}
	
	public class CMinorSyntaxExceptionThrower : BaseErrorListener
	{
		static public readonly CMinorSyntaxExceptionThrower INSTANCE = new CMinorSyntaxExceptionThrower();
		private CMinorSyntaxExceptionThrower()
		{
		}
		
		public override void SyntaxError(IRecognizer recognizer, IToken offendingSymbol, int line, int column, string msg, RecognitionException e)
		{
			throw new CMinorSyntaxException(line, column, msg);
		}
		
	}
	
}
