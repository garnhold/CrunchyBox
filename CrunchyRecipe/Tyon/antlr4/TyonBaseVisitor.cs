//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /home/garrett/Documents/Programming/CrunchyBox/CrunchyRecipe/Tyon/TyonGrammar/Tyon.g4 by ANTLR 4.7.2

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
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="ITyonVisitor{Result}"/>,
/// which can be extended to create a visitor which only needs to handle a subset
/// of the available methods.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.2")]
[System.CLSCompliant(false)]
public partial class TyonBaseVisitor<Result> : AbstractParseTreeVisitor<Result>, ITyonVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by the <c>tyonType_Normal</c>
	/// labeled alternative in <see cref="TyonParser.tyonType"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTyonType_Normal([NotNull] TyonParser.TyonType_NormalContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>tyonType_Array</c>
	/// labeled alternative in <see cref="TyonParser.tyonType"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTyonType_Array([NotNull] TyonParser.TyonType_ArrayContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>tyonType_Templated</c>
	/// labeled alternative in <see cref="TyonParser.tyonType"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTyonType_Templated([NotNull] TyonParser.TyonType_TemplatedContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="TyonParser.tyonObject"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTyonObject([NotNull] TyonParser.TyonObjectContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="TyonParser.tyonSurrogate"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTyonSurrogate([NotNull] TyonParser.TyonSurrogateContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="TyonParser.tyonArray"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTyonArray([NotNull] TyonParser.TyonArrayContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="TyonParser.tyonValueList"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTyonValueList([NotNull] TyonParser.TyonValueListContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>tyonValue_Int</c>
	/// labeled alternative in <see cref="TyonParser.tyonValue"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTyonValue_Int([NotNull] TyonParser.TyonValue_IntContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>tyonValue_Long</c>
	/// labeled alternative in <see cref="TyonParser.tyonValue"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTyonValue_Long([NotNull] TyonParser.TyonValue_LongContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>tyonValue_Float</c>
	/// labeled alternative in <see cref="TyonParser.tyonValue"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTyonValue_Float([NotNull] TyonParser.TyonValue_FloatContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>tyonValue_Double</c>
	/// labeled alternative in <see cref="TyonParser.tyonValue"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTyonValue_Double([NotNull] TyonParser.TyonValue_DoubleContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>tyonValue_Decimal</c>
	/// labeled alternative in <see cref="TyonParser.tyonValue"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTyonValue_Decimal([NotNull] TyonParser.TyonValue_DecimalContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>tyonValue_Boolean</c>
	/// labeled alternative in <see cref="TyonParser.tyonValue"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTyonValue_Boolean([NotNull] TyonParser.TyonValue_BooleanContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>tyonValue_String</c>
	/// labeled alternative in <see cref="TyonParser.tyonValue"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTyonValue_String([NotNull] TyonParser.TyonValue_StringContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>tyonValue_Null</c>
	/// labeled alternative in <see cref="TyonParser.tyonValue"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTyonValue_Null([NotNull] TyonParser.TyonValue_NullContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>tyonValue_Type</c>
	/// labeled alternative in <see cref="TyonParser.tyonValue"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTyonValue_Type([NotNull] TyonParser.TyonValue_TypeContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>tyonValue_InternalAddress</c>
	/// labeled alternative in <see cref="TyonParser.tyonValue"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTyonValue_InternalAddress([NotNull] TyonParser.TyonValue_InternalAddressContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>tyonValue_ExternalAddress</c>
	/// labeled alternative in <see cref="TyonParser.tyonValue"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTyonValue_ExternalAddress([NotNull] TyonParser.TyonValue_ExternalAddressContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>tyonValue_Array</c>
	/// labeled alternative in <see cref="TyonParser.tyonValue"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTyonValue_Array([NotNull] TyonParser.TyonValue_ArrayContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>tyonValue_Object</c>
	/// labeled alternative in <see cref="TyonParser.tyonValue"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTyonValue_Object([NotNull] TyonParser.TyonValue_ObjectContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>tyonValue_Surrogate</c>
	/// labeled alternative in <see cref="TyonParser.tyonValue"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTyonValue_Surrogate([NotNull] TyonParser.TyonValue_SurrogateContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>tyonAddress_Identifier</c>
	/// labeled alternative in <see cref="TyonParser.tyonAddress"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTyonAddress_Identifier([NotNull] TyonParser.TyonAddress_IdentifierContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>tyonAddress_Int</c>
	/// labeled alternative in <see cref="TyonParser.tyonAddress"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTyonAddress_Int([NotNull] TyonParser.TyonAddress_IntContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>tyonAddress_String</c>
	/// labeled alternative in <see cref="TyonParser.tyonAddress"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTyonAddress_String([NotNull] TyonParser.TyonAddress_StringContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="TyonParser.tyonVariable"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTyonVariable([NotNull] TyonParser.TyonVariableContext context) { return VisitChildren(context); }
}
