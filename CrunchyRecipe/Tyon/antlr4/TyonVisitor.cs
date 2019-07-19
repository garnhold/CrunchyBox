//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:/Users/Garrett/Documents/Visual Studio 2013/Projects/CrunchyBox/CrunchyRecipe/Tyon/TyonGrammar\Tyon.g4 by ANTLR 4.5.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="TyonParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.1")]
[System.CLSCompliant(false)]
public interface ITyonVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by the <c>tyonType_Normal</c>
	/// labeled alternative in <see cref="TyonParser.tyonType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTyonType_Normal([NotNull] TyonParser.TyonType_NormalContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>tyonType_Array</c>
	/// labeled alternative in <see cref="TyonParser.tyonType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTyonType_Array([NotNull] TyonParser.TyonType_ArrayContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>tyonType_Templated</c>
	/// labeled alternative in <see cref="TyonParser.tyonType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTyonType_Templated([NotNull] TyonParser.TyonType_TemplatedContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TyonParser.tyonObject"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTyonObject([NotNull] TyonParser.TyonObjectContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TyonParser.tyonSurrogate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTyonSurrogate([NotNull] TyonParser.TyonSurrogateContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TyonParser.tyonArray"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTyonArray([NotNull] TyonParser.TyonArrayContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>tyonValue_Number</c>
	/// labeled alternative in <see cref="TyonParser.tyonValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTyonValue_Number([NotNull] TyonParser.TyonValue_NumberContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>tyonValue_String</c>
	/// labeled alternative in <see cref="TyonParser.tyonValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTyonValue_String([NotNull] TyonParser.TyonValue_StringContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>tyonValue_Null</c>
	/// labeled alternative in <see cref="TyonParser.tyonValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTyonValue_Null([NotNull] TyonParser.TyonValue_NullContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>tyonValue_InternalAddress</c>
	/// labeled alternative in <see cref="TyonParser.tyonValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTyonValue_InternalAddress([NotNull] TyonParser.TyonValue_InternalAddressContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>tyonValue_ExternalAddress</c>
	/// labeled alternative in <see cref="TyonParser.tyonValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTyonValue_ExternalAddress([NotNull] TyonParser.TyonValue_ExternalAddressContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>tyonValue_Object</c>
	/// labeled alternative in <see cref="TyonParser.tyonValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTyonValue_Object([NotNull] TyonParser.TyonValue_ObjectContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>tyonValue_Surrogate</c>
	/// labeled alternative in <see cref="TyonParser.tyonValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTyonValue_Surrogate([NotNull] TyonParser.TyonValue_SurrogateContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>tyonValue_Array</c>
	/// labeled alternative in <see cref="TyonParser.tyonValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTyonValue_Array([NotNull] TyonParser.TyonValue_ArrayContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>tyonAddress_Identifier</c>
	/// labeled alternative in <see cref="TyonParser.tyonAddress"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTyonAddress_Identifier([NotNull] TyonParser.TyonAddress_IdentifierContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>tyonAddress_Int</c>
	/// labeled alternative in <see cref="TyonParser.tyonAddress"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTyonAddress_Int([NotNull] TyonParser.TyonAddress_IntContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>tyonAddress_String</c>
	/// labeled alternative in <see cref="TyonParser.tyonAddress"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTyonAddress_String([NotNull] TyonParser.TyonAddress_StringContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>tyonAddress_Object</c>
	/// labeled alternative in <see cref="TyonParser.tyonAddress"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTyonAddress_Object([NotNull] TyonParser.TyonAddress_ObjectContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TyonParser.tyonVariable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTyonVariable([NotNull] TyonParser.TyonVariableContext context);
}
