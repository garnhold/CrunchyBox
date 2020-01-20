//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /home/garrett/Documents/Programming/CrunchyBox/CrunchySack/Cml/CmlGrammar/Cml.g4 by ANTLR 4.7.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="CmlParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.2")]
[System.CLSCompliant(false)]
public interface ICmlVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="CmlParser.cmlClassDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlClassDefinition([NotNull] CmlParser.CmlClassDefinitionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CmlParser.cmlFragmentDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlFragmentDefinition([NotNull] CmlParser.CmlFragmentDefinitionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlValueSource_ComponentSource</c>
	/// labeled alternative in <see cref="CmlParser.cmlValueSource"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlValueSource_ComponentSource([NotNull] CmlParser.CmlValueSource_ComponentSourceContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlValueSource_ComponentSourceList</c>
	/// labeled alternative in <see cref="CmlParser.cmlValueSource"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlValueSource_ComponentSourceList([NotNull] CmlParser.CmlValueSource_ComponentSourceListContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlValueSource_LinkSource</c>
	/// labeled alternative in <see cref="CmlParser.cmlValueSource"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlValueSource_LinkSource([NotNull] CmlParser.CmlValueSource_LinkSourceContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlValueSource_LinkSourceWithEntitySource</c>
	/// labeled alternative in <see cref="CmlParser.cmlValueSource"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlValueSource_LinkSourceWithEntitySource([NotNull] CmlParser.CmlValueSource_LinkSourceWithEntitySourceContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlValueSource_FunctionSource</c>
	/// labeled alternative in <see cref="CmlParser.cmlValueSource"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlValueSource_FunctionSource([NotNull] CmlParser.CmlValueSource_FunctionSourceContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlComponentSource_Primitive</c>
	/// labeled alternative in <see cref="CmlParser.cmlComponentSource"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlComponentSource_Primitive([NotNull] CmlParser.CmlComponentSource_PrimitiveContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlComponentSource_Entity</c>
	/// labeled alternative in <see cref="CmlParser.cmlComponentSource"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlComponentSource_Entity([NotNull] CmlParser.CmlComponentSource_EntityContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlComponentSource_Constructor</c>
	/// labeled alternative in <see cref="CmlParser.cmlComponentSource"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlComponentSource_Constructor([NotNull] CmlParser.CmlComponentSource_ConstructorContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlComponentSource_InsertParameter</c>
	/// labeled alternative in <see cref="CmlParser.cmlComponentSource"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlComponentSource_InsertParameter([NotNull] CmlParser.CmlComponentSource_InsertParameterContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CmlParser.cmlComponentSourceList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlComponentSourceList([NotNull] CmlParser.CmlComponentSourceListContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlPrimitive_Int</c>
	/// labeled alternative in <see cref="CmlParser.cmlPrimitive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlPrimitive_Int([NotNull] CmlParser.CmlPrimitive_IntContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlPrimitive_Float</c>
	/// labeled alternative in <see cref="CmlParser.cmlPrimitive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlPrimitive_Float([NotNull] CmlParser.CmlPrimitive_FloatContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlPrimitive_Double</c>
	/// labeled alternative in <see cref="CmlParser.cmlPrimitive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlPrimitive_Double([NotNull] CmlParser.CmlPrimitive_DoubleContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlPrimitive_Null</c>
	/// labeled alternative in <see cref="CmlParser.cmlPrimitive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlPrimitive_Null([NotNull] CmlParser.CmlPrimitive_NullContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlPrimitive_Bool</c>
	/// labeled alternative in <see cref="CmlParser.cmlPrimitive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlPrimitive_Bool([NotNull] CmlParser.CmlPrimitive_BoolContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlPrimitive_String</c>
	/// labeled alternative in <see cref="CmlParser.cmlPrimitive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlPrimitive_String([NotNull] CmlParser.CmlPrimitive_StringContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CmlParser.cmlEntity"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlEntity([NotNull] CmlParser.CmlEntityContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlEntityChildren_Static</c>
	/// labeled alternative in <see cref="CmlParser.cmlEntityChildren"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlEntityChildren_Static([NotNull] CmlParser.CmlEntityChildren_StaticContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlEntityChildren_Dynamic</c>
	/// labeled alternative in <see cref="CmlParser.cmlEntityChildren"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlEntityChildren_Dynamic([NotNull] CmlParser.CmlEntityChildren_DynamicContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlEntityChildren_DynamicInline</c>
	/// labeled alternative in <see cref="CmlParser.cmlEntityChildren"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlEntityChildren_DynamicInline([NotNull] CmlParser.CmlEntityChildren_DynamicInlineContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CmlParser.cmlEntityMountPoint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlEntityMountPoint([NotNull] CmlParser.CmlEntityMountPointContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CmlParser.cmlEntityCompositeChild"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlEntityCompositeChild([NotNull] CmlParser.CmlEntityCompositeChildContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CmlParser.cmlEntityAttribute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlEntityAttribute([NotNull] CmlParser.CmlEntityAttributeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CmlParser.cmlConstructor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlConstructor([NotNull] CmlParser.CmlConstructorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CmlParser.cmlValueSourceList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlValueSourceList([NotNull] CmlParser.CmlValueSourceListContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlLinkSource_Normal</c>
	/// labeled alternative in <see cref="CmlParser.cmlLinkSource"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlLinkSource_Normal([NotNull] CmlParser.CmlLinkSource_NormalContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlLinkSource_InsertParameter</c>
	/// labeled alternative in <see cref="CmlParser.cmlLinkSource"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlLinkSource_InsertParameter([NotNull] CmlParser.CmlLinkSource_InsertParameterContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CmlParser.cmlLinkSourceWithEntitySource"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlLinkSourceWithEntitySource([NotNull] CmlParser.CmlLinkSourceWithEntitySourceContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlFunctionSource_Normal</c>
	/// labeled alternative in <see cref="CmlParser.cmlFunctionSource"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlFunctionSource_Normal([NotNull] CmlParser.CmlFunctionSource_NormalContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlFunctionSource_InsertParameter</c>
	/// labeled alternative in <see cref="CmlParser.cmlFunctionSource"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlFunctionSource_InsertParameter([NotNull] CmlParser.CmlFunctionSource_InsertParameterContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CmlParser.cmlInsertParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlInsertParameter([NotNull] CmlParser.CmlInsertParameterContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CmlParser.cmlInfo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlInfo([NotNull] CmlParser.CmlInfoContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CmlParser.cmlInfoSetting"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlInfoSetting([NotNull] CmlParser.CmlInfoSettingContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CmlParser.cmlScriptEntry_Link"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptEntry_Link([NotNull] CmlParser.CmlScriptEntry_LinkContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CmlParser.cmlScriptEntry_Function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptEntry_Function([NotNull] CmlParser.CmlScriptEntry_FunctionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CmlParser.cmlScriptFunctionParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptFunctionParameter([NotNull] CmlParser.CmlScriptFunctionParameterContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CmlParser.cmlScriptFunctionParameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptFunctionParameters([NotNull] CmlParser.CmlScriptFunctionParametersContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptExpression_BinaryOperation_Comparative</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptExpression_BinaryOperation_Comparative([NotNull] CmlParser.CmlScriptExpression_BinaryOperation_ComparativeContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptExpression_Parenthetical</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptExpression_Parenthetical([NotNull] CmlParser.CmlScriptExpression_ParentheticalContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptExpression_Indirect</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptExpression_Indirect([NotNull] CmlParser.CmlScriptExpression_IndirectContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptExpression_BinaryOperation_Boolean</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptExpression_BinaryOperation_Boolean([NotNull] CmlParser.CmlScriptExpression_BinaryOperation_BooleanContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptExpression_BinaryOperation_Multiplicative</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptExpression_BinaryOperation_Multiplicative([NotNull] CmlParser.CmlScriptExpression_BinaryOperation_MultiplicativeContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptExpression_BinaryOperation_Additive</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptExpression_BinaryOperation_Additive([NotNull] CmlParser.CmlScriptExpression_BinaryOperation_AdditiveContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptExpression_Direct</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptExpression_Direct([NotNull] CmlParser.CmlScriptExpression_DirectContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptBinaryOperatorMultiplicative_Times</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptBinaryOperatorMultiplicative"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptBinaryOperatorMultiplicative_Times([NotNull] CmlParser.CmlScriptBinaryOperatorMultiplicative_TimesContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptBinaryOperatorMultiplicative_Divide</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptBinaryOperatorMultiplicative"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptBinaryOperatorMultiplicative_Divide([NotNull] CmlParser.CmlScriptBinaryOperatorMultiplicative_DivideContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptBinaryOperatorMultiplicative_Modulo</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptBinaryOperatorMultiplicative"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptBinaryOperatorMultiplicative_Modulo([NotNull] CmlParser.CmlScriptBinaryOperatorMultiplicative_ModuloContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptBinaryOperatorAdditive_Plus</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptBinaryOperatorAdditive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptBinaryOperatorAdditive_Plus([NotNull] CmlParser.CmlScriptBinaryOperatorAdditive_PlusContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptBinaryOperatorAdditive_Minus</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptBinaryOperatorAdditive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptBinaryOperatorAdditive_Minus([NotNull] CmlParser.CmlScriptBinaryOperatorAdditive_MinusContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptBinaryOperatorComparative_IsEqualTo</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptBinaryOperatorComparative"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptBinaryOperatorComparative_IsEqualTo([NotNull] CmlParser.CmlScriptBinaryOperatorComparative_IsEqualToContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptBinaryOperatorComparative_IsNotEqualTo</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptBinaryOperatorComparative"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptBinaryOperatorComparative_IsNotEqualTo([NotNull] CmlParser.CmlScriptBinaryOperatorComparative_IsNotEqualToContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptBinaryOperatorComparative_IsLessThan</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptBinaryOperatorComparative"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptBinaryOperatorComparative_IsLessThan([NotNull] CmlParser.CmlScriptBinaryOperatorComparative_IsLessThanContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptBinaryOperatorComparative_IsLessThanOrEqualTo</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptBinaryOperatorComparative"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptBinaryOperatorComparative_IsLessThanOrEqualTo([NotNull] CmlParser.CmlScriptBinaryOperatorComparative_IsLessThanOrEqualToContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptBinaryOperatorComparative_IsGreaterThan</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptBinaryOperatorComparative"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptBinaryOperatorComparative_IsGreaterThan([NotNull] CmlParser.CmlScriptBinaryOperatorComparative_IsGreaterThanContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptBinaryOperatorComparative_IsGreaterThanOrEqualTo</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptBinaryOperatorComparative"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptBinaryOperatorComparative_IsGreaterThanOrEqualTo([NotNull] CmlParser.CmlScriptBinaryOperatorComparative_IsGreaterThanOrEqualToContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptBinaryOperatorBoolean_Or</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptBinaryOperatorBoolean"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptBinaryOperatorBoolean_Or([NotNull] CmlParser.CmlScriptBinaryOperatorBoolean_OrContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptBinaryOperatorBoolean_And</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptBinaryOperatorBoolean"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptBinaryOperatorBoolean_And([NotNull] CmlParser.CmlScriptBinaryOperatorBoolean_AndContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptSubExpression_Constant_Int</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptSubExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptSubExpression_Constant_Int([NotNull] CmlParser.CmlScriptSubExpression_Constant_IntContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptSubExpression_Constant_Float</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptSubExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptSubExpression_Constant_Float([NotNull] CmlParser.CmlScriptSubExpression_Constant_FloatContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptSubExpression_Constant_Double</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptSubExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptSubExpression_Constant_Double([NotNull] CmlParser.CmlScriptSubExpression_Constant_DoubleContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptSubExpression_Constant_Null</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptSubExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptSubExpression_Constant_Null([NotNull] CmlParser.CmlScriptSubExpression_Constant_NullContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptSubExpression_Constant_Bool</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptSubExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptSubExpression_Constant_Bool([NotNull] CmlParser.CmlScriptSubExpression_Constant_BoolContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptSubExpression_Constant_String</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptSubExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptSubExpression_Constant_String([NotNull] CmlParser.CmlScriptSubExpression_Constant_StringContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptSubExpression_SyntheticString</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptSubExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptSubExpression_SyntheticString([NotNull] CmlParser.CmlScriptSubExpression_SyntheticStringContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptSubExpression_InsertParameter</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptSubExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptSubExpression_InsertParameter([NotNull] CmlParser.CmlScriptSubExpression_InsertParameterContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptSubExpression_ValueReference</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptSubExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptSubExpression_ValueReference([NotNull] CmlParser.CmlScriptSubExpression_ValueReferenceContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptSubExpression_InsertRepresentation</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptSubExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptSubExpression_InsertRepresentation([NotNull] CmlParser.CmlScriptSubExpression_InsertRepresentationContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptSubExpression_FunctionCall</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptSubExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptSubExpression_FunctionCall([NotNull] CmlParser.CmlScriptSubExpression_FunctionCallContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CmlParser.cmlScriptSyntheticString"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptSyntheticString([NotNull] CmlParser.CmlScriptSyntheticStringContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptInsertRepresentation_Normal</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptInsertRepresentation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptInsertRepresentation_Normal([NotNull] CmlParser.CmlScriptInsertRepresentation_NormalContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptInsertRepresentation_This</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptInsertRepresentation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptInsertRepresentation_This([NotNull] CmlParser.CmlScriptInsertRepresentation_ThisContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptValueReference_Normal</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptValueReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptValueReference_Normal([NotNull] CmlParser.CmlScriptValueReference_NormalContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptValueReference_This</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptValueReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptValueReference_This([NotNull] CmlParser.CmlScriptValueReference_ThisContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptValueReference_Parent</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptValueReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptValueReference_Parent([NotNull] CmlParser.CmlScriptValueReference_ParentContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptValueReference_ParentOfType</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptValueReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptValueReference_ParentOfType([NotNull] CmlParser.CmlScriptValueReference_ParentOfTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CmlParser.cmlScriptFunctionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptFunctionCall([NotNull] CmlParser.CmlScriptFunctionCallContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CmlParser.cmlScriptExpressionList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptExpressionList([NotNull] CmlParser.CmlScriptExpressionListContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptLambda_Single</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptLambda"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptLambda_Single([NotNull] CmlParser.CmlScriptLambda_SingleContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptLambda_Block</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptLambda"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptLambda_Block([NotNull] CmlParser.CmlScriptLambda_BlockContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptStatement_Single</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptStatement_Single([NotNull] CmlParser.CmlScriptStatement_SingleContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptStatement_Block</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptStatement_Block([NotNull] CmlParser.CmlScriptStatement_BlockContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptStatement_If</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptStatement_If([NotNull] CmlParser.CmlScriptStatement_IfContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptStatement_While</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptStatement_While([NotNull] CmlParser.CmlScriptStatement_WhileContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptSingleStatement_Assign</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptSingleStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptSingleStatement_Assign([NotNull] CmlParser.CmlScriptSingleStatement_AssignContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptSingleStatement_IndirectAssign</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptSingleStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptSingleStatement_IndirectAssign([NotNull] CmlParser.CmlScriptSingleStatement_IndirectAssignContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptSingleStatement_FunctionCall</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptSingleStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptSingleStatement_FunctionCall([NotNull] CmlParser.CmlScriptSingleStatement_FunctionCallContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>cmlScriptSingleStatement_IndirectFunctionCall</c>
	/// labeled alternative in <see cref="CmlParser.cmlScriptSingleStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptSingleStatement_IndirectFunctionCall([NotNull] CmlParser.CmlScriptSingleStatement_IndirectFunctionCallContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CmlParser.cmlScriptStatementBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCmlScriptStatementBlock([NotNull] CmlParser.CmlScriptStatementBlockContext context);
}
