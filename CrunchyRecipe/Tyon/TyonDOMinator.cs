
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: December 27 2021 22:15:30 -08:00

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Noodle;

using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace Crunchy.Recipe
{
	public abstract partial class TyonType : TyonElement
	{
		public abstract TyonType Duplicate();
		static public TyonType DOMify(TyonParser.TyonTypeContext context)
		{
			return TyonResolver.Resolve<TyonType>(context);
		}
		
		static public TyonType DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as TyonParser.TyonTypeContext);
		}
		
		static public TyonType DOMify(Stream stream)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(stream).tyonType());
		}
		
		static public TyonType DOMify(string text)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(text).tyonType());
		}
		
		static public TyonType DOMifyFile(string filename)
		{
			return DOMify(TyonDOMinatorUtilities.CreateFileParser(filename).tyonType());
		}
		
	}
	
	public partial class TyonType_Direct_Normal : TyonType_Direct
	{
		private string id;
		static public TyonType_Direct_Normal DOMify(TyonParser.TyonType_NormalContext context)
		{
			if(context != null)
			{
				return new TyonType_Direct_Normal(context);
			}
			
			return null;
		}
		
		static new public TyonType_Direct_Normal DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as TyonParser.TyonType_NormalContext);
		}
		
		static new public TyonType_Direct_Normal DOMify(Stream stream)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(stream).tyonType());
		}
		
		static new public TyonType_Direct_Normal DOMify(string text)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(text).tyonType());
		}
		
		static new public TyonType_Direct_Normal DOMifyFile(string filename)
		{
			return DOMify(TyonDOMinatorUtilities.CreateFileParser(filename).tyonType());
		}
		
		public TyonType_Direct_Normal()
		{
			id = "";
			OnConstructor();
		}
		
		partial void OnConstructor();
		public TyonType_Direct_Normal(TyonParser.TyonType_NormalContext context) : this()
		{
			SetId(context.ID().GetTextEX());
		}
		
		public override TyonType Duplicate()
		{
			TyonType_Direct_Normal instance = new TyonType_Direct_Normal();
			instance.SetId(GetId());
			return instance;
		}
		
		private void SetId(string input)
		{
			id = input;
		}
		
		public override string GetId()
		{
			return id;
		}
		
	}
	
	public partial class TyonType_Direct_Templated : TyonType_Direct
	{
		private string id;
		[RelatableChild]private List<TyonType> tyon_types;
		static public TyonType_Direct_Templated DOMify(TyonParser.TyonType_TemplatedContext context)
		{
			if(context != null)
			{
				return new TyonType_Direct_Templated(context);
			}
			
			return null;
		}
		
		static new public TyonType_Direct_Templated DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as TyonParser.TyonType_TemplatedContext);
		}
		
		static new public TyonType_Direct_Templated DOMify(Stream stream)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(stream).tyonType());
		}
		
		static new public TyonType_Direct_Templated DOMify(string text)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(text).tyonType());
		}
		
		static new public TyonType_Direct_Templated DOMifyFile(string filename)
		{
			return DOMify(TyonDOMinatorUtilities.CreateFileParser(filename).tyonType());
		}
		
		public TyonType_Direct_Templated()
		{
			id = "";
			tyon_types = new List<TyonType>();
			OnConstructor();
		}
		
		partial void OnConstructor();
		public TyonType_Direct_Templated(TyonParser.TyonType_TemplatedContext context) : this()
		{
			SetId(context.ID().GetTextEX());
			AddTyonTypes(context.tyonType().Convert(c => TyonType.DOMify(c)));
		}
		
		public override TyonType Duplicate()
		{
			TyonType_Direct_Templated instance = new TyonType_Direct_Templated();
			instance.SetId(GetId());
			instance.SetTyonTypes(GetTyonTypes().Convert(i => i.IfNotNull(z => z.Duplicate())));
			return instance;
		}
		
		private void SetId(string input)
		{
			id = input;
		}
		
		public override string GetId()
		{
			return id;
		}
		
		private void ClearTyonTypes()
		{
			tyon_types.Clear();
		}
		
		private void SetTyonTypes(IEnumerable<TyonType> input)
		{
			ClearTyonTypes();
			AddTyonTypes(input);
		}
		
		private void SetTyonTypes(params TyonType[] input)
		{
			SetTyonTypes((IEnumerable<TyonType>)input);
		}
		
		private void AddTyonType(TyonType input)
		{
			tyon_types.Add(input);
		}
		
		private void AddTyonTypes(IEnumerable<TyonType> input)
		{
			input.Process(i => AddTyonType(i));
		}
		
		private void AddTyonTypes(params TyonType[] input)
		{
			AddTyonTypes((IEnumerable<TyonType>)input);
		}
		
		public IEnumerable<TyonType> GetTyonTypes()
		{
			return tyon_types;
		}
		
	}
	
	public partial class TyonType_Array : TyonType
	{
		[RelatableChild]private TyonType tyon_type;
		static public TyonType_Array DOMify(TyonParser.TyonType_ArrayContext context)
		{
			if(context != null)
			{
				return new TyonType_Array(context);
			}
			
			return null;
		}
		
		static new public TyonType_Array DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as TyonParser.TyonType_ArrayContext);
		}
		
		static new public TyonType_Array DOMify(Stream stream)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(stream).tyonType());
		}
		
		static new public TyonType_Array DOMify(string text)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(text).tyonType());
		}
		
		static new public TyonType_Array DOMifyFile(string filename)
		{
			return DOMify(TyonDOMinatorUtilities.CreateFileParser(filename).tyonType());
		}
		
		public TyonType_Array()
		{
			tyon_type = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public TyonType_Array(TyonParser.TyonType_ArrayContext context) : this()
		{
			SetTyonType(TyonType.DOMify(context.tyonType()));
		}
		
		public override TyonType Duplicate()
		{
			TyonType_Array instance = new TyonType_Array();
			instance.SetTyonType(GetTyonType().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetTyonType(TyonType input)
		{
			tyon_type = input;
		}
		
		public TyonType GetTyonType()
		{
			return tyon_type;
		}
		
	}
	
	public partial class TyonObject : TyonElement
	{
		[RelatableChild]private TyonType tyon_type;
		[RelatableChild]private TyonAddress tyon_address;
		[RelatableChild]private TyonValueList tyon_value_list;
		[RelatableChild]private List<TyonVariable> tyon_variables;
		static public TyonObject DOMify(TyonParser.TyonObjectContext context)
		{
			if(context != null)
			{
				return new TyonObject(context);
			}
			
			return null;
		}
		
		static public TyonObject DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as TyonParser.TyonObjectContext);
		}
		
		static public TyonObject DOMify(Stream stream)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(stream).tyonObject());
		}
		
		static public TyonObject DOMify(string text)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(text).tyonObject());
		}
		
		static public TyonObject DOMifyFile(string filename)
		{
			return DOMify(TyonDOMinatorUtilities.CreateFileParser(filename).tyonObject());
		}
		
		public TyonObject()
		{
			tyon_type = null;
			tyon_address = null;
			tyon_value_list = null;
			tyon_variables = new List<TyonVariable>();
			OnConstructor();
		}
		
		partial void OnConstructor();
		public TyonObject(TyonParser.TyonObjectContext context) : this()
		{
			SetTyonType(TyonType.DOMify(context.tyonType()));
			SetTyonAddress(TyonAddress.DOMify(context.tyonAddress()));
			SetTyonValueList(TyonValueList.DOMify(context.tyonValueList()));
			AddTyonVariables(context.tyonVariable().Convert(c => TyonVariable.DOMify(c)));
		}
		
		public TyonObject Duplicate()
		{
			TyonObject instance = new TyonObject();
			instance.SetTyonType(GetTyonType().IfNotNull(z => z.Duplicate()));
			instance.SetTyonAddress(GetTyonAddress().IfNotNull(z => z.Duplicate()));
			instance.SetTyonValueList(GetTyonValueList().IfNotNull(z => z.Duplicate()));
			instance.SetTyonVariables(GetTyonVariables().Convert(i => i.IfNotNull(z => z.Duplicate())));
			return instance;
		}
		
		private void SetTyonType(TyonType input)
		{
			tyon_type = input;
		}
		
		public TyonType GetTyonType()
		{
			return tyon_type;
		}
		
		private void SetTyonAddress(TyonAddress input)
		{
			tyon_address = input;
		}
		
		public TyonAddress GetTyonAddress()
		{
			return tyon_address;
		}
		
		private void SetTyonValueList(TyonValueList input)
		{
			tyon_value_list = input;
		}
		
		public TyonValueList GetTyonValueList()
		{
			return tyon_value_list;
		}
		
		private void ClearTyonVariables()
		{
			tyon_variables.Clear();
		}
		
		private void SetTyonVariables(IEnumerable<TyonVariable> input)
		{
			ClearTyonVariables();
			AddTyonVariables(input);
		}
		
		private void SetTyonVariables(params TyonVariable[] input)
		{
			SetTyonVariables((IEnumerable<TyonVariable>)input);
		}
		
		private void AddTyonVariable(TyonVariable input)
		{
			tyon_variables.Add(input);
		}
		
		private void AddTyonVariables(IEnumerable<TyonVariable> input)
		{
			input.Process(i => AddTyonVariable(i));
		}
		
		private void AddTyonVariables(params TyonVariable[] input)
		{
			AddTyonVariables((IEnumerable<TyonVariable>)input);
		}
		
		public IEnumerable<TyonVariable> GetTyonVariables()
		{
			return tyon_variables;
		}
		
	}
	
	public partial class TyonSurrogate : TyonElement
	{
		[RelatableChild]private TyonType tyon_type;
		[RelatableChild]private TyonValue tyon_value;
		static public TyonSurrogate DOMify(TyonParser.TyonSurrogateContext context)
		{
			if(context != null)
			{
				return new TyonSurrogate(context);
			}
			
			return null;
		}
		
		static public TyonSurrogate DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as TyonParser.TyonSurrogateContext);
		}
		
		static public TyonSurrogate DOMify(Stream stream)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(stream).tyonSurrogate());
		}
		
		static public TyonSurrogate DOMify(string text)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(text).tyonSurrogate());
		}
		
		static public TyonSurrogate DOMifyFile(string filename)
		{
			return DOMify(TyonDOMinatorUtilities.CreateFileParser(filename).tyonSurrogate());
		}
		
		public TyonSurrogate()
		{
			tyon_type = null;
			tyon_value = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public TyonSurrogate(TyonParser.TyonSurrogateContext context) : this()
		{
			SetTyonType(TyonType.DOMify(context.tyonType()));
			SetTyonValue(TyonValue.DOMify(context.tyonValue()));
		}
		
		public TyonSurrogate Duplicate()
		{
			TyonSurrogate instance = new TyonSurrogate();
			instance.SetTyonType(GetTyonType().IfNotNull(z => z.Duplicate()));
			instance.SetTyonValue(GetTyonValue().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetTyonType(TyonType input)
		{
			tyon_type = input;
		}
		
		public TyonType GetTyonType()
		{
			return tyon_type;
		}
		
		private void SetTyonValue(TyonValue input)
		{
			tyon_value = input;
		}
		
		public TyonValue GetTyonValue()
		{
			return tyon_value;
		}
		
	}
	
	public partial class TyonArray : TyonElement
	{
		[RelatableChild]private TyonType tyon_type;
		[RelatableChild]private TyonValueList tyon_value_list;
		static public TyonArray DOMify(TyonParser.TyonArrayContext context)
		{
			if(context != null)
			{
				return new TyonArray(context);
			}
			
			return null;
		}
		
		static public TyonArray DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as TyonParser.TyonArrayContext);
		}
		
		static public TyonArray DOMify(Stream stream)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(stream).tyonArray());
		}
		
		static public TyonArray DOMify(string text)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(text).tyonArray());
		}
		
		static public TyonArray DOMifyFile(string filename)
		{
			return DOMify(TyonDOMinatorUtilities.CreateFileParser(filename).tyonArray());
		}
		
		public TyonArray()
		{
			tyon_type = null;
			tyon_value_list = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public TyonArray(TyonParser.TyonArrayContext context) : this()
		{
			SetTyonType(TyonType.DOMify(context.tyonType()));
			SetTyonValueList(TyonValueList.DOMify(context.tyonValueList()));
		}
		
		public TyonArray Duplicate()
		{
			TyonArray instance = new TyonArray();
			instance.SetTyonType(GetTyonType().IfNotNull(z => z.Duplicate()));
			instance.SetTyonValueList(GetTyonValueList().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetTyonType(TyonType input)
		{
			tyon_type = input;
		}
		
		public TyonType GetTyonType()
		{
			return tyon_type;
		}
		
		private void SetTyonValueList(TyonValueList input)
		{
			tyon_value_list = input;
		}
		
		public TyonValueList GetTyonValueList()
		{
			return tyon_value_list;
		}
		
	}
	
	public partial class TyonValueList : TyonElement
	{
		[RelatableChild]private List<TyonValue> tyon_values;
		static public TyonValueList DOMify(TyonParser.TyonValueListContext context)
		{
			if(context != null)
			{
				return new TyonValueList(context);
			}
			
			return null;
		}
		
		static public TyonValueList DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as TyonParser.TyonValueListContext);
		}
		
		static public TyonValueList DOMify(Stream stream)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(stream).tyonValueList());
		}
		
		static public TyonValueList DOMify(string text)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(text).tyonValueList());
		}
		
		static public TyonValueList DOMifyFile(string filename)
		{
			return DOMify(TyonDOMinatorUtilities.CreateFileParser(filename).tyonValueList());
		}
		
		public TyonValueList()
		{
			tyon_values = new List<TyonValue>();
			OnConstructor();
		}
		
		partial void OnConstructor();
		public TyonValueList(TyonParser.TyonValueListContext context) : this()
		{
			AddTyonValues(context.tyonValue().Convert(c => TyonValue.DOMify(c)));
		}
		
		public TyonValueList Duplicate()
		{
			TyonValueList instance = new TyonValueList();
			instance.SetTyonValues(GetTyonValues().Convert(i => i.IfNotNull(z => z.Duplicate())));
			return instance;
		}
		
		private void ClearTyonValues()
		{
			tyon_values.Clear();
		}
		
		private void SetTyonValues(IEnumerable<TyonValue> input)
		{
			ClearTyonValues();
			AddTyonValues(input);
		}
		
		private void SetTyonValues(params TyonValue[] input)
		{
			SetTyonValues((IEnumerable<TyonValue>)input);
		}
		
		private void AddTyonValue(TyonValue input)
		{
			tyon_values.Add(input);
		}
		
		private void AddTyonValues(IEnumerable<TyonValue> input)
		{
			input.Process(i => AddTyonValue(i));
		}
		
		private void AddTyonValues(params TyonValue[] input)
		{
			AddTyonValues((IEnumerable<TyonValue>)input);
		}
		
		public IEnumerable<TyonValue> GetTyonValues()
		{
			return tyon_values;
		}
		
	}
	
	public abstract partial class TyonValue : TyonElement
	{
		public abstract TyonValue Duplicate();
		static public TyonValue DOMify(TyonParser.TyonValueContext context)
		{
			return TyonResolver.Resolve<TyonValue>(context);
		}
		
		static public TyonValue DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as TyonParser.TyonValueContext);
		}
		
		static public TyonValue DOMify(Stream stream)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(stream).tyonValue());
		}
		
		static public TyonValue DOMify(string text)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(text).tyonValue());
		}
		
		static public TyonValue DOMifyFile(string filename)
		{
			return DOMify(TyonDOMinatorUtilities.CreateFileParser(filename).tyonValue());
		}
		
	}
	
	public partial class TyonValue_Int : TyonValue
	{
		private int @int;
		static public TyonValue_Int DOMify(TyonParser.TyonValue_IntContext context)
		{
			if(context != null)
			{
				return new TyonValue_Int(context);
			}
			
			return null;
		}
		
		static new public TyonValue_Int DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as TyonParser.TyonValue_IntContext);
		}
		
		static new public TyonValue_Int DOMify(Stream stream)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(stream).tyonValue());
		}
		
		static new public TyonValue_Int DOMify(string text)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(text).tyonValue());
		}
		
		static new public TyonValue_Int DOMifyFile(string filename)
		{
			return DOMify(TyonDOMinatorUtilities.CreateFileParser(filename).tyonValue());
		}
		
		public TyonValue_Int()
		{
			@int = 0;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public TyonValue_Int(TyonParser.TyonValue_IntContext context) : this()
		{
			SetInt(context.INT().GetTextEX().ParseInt());
		}
		
		public override TyonValue Duplicate()
		{
			TyonValue_Int instance = new TyonValue_Int();
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
	
	public partial class TyonValue_Long : TyonValue
	{
		private long @long;
		static public TyonValue_Long DOMify(TyonParser.TyonValue_LongContext context)
		{
			if(context != null)
			{
				return new TyonValue_Long(context);
			}
			
			return null;
		}
		
		static new public TyonValue_Long DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as TyonParser.TyonValue_LongContext);
		}
		
		static new public TyonValue_Long DOMify(Stream stream)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(stream).tyonValue());
		}
		
		static new public TyonValue_Long DOMify(string text)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(text).tyonValue());
		}
		
		static new public TyonValue_Long DOMifyFile(string filename)
		{
			return DOMify(TyonDOMinatorUtilities.CreateFileParser(filename).tyonValue());
		}
		
		public TyonValue_Long()
		{
			@long = 0;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public TyonValue_Long(TyonParser.TyonValue_LongContext context) : this()
		{
			SetLong(context.LONG().GetTextEX().ParseLong());
		}
		
		public override TyonValue Duplicate()
		{
			TyonValue_Long instance = new TyonValue_Long();
			instance.SetLong(GetLong());
			return instance;
		}
		
		private void SetLong(long input)
		{
			@long = input;
		}
		
		public long GetLong()
		{
			return @long;
		}
		
	}
	
	public partial class TyonValue_Float : TyonValue
	{
		private float @float;
		static public TyonValue_Float DOMify(TyonParser.TyonValue_FloatContext context)
		{
			if(context != null)
			{
				return new TyonValue_Float(context);
			}
			
			return null;
		}
		
		static new public TyonValue_Float DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as TyonParser.TyonValue_FloatContext);
		}
		
		static new public TyonValue_Float DOMify(Stream stream)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(stream).tyonValue());
		}
		
		static new public TyonValue_Float DOMify(string text)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(text).tyonValue());
		}
		
		static new public TyonValue_Float DOMifyFile(string filename)
		{
			return DOMify(TyonDOMinatorUtilities.CreateFileParser(filename).tyonValue());
		}
		
		public TyonValue_Float()
		{
			@float = 0.0f;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public TyonValue_Float(TyonParser.TyonValue_FloatContext context) : this()
		{
			SetFloat(context.FLOAT().GetTextEX().ParseFloat());
		}
		
		public override TyonValue Duplicate()
		{
			TyonValue_Float instance = new TyonValue_Float();
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
	
	public partial class TyonValue_Double : TyonValue
	{
		private double @double;
		static public TyonValue_Double DOMify(TyonParser.TyonValue_DoubleContext context)
		{
			if(context != null)
			{
				return new TyonValue_Double(context);
			}
			
			return null;
		}
		
		static new public TyonValue_Double DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as TyonParser.TyonValue_DoubleContext);
		}
		
		static new public TyonValue_Double DOMify(Stream stream)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(stream).tyonValue());
		}
		
		static new public TyonValue_Double DOMify(string text)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(text).tyonValue());
		}
		
		static new public TyonValue_Double DOMifyFile(string filename)
		{
			return DOMify(TyonDOMinatorUtilities.CreateFileParser(filename).tyonValue());
		}
		
		public TyonValue_Double()
		{
			@double = 0.0;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public TyonValue_Double(TyonParser.TyonValue_DoubleContext context) : this()
		{
			SetDouble(context.DOUBLE().GetTextEX().ParseDouble());
		}
		
		public override TyonValue Duplicate()
		{
			TyonValue_Double instance = new TyonValue_Double();
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
	
	public partial class TyonValue_Decimal : TyonValue
	{
		private decimal @decimal;
		static public TyonValue_Decimal DOMify(TyonParser.TyonValue_DecimalContext context)
		{
			if(context != null)
			{
				return new TyonValue_Decimal(context);
			}
			
			return null;
		}
		
		static new public TyonValue_Decimal DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as TyonParser.TyonValue_DecimalContext);
		}
		
		static new public TyonValue_Decimal DOMify(Stream stream)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(stream).tyonValue());
		}
		
		static new public TyonValue_Decimal DOMify(string text)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(text).tyonValue());
		}
		
		static new public TyonValue_Decimal DOMifyFile(string filename)
		{
			return DOMify(TyonDOMinatorUtilities.CreateFileParser(filename).tyonValue());
		}
		
		public TyonValue_Decimal()
		{
			@decimal = 0.0m;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public TyonValue_Decimal(TyonParser.TyonValue_DecimalContext context) : this()
		{
			SetDecimal(context.DECIMAL().GetTextEX().ParseDecimal());
		}
		
		public override TyonValue Duplicate()
		{
			TyonValue_Decimal instance = new TyonValue_Decimal();
			instance.SetDecimal(GetDecimal());
			return instance;
		}
		
		private void SetDecimal(decimal input)
		{
			@decimal = input;
		}
		
		public decimal GetDecimal()
		{
			return @decimal;
		}
		
	}
	
	public partial class TyonValue_Boolean : TyonValue
	{
		private bool @bool;
		static public TyonValue_Boolean DOMify(TyonParser.TyonValue_BooleanContext context)
		{
			if(context != null)
			{
				return new TyonValue_Boolean(context);
			}
			
			return null;
		}
		
		static new public TyonValue_Boolean DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as TyonParser.TyonValue_BooleanContext);
		}
		
		static new public TyonValue_Boolean DOMify(Stream stream)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(stream).tyonValue());
		}
		
		static new public TyonValue_Boolean DOMify(string text)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(text).tyonValue());
		}
		
		static new public TyonValue_Boolean DOMifyFile(string filename)
		{
			return DOMify(TyonDOMinatorUtilities.CreateFileParser(filename).tyonValue());
		}
		
		public TyonValue_Boolean()
		{
			@bool = false;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public TyonValue_Boolean(TyonParser.TyonValue_BooleanContext context) : this()
		{
			SetBool(context.BOOL().GetTextEX().ParseBool());
		}
		
		public override TyonValue Duplicate()
		{
			TyonValue_Boolean instance = new TyonValue_Boolean();
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
	
	public partial class TyonValue_String : TyonValue
	{
		private string @string;
		static public TyonValue_String DOMify(TyonParser.TyonValue_StringContext context)
		{
			if(context != null)
			{
				return new TyonValue_String(context);
			}
			
			return null;
		}
		
		static new public TyonValue_String DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as TyonParser.TyonValue_StringContext);
		}
		
		static new public TyonValue_String DOMify(Stream stream)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(stream).tyonValue());
		}
		
		static new public TyonValue_String DOMify(string text)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(text).tyonValue());
		}
		
		static new public TyonValue_String DOMifyFile(string filename)
		{
			return DOMify(TyonDOMinatorUtilities.CreateFileParser(filename).tyonValue());
		}
		
		public TyonValue_String()
		{
			@string = "";
			OnConstructor();
		}
		
		partial void OnConstructor();
		public TyonValue_String(TyonParser.TyonValue_StringContext context) : this()
		{
			LoadContextIntermediateString(context.STRING().GetTextEX());
		}
		
		public override TyonValue Duplicate()
		{
			TyonValue_String instance = new TyonValue_String();
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
	
	public partial class TyonValue_Null : TyonValue
	{
		static public TyonValue_Null DOMify(TyonParser.TyonValue_NullContext context)
		{
			if(context != null)
			{
				return new TyonValue_Null(context);
			}
			
			return null;
		}
		
		static new public TyonValue_Null DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as TyonParser.TyonValue_NullContext);
		}
		
		static new public TyonValue_Null DOMify(Stream stream)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(stream).tyonValue());
		}
		
		static new public TyonValue_Null DOMify(string text)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(text).tyonValue());
		}
		
		static new public TyonValue_Null DOMifyFile(string filename)
		{
			return DOMify(TyonDOMinatorUtilities.CreateFileParser(filename).tyonValue());
		}
		
		public TyonValue_Null()
		{
			OnConstructor();
		}
		
		partial void OnConstructor();
		public TyonValue_Null(TyonParser.TyonValue_NullContext context) : this()
		{
		}
		
		public override TyonValue Duplicate()
		{
			TyonValue_Null instance = new TyonValue_Null();
			return instance;
		}
		
	}
	
	public partial class TyonValue_Type : TyonValue
	{
		[RelatableChild]private TyonType tyon_type;
		static public TyonValue_Type DOMify(TyonParser.TyonValue_TypeContext context)
		{
			if(context != null)
			{
				return new TyonValue_Type(context);
			}
			
			return null;
		}
		
		static new public TyonValue_Type DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as TyonParser.TyonValue_TypeContext);
		}
		
		static new public TyonValue_Type DOMify(Stream stream)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(stream).tyonValue());
		}
		
		static new public TyonValue_Type DOMify(string text)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(text).tyonValue());
		}
		
		static new public TyonValue_Type DOMifyFile(string filename)
		{
			return DOMify(TyonDOMinatorUtilities.CreateFileParser(filename).tyonValue());
		}
		
		public TyonValue_Type()
		{
			tyon_type = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public TyonValue_Type(TyonParser.TyonValue_TypeContext context) : this()
		{
			SetTyonType(TyonType.DOMify(context.tyonType()));
		}
		
		public override TyonValue Duplicate()
		{
			TyonValue_Type instance = new TyonValue_Type();
			instance.SetTyonType(GetTyonType().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetTyonType(TyonType input)
		{
			tyon_type = input;
		}
		
		public TyonType GetTyonType()
		{
			return tyon_type;
		}
		
	}
	
	public partial class TyonValue_InternalAddress : TyonValue
	{
		[RelatableChild]private TyonAddress tyon_address;
		static public TyonValue_InternalAddress DOMify(TyonParser.TyonValue_InternalAddressContext context)
		{
			if(context != null)
			{
				return new TyonValue_InternalAddress(context);
			}
			
			return null;
		}
		
		static new public TyonValue_InternalAddress DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as TyonParser.TyonValue_InternalAddressContext);
		}
		
		static new public TyonValue_InternalAddress DOMify(Stream stream)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(stream).tyonValue());
		}
		
		static new public TyonValue_InternalAddress DOMify(string text)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(text).tyonValue());
		}
		
		static new public TyonValue_InternalAddress DOMifyFile(string filename)
		{
			return DOMify(TyonDOMinatorUtilities.CreateFileParser(filename).tyonValue());
		}
		
		public TyonValue_InternalAddress()
		{
			tyon_address = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public TyonValue_InternalAddress(TyonParser.TyonValue_InternalAddressContext context) : this()
		{
			SetTyonAddress(TyonAddress.DOMify(context.tyonAddress()));
		}
		
		public override TyonValue Duplicate()
		{
			TyonValue_InternalAddress instance = new TyonValue_InternalAddress();
			instance.SetTyonAddress(GetTyonAddress().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetTyonAddress(TyonAddress input)
		{
			tyon_address = input;
		}
		
		public TyonAddress GetTyonAddress()
		{
			return tyon_address;
		}
		
	}
	
	public partial class TyonValue_ExternalAddress : TyonValue
	{
		[RelatableChild]private TyonAddress tyon_address;
		static public TyonValue_ExternalAddress DOMify(TyonParser.TyonValue_ExternalAddressContext context)
		{
			if(context != null)
			{
				return new TyonValue_ExternalAddress(context);
			}
			
			return null;
		}
		
		static new public TyonValue_ExternalAddress DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as TyonParser.TyonValue_ExternalAddressContext);
		}
		
		static new public TyonValue_ExternalAddress DOMify(Stream stream)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(stream).tyonValue());
		}
		
		static new public TyonValue_ExternalAddress DOMify(string text)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(text).tyonValue());
		}
		
		static new public TyonValue_ExternalAddress DOMifyFile(string filename)
		{
			return DOMify(TyonDOMinatorUtilities.CreateFileParser(filename).tyonValue());
		}
		
		public TyonValue_ExternalAddress()
		{
			tyon_address = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public TyonValue_ExternalAddress(TyonParser.TyonValue_ExternalAddressContext context) : this()
		{
			SetTyonAddress(TyonAddress.DOMify(context.tyonAddress()));
		}
		
		public override TyonValue Duplicate()
		{
			TyonValue_ExternalAddress instance = new TyonValue_ExternalAddress();
			instance.SetTyonAddress(GetTyonAddress().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetTyonAddress(TyonAddress input)
		{
			tyon_address = input;
		}
		
		public TyonAddress GetTyonAddress()
		{
			return tyon_address;
		}
		
	}
	
	public partial class TyonValue_Array : TyonValue
	{
		[RelatableChild]private TyonArray tyon_array;
		static public TyonValue_Array DOMify(TyonParser.TyonValue_ArrayContext context)
		{
			if(context != null)
			{
				return new TyonValue_Array(context);
			}
			
			return null;
		}
		
		static new public TyonValue_Array DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as TyonParser.TyonValue_ArrayContext);
		}
		
		static new public TyonValue_Array DOMify(Stream stream)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(stream).tyonValue());
		}
		
		static new public TyonValue_Array DOMify(string text)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(text).tyonValue());
		}
		
		static new public TyonValue_Array DOMifyFile(string filename)
		{
			return DOMify(TyonDOMinatorUtilities.CreateFileParser(filename).tyonValue());
		}
		
		public TyonValue_Array()
		{
			tyon_array = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public TyonValue_Array(TyonParser.TyonValue_ArrayContext context) : this()
		{
			SetTyonArray(TyonArray.DOMify(context.tyonArray()));
		}
		
		public override TyonValue Duplicate()
		{
			TyonValue_Array instance = new TyonValue_Array();
			instance.SetTyonArray(GetTyonArray().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetTyonArray(TyonArray input)
		{
			tyon_array = input;
		}
		
		public TyonArray GetTyonArray()
		{
			return tyon_array;
		}
		
	}
	
	public partial class TyonValue_Object : TyonValue
	{
		[RelatableChild]private TyonObject tyon_object;
		static public TyonValue_Object DOMify(TyonParser.TyonValue_ObjectContext context)
		{
			if(context != null)
			{
				return new TyonValue_Object(context);
			}
			
			return null;
		}
		
		static new public TyonValue_Object DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as TyonParser.TyonValue_ObjectContext);
		}
		
		static new public TyonValue_Object DOMify(Stream stream)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(stream).tyonValue());
		}
		
		static new public TyonValue_Object DOMify(string text)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(text).tyonValue());
		}
		
		static new public TyonValue_Object DOMifyFile(string filename)
		{
			return DOMify(TyonDOMinatorUtilities.CreateFileParser(filename).tyonValue());
		}
		
		public TyonValue_Object()
		{
			tyon_object = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public TyonValue_Object(TyonParser.TyonValue_ObjectContext context) : this()
		{
			SetTyonObject(TyonObject.DOMify(context.tyonObject()));
		}
		
		public override TyonValue Duplicate()
		{
			TyonValue_Object instance = new TyonValue_Object();
			instance.SetTyonObject(GetTyonObject().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetTyonObject(TyonObject input)
		{
			tyon_object = input;
		}
		
		public TyonObject GetTyonObject()
		{
			return tyon_object;
		}
		
	}
	
	public partial class TyonValue_Surrogate : TyonValue
	{
		[RelatableChild]private TyonSurrogate tyon_surrogate;
		static public TyonValue_Surrogate DOMify(TyonParser.TyonValue_SurrogateContext context)
		{
			if(context != null)
			{
				return new TyonValue_Surrogate(context);
			}
			
			return null;
		}
		
		static new public TyonValue_Surrogate DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as TyonParser.TyonValue_SurrogateContext);
		}
		
		static new public TyonValue_Surrogate DOMify(Stream stream)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(stream).tyonValue());
		}
		
		static new public TyonValue_Surrogate DOMify(string text)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(text).tyonValue());
		}
		
		static new public TyonValue_Surrogate DOMifyFile(string filename)
		{
			return DOMify(TyonDOMinatorUtilities.CreateFileParser(filename).tyonValue());
		}
		
		public TyonValue_Surrogate()
		{
			tyon_surrogate = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public TyonValue_Surrogate(TyonParser.TyonValue_SurrogateContext context) : this()
		{
			SetTyonSurrogate(TyonSurrogate.DOMify(context.tyonSurrogate()));
		}
		
		public override TyonValue Duplicate()
		{
			TyonValue_Surrogate instance = new TyonValue_Surrogate();
			instance.SetTyonSurrogate(GetTyonSurrogate().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetTyonSurrogate(TyonSurrogate input)
		{
			tyon_surrogate = input;
		}
		
		public TyonSurrogate GetTyonSurrogate()
		{
			return tyon_surrogate;
		}
		
	}
	
	public abstract partial class TyonAddress : TyonElement
	{
		public abstract TyonAddress Duplicate();
		static public TyonAddress DOMify(TyonParser.TyonAddressContext context)
		{
			return TyonResolver.Resolve<TyonAddress>(context);
		}
		
		static public TyonAddress DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as TyonParser.TyonAddressContext);
		}
		
		static public TyonAddress DOMify(Stream stream)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(stream).tyonAddress());
		}
		
		static public TyonAddress DOMify(string text)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(text).tyonAddress());
		}
		
		static public TyonAddress DOMifyFile(string filename)
		{
			return DOMify(TyonDOMinatorUtilities.CreateFileParser(filename).tyonAddress());
		}
		
	}
	
	public partial class TyonAddress_Identifier : TyonAddress
	{
		private string id;
		static public TyonAddress_Identifier DOMify(TyonParser.TyonAddress_IdentifierContext context)
		{
			if(context != null)
			{
				return new TyonAddress_Identifier(context);
			}
			
			return null;
		}
		
		static new public TyonAddress_Identifier DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as TyonParser.TyonAddress_IdentifierContext);
		}
		
		static new public TyonAddress_Identifier DOMify(Stream stream)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(stream).tyonAddress());
		}
		
		static new public TyonAddress_Identifier DOMify(string text)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(text).tyonAddress());
		}
		
		static new public TyonAddress_Identifier DOMifyFile(string filename)
		{
			return DOMify(TyonDOMinatorUtilities.CreateFileParser(filename).tyonAddress());
		}
		
		public TyonAddress_Identifier()
		{
			id = "";
			OnConstructor();
		}
		
		partial void OnConstructor();
		public TyonAddress_Identifier(TyonParser.TyonAddress_IdentifierContext context) : this()
		{
			SetId(context.ID().GetTextEX());
		}
		
		public override TyonAddress Duplicate()
		{
			TyonAddress_Identifier instance = new TyonAddress_Identifier();
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
	
	public partial class TyonAddress_Int : TyonAddress
	{
		private int @int;
		static public TyonAddress_Int DOMify(TyonParser.TyonAddress_IntContext context)
		{
			if(context != null)
			{
				return new TyonAddress_Int(context);
			}
			
			return null;
		}
		
		static new public TyonAddress_Int DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as TyonParser.TyonAddress_IntContext);
		}
		
		static new public TyonAddress_Int DOMify(Stream stream)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(stream).tyonAddress());
		}
		
		static new public TyonAddress_Int DOMify(string text)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(text).tyonAddress());
		}
		
		static new public TyonAddress_Int DOMifyFile(string filename)
		{
			return DOMify(TyonDOMinatorUtilities.CreateFileParser(filename).tyonAddress());
		}
		
		public TyonAddress_Int()
		{
			@int = 0;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public TyonAddress_Int(TyonParser.TyonAddress_IntContext context) : this()
		{
			SetInt(context.INT().GetTextEX().ParseInt());
		}
		
		public override TyonAddress Duplicate()
		{
			TyonAddress_Int instance = new TyonAddress_Int();
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
	
	public partial class TyonAddress_String : TyonAddress
	{
		private string @string;
		static public TyonAddress_String DOMify(TyonParser.TyonAddress_StringContext context)
		{
			if(context != null)
			{
				return new TyonAddress_String(context);
			}
			
			return null;
		}
		
		static new public TyonAddress_String DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as TyonParser.TyonAddress_StringContext);
		}
		
		static new public TyonAddress_String DOMify(Stream stream)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(stream).tyonAddress());
		}
		
		static new public TyonAddress_String DOMify(string text)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(text).tyonAddress());
		}
		
		static new public TyonAddress_String DOMifyFile(string filename)
		{
			return DOMify(TyonDOMinatorUtilities.CreateFileParser(filename).tyonAddress());
		}
		
		public TyonAddress_String()
		{
			@string = "";
			OnConstructor();
		}
		
		partial void OnConstructor();
		public TyonAddress_String(TyonParser.TyonAddress_StringContext context) : this()
		{
			LoadContextIntermediateString(context.STRING().GetTextEX());
		}
		
		public override TyonAddress Duplicate()
		{
			TyonAddress_String instance = new TyonAddress_String();
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
	
	public partial class TyonVariable : TyonElement
	{
		private string id;
		[RelatableChild]private TyonValue tyon_value;
		static public TyonVariable DOMify(TyonParser.TyonVariableContext context)
		{
			if(context != null)
			{
				return new TyonVariable(context);
			}
			
			return null;
		}
		
		static public TyonVariable DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as TyonParser.TyonVariableContext);
		}
		
		static public TyonVariable DOMify(Stream stream)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(stream).tyonVariable());
		}
		
		static public TyonVariable DOMify(string text)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(text).tyonVariable());
		}
		
		static public TyonVariable DOMifyFile(string filename)
		{
			return DOMify(TyonDOMinatorUtilities.CreateFileParser(filename).tyonVariable());
		}
		
		public TyonVariable()
		{
			id = "";
			tyon_value = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public TyonVariable(TyonParser.TyonVariableContext context) : this()
		{
			SetId(context.ID().GetTextEX());
			SetTyonValue(TyonValue.DOMify(context.tyonValue()));
		}
		
		public TyonVariable Duplicate()
		{
			TyonVariable instance = new TyonVariable();
			instance.SetId(GetId());
			instance.SetTyonValue(GetTyonValue().IfNotNull(z => z.Duplicate()));
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
		
		private void SetTyonValue(TyonValue input)
		{
			tyon_value = input;
		}
		
		public TyonValue GetTyonValue()
		{
			return tyon_value;
		}
		
	}
	
	public abstract partial class TyonElement : Object, Relatable
	{
		public TyonElement()
		{
			OnConstruct();
		}
		
		partial void OnConstruct();
	}
	
	static public class TyonDOMinatorUtilities
	{
		static public TyonParser CreateParser(ICharStream stream)
		{
			TyonParser parser = new TyonParser(new CommonTokenStream(new TyonLexer(stream)));
			parser.RemoveErrorListeners();
			parser.AddErrorListener(TyonSyntaxExceptionThrower.INSTANCE);
			return parser;
		}
		
		static public TyonParser CreateParser(Stream stream)
		{
			return CreateParser(new AntlrInputStream(stream));
		}
		
		static public TyonParser CreateParser(TextReader text_reader)
		{
			return CreateParser(new AntlrInputStream(text_reader));
		}
		
		static public TyonParser CreateParser(string text)
		{
			return CreateParser(new StringReader(text));
		}
		
		static public TyonParser CreateFileParser(string filename)
		{
			return CreateParser(new AntlrFileStream(filename));
		}
		
	}
	
	static public class TyonIParseTreeExtensions
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
	
	public partial class TyonResolver : TyonBaseVisitor<TyonElement>
	{
		static private TyonResolver instance;
		static public TyonResolver GetInstance()
		{
			if(instance == null)
			{
				instance = new TyonResolver();
			}
			
			return instance;
		}
		
		static public TyonElement Resolve(IParseTree parse_tree)
		{
			if(parse_tree != null)
			{
				return GetInstance().Visit(parse_tree);
			}
			
			return null;
		}
		
		static public T Resolve<T>(IParseTree parse_tree) where T : TyonElement
		{
			return Resolve(parse_tree) as T;
		}
		
		private TyonResolver()
		{
		}
		
		public override TyonElement VisitTyonType_Normal(TyonParser.TyonType_NormalContext context)
		{
			return TyonType_Direct_Normal.DOMify(context);
		}
		
		public override TyonElement VisitTyonType_Templated(TyonParser.TyonType_TemplatedContext context)
		{
			return TyonType_Direct_Templated.DOMify(context);
		}
		
		public override TyonElement VisitTyonType_Array(TyonParser.TyonType_ArrayContext context)
		{
			return TyonType_Array.DOMify(context);
		}
		
		public override TyonElement VisitTyonObject(TyonParser.TyonObjectContext context)
		{
			return TyonObject.DOMify(context);
		}
		
		public override TyonElement VisitTyonSurrogate(TyonParser.TyonSurrogateContext context)
		{
			return TyonSurrogate.DOMify(context);
		}
		
		public override TyonElement VisitTyonArray(TyonParser.TyonArrayContext context)
		{
			return TyonArray.DOMify(context);
		}
		
		public override TyonElement VisitTyonValueList(TyonParser.TyonValueListContext context)
		{
			return TyonValueList.DOMify(context);
		}
		
		public override TyonElement VisitTyonValue_Int(TyonParser.TyonValue_IntContext context)
		{
			return TyonValue_Int.DOMify(context);
		}
		
		public override TyonElement VisitTyonValue_Long(TyonParser.TyonValue_LongContext context)
		{
			return TyonValue_Long.DOMify(context);
		}
		
		public override TyonElement VisitTyonValue_Float(TyonParser.TyonValue_FloatContext context)
		{
			return TyonValue_Float.DOMify(context);
		}
		
		public override TyonElement VisitTyonValue_Double(TyonParser.TyonValue_DoubleContext context)
		{
			return TyonValue_Double.DOMify(context);
		}
		
		public override TyonElement VisitTyonValue_Decimal(TyonParser.TyonValue_DecimalContext context)
		{
			return TyonValue_Decimal.DOMify(context);
		}
		
		public override TyonElement VisitTyonValue_Boolean(TyonParser.TyonValue_BooleanContext context)
		{
			return TyonValue_Boolean.DOMify(context);
		}
		
		public override TyonElement VisitTyonValue_String(TyonParser.TyonValue_StringContext context)
		{
			return TyonValue_String.DOMify(context);
		}
		
		public override TyonElement VisitTyonValue_Null(TyonParser.TyonValue_NullContext context)
		{
			return TyonValue_Null.DOMify(context);
		}
		
		public override TyonElement VisitTyonValue_Type(TyonParser.TyonValue_TypeContext context)
		{
			return TyonValue_Type.DOMify(context);
		}
		
		public override TyonElement VisitTyonValue_InternalAddress(TyonParser.TyonValue_InternalAddressContext context)
		{
			return TyonValue_InternalAddress.DOMify(context);
		}
		
		public override TyonElement VisitTyonValue_ExternalAddress(TyonParser.TyonValue_ExternalAddressContext context)
		{
			return TyonValue_ExternalAddress.DOMify(context);
		}
		
		public override TyonElement VisitTyonValue_Array(TyonParser.TyonValue_ArrayContext context)
		{
			return TyonValue_Array.DOMify(context);
		}
		
		public override TyonElement VisitTyonValue_Object(TyonParser.TyonValue_ObjectContext context)
		{
			return TyonValue_Object.DOMify(context);
		}
		
		public override TyonElement VisitTyonValue_Surrogate(TyonParser.TyonValue_SurrogateContext context)
		{
			return TyonValue_Surrogate.DOMify(context);
		}
		
		public override TyonElement VisitTyonAddress_Identifier(TyonParser.TyonAddress_IdentifierContext context)
		{
			return TyonAddress_Identifier.DOMify(context);
		}
		
		public override TyonElement VisitTyonAddress_Int(TyonParser.TyonAddress_IntContext context)
		{
			return TyonAddress_Int.DOMify(context);
		}
		
		public override TyonElement VisitTyonAddress_String(TyonParser.TyonAddress_StringContext context)
		{
			return TyonAddress_String.DOMify(context);
		}
		
		public override TyonElement VisitTyonVariable(TyonParser.TyonVariableContext context)
		{
			return TyonVariable.DOMify(context);
		}
		
	}
	
	public partial class TyonSyntaxException : Exception
	{
		private int line;
		private string base_message;
		public override string Message { get{ return GetMessage(); } }
		public TyonSyntaxException(int l, string m) : base()
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
	
	public class TyonSyntaxExceptionThrower : BaseErrorListener
	{
		static public readonly TyonSyntaxExceptionThrower INSTANCE = new TyonSyntaxExceptionThrower();
		private TyonSyntaxExceptionThrower()
		{
		}
		
		public override void SyntaxError(TextWriter output, IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
		{
			throw new TyonSyntaxException(line, msg);
		}
		
	}
	
}
