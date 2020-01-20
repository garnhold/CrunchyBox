
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: January 19 2020 22:50:29 -08:00

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Noodle;

using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace Crunchy.Sack
{
	public partial class CmlClassDefinition : CmlElement
	{
		[RelatableChild]private CmlEntity entity;
		static public CmlClassDefinition DOMify(CmlParser.CmlClassDefinitionContext context)
		{
			if(context != null)
			{
				return new CmlClassDefinition(context);
			}
			
			return null;
		}
		
		static public CmlClassDefinition DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlClassDefinitionContext);
		}
		
		static public CmlClassDefinition DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlClassDefinition());
		}
		
		static public CmlClassDefinition DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlClassDefinition());
		}
		
		static public CmlClassDefinition DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlClassDefinition());
		}
		
		public CmlClassDefinition()
		{
			entity = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlClassDefinition(CmlParser.CmlClassDefinitionContext context) : this()
		{
			SetEntity(CmlEntity.DOMify(context.cmlEntity()));
		}
		
		public CmlClassDefinition Duplicate()
		{
			CmlClassDefinition instance = new CmlClassDefinition();
			instance.SetEntity(GetEntity().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetEntity(CmlEntity input)
		{
			entity = input;
		}
		
		public CmlEntity GetEntity()
		{
			return entity;
		}
		
	}
	
	public partial class CmlFragmentDefinition : CmlElement
	{
		[RelatableChild]private CmlEntity entity;
		static public CmlFragmentDefinition DOMify(CmlParser.CmlFragmentDefinitionContext context)
		{
			if(context != null)
			{
				return new CmlFragmentDefinition(context);
			}
			
			return null;
		}
		
		static public CmlFragmentDefinition DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlFragmentDefinitionContext);
		}
		
		static public CmlFragmentDefinition DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlFragmentDefinition());
		}
		
		static public CmlFragmentDefinition DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlFragmentDefinition());
		}
		
		static public CmlFragmentDefinition DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlFragmentDefinition());
		}
		
		public CmlFragmentDefinition()
		{
			entity = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlFragmentDefinition(CmlParser.CmlFragmentDefinitionContext context) : this()
		{
			SetEntity(CmlEntity.DOMify(context.cmlEntity()));
		}
		
		public CmlFragmentDefinition Duplicate()
		{
			CmlFragmentDefinition instance = new CmlFragmentDefinition();
			instance.SetEntity(GetEntity().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetEntity(CmlEntity input)
		{
			entity = input;
		}
		
		public CmlEntity GetEntity()
		{
			return entity;
		}
		
	}
	
	public abstract partial class CmlValueSource : CmlElement
	{
		public abstract CmlValueSource Duplicate();
		static public CmlValueSource DOMify(CmlParser.CmlValueSourceContext context)
		{
			return CmlResolver.Resolve<CmlValueSource>(context);
		}
		
		static public CmlValueSource DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlValueSourceContext);
		}
		
		static public CmlValueSource DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlValueSource());
		}
		
		static public CmlValueSource DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlValueSource());
		}
		
		static public CmlValueSource DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlValueSource());
		}
		
	}
	
	public partial class CmlValueSource_ComponentSource : CmlValueSource
	{
		[RelatableChild]private CmlComponentSource component_source;
		static public CmlValueSource_ComponentSource DOMify(CmlParser.CmlValueSource_ComponentSourceContext context)
		{
			if(context != null)
			{
				return new CmlValueSource_ComponentSource(context);
			}
			
			return null;
		}
		
		static new public CmlValueSource_ComponentSource DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlValueSource_ComponentSourceContext);
		}
		
		static new public CmlValueSource_ComponentSource DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlValueSource());
		}
		
		static new public CmlValueSource_ComponentSource DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlValueSource());
		}
		
		static new public CmlValueSource_ComponentSource DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlValueSource());
		}
		
		public CmlValueSource_ComponentSource()
		{
			component_source = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlValueSource_ComponentSource(CmlParser.CmlValueSource_ComponentSourceContext context) : this()
		{
			SetComponentSource(CmlComponentSource.DOMify(context.cmlComponentSource()));
		}
		
		public override CmlValueSource Duplicate()
		{
			CmlValueSource_ComponentSource instance = new CmlValueSource_ComponentSource();
			instance.SetComponentSource(GetComponentSource().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetComponentSource(CmlComponentSource input)
		{
			component_source = input;
		}
		
		public CmlComponentSource GetComponentSource()
		{
			return component_source;
		}
		
	}
	
	public partial class CmlValueSource_ComponentSourceList : CmlValueSource
	{
		[RelatableChild]private CmlComponentSourceList component_source_list;
		static public CmlValueSource_ComponentSourceList DOMify(CmlParser.CmlValueSource_ComponentSourceListContext context)
		{
			if(context != null)
			{
				return new CmlValueSource_ComponentSourceList(context);
			}
			
			return null;
		}
		
		static new public CmlValueSource_ComponentSourceList DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlValueSource_ComponentSourceListContext);
		}
		
		static new public CmlValueSource_ComponentSourceList DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlValueSource());
		}
		
		static new public CmlValueSource_ComponentSourceList DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlValueSource());
		}
		
		static new public CmlValueSource_ComponentSourceList DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlValueSource());
		}
		
		public CmlValueSource_ComponentSourceList()
		{
			component_source_list = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlValueSource_ComponentSourceList(CmlParser.CmlValueSource_ComponentSourceListContext context) : this()
		{
			SetComponentSourceList(CmlComponentSourceList.DOMify(context.cmlComponentSourceList()));
		}
		
		public override CmlValueSource Duplicate()
		{
			CmlValueSource_ComponentSourceList instance = new CmlValueSource_ComponentSourceList();
			instance.SetComponentSourceList(GetComponentSourceList().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetComponentSourceList(CmlComponentSourceList input)
		{
			component_source_list = input;
		}
		
		public CmlComponentSourceList GetComponentSourceList()
		{
			return component_source_list;
		}
		
	}
	
	public partial class CmlValueSource_LinkSource : CmlValueSource
	{
		[RelatableChild]private CmlLinkSource link_source;
		static public CmlValueSource_LinkSource DOMify(CmlParser.CmlValueSource_LinkSourceContext context)
		{
			if(context != null)
			{
				return new CmlValueSource_LinkSource(context);
			}
			
			return null;
		}
		
		static new public CmlValueSource_LinkSource DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlValueSource_LinkSourceContext);
		}
		
		static new public CmlValueSource_LinkSource DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlValueSource());
		}
		
		static new public CmlValueSource_LinkSource DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlValueSource());
		}
		
		static new public CmlValueSource_LinkSource DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlValueSource());
		}
		
		public CmlValueSource_LinkSource()
		{
			link_source = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlValueSource_LinkSource(CmlParser.CmlValueSource_LinkSourceContext context) : this()
		{
			SetLinkSource(CmlLinkSource.DOMify(context.cmlLinkSource()));
		}
		
		public override CmlValueSource Duplicate()
		{
			CmlValueSource_LinkSource instance = new CmlValueSource_LinkSource();
			instance.SetLinkSource(GetLinkSource().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetLinkSource(CmlLinkSource input)
		{
			link_source = input;
		}
		
		public CmlLinkSource GetLinkSource()
		{
			return link_source;
		}
		
	}
	
	public partial class CmlValueSource_LinkSourceWithEntitySource : CmlValueSource
	{
		[RelatableChild]private CmlLinkSourceWithEntitySource link_source_with_entity_source;
		static public CmlValueSource_LinkSourceWithEntitySource DOMify(CmlParser.CmlValueSource_LinkSourceWithEntitySourceContext context)
		{
			if(context != null)
			{
				return new CmlValueSource_LinkSourceWithEntitySource(context);
			}
			
			return null;
		}
		
		static new public CmlValueSource_LinkSourceWithEntitySource DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlValueSource_LinkSourceWithEntitySourceContext);
		}
		
		static new public CmlValueSource_LinkSourceWithEntitySource DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlValueSource());
		}
		
		static new public CmlValueSource_LinkSourceWithEntitySource DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlValueSource());
		}
		
		static new public CmlValueSource_LinkSourceWithEntitySource DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlValueSource());
		}
		
		public CmlValueSource_LinkSourceWithEntitySource()
		{
			link_source_with_entity_source = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlValueSource_LinkSourceWithEntitySource(CmlParser.CmlValueSource_LinkSourceWithEntitySourceContext context) : this()
		{
			SetLinkSourceWithEntitySource(CmlLinkSourceWithEntitySource.DOMify(context.cmlLinkSourceWithEntitySource()));
		}
		
		public override CmlValueSource Duplicate()
		{
			CmlValueSource_LinkSourceWithEntitySource instance = new CmlValueSource_LinkSourceWithEntitySource();
			instance.SetLinkSourceWithEntitySource(GetLinkSourceWithEntitySource().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetLinkSourceWithEntitySource(CmlLinkSourceWithEntitySource input)
		{
			link_source_with_entity_source = input;
		}
		
		public CmlLinkSourceWithEntitySource GetLinkSourceWithEntitySource()
		{
			return link_source_with_entity_source;
		}
		
	}
	
	public partial class CmlValueSource_FunctionSource : CmlValueSource
	{
		[RelatableChild]private CmlFunctionSource function_source;
		static public CmlValueSource_FunctionSource DOMify(CmlParser.CmlValueSource_FunctionSourceContext context)
		{
			if(context != null)
			{
				return new CmlValueSource_FunctionSource(context);
			}
			
			return null;
		}
		
		static new public CmlValueSource_FunctionSource DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlValueSource_FunctionSourceContext);
		}
		
		static new public CmlValueSource_FunctionSource DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlValueSource());
		}
		
		static new public CmlValueSource_FunctionSource DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlValueSource());
		}
		
		static new public CmlValueSource_FunctionSource DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlValueSource());
		}
		
		public CmlValueSource_FunctionSource()
		{
			function_source = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlValueSource_FunctionSource(CmlParser.CmlValueSource_FunctionSourceContext context) : this()
		{
			SetFunctionSource(CmlFunctionSource.DOMify(context.cmlFunctionSource()));
		}
		
		public override CmlValueSource Duplicate()
		{
			CmlValueSource_FunctionSource instance = new CmlValueSource_FunctionSource();
			instance.SetFunctionSource(GetFunctionSource().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetFunctionSource(CmlFunctionSource input)
		{
			function_source = input;
		}
		
		public CmlFunctionSource GetFunctionSource()
		{
			return function_source;
		}
		
	}
	
	public abstract partial class CmlComponentSource : CmlElement
	{
		public abstract CmlComponentSource Duplicate();
		static public CmlComponentSource DOMify(CmlParser.CmlComponentSourceContext context)
		{
			return CmlResolver.Resolve<CmlComponentSource>(context);
		}
		
		static public CmlComponentSource DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlComponentSourceContext);
		}
		
		static public CmlComponentSource DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlComponentSource());
		}
		
		static public CmlComponentSource DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlComponentSource());
		}
		
		static public CmlComponentSource DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlComponentSource());
		}
		
	}
	
	public partial class CmlComponentSource_Primitive : CmlComponentSource
	{
		[RelatableChild]private CmlPrimitive primitive;
		static public CmlComponentSource_Primitive DOMify(CmlParser.CmlComponentSource_PrimitiveContext context)
		{
			if(context != null)
			{
				return new CmlComponentSource_Primitive(context);
			}
			
			return null;
		}
		
		static new public CmlComponentSource_Primitive DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlComponentSource_PrimitiveContext);
		}
		
		static new public CmlComponentSource_Primitive DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlComponentSource());
		}
		
		static new public CmlComponentSource_Primitive DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlComponentSource());
		}
		
		static new public CmlComponentSource_Primitive DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlComponentSource());
		}
		
		public CmlComponentSource_Primitive()
		{
			primitive = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlComponentSource_Primitive(CmlParser.CmlComponentSource_PrimitiveContext context) : this()
		{
			SetPrimitive(CmlPrimitive.DOMify(context.cmlPrimitive()));
		}
		
		public override CmlComponentSource Duplicate()
		{
			CmlComponentSource_Primitive instance = new CmlComponentSource_Primitive();
			instance.SetPrimitive(GetPrimitive().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetPrimitive(CmlPrimitive input)
		{
			primitive = input;
		}
		
		public CmlPrimitive GetPrimitive()
		{
			return primitive;
		}
		
	}
	
	public partial class CmlComponentSource_Entity : CmlComponentSource
	{
		[RelatableChild]private CmlEntity entity;
		static public CmlComponentSource_Entity DOMify(CmlParser.CmlComponentSource_EntityContext context)
		{
			if(context != null)
			{
				return new CmlComponentSource_Entity(context);
			}
			
			return null;
		}
		
		static new public CmlComponentSource_Entity DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlComponentSource_EntityContext);
		}
		
		static new public CmlComponentSource_Entity DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlComponentSource());
		}
		
		static new public CmlComponentSource_Entity DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlComponentSource());
		}
		
		static new public CmlComponentSource_Entity DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlComponentSource());
		}
		
		public CmlComponentSource_Entity()
		{
			entity = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlComponentSource_Entity(CmlParser.CmlComponentSource_EntityContext context) : this()
		{
			SetEntity(CmlEntity.DOMify(context.cmlEntity()));
		}
		
		public override CmlComponentSource Duplicate()
		{
			CmlComponentSource_Entity instance = new CmlComponentSource_Entity();
			instance.SetEntity(GetEntity().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetEntity(CmlEntity input)
		{
			entity = input;
		}
		
		public CmlEntity GetEntity()
		{
			return entity;
		}
		
	}
	
	public partial class CmlComponentSource_Constructor : CmlComponentSource
	{
		[RelatableChild]private CmlConstructor constructor;
		static public CmlComponentSource_Constructor DOMify(CmlParser.CmlComponentSource_ConstructorContext context)
		{
			if(context != null)
			{
				return new CmlComponentSource_Constructor(context);
			}
			
			return null;
		}
		
		static new public CmlComponentSource_Constructor DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlComponentSource_ConstructorContext);
		}
		
		static new public CmlComponentSource_Constructor DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlComponentSource());
		}
		
		static new public CmlComponentSource_Constructor DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlComponentSource());
		}
		
		static new public CmlComponentSource_Constructor DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlComponentSource());
		}
		
		public CmlComponentSource_Constructor()
		{
			constructor = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlComponentSource_Constructor(CmlParser.CmlComponentSource_ConstructorContext context) : this()
		{
			SetConstructor(CmlConstructor.DOMify(context.cmlConstructor()));
		}
		
		public override CmlComponentSource Duplicate()
		{
			CmlComponentSource_Constructor instance = new CmlComponentSource_Constructor();
			instance.SetConstructor(GetConstructor().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetConstructor(CmlConstructor input)
		{
			constructor = input;
		}
		
		public CmlConstructor GetConstructor()
		{
			return constructor;
		}
		
	}
	
	public partial class CmlComponentSource_InsertParameter : CmlComponentSource
	{
		[RelatableChild]private CmlInsertParameter insert_parameter;
		static public CmlComponentSource_InsertParameter DOMify(CmlParser.CmlComponentSource_InsertParameterContext context)
		{
			if(context != null)
			{
				return new CmlComponentSource_InsertParameter(context);
			}
			
			return null;
		}
		
		static new public CmlComponentSource_InsertParameter DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlComponentSource_InsertParameterContext);
		}
		
		static new public CmlComponentSource_InsertParameter DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlComponentSource());
		}
		
		static new public CmlComponentSource_InsertParameter DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlComponentSource());
		}
		
		static new public CmlComponentSource_InsertParameter DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlComponentSource());
		}
		
		public CmlComponentSource_InsertParameter()
		{
			insert_parameter = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlComponentSource_InsertParameter(CmlParser.CmlComponentSource_InsertParameterContext context) : this()
		{
			SetInsertParameter(CmlInsertParameter.DOMify(context.cmlInsertParameter()));
		}
		
		public override CmlComponentSource Duplicate()
		{
			CmlComponentSource_InsertParameter instance = new CmlComponentSource_InsertParameter();
			instance.SetInsertParameter(GetInsertParameter().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetInsertParameter(CmlInsertParameter input)
		{
			insert_parameter = input;
		}
		
		public CmlInsertParameter GetInsertParameter()
		{
			return insert_parameter;
		}
		
	}
	
	public partial class CmlComponentSourceList : CmlElement
	{
		[RelatableChild]private List<CmlComponentSource> component_sources;
		static public CmlComponentSourceList DOMify(CmlParser.CmlComponentSourceListContext context)
		{
			if(context != null)
			{
				return new CmlComponentSourceList(context);
			}
			
			return null;
		}
		
		static public CmlComponentSourceList DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlComponentSourceListContext);
		}
		
		static public CmlComponentSourceList DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlComponentSourceList());
		}
		
		static public CmlComponentSourceList DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlComponentSourceList());
		}
		
		static public CmlComponentSourceList DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlComponentSourceList());
		}
		
		public CmlComponentSourceList()
		{
			component_sources = new List<CmlComponentSource>();
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlComponentSourceList(CmlParser.CmlComponentSourceListContext context) : this()
		{
			AddComponentSources(context.cmlComponentSource().Convert(c => CmlComponentSource.DOMify(c)));
		}
		
		public CmlComponentSourceList Duplicate()
		{
			CmlComponentSourceList instance = new CmlComponentSourceList();
			instance.SetComponentSources(GetComponentSources().Convert(i => i.IfNotNull(z => z.Duplicate())));
			return instance;
		}
		
		private void ClearComponentSources()
		{
			component_sources.Clear();
		}
		
		private void SetComponentSources(IEnumerable<CmlComponentSource> input)
		{
			ClearComponentSources();
			AddComponentSources(input);
		}
		
		private void SetComponentSources(params CmlComponentSource[] input)
		{
			SetComponentSources((IEnumerable<CmlComponentSource>)input);
		}
		
		private void AddComponentSource(CmlComponentSource input)
		{
			component_sources.Add(input);
		}
		
		private void AddComponentSources(IEnumerable<CmlComponentSource> input)
		{
			input.Process(i => AddComponentSource(i));
		}
		
		private void AddComponentSources(params CmlComponentSource[] input)
		{
			AddComponentSources((IEnumerable<CmlComponentSource>)input);
		}
		
		public IEnumerable<CmlComponentSource> GetComponentSources()
		{
			return component_sources;
		}
		
	}
	
	public abstract partial class CmlPrimitive : CmlElement
	{
		public abstract CmlPrimitive Duplicate();
		static public CmlPrimitive DOMify(CmlParser.CmlPrimitiveContext context)
		{
			return CmlResolver.Resolve<CmlPrimitive>(context);
		}
		
		static public CmlPrimitive DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlPrimitiveContext);
		}
		
		static public CmlPrimitive DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlPrimitive());
		}
		
		static public CmlPrimitive DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlPrimitive());
		}
		
		static public CmlPrimitive DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlPrimitive());
		}
		
	}
	
	public partial class CmlPrimitive_Int : CmlPrimitive
	{
		private int @int;
		static public CmlPrimitive_Int DOMify(CmlParser.CmlPrimitive_IntContext context)
		{
			if(context != null)
			{
				return new CmlPrimitive_Int(context);
			}
			
			return null;
		}
		
		static new public CmlPrimitive_Int DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlPrimitive_IntContext);
		}
		
		static new public CmlPrimitive_Int DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlPrimitive());
		}
		
		static new public CmlPrimitive_Int DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlPrimitive());
		}
		
		static new public CmlPrimitive_Int DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlPrimitive());
		}
		
		public CmlPrimitive_Int()
		{
			@int = 0;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlPrimitive_Int(CmlParser.CmlPrimitive_IntContext context) : this()
		{
			SetInt(context.INT().GetTextEX().ParseInt());
		}
		
		public override CmlPrimitive Duplicate()
		{
			CmlPrimitive_Int instance = new CmlPrimitive_Int();
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
	
	public partial class CmlPrimitive_Float : CmlPrimitive
	{
		private float @float;
		static public CmlPrimitive_Float DOMify(CmlParser.CmlPrimitive_FloatContext context)
		{
			if(context != null)
			{
				return new CmlPrimitive_Float(context);
			}
			
			return null;
		}
		
		static new public CmlPrimitive_Float DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlPrimitive_FloatContext);
		}
		
		static new public CmlPrimitive_Float DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlPrimitive());
		}
		
		static new public CmlPrimitive_Float DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlPrimitive());
		}
		
		static new public CmlPrimitive_Float DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlPrimitive());
		}
		
		public CmlPrimitive_Float()
		{
			@float = 0.0f;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlPrimitive_Float(CmlParser.CmlPrimitive_FloatContext context) : this()
		{
			SetFloat(context.FLOAT().GetTextEX().ParseFloat());
		}
		
		public override CmlPrimitive Duplicate()
		{
			CmlPrimitive_Float instance = new CmlPrimitive_Float();
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
	
	public partial class CmlPrimitive_Double : CmlPrimitive
	{
		private double @double;
		static public CmlPrimitive_Double DOMify(CmlParser.CmlPrimitive_DoubleContext context)
		{
			if(context != null)
			{
				return new CmlPrimitive_Double(context);
			}
			
			return null;
		}
		
		static new public CmlPrimitive_Double DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlPrimitive_DoubleContext);
		}
		
		static new public CmlPrimitive_Double DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlPrimitive());
		}
		
		static new public CmlPrimitive_Double DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlPrimitive());
		}
		
		static new public CmlPrimitive_Double DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlPrimitive());
		}
		
		public CmlPrimitive_Double()
		{
			@double = 0.0;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlPrimitive_Double(CmlParser.CmlPrimitive_DoubleContext context) : this()
		{
			SetDouble(context.DOUBLE().GetTextEX().ParseDouble());
		}
		
		public override CmlPrimitive Duplicate()
		{
			CmlPrimitive_Double instance = new CmlPrimitive_Double();
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
	
	public partial class CmlPrimitive_Null : CmlPrimitive
	{
		private string @null;
		static public CmlPrimitive_Null DOMify(CmlParser.CmlPrimitive_NullContext context)
		{
			if(context != null)
			{
				return new CmlPrimitive_Null(context);
			}
			
			return null;
		}
		
		static new public CmlPrimitive_Null DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlPrimitive_NullContext);
		}
		
		static new public CmlPrimitive_Null DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlPrimitive());
		}
		
		static new public CmlPrimitive_Null DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlPrimitive());
		}
		
		static new public CmlPrimitive_Null DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlPrimitive());
		}
		
		public CmlPrimitive_Null()
		{
			@null = "";
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlPrimitive_Null(CmlParser.CmlPrimitive_NullContext context) : this()
		{
			SetNull(context.NULL().GetTextEX());
		}
		
		public override CmlPrimitive Duplicate()
		{
			CmlPrimitive_Null instance = new CmlPrimitive_Null();
			instance.SetNull(GetNull());
			return instance;
		}
		
		private void SetNull(string input)
		{
			@null = input;
		}
		
		public string GetNull()
		{
			return @null;
		}
		
	}
	
	public partial class CmlPrimitive_Bool : CmlPrimitive
	{
		private bool @bool;
		static public CmlPrimitive_Bool DOMify(CmlParser.CmlPrimitive_BoolContext context)
		{
			if(context != null)
			{
				return new CmlPrimitive_Bool(context);
			}
			
			return null;
		}
		
		static new public CmlPrimitive_Bool DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlPrimitive_BoolContext);
		}
		
		static new public CmlPrimitive_Bool DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlPrimitive());
		}
		
		static new public CmlPrimitive_Bool DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlPrimitive());
		}
		
		static new public CmlPrimitive_Bool DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlPrimitive());
		}
		
		public CmlPrimitive_Bool()
		{
			@bool = false;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlPrimitive_Bool(CmlParser.CmlPrimitive_BoolContext context) : this()
		{
			SetBool(context.BOOL().GetTextEX().ParseBool());
		}
		
		public override CmlPrimitive Duplicate()
		{
			CmlPrimitive_Bool instance = new CmlPrimitive_Bool();
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
	
	public partial class CmlPrimitive_String : CmlPrimitive
	{
		private string @string;
		static public CmlPrimitive_String DOMify(CmlParser.CmlPrimitive_StringContext context)
		{
			if(context != null)
			{
				return new CmlPrimitive_String(context);
			}
			
			return null;
		}
		
		static new public CmlPrimitive_String DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlPrimitive_StringContext);
		}
		
		static new public CmlPrimitive_String DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlPrimitive());
		}
		
		static new public CmlPrimitive_String DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlPrimitive());
		}
		
		static new public CmlPrimitive_String DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlPrimitive());
		}
		
		public CmlPrimitive_String()
		{
			@string = "";
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlPrimitive_String(CmlParser.CmlPrimitive_StringContext context) : this()
		{
			LoadContextIntermediateString(context.STRING().GetTextEX());
		}
		
		public override CmlPrimitive Duplicate()
		{
			CmlPrimitive_String instance = new CmlPrimitive_String();
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
	
	public partial class CmlEntity : CmlElement
	{
		private string tag;
		private string id;
		[RelatableChild]private List<CmlEntityAttribute> attributes;
		[RelatableChild]private CmlEntityChildren children;
		[RelatableChild]private CmlEntityMountPoint mount_point;
		[RelatableChild]private CmlEntityCompositeChild composite_child;
		static public CmlEntity DOMify(CmlParser.CmlEntityContext context)
		{
			if(context != null)
			{
				return new CmlEntity(context);
			}
			
			return null;
		}
		
		static public CmlEntity DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlEntityContext);
		}
		
		static public CmlEntity DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlEntity());
		}
		
		static public CmlEntity DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlEntity());
		}
		
		static public CmlEntity DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlEntity());
		}
		
		public CmlEntity()
		{
			tag = "";
			id = "";
			attributes = new List<CmlEntityAttribute>();
			children = null;
			mount_point = null;
			composite_child = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlEntity(CmlParser.CmlEntityContext context) : this()
		{
			SetTag(context.ID(0).GetTextEX());
			SetId(context.ID(1).GetTextEX());
			AddAttributes(context.cmlEntityAttribute().Convert(c => CmlEntityAttribute.DOMify(c)));
			SetChildren(CmlEntityChildren.DOMify(context.cmlEntityChildren()));
			SetMountPoint(CmlEntityMountPoint.DOMify(context.cmlEntityMountPoint()));
			SetCompositeChild(CmlEntityCompositeChild.DOMify(context.cmlEntityCompositeChild()));
		}
		
		public CmlEntity Duplicate()
		{
			CmlEntity instance = new CmlEntity();
			instance.SetTag(GetTag());
			instance.SetId(GetId());
			instance.SetAttributes(GetAttributes().Convert(i => i.IfNotNull(z => z.Duplicate())));
			instance.SetChildren(GetChildren().IfNotNull(z => z.Duplicate()));
			instance.SetMountPoint(GetMountPoint().IfNotNull(z => z.Duplicate()));
			instance.SetCompositeChild(GetCompositeChild().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetTag(string input)
		{
			tag = input;
		}
		
		public string GetTag()
		{
			return tag;
		}
		
		private void SetId(string input)
		{
			id = input;
		}
		
		public string GetId()
		{
			return id;
		}
		
		private void ClearAttributes()
		{
			attributes.Clear();
		}
		
		private void SetAttributes(IEnumerable<CmlEntityAttribute> input)
		{
			ClearAttributes();
			AddAttributes(input);
		}
		
		private void SetAttributes(params CmlEntityAttribute[] input)
		{
			SetAttributes((IEnumerable<CmlEntityAttribute>)input);
		}
		
		private void AddAttribute(CmlEntityAttribute input)
		{
			attributes.Add(input);
		}
		
		private void AddAttributes(IEnumerable<CmlEntityAttribute> input)
		{
			input.Process(i => AddAttribute(i));
		}
		
		private void AddAttributes(params CmlEntityAttribute[] input)
		{
			AddAttributes((IEnumerable<CmlEntityAttribute>)input);
		}
		
		public IEnumerable<CmlEntityAttribute> GetAttributes()
		{
			return attributes;
		}
		
		private void SetChildren(CmlEntityChildren input)
		{
			children = input;
		}
		
		public CmlEntityChildren GetChildren()
		{
			return children;
		}
		
		private void SetMountPoint(CmlEntityMountPoint input)
		{
			mount_point = input;
		}
		
		public CmlEntityMountPoint GetMountPoint()
		{
			return mount_point;
		}
		
		private void SetCompositeChild(CmlEntityCompositeChild input)
		{
			composite_child = input;
		}
		
		public CmlEntityCompositeChild GetCompositeChild()
		{
			return composite_child;
		}
		
	}
	
	public abstract partial class CmlEntityChildren : CmlElement
	{
		public abstract CmlEntityChildren Duplicate();
		static public CmlEntityChildren DOMify(CmlParser.CmlEntityChildrenContext context)
		{
			return CmlResolver.Resolve<CmlEntityChildren>(context);
		}
		
		static public CmlEntityChildren DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlEntityChildrenContext);
		}
		
		static public CmlEntityChildren DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlEntityChildren());
		}
		
		static public CmlEntityChildren DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlEntityChildren());
		}
		
		static public CmlEntityChildren DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlEntityChildren());
		}
		
	}
	
	public partial class CmlEntityChildren_Static : CmlEntityChildren
	{
		[RelatableChild]private CmlComponentSourceList component_source_list;
		static public CmlEntityChildren_Static DOMify(CmlParser.CmlEntityChildren_StaticContext context)
		{
			if(context != null)
			{
				return new CmlEntityChildren_Static(context);
			}
			
			return null;
		}
		
		static new public CmlEntityChildren_Static DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlEntityChildren_StaticContext);
		}
		
		static new public CmlEntityChildren_Static DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlEntityChildren());
		}
		
		static new public CmlEntityChildren_Static DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlEntityChildren());
		}
		
		static new public CmlEntityChildren_Static DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlEntityChildren());
		}
		
		public CmlEntityChildren_Static()
		{
			component_source_list = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlEntityChildren_Static(CmlParser.CmlEntityChildren_StaticContext context) : this()
		{
			SetComponentSourceList(CmlComponentSourceList.DOMify(context.cmlComponentSourceList()));
		}
		
		public override CmlEntityChildren Duplicate()
		{
			CmlEntityChildren_Static instance = new CmlEntityChildren_Static();
			instance.SetComponentSourceList(GetComponentSourceList().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetComponentSourceList(CmlComponentSourceList input)
		{
			component_source_list = input;
		}
		
		public CmlComponentSourceList GetComponentSourceList()
		{
			return component_source_list;
		}
		
	}
	
	public partial class CmlEntityChildren_Dynamic : CmlEntityChildren
	{
		[RelatableChild]private CmlLinkSource link_source;
		static public CmlEntityChildren_Dynamic DOMify(CmlParser.CmlEntityChildren_DynamicContext context)
		{
			if(context != null)
			{
				return new CmlEntityChildren_Dynamic(context);
			}
			
			return null;
		}
		
		static new public CmlEntityChildren_Dynamic DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlEntityChildren_DynamicContext);
		}
		
		static new public CmlEntityChildren_Dynamic DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlEntityChildren());
		}
		
		static new public CmlEntityChildren_Dynamic DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlEntityChildren());
		}
		
		static new public CmlEntityChildren_Dynamic DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlEntityChildren());
		}
		
		public CmlEntityChildren_Dynamic()
		{
			link_source = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlEntityChildren_Dynamic(CmlParser.CmlEntityChildren_DynamicContext context) : this()
		{
			SetLinkSource(CmlLinkSource.DOMify(context.cmlLinkSource()));
		}
		
		public override CmlEntityChildren Duplicate()
		{
			CmlEntityChildren_Dynamic instance = new CmlEntityChildren_Dynamic();
			instance.SetLinkSource(GetLinkSource().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetLinkSource(CmlLinkSource input)
		{
			link_source = input;
		}
		
		public CmlLinkSource GetLinkSource()
		{
			return link_source;
		}
		
	}
	
	public partial class CmlEntityChildren_DynamicInline : CmlEntityChildren
	{
		[RelatableChild]private CmlLinkSourceWithEntitySource link_source_with_entity_source;
		static public CmlEntityChildren_DynamicInline DOMify(CmlParser.CmlEntityChildren_DynamicInlineContext context)
		{
			if(context != null)
			{
				return new CmlEntityChildren_DynamicInline(context);
			}
			
			return null;
		}
		
		static new public CmlEntityChildren_DynamicInline DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlEntityChildren_DynamicInlineContext);
		}
		
		static new public CmlEntityChildren_DynamicInline DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlEntityChildren());
		}
		
		static new public CmlEntityChildren_DynamicInline DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlEntityChildren());
		}
		
		static new public CmlEntityChildren_DynamicInline DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlEntityChildren());
		}
		
		public CmlEntityChildren_DynamicInline()
		{
			link_source_with_entity_source = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlEntityChildren_DynamicInline(CmlParser.CmlEntityChildren_DynamicInlineContext context) : this()
		{
			SetLinkSourceWithEntitySource(CmlLinkSourceWithEntitySource.DOMify(context.cmlLinkSourceWithEntitySource()));
		}
		
		public override CmlEntityChildren Duplicate()
		{
			CmlEntityChildren_DynamicInline instance = new CmlEntityChildren_DynamicInline();
			instance.SetLinkSourceWithEntitySource(GetLinkSourceWithEntitySource().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetLinkSourceWithEntitySource(CmlLinkSourceWithEntitySource input)
		{
			link_source_with_entity_source = input;
		}
		
		public CmlLinkSourceWithEntitySource GetLinkSourceWithEntitySource()
		{
			return link_source_with_entity_source;
		}
		
	}
	
	public partial class CmlEntityMountPoint : CmlElement
	{
		static public CmlEntityMountPoint DOMify(CmlParser.CmlEntityMountPointContext context)
		{
			if(context != null)
			{
				return new CmlEntityMountPoint(context);
			}
			
			return null;
		}
		
		static public CmlEntityMountPoint DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlEntityMountPointContext);
		}
		
		static public CmlEntityMountPoint DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlEntityMountPoint());
		}
		
		static public CmlEntityMountPoint DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlEntityMountPoint());
		}
		
		static public CmlEntityMountPoint DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlEntityMountPoint());
		}
		
		public CmlEntityMountPoint()
		{
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlEntityMountPoint(CmlParser.CmlEntityMountPointContext context) : this()
		{
		}
		
		public CmlEntityMountPoint Duplicate()
		{
			CmlEntityMountPoint instance = new CmlEntityMountPoint();
			return instance;
		}
		
	}
	
	public partial class CmlEntityCompositeChild : CmlElement
	{
		[RelatableChild]private CmlComponentSource component_source;
		static public CmlEntityCompositeChild DOMify(CmlParser.CmlEntityCompositeChildContext context)
		{
			if(context != null)
			{
				return new CmlEntityCompositeChild(context);
			}
			
			return null;
		}
		
		static public CmlEntityCompositeChild DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlEntityCompositeChildContext);
		}
		
		static public CmlEntityCompositeChild DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlEntityCompositeChild());
		}
		
		static public CmlEntityCompositeChild DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlEntityCompositeChild());
		}
		
		static public CmlEntityCompositeChild DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlEntityCompositeChild());
		}
		
		public CmlEntityCompositeChild()
		{
			component_source = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlEntityCompositeChild(CmlParser.CmlEntityCompositeChildContext context) : this()
		{
			SetComponentSource(CmlComponentSource.DOMify(context.cmlComponentSource()));
		}
		
		public CmlEntityCompositeChild Duplicate()
		{
			CmlEntityCompositeChild instance = new CmlEntityCompositeChild();
			instance.SetComponentSource(GetComponentSource().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetComponentSource(CmlComponentSource input)
		{
			component_source = input;
		}
		
		public CmlComponentSource GetComponentSource()
		{
			return component_source;
		}
		
	}
	
	public partial class CmlEntityAttribute : CmlElement
	{
		private string name;
		[RelatableChild]private CmlValueSource value_source;
		static public CmlEntityAttribute DOMify(CmlParser.CmlEntityAttributeContext context)
		{
			if(context != null)
			{
				return new CmlEntityAttribute(context);
			}
			
			return null;
		}
		
		static public CmlEntityAttribute DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlEntityAttributeContext);
		}
		
		static public CmlEntityAttribute DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlEntityAttribute());
		}
		
		static public CmlEntityAttribute DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlEntityAttribute());
		}
		
		static public CmlEntityAttribute DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlEntityAttribute());
		}
		
		public CmlEntityAttribute()
		{
			name = "";
			value_source = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlEntityAttribute(CmlParser.CmlEntityAttributeContext context) : this()
		{
			SetName(context.ID().GetTextEX());
			SetValueSource(CmlValueSource.DOMify(context.cmlValueSource()));
		}
		
		public CmlEntityAttribute Duplicate()
		{
			CmlEntityAttribute instance = new CmlEntityAttribute();
			instance.SetName(GetName());
			instance.SetValueSource(GetValueSource().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetName(string input)
		{
			name = input;
		}
		
		public string GetName()
		{
			return name;
		}
		
		private void SetValueSource(CmlValueSource input)
		{
			value_source = input;
		}
		
		public CmlValueSource GetValueSource()
		{
			return value_source;
		}
		
	}
	
	public partial class CmlConstructor : CmlElement
	{
		private string name;
		[RelatableChild]private CmlValueSourceList argument_sources;
		static public CmlConstructor DOMify(CmlParser.CmlConstructorContext context)
		{
			if(context != null)
			{
				return new CmlConstructor(context);
			}
			
			return null;
		}
		
		static public CmlConstructor DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlConstructorContext);
		}
		
		static public CmlConstructor DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlConstructor());
		}
		
		static public CmlConstructor DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlConstructor());
		}
		
		static public CmlConstructor DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlConstructor());
		}
		
		public CmlConstructor()
		{
			name = "";
			argument_sources = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlConstructor(CmlParser.CmlConstructorContext context) : this()
		{
			SetName(context.ID().GetTextEX());
			SetArgumentSources(CmlValueSourceList.DOMify(context.cmlValueSourceList()));
		}
		
		public CmlConstructor Duplicate()
		{
			CmlConstructor instance = new CmlConstructor();
			instance.SetName(GetName());
			instance.SetArgumentSources(GetArgumentSources().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetName(string input)
		{
			name = input;
		}
		
		public string GetName()
		{
			return name;
		}
		
		private void SetArgumentSources(CmlValueSourceList input)
		{
			argument_sources = input;
		}
		
		public CmlValueSourceList GetArgumentSources()
		{
			return argument_sources;
		}
		
	}
	
	public partial class CmlValueSourceList : CmlElement
	{
		[RelatableChild]private List<CmlValueSource> value_sources;
		static public CmlValueSourceList DOMify(CmlParser.CmlValueSourceListContext context)
		{
			if(context != null)
			{
				return new CmlValueSourceList(context);
			}
			
			return null;
		}
		
		static public CmlValueSourceList DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlValueSourceListContext);
		}
		
		static public CmlValueSourceList DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlValueSourceList());
		}
		
		static public CmlValueSourceList DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlValueSourceList());
		}
		
		static public CmlValueSourceList DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlValueSourceList());
		}
		
		public CmlValueSourceList()
		{
			value_sources = new List<CmlValueSource>();
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlValueSourceList(CmlParser.CmlValueSourceListContext context) : this()
		{
			AddValueSources(context.cmlValueSource().Convert(c => CmlValueSource.DOMify(c)));
		}
		
		public CmlValueSourceList Duplicate()
		{
			CmlValueSourceList instance = new CmlValueSourceList();
			instance.SetValueSources(GetValueSources().Convert(i => i.IfNotNull(z => z.Duplicate())));
			return instance;
		}
		
		private void ClearValueSources()
		{
			value_sources.Clear();
		}
		
		private void SetValueSources(IEnumerable<CmlValueSource> input)
		{
			ClearValueSources();
			AddValueSources(input);
		}
		
		private void SetValueSources(params CmlValueSource[] input)
		{
			SetValueSources((IEnumerable<CmlValueSource>)input);
		}
		
		private void AddValueSource(CmlValueSource input)
		{
			value_sources.Add(input);
		}
		
		private void AddValueSources(IEnumerable<CmlValueSource> input)
		{
			input.Process(i => AddValueSource(i));
		}
		
		private void AddValueSources(params CmlValueSource[] input)
		{
			AddValueSources((IEnumerable<CmlValueSource>)input);
		}
		
		public IEnumerable<CmlValueSource> GetValueSources()
		{
			return value_sources;
		}
		
	}
	
	public abstract partial class CmlLinkSource : CmlElement
	{
		public abstract CmlLinkSource Duplicate();
		static public CmlLinkSource DOMify(CmlParser.CmlLinkSourceContext context)
		{
			return CmlResolver.Resolve<CmlLinkSource>(context);
		}
		
		static public CmlLinkSource DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlLinkSourceContext);
		}
		
		static public CmlLinkSource DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlLinkSource());
		}
		
		static public CmlLinkSource DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlLinkSource());
		}
		
		static public CmlLinkSource DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlLinkSource());
		}
		
	}
	
	public partial class CmlLinkSource_Normal : CmlLinkSource
	{
		[RelatableChild]private CmlScriptEntry_Link link;
		[RelatableChild]private CmlInfo info;
		static public CmlLinkSource_Normal DOMify(CmlParser.CmlLinkSource_NormalContext context)
		{
			if(context != null)
			{
				return new CmlLinkSource_Normal(context);
			}
			
			return null;
		}
		
		static new public CmlLinkSource_Normal DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlLinkSource_NormalContext);
		}
		
		static new public CmlLinkSource_Normal DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlLinkSource());
		}
		
		static new public CmlLinkSource_Normal DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlLinkSource());
		}
		
		static new public CmlLinkSource_Normal DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlLinkSource());
		}
		
		public CmlLinkSource_Normal()
		{
			link = null;
			info = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlLinkSource_Normal(CmlParser.CmlLinkSource_NormalContext context) : this()
		{
			SetLink(CmlScriptEntry_Link.DOMify(context.cmlScriptEntry_Link()));
			SetInfo(CmlInfo.DOMify(context.cmlInfo()));
		}
		
		public override CmlLinkSource Duplicate()
		{
			CmlLinkSource_Normal instance = new CmlLinkSource_Normal();
			instance.SetLink(GetLink().IfNotNull(z => z.Duplicate()));
			instance.SetInfo(GetInfo().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetLink(CmlScriptEntry_Link input)
		{
			link = input;
		}
		
		public CmlScriptEntry_Link GetLink()
		{
			return link;
		}
		
		private void SetInfo(CmlInfo input)
		{
			info = input;
		}
		
		public CmlInfo GetInfo()
		{
			return info;
		}
		
	}
	
	public partial class CmlLinkSource_InsertParameter : CmlLinkSource
	{
		[RelatableChild]private CmlInsertParameter insert_parameter;
		static public CmlLinkSource_InsertParameter DOMify(CmlParser.CmlLinkSource_InsertParameterContext context)
		{
			if(context != null)
			{
				return new CmlLinkSource_InsertParameter(context);
			}
			
			return null;
		}
		
		static new public CmlLinkSource_InsertParameter DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlLinkSource_InsertParameterContext);
		}
		
		static new public CmlLinkSource_InsertParameter DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlLinkSource());
		}
		
		static new public CmlLinkSource_InsertParameter DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlLinkSource());
		}
		
		static new public CmlLinkSource_InsertParameter DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlLinkSource());
		}
		
		public CmlLinkSource_InsertParameter()
		{
			insert_parameter = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlLinkSource_InsertParameter(CmlParser.CmlLinkSource_InsertParameterContext context) : this()
		{
			SetInsertParameter(CmlInsertParameter.DOMify(context.cmlInsertParameter()));
		}
		
		public override CmlLinkSource Duplicate()
		{
			CmlLinkSource_InsertParameter instance = new CmlLinkSource_InsertParameter();
			instance.SetInsertParameter(GetInsertParameter().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetInsertParameter(CmlInsertParameter input)
		{
			insert_parameter = input;
		}
		
		public CmlInsertParameter GetInsertParameter()
		{
			return insert_parameter;
		}
		
	}
	
	public partial class CmlLinkSourceWithEntitySource : CmlElement
	{
		[RelatableChild]private CmlLinkSource link_source;
		[RelatableChild]private CmlEntity entity;
		static public CmlLinkSourceWithEntitySource DOMify(CmlParser.CmlLinkSourceWithEntitySourceContext context)
		{
			if(context != null)
			{
				return new CmlLinkSourceWithEntitySource(context);
			}
			
			return null;
		}
		
		static public CmlLinkSourceWithEntitySource DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlLinkSourceWithEntitySourceContext);
		}
		
		static public CmlLinkSourceWithEntitySource DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlLinkSourceWithEntitySource());
		}
		
		static public CmlLinkSourceWithEntitySource DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlLinkSourceWithEntitySource());
		}
		
		static public CmlLinkSourceWithEntitySource DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlLinkSourceWithEntitySource());
		}
		
		public CmlLinkSourceWithEntitySource()
		{
			link_source = null;
			entity = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlLinkSourceWithEntitySource(CmlParser.CmlLinkSourceWithEntitySourceContext context) : this()
		{
			SetLinkSource(CmlLinkSource.DOMify(context.cmlLinkSource()));
			SetEntity(CmlEntity.DOMify(context.cmlEntity()));
		}
		
		public CmlLinkSourceWithEntitySource Duplicate()
		{
			CmlLinkSourceWithEntitySource instance = new CmlLinkSourceWithEntitySource();
			instance.SetLinkSource(GetLinkSource().IfNotNull(z => z.Duplicate()));
			instance.SetEntity(GetEntity().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetLinkSource(CmlLinkSource input)
		{
			link_source = input;
		}
		
		public CmlLinkSource GetLinkSource()
		{
			return link_source;
		}
		
		private void SetEntity(CmlEntity input)
		{
			entity = input;
		}
		
		public CmlEntity GetEntity()
		{
			return entity;
		}
		
	}
	
	public abstract partial class CmlFunctionSource : CmlElement
	{
		public abstract CmlFunctionSource Duplicate();
		static public CmlFunctionSource DOMify(CmlParser.CmlFunctionSourceContext context)
		{
			return CmlResolver.Resolve<CmlFunctionSource>(context);
		}
		
		static public CmlFunctionSource DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlFunctionSourceContext);
		}
		
		static public CmlFunctionSource DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlFunctionSource());
		}
		
		static public CmlFunctionSource DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlFunctionSource());
		}
		
		static public CmlFunctionSource DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlFunctionSource());
		}
		
	}
	
	public partial class CmlFunctionSource_Normal : CmlFunctionSource
	{
		[RelatableChild]private CmlScriptEntry_Function function;
		[RelatableChild]private CmlInfo info;
		static public CmlFunctionSource_Normal DOMify(CmlParser.CmlFunctionSource_NormalContext context)
		{
			if(context != null)
			{
				return new CmlFunctionSource_Normal(context);
			}
			
			return null;
		}
		
		static new public CmlFunctionSource_Normal DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlFunctionSource_NormalContext);
		}
		
		static new public CmlFunctionSource_Normal DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlFunctionSource());
		}
		
		static new public CmlFunctionSource_Normal DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlFunctionSource());
		}
		
		static new public CmlFunctionSource_Normal DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlFunctionSource());
		}
		
		public CmlFunctionSource_Normal()
		{
			function = null;
			info = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlFunctionSource_Normal(CmlParser.CmlFunctionSource_NormalContext context) : this()
		{
			SetFunction(CmlScriptEntry_Function.DOMify(context.cmlScriptEntry_Function()));
			SetInfo(CmlInfo.DOMify(context.cmlInfo()));
		}
		
		public override CmlFunctionSource Duplicate()
		{
			CmlFunctionSource_Normal instance = new CmlFunctionSource_Normal();
			instance.SetFunction(GetFunction().IfNotNull(z => z.Duplicate()));
			instance.SetInfo(GetInfo().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetFunction(CmlScriptEntry_Function input)
		{
			function = input;
		}
		
		public CmlScriptEntry_Function GetFunction()
		{
			return function;
		}
		
		private void SetInfo(CmlInfo input)
		{
			info = input;
		}
		
		public CmlInfo GetInfo()
		{
			return info;
		}
		
	}
	
	public partial class CmlFunctionSource_InsertParameter : CmlFunctionSource
	{
		[RelatableChild]private CmlInsertParameter insert_parameter;
		static public CmlFunctionSource_InsertParameter DOMify(CmlParser.CmlFunctionSource_InsertParameterContext context)
		{
			if(context != null)
			{
				return new CmlFunctionSource_InsertParameter(context);
			}
			
			return null;
		}
		
		static new public CmlFunctionSource_InsertParameter DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlFunctionSource_InsertParameterContext);
		}
		
		static new public CmlFunctionSource_InsertParameter DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlFunctionSource());
		}
		
		static new public CmlFunctionSource_InsertParameter DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlFunctionSource());
		}
		
		static new public CmlFunctionSource_InsertParameter DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlFunctionSource());
		}
		
		public CmlFunctionSource_InsertParameter()
		{
			insert_parameter = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlFunctionSource_InsertParameter(CmlParser.CmlFunctionSource_InsertParameterContext context) : this()
		{
			SetInsertParameter(CmlInsertParameter.DOMify(context.cmlInsertParameter()));
		}
		
		public override CmlFunctionSource Duplicate()
		{
			CmlFunctionSource_InsertParameter instance = new CmlFunctionSource_InsertParameter();
			instance.SetInsertParameter(GetInsertParameter().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetInsertParameter(CmlInsertParameter input)
		{
			insert_parameter = input;
		}
		
		public CmlInsertParameter GetInsertParameter()
		{
			return insert_parameter;
		}
		
	}
	
	public partial class CmlInsertParameter : CmlElement
	{
		private string id;
		[RelatableChild]private CmlValueSource default_value_source;
		static public CmlInsertParameter DOMify(CmlParser.CmlInsertParameterContext context)
		{
			if(context != null)
			{
				return new CmlInsertParameter(context);
			}
			
			return null;
		}
		
		static public CmlInsertParameter DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlInsertParameterContext);
		}
		
		static public CmlInsertParameter DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlInsertParameter());
		}
		
		static public CmlInsertParameter DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlInsertParameter());
		}
		
		static public CmlInsertParameter DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlInsertParameter());
		}
		
		public CmlInsertParameter()
		{
			id = "";
			default_value_source = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlInsertParameter(CmlParser.CmlInsertParameterContext context) : this()
		{
			SetId(context.ID().GetTextEX());
			SetDefaultValueSource(CmlValueSource.DOMify(context.cmlValueSource()));
		}
		
		public CmlInsertParameter Duplicate()
		{
			CmlInsertParameter instance = new CmlInsertParameter();
			instance.SetId(GetId());
			instance.SetDefaultValueSource(GetDefaultValueSource().IfNotNull(z => z.Duplicate()));
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
		
		private void SetDefaultValueSource(CmlValueSource input)
		{
			default_value_source = input;
		}
		
		public CmlValueSource GetDefaultValueSource()
		{
			return default_value_source;
		}
		
	}
	
	public partial class CmlInfo : CmlElement
	{
		[RelatableChild]private LabeledItemSet<string, CmlInfoSetting> settings;
		static public CmlInfo DOMify(CmlParser.CmlInfoContext context)
		{
			if(context != null)
			{
				return new CmlInfo(context);
			}
			
			return null;
		}
		
		static public CmlInfo DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlInfoContext);
		}
		
		static public CmlInfo DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlInfo());
		}
		
		static public CmlInfo DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlInfo());
		}
		
		static public CmlInfo DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlInfo());
		}
		
		public CmlInfo()
		{
			settings = new LabeledItemSet<string, CmlInfoSetting>();
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlInfo(CmlParser.CmlInfoContext context) : this()
		{
			AddSettings(context.cmlInfoSetting().Convert(c => CmlInfoSetting.DOMify(c)));
		}
		
		public CmlInfo Duplicate()
		{
			CmlInfo instance = new CmlInfo();
			instance.SetSettings(GetSettings().Convert(i => i.IfNotNull(z => z.Duplicate())));
			return instance;
		}
		
		private void ClearSettings()
		{
			settings.Clear();
		}
		
		private void SetSettings(IEnumerable<CmlInfoSetting> input)
		{
			ClearSettings();
			AddSettings(input);
		}
		
		private void SetSettings(params CmlInfoSetting[] input)
		{
			SetSettings((IEnumerable<CmlInfoSetting>)input);
		}
		
		private void AddSetting(CmlInfoSetting input)
		{
			settings.Add(input);
		}
		
		private void AddSettings(IEnumerable<CmlInfoSetting> input)
		{
			input.Process(i => AddSetting(i));
		}
		
		private void AddSettings(params CmlInfoSetting[] input)
		{
			AddSettings((IEnumerable<CmlInfoSetting>)input);
		}
		
		public EnumerableLookupSet<string, CmlInfoSetting> GetSettings()
		{
			return settings;
		}
		
	}
	
	public partial class CmlInfoSetting : CmlElement
	{
		private string name;
		private string value;
		static public CmlInfoSetting DOMify(CmlParser.CmlInfoSettingContext context)
		{
			if(context != null)
			{
				return new CmlInfoSetting(context);
			}
			
			return null;
		}
		
		static public CmlInfoSetting DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlInfoSettingContext);
		}
		
		static public CmlInfoSetting DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlInfoSetting());
		}
		
		static public CmlInfoSetting DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlInfoSetting());
		}
		
		static public CmlInfoSetting DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlInfoSetting());
		}
		
		public CmlInfoSetting()
		{
			name = "";
			value = "";
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlInfoSetting(CmlParser.CmlInfoSettingContext context) : this()
		{
			SetName(context.ID().GetTextEX());
			LoadContextIntermediateValue(context.STRING().GetTextEX());
		}
		
		public CmlInfoSetting Duplicate()
		{
			CmlInfoSetting instance = new CmlInfoSetting();
			instance.SetName(GetName());
			instance.SetValue(GetValue());
			return instance;
		}
		
		private void SetName(string input)
		{
			name = input;
		}
		
		public string GetName()
		{
			return name;
		}
		
		private void SetValue(string input)
		{
			value = input;
		}
		
		public string GetValue()
		{
			return value;
		}
		
	}
	
	public partial class CmlScriptEntry_Link : CmlScriptEntry
	{
		private string stored_text;
		[RelatableChild]private CmlScriptExpression expression;
		static public CmlScriptEntry_Link DOMify(CmlParser.CmlScriptEntry_LinkContext context)
		{
			if(context != null)
			{
				return new CmlScriptEntry_Link(context);
			}
			
			return null;
		}
		
		static public CmlScriptEntry_Link DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptEntry_LinkContext);
		}
		
		static public CmlScriptEntry_Link DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptEntry_Link());
		}
		
		static public CmlScriptEntry_Link DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptEntry_Link());
		}
		
		static public CmlScriptEntry_Link DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptEntry_Link());
		}
		
		public CmlScriptEntry_Link()
		{
			expression = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptEntry_Link(CmlParser.CmlScriptEntry_LinkContext context) : this()
		{
			SetExpression(CmlScriptExpression.DOMify(context.cmlScriptExpression()));
			stored_text = context.GetText();
		}
		
		public CmlScriptEntry_Link Duplicate()
		{
			CmlScriptEntry_Link instance = new CmlScriptEntry_Link();
			instance.SetExpression(GetExpression().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetExpression(CmlScriptExpression input)
		{
			expression = input;
		}
		
		public CmlScriptExpression GetExpression()
		{
			return expression;
		}
		
	}
	
	public partial class CmlScriptEntry_Function : CmlScriptEntry
	{
		private string stored_text;
		[RelatableChild]private CmlScriptFunctionParameters function_parameters;
		[RelatableChild]private CmlScriptLambda lambda;
		static public CmlScriptEntry_Function DOMify(CmlParser.CmlScriptEntry_FunctionContext context)
		{
			if(context != null)
			{
				return new CmlScriptEntry_Function(context);
			}
			
			return null;
		}
		
		static public CmlScriptEntry_Function DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptEntry_FunctionContext);
		}
		
		static public CmlScriptEntry_Function DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptEntry_Function());
		}
		
		static public CmlScriptEntry_Function DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptEntry_Function());
		}
		
		static public CmlScriptEntry_Function DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptEntry_Function());
		}
		
		public CmlScriptEntry_Function()
		{
			function_parameters = null;
			lambda = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptEntry_Function(CmlParser.CmlScriptEntry_FunctionContext context) : this()
		{
			SetFunctionParameters(CmlScriptFunctionParameters.DOMify(context.cmlScriptFunctionParameters()));
			SetLambda(CmlScriptLambda.DOMify(context.cmlScriptLambda()));
			stored_text = context.GetText();
		}
		
		public CmlScriptEntry_Function Duplicate()
		{
			CmlScriptEntry_Function instance = new CmlScriptEntry_Function();
			instance.SetFunctionParameters(GetFunctionParameters().IfNotNull(z => z.Duplicate()));
			instance.SetLambda(GetLambda().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetFunctionParameters(CmlScriptFunctionParameters input)
		{
			function_parameters = input;
		}
		
		public CmlScriptFunctionParameters GetFunctionParameters()
		{
			return function_parameters;
		}
		
		private void SetLambda(CmlScriptLambda input)
		{
			lambda = input;
		}
		
		public CmlScriptLambda GetLambda()
		{
			return lambda;
		}
		
	}
	
	public partial class CmlScriptFunctionParameter : CmlElement
	{
		private string type_name;
		private string name;
		static public CmlScriptFunctionParameter DOMify(CmlParser.CmlScriptFunctionParameterContext context)
		{
			if(context != null)
			{
				return new CmlScriptFunctionParameter(context);
			}
			
			return null;
		}
		
		static public CmlScriptFunctionParameter DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptFunctionParameterContext);
		}
		
		static public CmlScriptFunctionParameter DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptFunctionParameter());
		}
		
		static public CmlScriptFunctionParameter DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptFunctionParameter());
		}
		
		static public CmlScriptFunctionParameter DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptFunctionParameter());
		}
		
		public CmlScriptFunctionParameter()
		{
			type_name = "";
			name = "";
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptFunctionParameter(CmlParser.CmlScriptFunctionParameterContext context) : this()
		{
			SetTypeName(context.ID(0).GetTextEX());
			SetName(context.ID(1).GetTextEX());
		}
		
		public CmlScriptFunctionParameter Duplicate()
		{
			CmlScriptFunctionParameter instance = new CmlScriptFunctionParameter();
			instance.SetTypeName(GetTypeName());
			instance.SetName(GetName());
			return instance;
		}
		
		private void SetTypeName(string input)
		{
			type_name = input;
		}
		
		public string GetTypeName()
		{
			return type_name;
		}
		
		private void SetName(string input)
		{
			name = input;
		}
		
		public string GetName()
		{
			return name;
		}
		
	}
	
	public partial class CmlScriptFunctionParameters : CmlElement
	{
		[RelatableChild]private List<CmlScriptFunctionParameter> function_parameters;
		static public CmlScriptFunctionParameters DOMify(CmlParser.CmlScriptFunctionParametersContext context)
		{
			if(context != null)
			{
				return new CmlScriptFunctionParameters(context);
			}
			
			return null;
		}
		
		static public CmlScriptFunctionParameters DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptFunctionParametersContext);
		}
		
		static public CmlScriptFunctionParameters DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptFunctionParameters());
		}
		
		static public CmlScriptFunctionParameters DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptFunctionParameters());
		}
		
		static public CmlScriptFunctionParameters DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptFunctionParameters());
		}
		
		public CmlScriptFunctionParameters()
		{
			function_parameters = new List<CmlScriptFunctionParameter>();
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptFunctionParameters(CmlParser.CmlScriptFunctionParametersContext context) : this()
		{
			AddFunctionParameters(context.cmlScriptFunctionParameter().Convert(c => CmlScriptFunctionParameter.DOMify(c)));
		}
		
		public CmlScriptFunctionParameters Duplicate()
		{
			CmlScriptFunctionParameters instance = new CmlScriptFunctionParameters();
			instance.SetFunctionParameters(GetFunctionParameters().Convert(i => i.IfNotNull(z => z.Duplicate())));
			return instance;
		}
		
		private void ClearFunctionParameters()
		{
			function_parameters.Clear();
		}
		
		private void SetFunctionParameters(IEnumerable<CmlScriptFunctionParameter> input)
		{
			ClearFunctionParameters();
			AddFunctionParameters(input);
		}
		
		private void SetFunctionParameters(params CmlScriptFunctionParameter[] input)
		{
			SetFunctionParameters((IEnumerable<CmlScriptFunctionParameter>)input);
		}
		
		private void AddFunctionParameter(CmlScriptFunctionParameter input)
		{
			function_parameters.Add(input);
		}
		
		private void AddFunctionParameters(IEnumerable<CmlScriptFunctionParameter> input)
		{
			input.Process(i => AddFunctionParameter(i));
		}
		
		private void AddFunctionParameters(params CmlScriptFunctionParameter[] input)
		{
			AddFunctionParameters((IEnumerable<CmlScriptFunctionParameter>)input);
		}
		
		public IEnumerable<CmlScriptFunctionParameter> GetFunctionParameters()
		{
			return function_parameters;
		}
		
	}
	
	public abstract partial class CmlScriptExpression : CmlElement
	{
		public abstract CmlScriptExpression Duplicate();
		static public CmlScriptExpression DOMify(CmlParser.CmlScriptExpressionContext context)
		{
			return CmlResolver.Resolve<CmlScriptExpression>(context);
		}
		
		static public CmlScriptExpression DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptExpressionContext);
		}
		
		static public CmlScriptExpression DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptExpression());
		}
		
		static public CmlScriptExpression DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptExpression());
		}
		
		static public CmlScriptExpression DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptExpression());
		}
		
	}
	
	public partial class CmlScriptExpression_Direct : CmlScriptExpression
	{
		[RelatableChild]private CmlScriptSubExpression sub_expression;
		static public CmlScriptExpression_Direct DOMify(CmlParser.CmlScriptExpression_DirectContext context)
		{
			if(context != null)
			{
				return new CmlScriptExpression_Direct(context);
			}
			
			return null;
		}
		
		static new public CmlScriptExpression_Direct DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptExpression_DirectContext);
		}
		
		static new public CmlScriptExpression_Direct DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptExpression());
		}
		
		static new public CmlScriptExpression_Direct DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptExpression());
		}
		
		static new public CmlScriptExpression_Direct DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptExpression());
		}
		
		public CmlScriptExpression_Direct()
		{
			sub_expression = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptExpression_Direct(CmlParser.CmlScriptExpression_DirectContext context) : this()
		{
			SetSubExpression(CmlScriptSubExpression.DOMify(context.cmlScriptSubExpression()));
		}
		
		public override CmlScriptExpression Duplicate()
		{
			CmlScriptExpression_Direct instance = new CmlScriptExpression_Direct();
			instance.SetSubExpression(GetSubExpression().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetSubExpression(CmlScriptSubExpression input)
		{
			sub_expression = input;
		}
		
		public CmlScriptSubExpression GetSubExpression()
		{
			return sub_expression;
		}
		
	}
	
	public partial class CmlScriptExpression_Indirect : CmlScriptExpression
	{
		[RelatableChild]private CmlScriptExpression indirection_expression;
		[RelatableChild]private CmlScriptSubExpression sub_expression;
		static public CmlScriptExpression_Indirect DOMify(CmlParser.CmlScriptExpression_IndirectContext context)
		{
			if(context != null)
			{
				return new CmlScriptExpression_Indirect(context);
			}
			
			return null;
		}
		
		static new public CmlScriptExpression_Indirect DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptExpression_IndirectContext);
		}
		
		static new public CmlScriptExpression_Indirect DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptExpression());
		}
		
		static new public CmlScriptExpression_Indirect DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptExpression());
		}
		
		static new public CmlScriptExpression_Indirect DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptExpression());
		}
		
		public CmlScriptExpression_Indirect()
		{
			indirection_expression = null;
			sub_expression = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptExpression_Indirect(CmlParser.CmlScriptExpression_IndirectContext context) : this()
		{
			SetIndirectionExpression(CmlScriptExpression.DOMify(context.cmlScriptExpression()));
			SetSubExpression(CmlScriptSubExpression.DOMify(context.cmlScriptSubExpression()));
		}
		
		public override CmlScriptExpression Duplicate()
		{
			CmlScriptExpression_Indirect instance = new CmlScriptExpression_Indirect();
			instance.SetIndirectionExpression(GetIndirectionExpression().IfNotNull(z => z.Duplicate()));
			instance.SetSubExpression(GetSubExpression().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetIndirectionExpression(CmlScriptExpression input)
		{
			indirection_expression = input;
		}
		
		public CmlScriptExpression GetIndirectionExpression()
		{
			return indirection_expression;
		}
		
		private void SetSubExpression(CmlScriptSubExpression input)
		{
			sub_expression = input;
		}
		
		public CmlScriptSubExpression GetSubExpression()
		{
			return sub_expression;
		}
		
	}
	
	public partial class CmlScriptExpression_Parenthetical : CmlScriptExpression
	{
		[RelatableChild]private CmlScriptExpression inner_expression;
		static public CmlScriptExpression_Parenthetical DOMify(CmlParser.CmlScriptExpression_ParentheticalContext context)
		{
			if(context != null)
			{
				return new CmlScriptExpression_Parenthetical(context);
			}
			
			return null;
		}
		
		static new public CmlScriptExpression_Parenthetical DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptExpression_ParentheticalContext);
		}
		
		static new public CmlScriptExpression_Parenthetical DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptExpression());
		}
		
		static new public CmlScriptExpression_Parenthetical DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptExpression());
		}
		
		static new public CmlScriptExpression_Parenthetical DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptExpression());
		}
		
		public CmlScriptExpression_Parenthetical()
		{
			inner_expression = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptExpression_Parenthetical(CmlParser.CmlScriptExpression_ParentheticalContext context) : this()
		{
			SetInnerExpression(CmlScriptExpression.DOMify(context.cmlScriptExpression()));
		}
		
		public override CmlScriptExpression Duplicate()
		{
			CmlScriptExpression_Parenthetical instance = new CmlScriptExpression_Parenthetical();
			instance.SetInnerExpression(GetInnerExpression().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetInnerExpression(CmlScriptExpression input)
		{
			inner_expression = input;
		}
		
		public CmlScriptExpression GetInnerExpression()
		{
			return inner_expression;
		}
		
	}
	
	public partial class CmlScriptExpression_BinaryOperation_Multiplicative : CmlScriptExpression_BinaryOperation
	{
		[RelatableChild]private CmlScriptExpression left;
		[RelatableChild]private CmlScriptBinaryOperator_Multiplicative operator_multiplicative;
		[RelatableChild]private CmlScriptExpression right;
		static public CmlScriptExpression_BinaryOperation_Multiplicative DOMify(CmlParser.CmlScriptExpression_BinaryOperation_MultiplicativeContext context)
		{
			if(context != null)
			{
				return new CmlScriptExpression_BinaryOperation_Multiplicative(context);
			}
			
			return null;
		}
		
		static new public CmlScriptExpression_BinaryOperation_Multiplicative DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptExpression_BinaryOperation_MultiplicativeContext);
		}
		
		static new public CmlScriptExpression_BinaryOperation_Multiplicative DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptExpression());
		}
		
		static new public CmlScriptExpression_BinaryOperation_Multiplicative DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptExpression());
		}
		
		static new public CmlScriptExpression_BinaryOperation_Multiplicative DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptExpression());
		}
		
		public CmlScriptExpression_BinaryOperation_Multiplicative()
		{
			left = null;
			operator_multiplicative = null;
			right = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptExpression_BinaryOperation_Multiplicative(CmlParser.CmlScriptExpression_BinaryOperation_MultiplicativeContext context) : this()
		{
			SetLeft(CmlScriptExpression.DOMify(context.cmlScriptExpression(0)));
			SetOperatorMultiplicative(CmlScriptBinaryOperator_Multiplicative.DOMify(context.cmlScriptBinaryOperatorMultiplicative()));
			SetRight(CmlScriptExpression.DOMify(context.cmlScriptExpression(1)));
		}
		
		public override CmlScriptExpression Duplicate()
		{
			CmlScriptExpression_BinaryOperation_Multiplicative instance = new CmlScriptExpression_BinaryOperation_Multiplicative();
			instance.SetLeft(GetLeft().IfNotNull(z => z.Duplicate()));
			instance.SetOperatorMultiplicative(GetOperatorMultiplicative().IfNotNull(z => z.Duplicate()));
			instance.SetRight(GetRight().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetLeft(CmlScriptExpression input)
		{
			left = input;
		}
		
		public override CmlScriptExpression GetLeft()
		{
			return left;
		}
		
		private void SetOperatorMultiplicative(CmlScriptBinaryOperator_Multiplicative input)
		{
			operator_multiplicative = input;
		}
		
		public CmlScriptBinaryOperator_Multiplicative GetOperatorMultiplicative()
		{
			return operator_multiplicative;
		}
		
		private void SetRight(CmlScriptExpression input)
		{
			right = input;
		}
		
		public override CmlScriptExpression GetRight()
		{
			return right;
		}
		
	}
	
	public partial class CmlScriptExpression_BinaryOperation_Additive : CmlScriptExpression_BinaryOperation
	{
		[RelatableChild]private CmlScriptExpression left;
		[RelatableChild]private CmlScriptBinaryOperator_Additive operator_additive;
		[RelatableChild]private CmlScriptExpression right;
		static public CmlScriptExpression_BinaryOperation_Additive DOMify(CmlParser.CmlScriptExpression_BinaryOperation_AdditiveContext context)
		{
			if(context != null)
			{
				return new CmlScriptExpression_BinaryOperation_Additive(context);
			}
			
			return null;
		}
		
		static new public CmlScriptExpression_BinaryOperation_Additive DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptExpression_BinaryOperation_AdditiveContext);
		}
		
		static new public CmlScriptExpression_BinaryOperation_Additive DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptExpression());
		}
		
		static new public CmlScriptExpression_BinaryOperation_Additive DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptExpression());
		}
		
		static new public CmlScriptExpression_BinaryOperation_Additive DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptExpression());
		}
		
		public CmlScriptExpression_BinaryOperation_Additive()
		{
			left = null;
			operator_additive = null;
			right = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptExpression_BinaryOperation_Additive(CmlParser.CmlScriptExpression_BinaryOperation_AdditiveContext context) : this()
		{
			SetLeft(CmlScriptExpression.DOMify(context.cmlScriptExpression(0)));
			SetOperatorAdditive(CmlScriptBinaryOperator_Additive.DOMify(context.cmlScriptBinaryOperatorAdditive()));
			SetRight(CmlScriptExpression.DOMify(context.cmlScriptExpression(1)));
		}
		
		public override CmlScriptExpression Duplicate()
		{
			CmlScriptExpression_BinaryOperation_Additive instance = new CmlScriptExpression_BinaryOperation_Additive();
			instance.SetLeft(GetLeft().IfNotNull(z => z.Duplicate()));
			instance.SetOperatorAdditive(GetOperatorAdditive().IfNotNull(z => z.Duplicate()));
			instance.SetRight(GetRight().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetLeft(CmlScriptExpression input)
		{
			left = input;
		}
		
		public override CmlScriptExpression GetLeft()
		{
			return left;
		}
		
		private void SetOperatorAdditive(CmlScriptBinaryOperator_Additive input)
		{
			operator_additive = input;
		}
		
		public CmlScriptBinaryOperator_Additive GetOperatorAdditive()
		{
			return operator_additive;
		}
		
		private void SetRight(CmlScriptExpression input)
		{
			right = input;
		}
		
		public override CmlScriptExpression GetRight()
		{
			return right;
		}
		
	}
	
	public partial class CmlScriptExpression_BinaryOperation_Comparative : CmlScriptExpression_BinaryOperation
	{
		[RelatableChild]private CmlScriptExpression left;
		[RelatableChild]private CmlScriptBinaryOperator_Comparative operator_comparative;
		[RelatableChild]private CmlScriptExpression right;
		static public CmlScriptExpression_BinaryOperation_Comparative DOMify(CmlParser.CmlScriptExpression_BinaryOperation_ComparativeContext context)
		{
			if(context != null)
			{
				return new CmlScriptExpression_BinaryOperation_Comparative(context);
			}
			
			return null;
		}
		
		static new public CmlScriptExpression_BinaryOperation_Comparative DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptExpression_BinaryOperation_ComparativeContext);
		}
		
		static new public CmlScriptExpression_BinaryOperation_Comparative DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptExpression());
		}
		
		static new public CmlScriptExpression_BinaryOperation_Comparative DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptExpression());
		}
		
		static new public CmlScriptExpression_BinaryOperation_Comparative DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptExpression());
		}
		
		public CmlScriptExpression_BinaryOperation_Comparative()
		{
			left = null;
			operator_comparative = null;
			right = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptExpression_BinaryOperation_Comparative(CmlParser.CmlScriptExpression_BinaryOperation_ComparativeContext context) : this()
		{
			SetLeft(CmlScriptExpression.DOMify(context.cmlScriptExpression(0)));
			SetOperatorComparative(CmlScriptBinaryOperator_Comparative.DOMify(context.cmlScriptBinaryOperatorComparative()));
			SetRight(CmlScriptExpression.DOMify(context.cmlScriptExpression(1)));
		}
		
		public override CmlScriptExpression Duplicate()
		{
			CmlScriptExpression_BinaryOperation_Comparative instance = new CmlScriptExpression_BinaryOperation_Comparative();
			instance.SetLeft(GetLeft().IfNotNull(z => z.Duplicate()));
			instance.SetOperatorComparative(GetOperatorComparative().IfNotNull(z => z.Duplicate()));
			instance.SetRight(GetRight().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetLeft(CmlScriptExpression input)
		{
			left = input;
		}
		
		public override CmlScriptExpression GetLeft()
		{
			return left;
		}
		
		private void SetOperatorComparative(CmlScriptBinaryOperator_Comparative input)
		{
			operator_comparative = input;
		}
		
		public CmlScriptBinaryOperator_Comparative GetOperatorComparative()
		{
			return operator_comparative;
		}
		
		private void SetRight(CmlScriptExpression input)
		{
			right = input;
		}
		
		public override CmlScriptExpression GetRight()
		{
			return right;
		}
		
	}
	
	public partial class CmlScriptExpression_BinaryOperation_Boolean : CmlScriptExpression_BinaryOperation
	{
		[RelatableChild]private CmlScriptExpression left;
		[RelatableChild]private CmlScriptBinaryOperator_Boolean operator_boolean;
		[RelatableChild]private CmlScriptExpression right;
		static public CmlScriptExpression_BinaryOperation_Boolean DOMify(CmlParser.CmlScriptExpression_BinaryOperation_BooleanContext context)
		{
			if(context != null)
			{
				return new CmlScriptExpression_BinaryOperation_Boolean(context);
			}
			
			return null;
		}
		
		static new public CmlScriptExpression_BinaryOperation_Boolean DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptExpression_BinaryOperation_BooleanContext);
		}
		
		static new public CmlScriptExpression_BinaryOperation_Boolean DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptExpression());
		}
		
		static new public CmlScriptExpression_BinaryOperation_Boolean DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptExpression());
		}
		
		static new public CmlScriptExpression_BinaryOperation_Boolean DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptExpression());
		}
		
		public CmlScriptExpression_BinaryOperation_Boolean()
		{
			left = null;
			operator_boolean = null;
			right = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptExpression_BinaryOperation_Boolean(CmlParser.CmlScriptExpression_BinaryOperation_BooleanContext context) : this()
		{
			SetLeft(CmlScriptExpression.DOMify(context.cmlScriptExpression(0)));
			SetOperatorBoolean(CmlScriptBinaryOperator_Boolean.DOMify(context.cmlScriptBinaryOperatorBoolean()));
			SetRight(CmlScriptExpression.DOMify(context.cmlScriptExpression(1)));
		}
		
		public override CmlScriptExpression Duplicate()
		{
			CmlScriptExpression_BinaryOperation_Boolean instance = new CmlScriptExpression_BinaryOperation_Boolean();
			instance.SetLeft(GetLeft().IfNotNull(z => z.Duplicate()));
			instance.SetOperatorBoolean(GetOperatorBoolean().IfNotNull(z => z.Duplicate()));
			instance.SetRight(GetRight().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetLeft(CmlScriptExpression input)
		{
			left = input;
		}
		
		public override CmlScriptExpression GetLeft()
		{
			return left;
		}
		
		private void SetOperatorBoolean(CmlScriptBinaryOperator_Boolean input)
		{
			operator_boolean = input;
		}
		
		public CmlScriptBinaryOperator_Boolean GetOperatorBoolean()
		{
			return operator_boolean;
		}
		
		private void SetRight(CmlScriptExpression input)
		{
			right = input;
		}
		
		public override CmlScriptExpression GetRight()
		{
			return right;
		}
		
	}
	
	public abstract partial class CmlScriptBinaryOperator_Multiplicative : CmlScriptBinaryOperator
	{
		public abstract CmlScriptBinaryOperator_Multiplicative Duplicate();
		static public CmlScriptBinaryOperator_Multiplicative DOMify(CmlParser.CmlScriptBinaryOperatorMultiplicativeContext context)
		{
			return CmlResolver.Resolve<CmlScriptBinaryOperator_Multiplicative>(context);
		}
		
		static public CmlScriptBinaryOperator_Multiplicative DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptBinaryOperatorMultiplicativeContext);
		}
		
		static public CmlScriptBinaryOperator_Multiplicative DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptBinaryOperatorMultiplicative());
		}
		
		static public CmlScriptBinaryOperator_Multiplicative DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptBinaryOperatorMultiplicative());
		}
		
		static public CmlScriptBinaryOperator_Multiplicative DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptBinaryOperatorMultiplicative());
		}
		
	}
	
	public partial class CmlScriptBinaryOperator_Multiplicative_Times : CmlScriptBinaryOperator_Multiplicative
	{
		static public CmlScriptBinaryOperator_Multiplicative_Times DOMify(CmlParser.CmlScriptBinaryOperatorMultiplicative_TimesContext context)
		{
			if(context != null)
			{
				return new CmlScriptBinaryOperator_Multiplicative_Times(context);
			}
			
			return null;
		}
		
		static new public CmlScriptBinaryOperator_Multiplicative_Times DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptBinaryOperatorMultiplicative_TimesContext);
		}
		
		static new public CmlScriptBinaryOperator_Multiplicative_Times DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptBinaryOperatorMultiplicative());
		}
		
		static new public CmlScriptBinaryOperator_Multiplicative_Times DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptBinaryOperatorMultiplicative());
		}
		
		static new public CmlScriptBinaryOperator_Multiplicative_Times DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptBinaryOperatorMultiplicative());
		}
		
		public CmlScriptBinaryOperator_Multiplicative_Times()
		{
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptBinaryOperator_Multiplicative_Times(CmlParser.CmlScriptBinaryOperatorMultiplicative_TimesContext context) : this()
		{
		}
		
		public override CmlScriptBinaryOperator_Multiplicative Duplicate()
		{
			CmlScriptBinaryOperator_Multiplicative_Times instance = new CmlScriptBinaryOperator_Multiplicative_Times();
			return instance;
		}
		
	}
	
	public partial class CmlScriptBinaryOperator_Multiplicative_Divide : CmlScriptBinaryOperator_Multiplicative
	{
		static public CmlScriptBinaryOperator_Multiplicative_Divide DOMify(CmlParser.CmlScriptBinaryOperatorMultiplicative_DivideContext context)
		{
			if(context != null)
			{
				return new CmlScriptBinaryOperator_Multiplicative_Divide(context);
			}
			
			return null;
		}
		
		static new public CmlScriptBinaryOperator_Multiplicative_Divide DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptBinaryOperatorMultiplicative_DivideContext);
		}
		
		static new public CmlScriptBinaryOperator_Multiplicative_Divide DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptBinaryOperatorMultiplicative());
		}
		
		static new public CmlScriptBinaryOperator_Multiplicative_Divide DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptBinaryOperatorMultiplicative());
		}
		
		static new public CmlScriptBinaryOperator_Multiplicative_Divide DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptBinaryOperatorMultiplicative());
		}
		
		public CmlScriptBinaryOperator_Multiplicative_Divide()
		{
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptBinaryOperator_Multiplicative_Divide(CmlParser.CmlScriptBinaryOperatorMultiplicative_DivideContext context) : this()
		{
		}
		
		public override CmlScriptBinaryOperator_Multiplicative Duplicate()
		{
			CmlScriptBinaryOperator_Multiplicative_Divide instance = new CmlScriptBinaryOperator_Multiplicative_Divide();
			return instance;
		}
		
	}
	
	public partial class CmlScriptBinaryOperator_Multiplicative_Modulo : CmlScriptBinaryOperator_Multiplicative
	{
		static public CmlScriptBinaryOperator_Multiplicative_Modulo DOMify(CmlParser.CmlScriptBinaryOperatorMultiplicative_ModuloContext context)
		{
			if(context != null)
			{
				return new CmlScriptBinaryOperator_Multiplicative_Modulo(context);
			}
			
			return null;
		}
		
		static new public CmlScriptBinaryOperator_Multiplicative_Modulo DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptBinaryOperatorMultiplicative_ModuloContext);
		}
		
		static new public CmlScriptBinaryOperator_Multiplicative_Modulo DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptBinaryOperatorMultiplicative());
		}
		
		static new public CmlScriptBinaryOperator_Multiplicative_Modulo DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptBinaryOperatorMultiplicative());
		}
		
		static new public CmlScriptBinaryOperator_Multiplicative_Modulo DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptBinaryOperatorMultiplicative());
		}
		
		public CmlScriptBinaryOperator_Multiplicative_Modulo()
		{
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptBinaryOperator_Multiplicative_Modulo(CmlParser.CmlScriptBinaryOperatorMultiplicative_ModuloContext context) : this()
		{
		}
		
		public override CmlScriptBinaryOperator_Multiplicative Duplicate()
		{
			CmlScriptBinaryOperator_Multiplicative_Modulo instance = new CmlScriptBinaryOperator_Multiplicative_Modulo();
			return instance;
		}
		
	}
	
	public abstract partial class CmlScriptBinaryOperator_Additive : CmlScriptBinaryOperator
	{
		public abstract CmlScriptBinaryOperator_Additive Duplicate();
		static public CmlScriptBinaryOperator_Additive DOMify(CmlParser.CmlScriptBinaryOperatorAdditiveContext context)
		{
			return CmlResolver.Resolve<CmlScriptBinaryOperator_Additive>(context);
		}
		
		static public CmlScriptBinaryOperator_Additive DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptBinaryOperatorAdditiveContext);
		}
		
		static public CmlScriptBinaryOperator_Additive DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptBinaryOperatorAdditive());
		}
		
		static public CmlScriptBinaryOperator_Additive DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptBinaryOperatorAdditive());
		}
		
		static public CmlScriptBinaryOperator_Additive DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptBinaryOperatorAdditive());
		}
		
	}
	
	public partial class CmlScriptBinaryOperator_Additive_Plus : CmlScriptBinaryOperator_Additive
	{
		static public CmlScriptBinaryOperator_Additive_Plus DOMify(CmlParser.CmlScriptBinaryOperatorAdditive_PlusContext context)
		{
			if(context != null)
			{
				return new CmlScriptBinaryOperator_Additive_Plus(context);
			}
			
			return null;
		}
		
		static new public CmlScriptBinaryOperator_Additive_Plus DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptBinaryOperatorAdditive_PlusContext);
		}
		
		static new public CmlScriptBinaryOperator_Additive_Plus DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptBinaryOperatorAdditive());
		}
		
		static new public CmlScriptBinaryOperator_Additive_Plus DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptBinaryOperatorAdditive());
		}
		
		static new public CmlScriptBinaryOperator_Additive_Plus DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptBinaryOperatorAdditive());
		}
		
		public CmlScriptBinaryOperator_Additive_Plus()
		{
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptBinaryOperator_Additive_Plus(CmlParser.CmlScriptBinaryOperatorAdditive_PlusContext context) : this()
		{
		}
		
		public override CmlScriptBinaryOperator_Additive Duplicate()
		{
			CmlScriptBinaryOperator_Additive_Plus instance = new CmlScriptBinaryOperator_Additive_Plus();
			return instance;
		}
		
	}
	
	public partial class CmlScriptBinaryOperator_Additive_Minus : CmlScriptBinaryOperator_Additive
	{
		static public CmlScriptBinaryOperator_Additive_Minus DOMify(CmlParser.CmlScriptBinaryOperatorAdditive_MinusContext context)
		{
			if(context != null)
			{
				return new CmlScriptBinaryOperator_Additive_Minus(context);
			}
			
			return null;
		}
		
		static new public CmlScriptBinaryOperator_Additive_Minus DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptBinaryOperatorAdditive_MinusContext);
		}
		
		static new public CmlScriptBinaryOperator_Additive_Minus DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptBinaryOperatorAdditive());
		}
		
		static new public CmlScriptBinaryOperator_Additive_Minus DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptBinaryOperatorAdditive());
		}
		
		static new public CmlScriptBinaryOperator_Additive_Minus DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptBinaryOperatorAdditive());
		}
		
		public CmlScriptBinaryOperator_Additive_Minus()
		{
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptBinaryOperator_Additive_Minus(CmlParser.CmlScriptBinaryOperatorAdditive_MinusContext context) : this()
		{
		}
		
		public override CmlScriptBinaryOperator_Additive Duplicate()
		{
			CmlScriptBinaryOperator_Additive_Minus instance = new CmlScriptBinaryOperator_Additive_Minus();
			return instance;
		}
		
	}
	
	public abstract partial class CmlScriptBinaryOperator_Comparative : CmlScriptBinaryOperator
	{
		public abstract CmlScriptBinaryOperator_Comparative Duplicate();
		static public CmlScriptBinaryOperator_Comparative DOMify(CmlParser.CmlScriptBinaryOperatorComparativeContext context)
		{
			return CmlResolver.Resolve<CmlScriptBinaryOperator_Comparative>(context);
		}
		
		static public CmlScriptBinaryOperator_Comparative DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptBinaryOperatorComparativeContext);
		}
		
		static public CmlScriptBinaryOperator_Comparative DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptBinaryOperatorComparative());
		}
		
		static public CmlScriptBinaryOperator_Comparative DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptBinaryOperatorComparative());
		}
		
		static public CmlScriptBinaryOperator_Comparative DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptBinaryOperatorComparative());
		}
		
	}
	
	public partial class CmlScriptBinaryOperator_Comparative_IsEqualTo : CmlScriptBinaryOperator_Comparative
	{
		static public CmlScriptBinaryOperator_Comparative_IsEqualTo DOMify(CmlParser.CmlScriptBinaryOperatorComparative_IsEqualToContext context)
		{
			if(context != null)
			{
				return new CmlScriptBinaryOperator_Comparative_IsEqualTo(context);
			}
			
			return null;
		}
		
		static new public CmlScriptBinaryOperator_Comparative_IsEqualTo DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptBinaryOperatorComparative_IsEqualToContext);
		}
		
		static new public CmlScriptBinaryOperator_Comparative_IsEqualTo DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptBinaryOperatorComparative());
		}
		
		static new public CmlScriptBinaryOperator_Comparative_IsEqualTo DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptBinaryOperatorComparative());
		}
		
		static new public CmlScriptBinaryOperator_Comparative_IsEqualTo DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptBinaryOperatorComparative());
		}
		
		public CmlScriptBinaryOperator_Comparative_IsEqualTo()
		{
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptBinaryOperator_Comparative_IsEqualTo(CmlParser.CmlScriptBinaryOperatorComparative_IsEqualToContext context) : this()
		{
		}
		
		public override CmlScriptBinaryOperator_Comparative Duplicate()
		{
			CmlScriptBinaryOperator_Comparative_IsEqualTo instance = new CmlScriptBinaryOperator_Comparative_IsEqualTo();
			return instance;
		}
		
	}
	
	public partial class CmlScriptBinaryOperator_Comparative_IsNotEqualTo : CmlScriptBinaryOperator_Comparative
	{
		static public CmlScriptBinaryOperator_Comparative_IsNotEqualTo DOMify(CmlParser.CmlScriptBinaryOperatorComparative_IsNotEqualToContext context)
		{
			if(context != null)
			{
				return new CmlScriptBinaryOperator_Comparative_IsNotEqualTo(context);
			}
			
			return null;
		}
		
		static new public CmlScriptBinaryOperator_Comparative_IsNotEqualTo DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptBinaryOperatorComparative_IsNotEqualToContext);
		}
		
		static new public CmlScriptBinaryOperator_Comparative_IsNotEqualTo DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptBinaryOperatorComparative());
		}
		
		static new public CmlScriptBinaryOperator_Comparative_IsNotEqualTo DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptBinaryOperatorComparative());
		}
		
		static new public CmlScriptBinaryOperator_Comparative_IsNotEqualTo DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptBinaryOperatorComparative());
		}
		
		public CmlScriptBinaryOperator_Comparative_IsNotEqualTo()
		{
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptBinaryOperator_Comparative_IsNotEqualTo(CmlParser.CmlScriptBinaryOperatorComparative_IsNotEqualToContext context) : this()
		{
		}
		
		public override CmlScriptBinaryOperator_Comparative Duplicate()
		{
			CmlScriptBinaryOperator_Comparative_IsNotEqualTo instance = new CmlScriptBinaryOperator_Comparative_IsNotEqualTo();
			return instance;
		}
		
	}
	
	public partial class CmlScriptBinaryOperator_Comparative_IsLessThan : CmlScriptBinaryOperator_Comparative
	{
		static public CmlScriptBinaryOperator_Comparative_IsLessThan DOMify(CmlParser.CmlScriptBinaryOperatorComparative_IsLessThanContext context)
		{
			if(context != null)
			{
				return new CmlScriptBinaryOperator_Comparative_IsLessThan(context);
			}
			
			return null;
		}
		
		static new public CmlScriptBinaryOperator_Comparative_IsLessThan DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptBinaryOperatorComparative_IsLessThanContext);
		}
		
		static new public CmlScriptBinaryOperator_Comparative_IsLessThan DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptBinaryOperatorComparative());
		}
		
		static new public CmlScriptBinaryOperator_Comparative_IsLessThan DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptBinaryOperatorComparative());
		}
		
		static new public CmlScriptBinaryOperator_Comparative_IsLessThan DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptBinaryOperatorComparative());
		}
		
		public CmlScriptBinaryOperator_Comparative_IsLessThan()
		{
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptBinaryOperator_Comparative_IsLessThan(CmlParser.CmlScriptBinaryOperatorComparative_IsLessThanContext context) : this()
		{
		}
		
		public override CmlScriptBinaryOperator_Comparative Duplicate()
		{
			CmlScriptBinaryOperator_Comparative_IsLessThan instance = new CmlScriptBinaryOperator_Comparative_IsLessThan();
			return instance;
		}
		
	}
	
	public partial class CmlScriptBinaryOperator_Comparative_IsLessThanOrEqualTo : CmlScriptBinaryOperator_Comparative
	{
		static public CmlScriptBinaryOperator_Comparative_IsLessThanOrEqualTo DOMify(CmlParser.CmlScriptBinaryOperatorComparative_IsLessThanOrEqualToContext context)
		{
			if(context != null)
			{
				return new CmlScriptBinaryOperator_Comparative_IsLessThanOrEqualTo(context);
			}
			
			return null;
		}
		
		static new public CmlScriptBinaryOperator_Comparative_IsLessThanOrEqualTo DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptBinaryOperatorComparative_IsLessThanOrEqualToContext);
		}
		
		static new public CmlScriptBinaryOperator_Comparative_IsLessThanOrEqualTo DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptBinaryOperatorComparative());
		}
		
		static new public CmlScriptBinaryOperator_Comparative_IsLessThanOrEqualTo DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptBinaryOperatorComparative());
		}
		
		static new public CmlScriptBinaryOperator_Comparative_IsLessThanOrEqualTo DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptBinaryOperatorComparative());
		}
		
		public CmlScriptBinaryOperator_Comparative_IsLessThanOrEqualTo()
		{
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptBinaryOperator_Comparative_IsLessThanOrEqualTo(CmlParser.CmlScriptBinaryOperatorComparative_IsLessThanOrEqualToContext context) : this()
		{
		}
		
		public override CmlScriptBinaryOperator_Comparative Duplicate()
		{
			CmlScriptBinaryOperator_Comparative_IsLessThanOrEqualTo instance = new CmlScriptBinaryOperator_Comparative_IsLessThanOrEqualTo();
			return instance;
		}
		
	}
	
	public partial class CmlScriptBinaryOperator_Comparative_IsGreaterThan : CmlScriptBinaryOperator_Comparative
	{
		static public CmlScriptBinaryOperator_Comparative_IsGreaterThan DOMify(CmlParser.CmlScriptBinaryOperatorComparative_IsGreaterThanContext context)
		{
			if(context != null)
			{
				return new CmlScriptBinaryOperator_Comparative_IsGreaterThan(context);
			}
			
			return null;
		}
		
		static new public CmlScriptBinaryOperator_Comparative_IsGreaterThan DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptBinaryOperatorComparative_IsGreaterThanContext);
		}
		
		static new public CmlScriptBinaryOperator_Comparative_IsGreaterThan DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptBinaryOperatorComparative());
		}
		
		static new public CmlScriptBinaryOperator_Comparative_IsGreaterThan DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptBinaryOperatorComparative());
		}
		
		static new public CmlScriptBinaryOperator_Comparative_IsGreaterThan DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptBinaryOperatorComparative());
		}
		
		public CmlScriptBinaryOperator_Comparative_IsGreaterThan()
		{
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptBinaryOperator_Comparative_IsGreaterThan(CmlParser.CmlScriptBinaryOperatorComparative_IsGreaterThanContext context) : this()
		{
		}
		
		public override CmlScriptBinaryOperator_Comparative Duplicate()
		{
			CmlScriptBinaryOperator_Comparative_IsGreaterThan instance = new CmlScriptBinaryOperator_Comparative_IsGreaterThan();
			return instance;
		}
		
	}
	
	public partial class CmlScriptBinaryOperator_Comparative_IsGreaterThanOrEqualTo : CmlScriptBinaryOperator_Comparative
	{
		static public CmlScriptBinaryOperator_Comparative_IsGreaterThanOrEqualTo DOMify(CmlParser.CmlScriptBinaryOperatorComparative_IsGreaterThanOrEqualToContext context)
		{
			if(context != null)
			{
				return new CmlScriptBinaryOperator_Comparative_IsGreaterThanOrEqualTo(context);
			}
			
			return null;
		}
		
		static new public CmlScriptBinaryOperator_Comparative_IsGreaterThanOrEqualTo DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptBinaryOperatorComparative_IsGreaterThanOrEqualToContext);
		}
		
		static new public CmlScriptBinaryOperator_Comparative_IsGreaterThanOrEqualTo DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptBinaryOperatorComparative());
		}
		
		static new public CmlScriptBinaryOperator_Comparative_IsGreaterThanOrEqualTo DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptBinaryOperatorComparative());
		}
		
		static new public CmlScriptBinaryOperator_Comparative_IsGreaterThanOrEqualTo DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptBinaryOperatorComparative());
		}
		
		public CmlScriptBinaryOperator_Comparative_IsGreaterThanOrEqualTo()
		{
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptBinaryOperator_Comparative_IsGreaterThanOrEqualTo(CmlParser.CmlScriptBinaryOperatorComparative_IsGreaterThanOrEqualToContext context) : this()
		{
		}
		
		public override CmlScriptBinaryOperator_Comparative Duplicate()
		{
			CmlScriptBinaryOperator_Comparative_IsGreaterThanOrEqualTo instance = new CmlScriptBinaryOperator_Comparative_IsGreaterThanOrEqualTo();
			return instance;
		}
		
	}
	
	public abstract partial class CmlScriptBinaryOperator_Boolean : CmlScriptBinaryOperator
	{
		public abstract CmlScriptBinaryOperator_Boolean Duplicate();
		static public CmlScriptBinaryOperator_Boolean DOMify(CmlParser.CmlScriptBinaryOperatorBooleanContext context)
		{
			return CmlResolver.Resolve<CmlScriptBinaryOperator_Boolean>(context);
		}
		
		static public CmlScriptBinaryOperator_Boolean DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptBinaryOperatorBooleanContext);
		}
		
		static public CmlScriptBinaryOperator_Boolean DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptBinaryOperatorBoolean());
		}
		
		static public CmlScriptBinaryOperator_Boolean DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptBinaryOperatorBoolean());
		}
		
		static public CmlScriptBinaryOperator_Boolean DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptBinaryOperatorBoolean());
		}
		
	}
	
	public partial class CmlScriptBinaryOperator_Boolean_Or : CmlScriptBinaryOperator_Boolean
	{
		static public CmlScriptBinaryOperator_Boolean_Or DOMify(CmlParser.CmlScriptBinaryOperatorBoolean_OrContext context)
		{
			if(context != null)
			{
				return new CmlScriptBinaryOperator_Boolean_Or(context);
			}
			
			return null;
		}
		
		static new public CmlScriptBinaryOperator_Boolean_Or DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptBinaryOperatorBoolean_OrContext);
		}
		
		static new public CmlScriptBinaryOperator_Boolean_Or DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptBinaryOperatorBoolean());
		}
		
		static new public CmlScriptBinaryOperator_Boolean_Or DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptBinaryOperatorBoolean());
		}
		
		static new public CmlScriptBinaryOperator_Boolean_Or DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptBinaryOperatorBoolean());
		}
		
		public CmlScriptBinaryOperator_Boolean_Or()
		{
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptBinaryOperator_Boolean_Or(CmlParser.CmlScriptBinaryOperatorBoolean_OrContext context) : this()
		{
		}
		
		public override CmlScriptBinaryOperator_Boolean Duplicate()
		{
			CmlScriptBinaryOperator_Boolean_Or instance = new CmlScriptBinaryOperator_Boolean_Or();
			return instance;
		}
		
	}
	
	public partial class CmlScriptBinaryOperator_Boolean_And : CmlScriptBinaryOperator_Boolean
	{
		static public CmlScriptBinaryOperator_Boolean_And DOMify(CmlParser.CmlScriptBinaryOperatorBoolean_AndContext context)
		{
			if(context != null)
			{
				return new CmlScriptBinaryOperator_Boolean_And(context);
			}
			
			return null;
		}
		
		static new public CmlScriptBinaryOperator_Boolean_And DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptBinaryOperatorBoolean_AndContext);
		}
		
		static new public CmlScriptBinaryOperator_Boolean_And DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptBinaryOperatorBoolean());
		}
		
		static new public CmlScriptBinaryOperator_Boolean_And DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptBinaryOperatorBoolean());
		}
		
		static new public CmlScriptBinaryOperator_Boolean_And DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptBinaryOperatorBoolean());
		}
		
		public CmlScriptBinaryOperator_Boolean_And()
		{
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptBinaryOperator_Boolean_And(CmlParser.CmlScriptBinaryOperatorBoolean_AndContext context) : this()
		{
		}
		
		public override CmlScriptBinaryOperator_Boolean Duplicate()
		{
			CmlScriptBinaryOperator_Boolean_And instance = new CmlScriptBinaryOperator_Boolean_And();
			return instance;
		}
		
	}
	
	public abstract partial class CmlScriptSubExpression : CmlElement
	{
		public abstract CmlScriptSubExpression Duplicate();
		static public CmlScriptSubExpression DOMify(CmlParser.CmlScriptSubExpressionContext context)
		{
			return CmlResolver.Resolve<CmlScriptSubExpression>(context);
		}
		
		static public CmlScriptSubExpression DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptSubExpressionContext);
		}
		
		static public CmlScriptSubExpression DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptSubExpression());
		}
		
		static public CmlScriptSubExpression DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptSubExpression());
		}
		
		static public CmlScriptSubExpression DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptSubExpression());
		}
		
	}
	
	public partial class CmlScriptSubExpression_Constant_Int : CmlScriptSubExpression_Constant
	{
		private int @int;
		static public CmlScriptSubExpression_Constant_Int DOMify(CmlParser.CmlScriptSubExpression_Constant_IntContext context)
		{
			if(context != null)
			{
				return new CmlScriptSubExpression_Constant_Int(context);
			}
			
			return null;
		}
		
		static new public CmlScriptSubExpression_Constant_Int DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptSubExpression_Constant_IntContext);
		}
		
		static new public CmlScriptSubExpression_Constant_Int DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptSubExpression());
		}
		
		static new public CmlScriptSubExpression_Constant_Int DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptSubExpression());
		}
		
		static new public CmlScriptSubExpression_Constant_Int DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptSubExpression());
		}
		
		public CmlScriptSubExpression_Constant_Int()
		{
			@int = 0;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptSubExpression_Constant_Int(CmlParser.CmlScriptSubExpression_Constant_IntContext context) : this()
		{
			SetInt(context.INT().GetTextEX().ParseInt());
		}
		
		public override CmlScriptSubExpression Duplicate()
		{
			CmlScriptSubExpression_Constant_Int instance = new CmlScriptSubExpression_Constant_Int();
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
	
	public partial class CmlScriptSubExpression_Constant_Float : CmlScriptSubExpression_Constant
	{
		private float @float;
		static public CmlScriptSubExpression_Constant_Float DOMify(CmlParser.CmlScriptSubExpression_Constant_FloatContext context)
		{
			if(context != null)
			{
				return new CmlScriptSubExpression_Constant_Float(context);
			}
			
			return null;
		}
		
		static new public CmlScriptSubExpression_Constant_Float DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptSubExpression_Constant_FloatContext);
		}
		
		static new public CmlScriptSubExpression_Constant_Float DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptSubExpression());
		}
		
		static new public CmlScriptSubExpression_Constant_Float DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptSubExpression());
		}
		
		static new public CmlScriptSubExpression_Constant_Float DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptSubExpression());
		}
		
		public CmlScriptSubExpression_Constant_Float()
		{
			@float = 0.0f;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptSubExpression_Constant_Float(CmlParser.CmlScriptSubExpression_Constant_FloatContext context) : this()
		{
			SetFloat(context.FLOAT().GetTextEX().ParseFloat());
		}
		
		public override CmlScriptSubExpression Duplicate()
		{
			CmlScriptSubExpression_Constant_Float instance = new CmlScriptSubExpression_Constant_Float();
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
	
	public partial class CmlScriptSubExpression_Constant_Double : CmlScriptSubExpression_Constant
	{
		private double @double;
		static public CmlScriptSubExpression_Constant_Double DOMify(CmlParser.CmlScriptSubExpression_Constant_DoubleContext context)
		{
			if(context != null)
			{
				return new CmlScriptSubExpression_Constant_Double(context);
			}
			
			return null;
		}
		
		static new public CmlScriptSubExpression_Constant_Double DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptSubExpression_Constant_DoubleContext);
		}
		
		static new public CmlScriptSubExpression_Constant_Double DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptSubExpression());
		}
		
		static new public CmlScriptSubExpression_Constant_Double DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptSubExpression());
		}
		
		static new public CmlScriptSubExpression_Constant_Double DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptSubExpression());
		}
		
		public CmlScriptSubExpression_Constant_Double()
		{
			@double = 0.0;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptSubExpression_Constant_Double(CmlParser.CmlScriptSubExpression_Constant_DoubleContext context) : this()
		{
			SetDouble(context.DOUBLE().GetTextEX().ParseDouble());
		}
		
		public override CmlScriptSubExpression Duplicate()
		{
			CmlScriptSubExpression_Constant_Double instance = new CmlScriptSubExpression_Constant_Double();
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
	
	public partial class CmlScriptSubExpression_Constant_Null : CmlScriptSubExpression_Constant
	{
		private string @null;
		static public CmlScriptSubExpression_Constant_Null DOMify(CmlParser.CmlScriptSubExpression_Constant_NullContext context)
		{
			if(context != null)
			{
				return new CmlScriptSubExpression_Constant_Null(context);
			}
			
			return null;
		}
		
		static new public CmlScriptSubExpression_Constant_Null DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptSubExpression_Constant_NullContext);
		}
		
		static new public CmlScriptSubExpression_Constant_Null DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptSubExpression());
		}
		
		static new public CmlScriptSubExpression_Constant_Null DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptSubExpression());
		}
		
		static new public CmlScriptSubExpression_Constant_Null DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptSubExpression());
		}
		
		public CmlScriptSubExpression_Constant_Null()
		{
			@null = "";
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptSubExpression_Constant_Null(CmlParser.CmlScriptSubExpression_Constant_NullContext context) : this()
		{
			SetNull(context.NULL().GetTextEX());
		}
		
		public override CmlScriptSubExpression Duplicate()
		{
			CmlScriptSubExpression_Constant_Null instance = new CmlScriptSubExpression_Constant_Null();
			instance.SetNull(GetNull());
			return instance;
		}
		
		private void SetNull(string input)
		{
			@null = input;
		}
		
		public string GetNull()
		{
			return @null;
		}
		
	}
	
	public partial class CmlScriptSubExpression_Constant_Bool : CmlScriptSubExpression_Constant
	{
		private bool @bool;
		static public CmlScriptSubExpression_Constant_Bool DOMify(CmlParser.CmlScriptSubExpression_Constant_BoolContext context)
		{
			if(context != null)
			{
				return new CmlScriptSubExpression_Constant_Bool(context);
			}
			
			return null;
		}
		
		static new public CmlScriptSubExpression_Constant_Bool DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptSubExpression_Constant_BoolContext);
		}
		
		static new public CmlScriptSubExpression_Constant_Bool DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptSubExpression());
		}
		
		static new public CmlScriptSubExpression_Constant_Bool DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptSubExpression());
		}
		
		static new public CmlScriptSubExpression_Constant_Bool DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptSubExpression());
		}
		
		public CmlScriptSubExpression_Constant_Bool()
		{
			@bool = false;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptSubExpression_Constant_Bool(CmlParser.CmlScriptSubExpression_Constant_BoolContext context) : this()
		{
			SetBool(context.BOOL().GetTextEX().ParseBool());
		}
		
		public override CmlScriptSubExpression Duplicate()
		{
			CmlScriptSubExpression_Constant_Bool instance = new CmlScriptSubExpression_Constant_Bool();
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
	
	public partial class CmlScriptSubExpression_Constant_String : CmlScriptSubExpression_Constant
	{
		private string @string;
		static public CmlScriptSubExpression_Constant_String DOMify(CmlParser.CmlScriptSubExpression_Constant_StringContext context)
		{
			if(context != null)
			{
				return new CmlScriptSubExpression_Constant_String(context);
			}
			
			return null;
		}
		
		static new public CmlScriptSubExpression_Constant_String DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptSubExpression_Constant_StringContext);
		}
		
		static new public CmlScriptSubExpression_Constant_String DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptSubExpression());
		}
		
		static new public CmlScriptSubExpression_Constant_String DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptSubExpression());
		}
		
		static new public CmlScriptSubExpression_Constant_String DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptSubExpression());
		}
		
		public CmlScriptSubExpression_Constant_String()
		{
			@string = "";
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptSubExpression_Constant_String(CmlParser.CmlScriptSubExpression_Constant_StringContext context) : this()
		{
			LoadContextIntermediateString(context.STRING().GetTextEX());
		}
		
		public override CmlScriptSubExpression Duplicate()
		{
			CmlScriptSubExpression_Constant_String instance = new CmlScriptSubExpression_Constant_String();
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
	
	public partial class CmlScriptSubExpression_SyntheticString : CmlScriptSubExpression
	{
		[RelatableChild]private CmlScriptSyntheticString synthetic_string;
		static public CmlScriptSubExpression_SyntheticString DOMify(CmlParser.CmlScriptSubExpression_SyntheticStringContext context)
		{
			if(context != null)
			{
				return new CmlScriptSubExpression_SyntheticString(context);
			}
			
			return null;
		}
		
		static new public CmlScriptSubExpression_SyntheticString DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptSubExpression_SyntheticStringContext);
		}
		
		static new public CmlScriptSubExpression_SyntheticString DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptSubExpression());
		}
		
		static new public CmlScriptSubExpression_SyntheticString DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptSubExpression());
		}
		
		static new public CmlScriptSubExpression_SyntheticString DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptSubExpression());
		}
		
		public CmlScriptSubExpression_SyntheticString()
		{
			synthetic_string = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptSubExpression_SyntheticString(CmlParser.CmlScriptSubExpression_SyntheticStringContext context) : this()
		{
			SetSyntheticString(CmlScriptSyntheticString.DOMify(context.cmlScriptSyntheticString()));
		}
		
		public override CmlScriptSubExpression Duplicate()
		{
			CmlScriptSubExpression_SyntheticString instance = new CmlScriptSubExpression_SyntheticString();
			instance.SetSyntheticString(GetSyntheticString().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetSyntheticString(CmlScriptSyntheticString input)
		{
			synthetic_string = input;
		}
		
		public CmlScriptSyntheticString GetSyntheticString()
		{
			return synthetic_string;
		}
		
	}
	
	public partial class CmlScriptSubExpression_InsertParameter : CmlScriptSubExpression
	{
		[RelatableChild]private CmlInsertParameter insert_parameter;
		static public CmlScriptSubExpression_InsertParameter DOMify(CmlParser.CmlScriptSubExpression_InsertParameterContext context)
		{
			if(context != null)
			{
				return new CmlScriptSubExpression_InsertParameter(context);
			}
			
			return null;
		}
		
		static new public CmlScriptSubExpression_InsertParameter DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptSubExpression_InsertParameterContext);
		}
		
		static new public CmlScriptSubExpression_InsertParameter DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptSubExpression());
		}
		
		static new public CmlScriptSubExpression_InsertParameter DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptSubExpression());
		}
		
		static new public CmlScriptSubExpression_InsertParameter DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptSubExpression());
		}
		
		public CmlScriptSubExpression_InsertParameter()
		{
			insert_parameter = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptSubExpression_InsertParameter(CmlParser.CmlScriptSubExpression_InsertParameterContext context) : this()
		{
			SetInsertParameter(CmlInsertParameter.DOMify(context.cmlInsertParameter()));
		}
		
		public override CmlScriptSubExpression Duplicate()
		{
			CmlScriptSubExpression_InsertParameter instance = new CmlScriptSubExpression_InsertParameter();
			instance.SetInsertParameter(GetInsertParameter().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetInsertParameter(CmlInsertParameter input)
		{
			insert_parameter = input;
		}
		
		public CmlInsertParameter GetInsertParameter()
		{
			return insert_parameter;
		}
		
	}
	
	public partial class CmlScriptSubExpression_ValueReference : CmlScriptSubExpression
	{
		[RelatableChild]private CmlScriptValueReference value_reference;
		static public CmlScriptSubExpression_ValueReference DOMify(CmlParser.CmlScriptSubExpression_ValueReferenceContext context)
		{
			if(context != null)
			{
				return new CmlScriptSubExpression_ValueReference(context);
			}
			
			return null;
		}
		
		static new public CmlScriptSubExpression_ValueReference DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptSubExpression_ValueReferenceContext);
		}
		
		static new public CmlScriptSubExpression_ValueReference DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptSubExpression());
		}
		
		static new public CmlScriptSubExpression_ValueReference DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptSubExpression());
		}
		
		static new public CmlScriptSubExpression_ValueReference DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptSubExpression());
		}
		
		public CmlScriptSubExpression_ValueReference()
		{
			value_reference = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptSubExpression_ValueReference(CmlParser.CmlScriptSubExpression_ValueReferenceContext context) : this()
		{
			SetValueReference(CmlScriptValueReference.DOMify(context.cmlScriptValueReference()));
		}
		
		public override CmlScriptSubExpression Duplicate()
		{
			CmlScriptSubExpression_ValueReference instance = new CmlScriptSubExpression_ValueReference();
			instance.SetValueReference(GetValueReference().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetValueReference(CmlScriptValueReference input)
		{
			value_reference = input;
		}
		
		public CmlScriptValueReference GetValueReference()
		{
			return value_reference;
		}
		
	}
	
	public partial class CmlScriptSubExpression_InsertRepresentation : CmlScriptSubExpression
	{
		[RelatableChild]private CmlScriptInsertRepresentation insert_representation;
		static public CmlScriptSubExpression_InsertRepresentation DOMify(CmlParser.CmlScriptSubExpression_InsertRepresentationContext context)
		{
			if(context != null)
			{
				return new CmlScriptSubExpression_InsertRepresentation(context);
			}
			
			return null;
		}
		
		static new public CmlScriptSubExpression_InsertRepresentation DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptSubExpression_InsertRepresentationContext);
		}
		
		static new public CmlScriptSubExpression_InsertRepresentation DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptSubExpression());
		}
		
		static new public CmlScriptSubExpression_InsertRepresentation DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptSubExpression());
		}
		
		static new public CmlScriptSubExpression_InsertRepresentation DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptSubExpression());
		}
		
		public CmlScriptSubExpression_InsertRepresentation()
		{
			insert_representation = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptSubExpression_InsertRepresentation(CmlParser.CmlScriptSubExpression_InsertRepresentationContext context) : this()
		{
			SetInsertRepresentation(CmlScriptInsertRepresentation.DOMify(context.cmlScriptInsertRepresentation()));
		}
		
		public override CmlScriptSubExpression Duplicate()
		{
			CmlScriptSubExpression_InsertRepresentation instance = new CmlScriptSubExpression_InsertRepresentation();
			instance.SetInsertRepresentation(GetInsertRepresentation().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetInsertRepresentation(CmlScriptInsertRepresentation input)
		{
			insert_representation = input;
		}
		
		public CmlScriptInsertRepresentation GetInsertRepresentation()
		{
			return insert_representation;
		}
		
	}
	
	public partial class CmlScriptSubExpression_FunctionCall : CmlScriptSubExpression
	{
		[RelatableChild]private CmlScriptFunctionCall function_call;
		static public CmlScriptSubExpression_FunctionCall DOMify(CmlParser.CmlScriptSubExpression_FunctionCallContext context)
		{
			if(context != null)
			{
				return new CmlScriptSubExpression_FunctionCall(context);
			}
			
			return null;
		}
		
		static new public CmlScriptSubExpression_FunctionCall DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptSubExpression_FunctionCallContext);
		}
		
		static new public CmlScriptSubExpression_FunctionCall DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptSubExpression());
		}
		
		static new public CmlScriptSubExpression_FunctionCall DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptSubExpression());
		}
		
		static new public CmlScriptSubExpression_FunctionCall DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptSubExpression());
		}
		
		public CmlScriptSubExpression_FunctionCall()
		{
			function_call = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptSubExpression_FunctionCall(CmlParser.CmlScriptSubExpression_FunctionCallContext context) : this()
		{
			SetFunctionCall(CmlScriptFunctionCall.DOMify(context.cmlScriptFunctionCall()));
		}
		
		public override CmlScriptSubExpression Duplicate()
		{
			CmlScriptSubExpression_FunctionCall instance = new CmlScriptSubExpression_FunctionCall();
			instance.SetFunctionCall(GetFunctionCall().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetFunctionCall(CmlScriptFunctionCall input)
		{
			function_call = input;
		}
		
		public CmlScriptFunctionCall GetFunctionCall()
		{
			return function_call;
		}
		
	}
	
	public partial class CmlScriptSyntheticString : CmlElement
	{
		private string @string;
		static public CmlScriptSyntheticString DOMify(CmlParser.CmlScriptSyntheticStringContext context)
		{
			if(context != null)
			{
				return new CmlScriptSyntheticString(context);
			}
			
			return null;
		}
		
		static public CmlScriptSyntheticString DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptSyntheticStringContext);
		}
		
		static public CmlScriptSyntheticString DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptSyntheticString());
		}
		
		static public CmlScriptSyntheticString DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptSyntheticString());
		}
		
		static public CmlScriptSyntheticString DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptSyntheticString());
		}
		
		public CmlScriptSyntheticString()
		{
			@string = "";
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptSyntheticString(CmlParser.CmlScriptSyntheticStringContext context) : this()
		{
			LoadContextIntermediateString(context.STRING().GetTextEX());
		}
		
		public CmlScriptSyntheticString Duplicate()
		{
			CmlScriptSyntheticString instance = new CmlScriptSyntheticString();
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
	
	public abstract partial class CmlScriptInsertRepresentation : CmlElement
	{
		public abstract CmlScriptInsertRepresentation Duplicate();
		static public CmlScriptInsertRepresentation DOMify(CmlParser.CmlScriptInsertRepresentationContext context)
		{
			return CmlResolver.Resolve<CmlScriptInsertRepresentation>(context);
		}
		
		static public CmlScriptInsertRepresentation DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptInsertRepresentationContext);
		}
		
		static public CmlScriptInsertRepresentation DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptInsertRepresentation());
		}
		
		static public CmlScriptInsertRepresentation DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptInsertRepresentation());
		}
		
		static public CmlScriptInsertRepresentation DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptInsertRepresentation());
		}
		
	}
	
	public partial class CmlScriptInsertRepresentation_Normal : CmlScriptInsertRepresentation
	{
		private string id;
		static public CmlScriptInsertRepresentation_Normal DOMify(CmlParser.CmlScriptInsertRepresentation_NormalContext context)
		{
			if(context != null)
			{
				return new CmlScriptInsertRepresentation_Normal(context);
			}
			
			return null;
		}
		
		static new public CmlScriptInsertRepresentation_Normal DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptInsertRepresentation_NormalContext);
		}
		
		static new public CmlScriptInsertRepresentation_Normal DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptInsertRepresentation());
		}
		
		static new public CmlScriptInsertRepresentation_Normal DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptInsertRepresentation());
		}
		
		static new public CmlScriptInsertRepresentation_Normal DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptInsertRepresentation());
		}
		
		public CmlScriptInsertRepresentation_Normal()
		{
			id = "";
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptInsertRepresentation_Normal(CmlParser.CmlScriptInsertRepresentation_NormalContext context) : this()
		{
			SetId(context.ID().GetTextEX());
		}
		
		public override CmlScriptInsertRepresentation Duplicate()
		{
			CmlScriptInsertRepresentation_Normal instance = new CmlScriptInsertRepresentation_Normal();
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
	
	public partial class CmlScriptInsertRepresentation_This : CmlScriptInsertRepresentation
	{
		static public CmlScriptInsertRepresentation_This DOMify(CmlParser.CmlScriptInsertRepresentation_ThisContext context)
		{
			if(context != null)
			{
				return new CmlScriptInsertRepresentation_This(context);
			}
			
			return null;
		}
		
		static new public CmlScriptInsertRepresentation_This DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptInsertRepresentation_ThisContext);
		}
		
		static new public CmlScriptInsertRepresentation_This DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptInsertRepresentation());
		}
		
		static new public CmlScriptInsertRepresentation_This DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptInsertRepresentation());
		}
		
		static new public CmlScriptInsertRepresentation_This DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptInsertRepresentation());
		}
		
		public CmlScriptInsertRepresentation_This()
		{
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptInsertRepresentation_This(CmlParser.CmlScriptInsertRepresentation_ThisContext context) : this()
		{
		}
		
		public override CmlScriptInsertRepresentation Duplicate()
		{
			CmlScriptInsertRepresentation_This instance = new CmlScriptInsertRepresentation_This();
			return instance;
		}
		
	}
	
	public abstract partial class CmlScriptValueReference : CmlElement
	{
		public abstract CmlScriptValueReference Duplicate();
		static public CmlScriptValueReference DOMify(CmlParser.CmlScriptValueReferenceContext context)
		{
			return CmlResolver.Resolve<CmlScriptValueReference>(context);
		}
		
		static public CmlScriptValueReference DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptValueReferenceContext);
		}
		
		static public CmlScriptValueReference DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptValueReference());
		}
		
		static public CmlScriptValueReference DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptValueReference());
		}
		
		static public CmlScriptValueReference DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptValueReference());
		}
		
	}
	
	public partial class CmlScriptValueReference_Normal : CmlScriptValueReference
	{
		private string id;
		static public CmlScriptValueReference_Normal DOMify(CmlParser.CmlScriptValueReference_NormalContext context)
		{
			if(context != null)
			{
				return new CmlScriptValueReference_Normal(context);
			}
			
			return null;
		}
		
		static new public CmlScriptValueReference_Normal DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptValueReference_NormalContext);
		}
		
		static new public CmlScriptValueReference_Normal DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptValueReference());
		}
		
		static new public CmlScriptValueReference_Normal DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptValueReference());
		}
		
		static new public CmlScriptValueReference_Normal DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptValueReference());
		}
		
		public CmlScriptValueReference_Normal()
		{
			id = "";
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptValueReference_Normal(CmlParser.CmlScriptValueReference_NormalContext context) : this()
		{
			SetId(context.ID().GetTextEX());
		}
		
		public override CmlScriptValueReference Duplicate()
		{
			CmlScriptValueReference_Normal instance = new CmlScriptValueReference_Normal();
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
	
	public partial class CmlScriptValueReference_This : CmlScriptValueReference
	{
		static public CmlScriptValueReference_This DOMify(CmlParser.CmlScriptValueReference_ThisContext context)
		{
			if(context != null)
			{
				return new CmlScriptValueReference_This(context);
			}
			
			return null;
		}
		
		static new public CmlScriptValueReference_This DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptValueReference_ThisContext);
		}
		
		static new public CmlScriptValueReference_This DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptValueReference());
		}
		
		static new public CmlScriptValueReference_This DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptValueReference());
		}
		
		static new public CmlScriptValueReference_This DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptValueReference());
		}
		
		public CmlScriptValueReference_This()
		{
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptValueReference_This(CmlParser.CmlScriptValueReference_ThisContext context) : this()
		{
		}
		
		public override CmlScriptValueReference Duplicate()
		{
			CmlScriptValueReference_This instance = new CmlScriptValueReference_This();
			return instance;
		}
		
	}
	
	public partial class CmlScriptValueReference_Parent : CmlScriptValueReference
	{
		static public CmlScriptValueReference_Parent DOMify(CmlParser.CmlScriptValueReference_ParentContext context)
		{
			if(context != null)
			{
				return new CmlScriptValueReference_Parent(context);
			}
			
			return null;
		}
		
		static new public CmlScriptValueReference_Parent DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptValueReference_ParentContext);
		}
		
		static new public CmlScriptValueReference_Parent DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptValueReference());
		}
		
		static new public CmlScriptValueReference_Parent DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptValueReference());
		}
		
		static new public CmlScriptValueReference_Parent DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptValueReference());
		}
		
		public CmlScriptValueReference_Parent()
		{
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptValueReference_Parent(CmlParser.CmlScriptValueReference_ParentContext context) : this()
		{
		}
		
		public override CmlScriptValueReference Duplicate()
		{
			CmlScriptValueReference_Parent instance = new CmlScriptValueReference_Parent();
			return instance;
		}
		
	}
	
	public partial class CmlScriptValueReference_ParentOfType : CmlScriptValueReference
	{
		private string type_name;
		static public CmlScriptValueReference_ParentOfType DOMify(CmlParser.CmlScriptValueReference_ParentOfTypeContext context)
		{
			if(context != null)
			{
				return new CmlScriptValueReference_ParentOfType(context);
			}
			
			return null;
		}
		
		static new public CmlScriptValueReference_ParentOfType DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptValueReference_ParentOfTypeContext);
		}
		
		static new public CmlScriptValueReference_ParentOfType DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptValueReference());
		}
		
		static new public CmlScriptValueReference_ParentOfType DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptValueReference());
		}
		
		static new public CmlScriptValueReference_ParentOfType DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptValueReference());
		}
		
		public CmlScriptValueReference_ParentOfType()
		{
			type_name = "";
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptValueReference_ParentOfType(CmlParser.CmlScriptValueReference_ParentOfTypeContext context) : this()
		{
			SetTypeName(context.ID().GetTextEX());
		}
		
		public override CmlScriptValueReference Duplicate()
		{
			CmlScriptValueReference_ParentOfType instance = new CmlScriptValueReference_ParentOfType();
			instance.SetTypeName(GetTypeName());
			return instance;
		}
		
		private void SetTypeName(string input)
		{
			type_name = input;
		}
		
		public string GetTypeName()
		{
			return type_name;
		}
		
	}
	
	public partial class CmlScriptFunctionCall : CmlElement
	{
		private string id;
		[RelatableChild]private CmlScriptExpressionList arguments;
		static public CmlScriptFunctionCall DOMify(CmlParser.CmlScriptFunctionCallContext context)
		{
			if(context != null)
			{
				return new CmlScriptFunctionCall(context);
			}
			
			return null;
		}
		
		static public CmlScriptFunctionCall DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptFunctionCallContext);
		}
		
		static public CmlScriptFunctionCall DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptFunctionCall());
		}
		
		static public CmlScriptFunctionCall DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptFunctionCall());
		}
		
		static public CmlScriptFunctionCall DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptFunctionCall());
		}
		
		public CmlScriptFunctionCall()
		{
			id = "";
			arguments = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptFunctionCall(CmlParser.CmlScriptFunctionCallContext context) : this()
		{
			SetId(context.ID().GetTextEX());
			SetArguments(CmlScriptExpressionList.DOMify(context.cmlScriptExpressionList()));
		}
		
		public CmlScriptFunctionCall Duplicate()
		{
			CmlScriptFunctionCall instance = new CmlScriptFunctionCall();
			instance.SetId(GetId());
			instance.SetArguments(GetArguments().IfNotNull(z => z.Duplicate()));
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
		
		private void SetArguments(CmlScriptExpressionList input)
		{
			arguments = input;
		}
		
		public CmlScriptExpressionList GetArguments()
		{
			return arguments;
		}
		
	}
	
	public partial class CmlScriptExpressionList : CmlElement
	{
		[RelatableChild]private List<CmlScriptExpression> expressions;
		static public CmlScriptExpressionList DOMify(CmlParser.CmlScriptExpressionListContext context)
		{
			if(context != null)
			{
				return new CmlScriptExpressionList(context);
			}
			
			return null;
		}
		
		static public CmlScriptExpressionList DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptExpressionListContext);
		}
		
		static public CmlScriptExpressionList DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptExpressionList());
		}
		
		static public CmlScriptExpressionList DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptExpressionList());
		}
		
		static public CmlScriptExpressionList DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptExpressionList());
		}
		
		public CmlScriptExpressionList()
		{
			expressions = new List<CmlScriptExpression>();
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptExpressionList(CmlParser.CmlScriptExpressionListContext context) : this()
		{
			AddExpressions(context.cmlScriptExpression().Convert(c => CmlScriptExpression.DOMify(c)));
		}
		
		public CmlScriptExpressionList Duplicate()
		{
			CmlScriptExpressionList instance = new CmlScriptExpressionList();
			instance.SetExpressions(GetExpressions().Convert(i => i.IfNotNull(z => z.Duplicate())));
			return instance;
		}
		
		private void ClearExpressions()
		{
			expressions.Clear();
		}
		
		private void SetExpressions(IEnumerable<CmlScriptExpression> input)
		{
			ClearExpressions();
			AddExpressions(input);
		}
		
		private void SetExpressions(params CmlScriptExpression[] input)
		{
			SetExpressions((IEnumerable<CmlScriptExpression>)input);
		}
		
		private void AddExpression(CmlScriptExpression input)
		{
			expressions.Add(input);
		}
		
		private void AddExpressions(IEnumerable<CmlScriptExpression> input)
		{
			input.Process(i => AddExpression(i));
		}
		
		private void AddExpressions(params CmlScriptExpression[] input)
		{
			AddExpressions((IEnumerable<CmlScriptExpression>)input);
		}
		
		public IEnumerable<CmlScriptExpression> GetExpressions()
		{
			return expressions;
		}
		
	}
	
	public abstract partial class CmlScriptLambda : CmlElement
	{
		public abstract CmlScriptLambda Duplicate();
		static public CmlScriptLambda DOMify(CmlParser.CmlScriptLambdaContext context)
		{
			return CmlResolver.Resolve<CmlScriptLambda>(context);
		}
		
		static public CmlScriptLambda DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptLambdaContext);
		}
		
		static public CmlScriptLambda DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptLambda());
		}
		
		static public CmlScriptLambda DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptLambda());
		}
		
		static public CmlScriptLambda DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptLambda());
		}
		
	}
	
	public partial class CmlScriptLambda_Single : CmlScriptLambda
	{
		[RelatableChild]private CmlScriptSingleStatement single_statement;
		static public CmlScriptLambda_Single DOMify(CmlParser.CmlScriptLambda_SingleContext context)
		{
			if(context != null)
			{
				return new CmlScriptLambda_Single(context);
			}
			
			return null;
		}
		
		static new public CmlScriptLambda_Single DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptLambda_SingleContext);
		}
		
		static new public CmlScriptLambda_Single DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptLambda());
		}
		
		static new public CmlScriptLambda_Single DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptLambda());
		}
		
		static new public CmlScriptLambda_Single DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptLambda());
		}
		
		public CmlScriptLambda_Single()
		{
			single_statement = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptLambda_Single(CmlParser.CmlScriptLambda_SingleContext context) : this()
		{
			SetSingleStatement(CmlScriptSingleStatement.DOMify(context.cmlScriptSingleStatement()));
		}
		
		public override CmlScriptLambda Duplicate()
		{
			CmlScriptLambda_Single instance = new CmlScriptLambda_Single();
			instance.SetSingleStatement(GetSingleStatement().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetSingleStatement(CmlScriptSingleStatement input)
		{
			single_statement = input;
		}
		
		public CmlScriptSingleStatement GetSingleStatement()
		{
			return single_statement;
		}
		
	}
	
	public partial class CmlScriptLambda_Block : CmlScriptLambda
	{
		[RelatableChild]private CmlScriptStatementBlock block;
		static public CmlScriptLambda_Block DOMify(CmlParser.CmlScriptLambda_BlockContext context)
		{
			if(context != null)
			{
				return new CmlScriptLambda_Block(context);
			}
			
			return null;
		}
		
		static new public CmlScriptLambda_Block DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptLambda_BlockContext);
		}
		
		static new public CmlScriptLambda_Block DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptLambda());
		}
		
		static new public CmlScriptLambda_Block DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptLambda());
		}
		
		static new public CmlScriptLambda_Block DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptLambda());
		}
		
		public CmlScriptLambda_Block()
		{
			block = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptLambda_Block(CmlParser.CmlScriptLambda_BlockContext context) : this()
		{
			SetBlock(CmlScriptStatementBlock.DOMify(context.cmlScriptStatementBlock()));
		}
		
		public override CmlScriptLambda Duplicate()
		{
			CmlScriptLambda_Block instance = new CmlScriptLambda_Block();
			instance.SetBlock(GetBlock().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetBlock(CmlScriptStatementBlock input)
		{
			block = input;
		}
		
		public CmlScriptStatementBlock GetBlock()
		{
			return block;
		}
		
	}
	
	public abstract partial class CmlScriptStatement : CmlElement
	{
		public abstract CmlScriptStatement Duplicate();
		static public CmlScriptStatement DOMify(CmlParser.CmlScriptStatementContext context)
		{
			return CmlResolver.Resolve<CmlScriptStatement>(context);
		}
		
		static public CmlScriptStatement DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptStatementContext);
		}
		
		static public CmlScriptStatement DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptStatement());
		}
		
		static public CmlScriptStatement DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptStatement());
		}
		
		static public CmlScriptStatement DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptStatement());
		}
		
	}
	
	public partial class CmlScriptStatement_Single : CmlScriptStatement
	{
		[RelatableChild]private CmlScriptSingleStatement single_statement;
		static public CmlScriptStatement_Single DOMify(CmlParser.CmlScriptStatement_SingleContext context)
		{
			if(context != null)
			{
				return new CmlScriptStatement_Single(context);
			}
			
			return null;
		}
		
		static new public CmlScriptStatement_Single DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptStatement_SingleContext);
		}
		
		static new public CmlScriptStatement_Single DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptStatement());
		}
		
		static new public CmlScriptStatement_Single DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptStatement());
		}
		
		static new public CmlScriptStatement_Single DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptStatement());
		}
		
		public CmlScriptStatement_Single()
		{
			single_statement = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptStatement_Single(CmlParser.CmlScriptStatement_SingleContext context) : this()
		{
			SetSingleStatement(CmlScriptSingleStatement.DOMify(context.cmlScriptSingleStatement()));
		}
		
		public override CmlScriptStatement Duplicate()
		{
			CmlScriptStatement_Single instance = new CmlScriptStatement_Single();
			instance.SetSingleStatement(GetSingleStatement().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetSingleStatement(CmlScriptSingleStatement input)
		{
			single_statement = input;
		}
		
		public CmlScriptSingleStatement GetSingleStatement()
		{
			return single_statement;
		}
		
	}
	
	public partial class CmlScriptStatement_Block : CmlScriptStatement
	{
		[RelatableChild]private CmlScriptStatementBlock block;
		static public CmlScriptStatement_Block DOMify(CmlParser.CmlScriptStatement_BlockContext context)
		{
			if(context != null)
			{
				return new CmlScriptStatement_Block(context);
			}
			
			return null;
		}
		
		static new public CmlScriptStatement_Block DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptStatement_BlockContext);
		}
		
		static new public CmlScriptStatement_Block DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptStatement());
		}
		
		static new public CmlScriptStatement_Block DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptStatement());
		}
		
		static new public CmlScriptStatement_Block DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptStatement());
		}
		
		public CmlScriptStatement_Block()
		{
			block = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptStatement_Block(CmlParser.CmlScriptStatement_BlockContext context) : this()
		{
			SetBlock(CmlScriptStatementBlock.DOMify(context.cmlScriptStatementBlock()));
		}
		
		public override CmlScriptStatement Duplicate()
		{
			CmlScriptStatement_Block instance = new CmlScriptStatement_Block();
			instance.SetBlock(GetBlock().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetBlock(CmlScriptStatementBlock input)
		{
			block = input;
		}
		
		public CmlScriptStatementBlock GetBlock()
		{
			return block;
		}
		
	}
	
	public partial class CmlScriptStatement_If : CmlScriptStatement
	{
		[RelatableChild]private CmlScriptExpression condition_expression;
		[RelatableChild]private CmlScriptStatement true_statement;
		[RelatableChild]private CmlScriptStatement false_statement;
		static public CmlScriptStatement_If DOMify(CmlParser.CmlScriptStatement_IfContext context)
		{
			if(context != null)
			{
				return new CmlScriptStatement_If(context);
			}
			
			return null;
		}
		
		static new public CmlScriptStatement_If DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptStatement_IfContext);
		}
		
		static new public CmlScriptStatement_If DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptStatement());
		}
		
		static new public CmlScriptStatement_If DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptStatement());
		}
		
		static new public CmlScriptStatement_If DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptStatement());
		}
		
		public CmlScriptStatement_If()
		{
			condition_expression = null;
			true_statement = null;
			false_statement = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptStatement_If(CmlParser.CmlScriptStatement_IfContext context) : this()
		{
			SetConditionExpression(CmlScriptExpression.DOMify(context.cmlScriptExpression()));
			SetTrueStatement(CmlScriptStatement.DOMify(context.cmlScriptStatement(0)));
			SetFalseStatement(CmlScriptStatement.DOMify(context.cmlScriptStatement(1)));
		}
		
		public override CmlScriptStatement Duplicate()
		{
			CmlScriptStatement_If instance = new CmlScriptStatement_If();
			instance.SetConditionExpression(GetConditionExpression().IfNotNull(z => z.Duplicate()));
			instance.SetTrueStatement(GetTrueStatement().IfNotNull(z => z.Duplicate()));
			instance.SetFalseStatement(GetFalseStatement().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetConditionExpression(CmlScriptExpression input)
		{
			condition_expression = input;
		}
		
		public CmlScriptExpression GetConditionExpression()
		{
			return condition_expression;
		}
		
		private void SetTrueStatement(CmlScriptStatement input)
		{
			true_statement = input;
		}
		
		public CmlScriptStatement GetTrueStatement()
		{
			return true_statement;
		}
		
		private void SetFalseStatement(CmlScriptStatement input)
		{
			false_statement = input;
		}
		
		public CmlScriptStatement GetFalseStatement()
		{
			return false_statement;
		}
		
	}
	
	public partial class CmlScriptStatement_While : CmlScriptStatement
	{
		[RelatableChild]private CmlScriptExpression condition_expression;
		[RelatableChild]private CmlScriptStatement while_statement;
		static public CmlScriptStatement_While DOMify(CmlParser.CmlScriptStatement_WhileContext context)
		{
			if(context != null)
			{
				return new CmlScriptStatement_While(context);
			}
			
			return null;
		}
		
		static new public CmlScriptStatement_While DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptStatement_WhileContext);
		}
		
		static new public CmlScriptStatement_While DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptStatement());
		}
		
		static new public CmlScriptStatement_While DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptStatement());
		}
		
		static new public CmlScriptStatement_While DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptStatement());
		}
		
		public CmlScriptStatement_While()
		{
			condition_expression = null;
			while_statement = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptStatement_While(CmlParser.CmlScriptStatement_WhileContext context) : this()
		{
			SetConditionExpression(CmlScriptExpression.DOMify(context.cmlScriptExpression()));
			SetWhileStatement(CmlScriptStatement.DOMify(context.cmlScriptStatement()));
		}
		
		public override CmlScriptStatement Duplicate()
		{
			CmlScriptStatement_While instance = new CmlScriptStatement_While();
			instance.SetConditionExpression(GetConditionExpression().IfNotNull(z => z.Duplicate()));
			instance.SetWhileStatement(GetWhileStatement().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetConditionExpression(CmlScriptExpression input)
		{
			condition_expression = input;
		}
		
		public CmlScriptExpression GetConditionExpression()
		{
			return condition_expression;
		}
		
		private void SetWhileStatement(CmlScriptStatement input)
		{
			while_statement = input;
		}
		
		public CmlScriptStatement GetWhileStatement()
		{
			return while_statement;
		}
		
	}
	
	public abstract partial class CmlScriptSingleStatement : CmlElement
	{
		public abstract CmlScriptSingleStatement Duplicate();
		static public CmlScriptSingleStatement DOMify(CmlParser.CmlScriptSingleStatementContext context)
		{
			return CmlResolver.Resolve<CmlScriptSingleStatement>(context);
		}
		
		static public CmlScriptSingleStatement DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptSingleStatementContext);
		}
		
		static public CmlScriptSingleStatement DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptSingleStatement());
		}
		
		static public CmlScriptSingleStatement DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptSingleStatement());
		}
		
		static public CmlScriptSingleStatement DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptSingleStatement());
		}
		
	}
	
	public partial class CmlScriptSingleStatement_Assign : CmlScriptSingleStatement
	{
		[RelatableChild]private CmlScriptValueReference value_reference;
		[RelatableChild]private CmlScriptExpression expression;
		static public CmlScriptSingleStatement_Assign DOMify(CmlParser.CmlScriptSingleStatement_AssignContext context)
		{
			if(context != null)
			{
				return new CmlScriptSingleStatement_Assign(context);
			}
			
			return null;
		}
		
		static new public CmlScriptSingleStatement_Assign DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptSingleStatement_AssignContext);
		}
		
		static new public CmlScriptSingleStatement_Assign DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptSingleStatement());
		}
		
		static new public CmlScriptSingleStatement_Assign DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptSingleStatement());
		}
		
		static new public CmlScriptSingleStatement_Assign DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptSingleStatement());
		}
		
		public CmlScriptSingleStatement_Assign()
		{
			value_reference = null;
			expression = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptSingleStatement_Assign(CmlParser.CmlScriptSingleStatement_AssignContext context) : this()
		{
			SetValueReference(CmlScriptValueReference.DOMify(context.cmlScriptValueReference()));
			SetExpression(CmlScriptExpression.DOMify(context.cmlScriptExpression()));
		}
		
		public override CmlScriptSingleStatement Duplicate()
		{
			CmlScriptSingleStatement_Assign instance = new CmlScriptSingleStatement_Assign();
			instance.SetValueReference(GetValueReference().IfNotNull(z => z.Duplicate()));
			instance.SetExpression(GetExpression().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetValueReference(CmlScriptValueReference input)
		{
			value_reference = input;
		}
		
		public CmlScriptValueReference GetValueReference()
		{
			return value_reference;
		}
		
		private void SetExpression(CmlScriptExpression input)
		{
			expression = input;
		}
		
		public CmlScriptExpression GetExpression()
		{
			return expression;
		}
		
	}
	
	public partial class CmlScriptSingleStatement_IndirectAssign : CmlScriptSingleStatement
	{
		[RelatableChild]private CmlScriptExpression indirection_expression;
		[RelatableChild]private CmlScriptValueReference value_reference;
		[RelatableChild]private CmlScriptExpression expression;
		static public CmlScriptSingleStatement_IndirectAssign DOMify(CmlParser.CmlScriptSingleStatement_IndirectAssignContext context)
		{
			if(context != null)
			{
				return new CmlScriptSingleStatement_IndirectAssign(context);
			}
			
			return null;
		}
		
		static new public CmlScriptSingleStatement_IndirectAssign DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptSingleStatement_IndirectAssignContext);
		}
		
		static new public CmlScriptSingleStatement_IndirectAssign DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptSingleStatement());
		}
		
		static new public CmlScriptSingleStatement_IndirectAssign DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptSingleStatement());
		}
		
		static new public CmlScriptSingleStatement_IndirectAssign DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptSingleStatement());
		}
		
		public CmlScriptSingleStatement_IndirectAssign()
		{
			indirection_expression = null;
			value_reference = null;
			expression = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptSingleStatement_IndirectAssign(CmlParser.CmlScriptSingleStatement_IndirectAssignContext context) : this()
		{
			SetIndirectionExpression(CmlScriptExpression.DOMify(context.cmlScriptExpression(0)));
			SetValueReference(CmlScriptValueReference.DOMify(context.cmlScriptValueReference()));
			SetExpression(CmlScriptExpression.DOMify(context.cmlScriptExpression(1)));
		}
		
		public override CmlScriptSingleStatement Duplicate()
		{
			CmlScriptSingleStatement_IndirectAssign instance = new CmlScriptSingleStatement_IndirectAssign();
			instance.SetIndirectionExpression(GetIndirectionExpression().IfNotNull(z => z.Duplicate()));
			instance.SetValueReference(GetValueReference().IfNotNull(z => z.Duplicate()));
			instance.SetExpression(GetExpression().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetIndirectionExpression(CmlScriptExpression input)
		{
			indirection_expression = input;
		}
		
		public CmlScriptExpression GetIndirectionExpression()
		{
			return indirection_expression;
		}
		
		private void SetValueReference(CmlScriptValueReference input)
		{
			value_reference = input;
		}
		
		public CmlScriptValueReference GetValueReference()
		{
			return value_reference;
		}
		
		private void SetExpression(CmlScriptExpression input)
		{
			expression = input;
		}
		
		public CmlScriptExpression GetExpression()
		{
			return expression;
		}
		
	}
	
	public partial class CmlScriptSingleStatement_FunctionCall : CmlScriptSingleStatement
	{
		[RelatableChild]private CmlScriptFunctionCall function_call;
		static public CmlScriptSingleStatement_FunctionCall DOMify(CmlParser.CmlScriptSingleStatement_FunctionCallContext context)
		{
			if(context != null)
			{
				return new CmlScriptSingleStatement_FunctionCall(context);
			}
			
			return null;
		}
		
		static new public CmlScriptSingleStatement_FunctionCall DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptSingleStatement_FunctionCallContext);
		}
		
		static new public CmlScriptSingleStatement_FunctionCall DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptSingleStatement());
		}
		
		static new public CmlScriptSingleStatement_FunctionCall DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptSingleStatement());
		}
		
		static new public CmlScriptSingleStatement_FunctionCall DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptSingleStatement());
		}
		
		public CmlScriptSingleStatement_FunctionCall()
		{
			function_call = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptSingleStatement_FunctionCall(CmlParser.CmlScriptSingleStatement_FunctionCallContext context) : this()
		{
			SetFunctionCall(CmlScriptFunctionCall.DOMify(context.cmlScriptFunctionCall()));
		}
		
		public override CmlScriptSingleStatement Duplicate()
		{
			CmlScriptSingleStatement_FunctionCall instance = new CmlScriptSingleStatement_FunctionCall();
			instance.SetFunctionCall(GetFunctionCall().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetFunctionCall(CmlScriptFunctionCall input)
		{
			function_call = input;
		}
		
		public CmlScriptFunctionCall GetFunctionCall()
		{
			return function_call;
		}
		
	}
	
	public partial class CmlScriptSingleStatement_IndirectFunctionCall : CmlScriptSingleStatement
	{
		[RelatableChild]private CmlScriptExpression indirection_expression;
		[RelatableChild]private CmlScriptFunctionCall function_call;
		static public CmlScriptSingleStatement_IndirectFunctionCall DOMify(CmlParser.CmlScriptSingleStatement_IndirectFunctionCallContext context)
		{
			if(context != null)
			{
				return new CmlScriptSingleStatement_IndirectFunctionCall(context);
			}
			
			return null;
		}
		
		static new public CmlScriptSingleStatement_IndirectFunctionCall DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptSingleStatement_IndirectFunctionCallContext);
		}
		
		static new public CmlScriptSingleStatement_IndirectFunctionCall DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptSingleStatement());
		}
		
		static new public CmlScriptSingleStatement_IndirectFunctionCall DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptSingleStatement());
		}
		
		static new public CmlScriptSingleStatement_IndirectFunctionCall DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptSingleStatement());
		}
		
		public CmlScriptSingleStatement_IndirectFunctionCall()
		{
			indirection_expression = null;
			function_call = null;
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptSingleStatement_IndirectFunctionCall(CmlParser.CmlScriptSingleStatement_IndirectFunctionCallContext context) : this()
		{
			SetIndirectionExpression(CmlScriptExpression.DOMify(context.cmlScriptExpression()));
			SetFunctionCall(CmlScriptFunctionCall.DOMify(context.cmlScriptFunctionCall()));
		}
		
		public override CmlScriptSingleStatement Duplicate()
		{
			CmlScriptSingleStatement_IndirectFunctionCall instance = new CmlScriptSingleStatement_IndirectFunctionCall();
			instance.SetIndirectionExpression(GetIndirectionExpression().IfNotNull(z => z.Duplicate()));
			instance.SetFunctionCall(GetFunctionCall().IfNotNull(z => z.Duplicate()));
			return instance;
		}
		
		private void SetIndirectionExpression(CmlScriptExpression input)
		{
			indirection_expression = input;
		}
		
		public CmlScriptExpression GetIndirectionExpression()
		{
			return indirection_expression;
		}
		
		private void SetFunctionCall(CmlScriptFunctionCall input)
		{
			function_call = input;
		}
		
		public CmlScriptFunctionCall GetFunctionCall()
		{
			return function_call;
		}
		
	}
	
	public partial class CmlScriptStatementBlock : CmlElement
	{
		[RelatableChild]private List<CmlScriptStatement> statements;
		static public CmlScriptStatementBlock DOMify(CmlParser.CmlScriptStatementBlockContext context)
		{
			if(context != null)
			{
				return new CmlScriptStatementBlock(context);
			}
			
			return null;
		}
		
		static public CmlScriptStatementBlock DOMify(IParseTree parse_tree)
		{
			return DOMify(parse_tree as CmlParser.CmlScriptStatementBlockContext);
		}
		
		static public CmlScriptStatementBlock DOMify(Stream stream)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(stream).cmlScriptStatementBlock());
		}
		
		static public CmlScriptStatementBlock DOMify(string text)
		{
			return DOMify(CmlDOMinatorUtilities.CreateParser(text).cmlScriptStatementBlock());
		}
		
		static public CmlScriptStatementBlock DOMifyFile(string filename)
		{
			return DOMify(CmlDOMinatorUtilities.CreateFileParser(filename).cmlScriptStatementBlock());
		}
		
		public CmlScriptStatementBlock()
		{
			statements = new List<CmlScriptStatement>();
			OnConstructor();
		}
		
		partial void OnConstructor();
		public CmlScriptStatementBlock(CmlParser.CmlScriptStatementBlockContext context) : this()
		{
			AddStatements(context.cmlScriptStatement().Convert(c => CmlScriptStatement.DOMify(c)));
		}
		
		public CmlScriptStatementBlock Duplicate()
		{
			CmlScriptStatementBlock instance = new CmlScriptStatementBlock();
			instance.SetStatements(GetStatements().Convert(i => i.IfNotNull(z => z.Duplicate())));
			return instance;
		}
		
		private void ClearStatements()
		{
			statements.Clear();
		}
		
		private void SetStatements(IEnumerable<CmlScriptStatement> input)
		{
			ClearStatements();
			AddStatements(input);
		}
		
		private void SetStatements(params CmlScriptStatement[] input)
		{
			SetStatements((IEnumerable<CmlScriptStatement>)input);
		}
		
		private void AddStatement(CmlScriptStatement input)
		{
			statements.Add(input);
		}
		
		private void AddStatements(IEnumerable<CmlScriptStatement> input)
		{
			input.Process(i => AddStatement(i));
		}
		
		private void AddStatements(params CmlScriptStatement[] input)
		{
			AddStatements((IEnumerable<CmlScriptStatement>)input);
		}
		
		public IEnumerable<CmlScriptStatement> GetStatements()
		{
			return statements;
		}
		
	}
	
	public abstract partial class CmlElement : Object, Relatable
	{
		public CmlElement()
		{
			OnConstruct();
		}
		
		partial void OnConstruct();
	}
	
	static public class CmlDOMinatorUtilities
	{
		static public CmlParser CreateParser(ICharStream stream)
		{
			CmlParser parser = new CmlParser(new CommonTokenStream(new CmlLexer(stream)));
			parser.RemoveErrorListeners();
			parser.AddErrorListener(CmlSyntaxExceptionThrower.INSTANCE);
			return parser;
		}
		
		static public CmlParser CreateParser(Stream stream)
		{
			return CreateParser(new AntlrInputStream(stream));
		}
		
		static public CmlParser CreateParser(TextReader text_reader)
		{
			return CreateParser(new AntlrInputStream(text_reader));
		}
		
		static public CmlParser CreateParser(string text)
		{
			return CreateParser(new StringReader(text));
		}
		
		static public CmlParser CreateFileParser(string filename)
		{
			return CreateParser(new AntlrFileStream(filename));
		}
		
	}
	
	static public class CmlIParseTreeExtensions
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
	
	public partial class CmlResolver : CmlBaseVisitor<CmlElement>
	{
		static private CmlResolver instance;
		static public CmlResolver GetInstance()
		{
			if(instance == null)
			{
				instance = new CmlResolver();
			}
			
			return instance;
		}
		
		static public CmlElement Resolve(IParseTree parse_tree)
		{
			if(parse_tree != null)
			{
				return GetInstance().Visit(parse_tree);
			}
			
			return null;
		}
		
		static public T Resolve<T>(IParseTree parse_tree) where T : CmlElement
		{
			return Resolve(parse_tree) as T;
		}
		
		private CmlResolver()
		{
		}
		
		public override CmlElement VisitCmlClassDefinition(CmlParser.CmlClassDefinitionContext context)
		{
			return CmlClassDefinition.DOMify(context);
		}
		
		public override CmlElement VisitCmlFragmentDefinition(CmlParser.CmlFragmentDefinitionContext context)
		{
			return CmlFragmentDefinition.DOMify(context);
		}
		
		public override CmlElement VisitCmlValueSource_ComponentSource(CmlParser.CmlValueSource_ComponentSourceContext context)
		{
			return CmlValueSource_ComponentSource.DOMify(context);
		}
		
		public override CmlElement VisitCmlValueSource_ComponentSourceList(CmlParser.CmlValueSource_ComponentSourceListContext context)
		{
			return CmlValueSource_ComponentSourceList.DOMify(context);
		}
		
		public override CmlElement VisitCmlValueSource_LinkSource(CmlParser.CmlValueSource_LinkSourceContext context)
		{
			return CmlValueSource_LinkSource.DOMify(context);
		}
		
		public override CmlElement VisitCmlValueSource_LinkSourceWithEntitySource(CmlParser.CmlValueSource_LinkSourceWithEntitySourceContext context)
		{
			return CmlValueSource_LinkSourceWithEntitySource.DOMify(context);
		}
		
		public override CmlElement VisitCmlValueSource_FunctionSource(CmlParser.CmlValueSource_FunctionSourceContext context)
		{
			return CmlValueSource_FunctionSource.DOMify(context);
		}
		
		public override CmlElement VisitCmlComponentSource_Primitive(CmlParser.CmlComponentSource_PrimitiveContext context)
		{
			return CmlComponentSource_Primitive.DOMify(context);
		}
		
		public override CmlElement VisitCmlComponentSource_Entity(CmlParser.CmlComponentSource_EntityContext context)
		{
			return CmlComponentSource_Entity.DOMify(context);
		}
		
		public override CmlElement VisitCmlComponentSource_Constructor(CmlParser.CmlComponentSource_ConstructorContext context)
		{
			return CmlComponentSource_Constructor.DOMify(context);
		}
		
		public override CmlElement VisitCmlComponentSource_InsertParameter(CmlParser.CmlComponentSource_InsertParameterContext context)
		{
			return CmlComponentSource_InsertParameter.DOMify(context);
		}
		
		public override CmlElement VisitCmlComponentSourceList(CmlParser.CmlComponentSourceListContext context)
		{
			return CmlComponentSourceList.DOMify(context);
		}
		
		public override CmlElement VisitCmlPrimitive_Int(CmlParser.CmlPrimitive_IntContext context)
		{
			return CmlPrimitive_Int.DOMify(context);
		}
		
		public override CmlElement VisitCmlPrimitive_Float(CmlParser.CmlPrimitive_FloatContext context)
		{
			return CmlPrimitive_Float.DOMify(context);
		}
		
		public override CmlElement VisitCmlPrimitive_Double(CmlParser.CmlPrimitive_DoubleContext context)
		{
			return CmlPrimitive_Double.DOMify(context);
		}
		
		public override CmlElement VisitCmlPrimitive_Null(CmlParser.CmlPrimitive_NullContext context)
		{
			return CmlPrimitive_Null.DOMify(context);
		}
		
		public override CmlElement VisitCmlPrimitive_Bool(CmlParser.CmlPrimitive_BoolContext context)
		{
			return CmlPrimitive_Bool.DOMify(context);
		}
		
		public override CmlElement VisitCmlPrimitive_String(CmlParser.CmlPrimitive_StringContext context)
		{
			return CmlPrimitive_String.DOMify(context);
		}
		
		public override CmlElement VisitCmlEntity(CmlParser.CmlEntityContext context)
		{
			return CmlEntity.DOMify(context);
		}
		
		public override CmlElement VisitCmlEntityChildren_Static(CmlParser.CmlEntityChildren_StaticContext context)
		{
			return CmlEntityChildren_Static.DOMify(context);
		}
		
		public override CmlElement VisitCmlEntityChildren_Dynamic(CmlParser.CmlEntityChildren_DynamicContext context)
		{
			return CmlEntityChildren_Dynamic.DOMify(context);
		}
		
		public override CmlElement VisitCmlEntityChildren_DynamicInline(CmlParser.CmlEntityChildren_DynamicInlineContext context)
		{
			return CmlEntityChildren_DynamicInline.DOMify(context);
		}
		
		public override CmlElement VisitCmlEntityMountPoint(CmlParser.CmlEntityMountPointContext context)
		{
			return CmlEntityMountPoint.DOMify(context);
		}
		
		public override CmlElement VisitCmlEntityCompositeChild(CmlParser.CmlEntityCompositeChildContext context)
		{
			return CmlEntityCompositeChild.DOMify(context);
		}
		
		public override CmlElement VisitCmlEntityAttribute(CmlParser.CmlEntityAttributeContext context)
		{
			return CmlEntityAttribute.DOMify(context);
		}
		
		public override CmlElement VisitCmlConstructor(CmlParser.CmlConstructorContext context)
		{
			return CmlConstructor.DOMify(context);
		}
		
		public override CmlElement VisitCmlValueSourceList(CmlParser.CmlValueSourceListContext context)
		{
			return CmlValueSourceList.DOMify(context);
		}
		
		public override CmlElement VisitCmlLinkSource_Normal(CmlParser.CmlLinkSource_NormalContext context)
		{
			return CmlLinkSource_Normal.DOMify(context);
		}
		
		public override CmlElement VisitCmlLinkSource_InsertParameter(CmlParser.CmlLinkSource_InsertParameterContext context)
		{
			return CmlLinkSource_InsertParameter.DOMify(context);
		}
		
		public override CmlElement VisitCmlLinkSourceWithEntitySource(CmlParser.CmlLinkSourceWithEntitySourceContext context)
		{
			return CmlLinkSourceWithEntitySource.DOMify(context);
		}
		
		public override CmlElement VisitCmlFunctionSource_Normal(CmlParser.CmlFunctionSource_NormalContext context)
		{
			return CmlFunctionSource_Normal.DOMify(context);
		}
		
		public override CmlElement VisitCmlFunctionSource_InsertParameter(CmlParser.CmlFunctionSource_InsertParameterContext context)
		{
			return CmlFunctionSource_InsertParameter.DOMify(context);
		}
		
		public override CmlElement VisitCmlInsertParameter(CmlParser.CmlInsertParameterContext context)
		{
			return CmlInsertParameter.DOMify(context);
		}
		
		public override CmlElement VisitCmlInfo(CmlParser.CmlInfoContext context)
		{
			return CmlInfo.DOMify(context);
		}
		
		public override CmlElement VisitCmlInfoSetting(CmlParser.CmlInfoSettingContext context)
		{
			return CmlInfoSetting.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptEntry_Link(CmlParser.CmlScriptEntry_LinkContext context)
		{
			return CmlScriptEntry_Link.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptEntry_Function(CmlParser.CmlScriptEntry_FunctionContext context)
		{
			return CmlScriptEntry_Function.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptFunctionParameter(CmlParser.CmlScriptFunctionParameterContext context)
		{
			return CmlScriptFunctionParameter.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptFunctionParameters(CmlParser.CmlScriptFunctionParametersContext context)
		{
			return CmlScriptFunctionParameters.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptExpression_Direct(CmlParser.CmlScriptExpression_DirectContext context)
		{
			return CmlScriptExpression_Direct.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptExpression_Indirect(CmlParser.CmlScriptExpression_IndirectContext context)
		{
			return CmlScriptExpression_Indirect.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptExpression_Parenthetical(CmlParser.CmlScriptExpression_ParentheticalContext context)
		{
			return CmlScriptExpression_Parenthetical.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptExpression_BinaryOperation_Multiplicative(CmlParser.CmlScriptExpression_BinaryOperation_MultiplicativeContext context)
		{
			return CmlScriptExpression_BinaryOperation_Multiplicative.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptExpression_BinaryOperation_Additive(CmlParser.CmlScriptExpression_BinaryOperation_AdditiveContext context)
		{
			return CmlScriptExpression_BinaryOperation_Additive.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptExpression_BinaryOperation_Comparative(CmlParser.CmlScriptExpression_BinaryOperation_ComparativeContext context)
		{
			return CmlScriptExpression_BinaryOperation_Comparative.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptExpression_BinaryOperation_Boolean(CmlParser.CmlScriptExpression_BinaryOperation_BooleanContext context)
		{
			return CmlScriptExpression_BinaryOperation_Boolean.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptBinaryOperatorMultiplicative_Times(CmlParser.CmlScriptBinaryOperatorMultiplicative_TimesContext context)
		{
			return CmlScriptBinaryOperator_Multiplicative_Times.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptBinaryOperatorMultiplicative_Divide(CmlParser.CmlScriptBinaryOperatorMultiplicative_DivideContext context)
		{
			return CmlScriptBinaryOperator_Multiplicative_Divide.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptBinaryOperatorMultiplicative_Modulo(CmlParser.CmlScriptBinaryOperatorMultiplicative_ModuloContext context)
		{
			return CmlScriptBinaryOperator_Multiplicative_Modulo.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptBinaryOperatorAdditive_Plus(CmlParser.CmlScriptBinaryOperatorAdditive_PlusContext context)
		{
			return CmlScriptBinaryOperator_Additive_Plus.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptBinaryOperatorAdditive_Minus(CmlParser.CmlScriptBinaryOperatorAdditive_MinusContext context)
		{
			return CmlScriptBinaryOperator_Additive_Minus.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptBinaryOperatorComparative_IsEqualTo(CmlParser.CmlScriptBinaryOperatorComparative_IsEqualToContext context)
		{
			return CmlScriptBinaryOperator_Comparative_IsEqualTo.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptBinaryOperatorComparative_IsNotEqualTo(CmlParser.CmlScriptBinaryOperatorComparative_IsNotEqualToContext context)
		{
			return CmlScriptBinaryOperator_Comparative_IsNotEqualTo.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptBinaryOperatorComparative_IsLessThan(CmlParser.CmlScriptBinaryOperatorComparative_IsLessThanContext context)
		{
			return CmlScriptBinaryOperator_Comparative_IsLessThan.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptBinaryOperatorComparative_IsLessThanOrEqualTo(CmlParser.CmlScriptBinaryOperatorComparative_IsLessThanOrEqualToContext context)
		{
			return CmlScriptBinaryOperator_Comparative_IsLessThanOrEqualTo.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptBinaryOperatorComparative_IsGreaterThan(CmlParser.CmlScriptBinaryOperatorComparative_IsGreaterThanContext context)
		{
			return CmlScriptBinaryOperator_Comparative_IsGreaterThan.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptBinaryOperatorComparative_IsGreaterThanOrEqualTo(CmlParser.CmlScriptBinaryOperatorComparative_IsGreaterThanOrEqualToContext context)
		{
			return CmlScriptBinaryOperator_Comparative_IsGreaterThanOrEqualTo.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptBinaryOperatorBoolean_Or(CmlParser.CmlScriptBinaryOperatorBoolean_OrContext context)
		{
			return CmlScriptBinaryOperator_Boolean_Or.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptBinaryOperatorBoolean_And(CmlParser.CmlScriptBinaryOperatorBoolean_AndContext context)
		{
			return CmlScriptBinaryOperator_Boolean_And.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptSubExpression_Constant_Int(CmlParser.CmlScriptSubExpression_Constant_IntContext context)
		{
			return CmlScriptSubExpression_Constant_Int.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptSubExpression_Constant_Float(CmlParser.CmlScriptSubExpression_Constant_FloatContext context)
		{
			return CmlScriptSubExpression_Constant_Float.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptSubExpression_Constant_Double(CmlParser.CmlScriptSubExpression_Constant_DoubleContext context)
		{
			return CmlScriptSubExpression_Constant_Double.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptSubExpression_Constant_Null(CmlParser.CmlScriptSubExpression_Constant_NullContext context)
		{
			return CmlScriptSubExpression_Constant_Null.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptSubExpression_Constant_Bool(CmlParser.CmlScriptSubExpression_Constant_BoolContext context)
		{
			return CmlScriptSubExpression_Constant_Bool.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptSubExpression_Constant_String(CmlParser.CmlScriptSubExpression_Constant_StringContext context)
		{
			return CmlScriptSubExpression_Constant_String.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptSubExpression_SyntheticString(CmlParser.CmlScriptSubExpression_SyntheticStringContext context)
		{
			return CmlScriptSubExpression_SyntheticString.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptSubExpression_InsertParameter(CmlParser.CmlScriptSubExpression_InsertParameterContext context)
		{
			return CmlScriptSubExpression_InsertParameter.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptSubExpression_ValueReference(CmlParser.CmlScriptSubExpression_ValueReferenceContext context)
		{
			return CmlScriptSubExpression_ValueReference.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptSubExpression_InsertRepresentation(CmlParser.CmlScriptSubExpression_InsertRepresentationContext context)
		{
			return CmlScriptSubExpression_InsertRepresentation.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptSubExpression_FunctionCall(CmlParser.CmlScriptSubExpression_FunctionCallContext context)
		{
			return CmlScriptSubExpression_FunctionCall.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptSyntheticString(CmlParser.CmlScriptSyntheticStringContext context)
		{
			return CmlScriptSyntheticString.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptInsertRepresentation_Normal(CmlParser.CmlScriptInsertRepresentation_NormalContext context)
		{
			return CmlScriptInsertRepresentation_Normal.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptInsertRepresentation_This(CmlParser.CmlScriptInsertRepresentation_ThisContext context)
		{
			return CmlScriptInsertRepresentation_This.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptValueReference_Normal(CmlParser.CmlScriptValueReference_NormalContext context)
		{
			return CmlScriptValueReference_Normal.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptValueReference_This(CmlParser.CmlScriptValueReference_ThisContext context)
		{
			return CmlScriptValueReference_This.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptValueReference_Parent(CmlParser.CmlScriptValueReference_ParentContext context)
		{
			return CmlScriptValueReference_Parent.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptValueReference_ParentOfType(CmlParser.CmlScriptValueReference_ParentOfTypeContext context)
		{
			return CmlScriptValueReference_ParentOfType.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptFunctionCall(CmlParser.CmlScriptFunctionCallContext context)
		{
			return CmlScriptFunctionCall.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptExpressionList(CmlParser.CmlScriptExpressionListContext context)
		{
			return CmlScriptExpressionList.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptLambda_Single(CmlParser.CmlScriptLambda_SingleContext context)
		{
			return CmlScriptLambda_Single.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptLambda_Block(CmlParser.CmlScriptLambda_BlockContext context)
		{
			return CmlScriptLambda_Block.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptStatement_Single(CmlParser.CmlScriptStatement_SingleContext context)
		{
			return CmlScriptStatement_Single.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptStatement_Block(CmlParser.CmlScriptStatement_BlockContext context)
		{
			return CmlScriptStatement_Block.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptStatement_If(CmlParser.CmlScriptStatement_IfContext context)
		{
			return CmlScriptStatement_If.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptStatement_While(CmlParser.CmlScriptStatement_WhileContext context)
		{
			return CmlScriptStatement_While.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptSingleStatement_Assign(CmlParser.CmlScriptSingleStatement_AssignContext context)
		{
			return CmlScriptSingleStatement_Assign.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptSingleStatement_IndirectAssign(CmlParser.CmlScriptSingleStatement_IndirectAssignContext context)
		{
			return CmlScriptSingleStatement_IndirectAssign.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptSingleStatement_FunctionCall(CmlParser.CmlScriptSingleStatement_FunctionCallContext context)
		{
			return CmlScriptSingleStatement_FunctionCall.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptSingleStatement_IndirectFunctionCall(CmlParser.CmlScriptSingleStatement_IndirectFunctionCallContext context)
		{
			return CmlScriptSingleStatement_IndirectFunctionCall.DOMify(context);
		}
		
		public override CmlElement VisitCmlScriptStatementBlock(CmlParser.CmlScriptStatementBlockContext context)
		{
			return CmlScriptStatementBlock.DOMify(context);
		}
		
	}
	
	public partial class CmlSyntaxException : Exception
	{
		private int line;
		private string base_message;
		public override string Message { get{ return GetMessage(); } }
		public CmlSyntaxException(int l, string m) : base()
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
	
	public class CmlSyntaxExceptionThrower : BaseErrorListener
	{
		static public readonly CmlSyntaxExceptionThrower INSTANCE = new CmlSyntaxExceptionThrower();
		private CmlSyntaxExceptionThrower()
		{
		}
		
		public override void SyntaxError(TextWriter output, IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
		{
			throw new CmlSyntaxException(line, msg);
		}
		
	}
	
}
