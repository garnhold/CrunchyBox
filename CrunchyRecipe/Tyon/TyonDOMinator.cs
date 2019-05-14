
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: March 02 2019 22:17:42 -08:00

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace CrunchyRecipe
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
	
	public partial class TyonType_Normal : TyonType
	{
		private string id;
		static public TyonType_Normal DOMify(TyonParser.TyonType_NormalContext context)
		{
			if(context != null)
			{
				return new TyonType_Normal(context);
			}
			
			return null;
		}
		
		static new public TyonType_Normal DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as TyonParser.TyonType_NormalContext);
		}
		
		static new public TyonType_Normal DOMify(Stream stream)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(stream).tyonType());
		}
		
		static new public TyonType_Normal DOMify(string text)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(text).tyonType());
		}
		
		static new public TyonType_Normal DOMifyFile(string filename)
		{
			return DOMify(TyonDOMinatorUtilities.CreateFileParser(filename).tyonType());
		}
		
		public TyonType_Normal()
		{
			id = "";
			OnConstructor();
		}
		
		partial void OnConstructor();
		public TyonType_Normal(TyonParser.TyonType_NormalContext context) : this()
		{
			SetId(context.ID().GetTextEX());
		}
		
		public override TyonType Duplicate()
		{
			TyonType_Normal instance = new TyonType_Normal();
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
	
	public partial class TyonType_Templated : TyonType
	{
		private string id;
		[RelatableChild]private List<TyonType> tyon_types;
		static public TyonType_Templated DOMify(TyonParser.TyonType_TemplatedContext context)
		{
			if(context != null)
			{
				return new TyonType_Templated(context);
			}
			
			return null;
		}
		
		static new public TyonType_Templated DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as TyonParser.TyonType_TemplatedContext);
		}
		
		static new public TyonType_Templated DOMify(Stream stream)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(stream).tyonType());
		}
		
		static new public TyonType_Templated DOMify(string text)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(text).tyonType());
		}
		
		static new public TyonType_Templated DOMifyFile(string filename)
		{
			return DOMify(TyonDOMinatorUtilities.CreateFileParser(filename).tyonType());
		}
		
		public TyonType_Templated()
		{
			id = "";
			tyon_types = new List<TyonType>();
			OnConstructor();
		}
		
		partial void OnConstructor();
		public TyonType_Templated(TyonParser.TyonType_TemplatedContext context) : this()
		{
			SetId(context.ID().GetTextEX());
			AddTyonTypes(context.tyonType().Convert(c => TyonType.DOMify(c)));
		}
		
		public override TyonType Duplicate()
		{
			TyonType_Templated instance = new TyonType_Templated();
			instance.SetId(GetId());
			instance.SetTyonTypes(GetTyonTypes().Convert(i => i.IfNotNull(z => z.Duplicate())));
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
	
	public partial class TyonObject : TyonElement
	{
		[RelatableChild]private TyonType tyon_type;
		[RelatableChild]private TyonAddress tyon_address;
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
			tyon_variables = new List<TyonVariable>();
			OnConstructor();
		}
		
		partial void OnConstructor();
		public TyonObject(TyonParser.TyonObjectContext context) : this()
		{
			SetTyonType(TyonType.DOMify(context.tyonType()));
			SetTyonAddress(TyonAddress.DOMify(context.tyonAddress()));
			AddTyonVariables(context.tyonVariable().Convert(c => TyonVariable.DOMify(c)));
		}
		
		public TyonObject Duplicate()
		{
			TyonObject instance = new TyonObject();
			instance.SetTyonType(GetTyonType().IfNotNull(z => z.Duplicate()));
			instance.SetTyonAddress(GetTyonAddress().IfNotNull(z => z.Duplicate()));
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
		[RelatableChild]private TyonAddress tyon_address;
		private string @string;
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
			tyon_address = null;
			@string = "";
			OnConstructor();
		}
		
		partial void OnConstructor();
		public TyonSurrogate(TyonParser.TyonSurrogateContext context) : this()
		{
			SetTyonType(TyonType.DOMify(context.tyonType()));
			SetTyonAddress(TyonAddress.DOMify(context.tyonAddress()));
			LoadContextIntermediateString(context.STRING().GetTextEX());
		}
		
		public TyonSurrogate Duplicate()
		{
			TyonSurrogate instance = new TyonSurrogate();
			instance.SetTyonType(GetTyonType().IfNotNull(z => z.Duplicate()));
			instance.SetTyonAddress(GetTyonAddress().IfNotNull(z => z.Duplicate()));
			instance.SetString(GetString());
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
		
		private void SetString(string input)
		{
			@string = input;
		}
		
		public string GetString()
		{
			return @string;
		}
		
	}
	
	public partial class TyonArray : TyonElement
	{
		[RelatableChild]private TyonType tyon_type;
		[RelatableChild]private List<TyonValue> tyon_values;
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
			tyon_values = new List<TyonValue>();
			OnConstructor();
		}
		
		partial void OnConstructor();
		public TyonArray(TyonParser.TyonArrayContext context) : this()
		{
			SetTyonType(TyonType.DOMify(context.tyonType()));
			AddTyonValues(context.tyonValue().Convert(c => TyonValue.DOMify(c)));
		}
		
		public TyonArray Duplicate()
		{
			TyonArray instance = new TyonArray();
			instance.SetTyonType(GetTyonType().IfNotNull(z => z.Duplicate()));
			instance.SetTyonValues(GetTyonValues().Convert(i => i.IfNotNull(z => z.Duplicate())));
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
	
	public partial class TyonValue_Number : TyonValue
	{
		private string number;
		static public TyonValue_Number DOMify(TyonParser.TyonValue_NumberContext context)
		{
			if(context != null)
			{
				return new TyonValue_Number(context);
			}
			
			return null;
		}
		
		static new public TyonValue_Number DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as TyonParser.TyonValue_NumberContext);
		}
		
		static new public TyonValue_Number DOMify(Stream stream)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(stream).tyonValue());
		}
		
		static new public TyonValue_Number DOMify(string text)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(text).tyonValue());
		}
		
		static new public TyonValue_Number DOMifyFile(string filename)
		{
			return DOMify(TyonDOMinatorUtilities.CreateFileParser(filename).tyonValue());
		}
		
		public TyonValue_Number()
		{
			number = "";
			OnConstructor();
		}
		
		partial void OnConstructor();
		public TyonValue_Number(TyonParser.TyonValue_NumberContext context) : this()
		{
			SetNumber(context.NUMBER().GetTextEX());
		}
		
		public override TyonValue Duplicate()
		{
			TyonValue_Number instance = new TyonValue_Number();
			instance.SetNumber(GetNumber());
			return instance;
		}
		
		private void SetNumber(string input)
		{
			number = input;
		}
		
		public string GetNumber()
		{
			return number;
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
		private int number;
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
			number = 0;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public TyonAddress_Int(TyonParser.TyonAddress_IntContext context) : this()
		{
			SetNumber(context.NUMBER().GetTextEX().ParseInt());
		}
		
		public override TyonAddress Duplicate()
		{
			TyonAddress_Int instance = new TyonAddress_Int();
			instance.SetNumber(GetNumber());
			return instance;
		}
		
		private void SetNumber(int input)
		{
			number = input;
		}
		
		public int GetNumber()
		{
			return number;
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
	
	public partial class TyonAddress_Object : TyonAddress
	{
		[RelatableChild]private TyonObject tyon_object;
		static public TyonAddress_Object DOMify(TyonParser.TyonAddress_ObjectContext context)
		{
			if(context != null)
			{
				return new TyonAddress_Object(context);
			}
			
			return null;
		}
		
		static new public TyonAddress_Object DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as TyonParser.TyonAddress_ObjectContext);
		}
		
		static new public TyonAddress_Object DOMify(Stream stream)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(stream).tyonAddress());
		}
		
		static new public TyonAddress_Object DOMify(string text)
		{
			return DOMify(TyonDOMinatorUtilities.CreateParser(text).tyonAddress());
		}
		
		static new public TyonAddress_Object DOMifyFile(string filename)
		{
			return DOMify(TyonDOMinatorUtilities.CreateFileParser(filename).tyonAddress());
		}
		
		public TyonAddress_Object()
		{
			tyon_object = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public TyonAddress_Object(TyonParser.TyonAddress_ObjectContext context) : this()
		{
			SetTyonObject(TyonObject.DOMify(context.tyonObject()));
		}
		
		public override TyonAddress Duplicate()
		{
			TyonAddress_Object instance = new TyonAddress_Object();
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
			return TyonType_Normal.DOMify(context);
		}
		
		public override TyonElement VisitTyonType_Templated(TyonParser.TyonType_TemplatedContext context)
		{
			return TyonType_Templated.DOMify(context);
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
		
		public override TyonElement VisitTyonValue_Number(TyonParser.TyonValue_NumberContext context)
		{
			return TyonValue_Number.DOMify(context);
		}
		
		public override TyonElement VisitTyonValue_String(TyonParser.TyonValue_StringContext context)
		{
			return TyonValue_String.DOMify(context);
		}
		
		public override TyonElement VisitTyonValue_Null(TyonParser.TyonValue_NullContext context)
		{
			return TyonValue_Null.DOMify(context);
		}
		
		public override TyonElement VisitTyonValue_InternalAddress(TyonParser.TyonValue_InternalAddressContext context)
		{
			return TyonValue_InternalAddress.DOMify(context);
		}
		
		public override TyonElement VisitTyonValue_ExternalAddress(TyonParser.TyonValue_ExternalAddressContext context)
		{
			return TyonValue_ExternalAddress.DOMify(context);
		}
		
		public override TyonElement VisitTyonValue_Object(TyonParser.TyonValue_ObjectContext context)
		{
			return TyonValue_Object.DOMify(context);
		}
		
		public override TyonElement VisitTyonValue_Surrogate(TyonParser.TyonValue_SurrogateContext context)
		{
			return TyonValue_Surrogate.DOMify(context);
		}
		
		public override TyonElement VisitTyonValue_Array(TyonParser.TyonValue_ArrayContext context)
		{
			return TyonValue_Array.DOMify(context);
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
		
		public override TyonElement VisitTyonAddress_Object(TyonParser.TyonAddress_ObjectContext context)
		{
			return TyonAddress_Object.DOMify(context);
		}
		
		public override TyonElement VisitTyonVariable(TyonParser.TyonVariableContext context)
		{
			return TyonVariable.DOMify(context);
		}
		
	}
	
	public partial class TyonSyntaxException : Exception
	{
		private int line;
		private int column;
		private string base_message;
		public TyonSyntaxException(int l, int c, string m) : base()
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
	
	public class TyonSyntaxExceptionThrower : BaseErrorListener
	{
		static public readonly TyonSyntaxExceptionThrower INSTANCE = new TyonSyntaxExceptionThrower();
		private TyonSyntaxExceptionThrower()
		{
		}
		
		public override void SyntaxError(IRecognizer recognizer, IToken offendingSymbol, int line, int column, string msg, RecognitionException e)
		{
			throw new TyonSyntaxException(line, column, msg);
		}
		
	}
	
}
