//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /home/garrett/Documents/Programming/CrunchyBox/CrunchyRamen/CMinor/CMinorGrammar/CMinor.g4 by ANTLR 4.7.2

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
/// This class provides an empty implementation of <see cref="ICMinorVisitor{Result}"/>,
/// which can be extended to create a visitor which only needs to handle a subset
/// of the available methods.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.2")]
[System.CLSCompliant(false)]
public partial class CMinorBaseVisitor<Result> : AbstractParseTreeVisitor<Result>, ICMinorVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorType_Normal</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorType"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorType_Normal([NotNull] CMinorParser.CMinorType_NormalContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorType_Templated</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorType"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorType_Templated([NotNull] CMinorParser.CMinorType_TemplatedContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorType_Array</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorType"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorType_Array([NotNull] CMinorParser.CMinorType_ArrayContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CMinorParser.cMinorTypeList"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorTypeList([NotNull] CMinorParser.CMinorTypeListContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorLiteral_Null</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorLiteral"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorLiteral_Null([NotNull] CMinorParser.CMinorLiteral_NullContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorLiteral_Bool</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorLiteral"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorLiteral_Bool([NotNull] CMinorParser.CMinorLiteral_BoolContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorLiteral_Int</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorLiteral"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorLiteral_Int([NotNull] CMinorParser.CMinorLiteral_IntContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorLiteral_Float</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorLiteral"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorLiteral_Float([NotNull] CMinorParser.CMinorLiteral_FloatContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorLiteral_Double</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorLiteral"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorLiteral_Double([NotNull] CMinorParser.CMinorLiteral_DoubleContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorLiteral_String</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorLiteral"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorLiteral_String([NotNull] CMinorParser.CMinorLiteral_StringContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorExpression_DirectIdentifier</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorExpression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorExpression_DirectIdentifier([NotNull] CMinorParser.CMinorExpression_DirectIdentifierContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorExpression_InvokeGeneric</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorExpression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorExpression_InvokeGeneric([NotNull] CMinorParser.CMinorExpression_InvokeGenericContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorExpression_Literal</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorExpression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorExpression_Literal([NotNull] CMinorParser.CMinorExpression_LiteralContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorExpression_BinaryOperation_Comparative</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorExpression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorExpression_BinaryOperation_Comparative([NotNull] CMinorParser.CMinorExpression_BinaryOperation_ComparativeContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorExpression_Invoke</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorExpression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorExpression_Invoke([NotNull] CMinorParser.CMinorExpression_InvokeContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorExpression_BinaryOperation_Additive</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorExpression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorExpression_BinaryOperation_Additive([NotNull] CMinorParser.CMinorExpression_BinaryOperation_AdditiveContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorExpression_This</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorExpression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorExpression_This([NotNull] CMinorParser.CMinorExpression_ThisContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorExpression_Group</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorExpression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorExpression_Group([NotNull] CMinorParser.CMinorExpression_GroupContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorExpression_IndirectIdentifier</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorExpression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorExpression_IndirectIdentifier([NotNull] CMinorParser.CMinorExpression_IndirectIdentifierContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorExpression_BinaryOperation_Boolean</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorExpression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorExpression_BinaryOperation_Boolean([NotNull] CMinorParser.CMinorExpression_BinaryOperation_BooleanContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorExpression_Index</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorExpression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorExpression_Index([NotNull] CMinorParser.CMinorExpression_IndexContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorExpression_BinaryOperation_Multiplicative</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorExpression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorExpression_BinaryOperation_Multiplicative([NotNull] CMinorParser.CMinorExpression_BinaryOperation_MultiplicativeContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorBinaryOperator_Multiplicative_Multiply</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorBinaryOperator_Multiplicative"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorBinaryOperator_Multiplicative_Multiply([NotNull] CMinorParser.CMinorBinaryOperator_Multiplicative_MultiplyContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorBinaryOperator_Multiplicative_Divide</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorBinaryOperator_Multiplicative"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorBinaryOperator_Multiplicative_Divide([NotNull] CMinorParser.CMinorBinaryOperator_Multiplicative_DivideContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorBinaryOperator_Multiplicative_Modulo</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorBinaryOperator_Multiplicative"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorBinaryOperator_Multiplicative_Modulo([NotNull] CMinorParser.CMinorBinaryOperator_Multiplicative_ModuloContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorBinaryOperator_Additive_Add</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorBinaryOperator_Additive"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorBinaryOperator_Additive_Add([NotNull] CMinorParser.CMinorBinaryOperator_Additive_AddContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorBinaryOperator_Additive_Subtract</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorBinaryOperator_Additive"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorBinaryOperator_Additive_Subtract([NotNull] CMinorParser.CMinorBinaryOperator_Additive_SubtractContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorBinaryOperator_Comparative_LessThan</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorBinaryOperator_Comparative"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorBinaryOperator_Comparative_LessThan([NotNull] CMinorParser.CMinorBinaryOperator_Comparative_LessThanContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorBinaryOperator_Comparative_LessThanOrEqualTo</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorBinaryOperator_Comparative"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorBinaryOperator_Comparative_LessThanOrEqualTo([NotNull] CMinorParser.CMinorBinaryOperator_Comparative_LessThanOrEqualToContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorBinaryOperator_Comparative_GreaterThan</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorBinaryOperator_Comparative"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorBinaryOperator_Comparative_GreaterThan([NotNull] CMinorParser.CMinorBinaryOperator_Comparative_GreaterThanContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorBinaryOperator_Comparative_GreaterThanOrEqualTo</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorBinaryOperator_Comparative"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorBinaryOperator_Comparative_GreaterThanOrEqualTo([NotNull] CMinorParser.CMinorBinaryOperator_Comparative_GreaterThanOrEqualToContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorBinaryOperator_Comparative_EqualTo</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorBinaryOperator_Comparative"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorBinaryOperator_Comparative_EqualTo([NotNull] CMinorParser.CMinorBinaryOperator_Comparative_EqualToContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorBinaryOperator_Comparative_NotEqualTo</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorBinaryOperator_Comparative"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorBinaryOperator_Comparative_NotEqualTo([NotNull] CMinorParser.CMinorBinaryOperator_Comparative_NotEqualToContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorBinaryOperator_Boolean_And</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorBinaryOperator_Boolean"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorBinaryOperator_Boolean_And([NotNull] CMinorParser.CMinorBinaryOperator_Boolean_AndContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorBinaryOperator_Boolean_Or</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorBinaryOperator_Boolean"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorBinaryOperator_Boolean_Or([NotNull] CMinorParser.CMinorBinaryOperator_Boolean_OrContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CMinorParser.cMinorExpressionList"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorExpressionList([NotNull] CMinorParser.CMinorExpressionListContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorStatement_DirectAssign</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorStatement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorStatement_DirectAssign([NotNull] CMinorParser.CMinorStatement_DirectAssignContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorStatement_IndirectAssign</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorStatement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorStatement_IndirectAssign([NotNull] CMinorParser.CMinorStatement_IndirectAssignContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorStatement_OperationAssign_DirectAdditive</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorStatement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorStatement_OperationAssign_DirectAdditive([NotNull] CMinorParser.CMinorStatement_OperationAssign_DirectAdditiveContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorStatement_OperationAssign_DirectMultiplicative</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorStatement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorStatement_OperationAssign_DirectMultiplicative([NotNull] CMinorParser.CMinorStatement_OperationAssign_DirectMultiplicativeContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorStatement_OperationAssign_IndirectAdditive</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorStatement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorStatement_OperationAssign_IndirectAdditive([NotNull] CMinorParser.CMinorStatement_OperationAssign_IndirectAdditiveContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorStatement_OperationAssign_IndirectMultiplicative</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorStatement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorStatement_OperationAssign_IndirectMultiplicative([NotNull] CMinorParser.CMinorStatement_OperationAssign_IndirectMultiplicativeContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorStatement_InvokeGeneric</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorStatement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorStatement_InvokeGeneric([NotNull] CMinorParser.CMinorStatement_InvokeGenericContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorStatement_Invoke</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorStatement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorStatement_Invoke([NotNull] CMinorParser.CMinorStatement_InvokeContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorStatement_Block</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorStatement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorStatement_Block([NotNull] CMinorParser.CMinorStatement_BlockContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorStatement_If</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorStatement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorStatement_If([NotNull] CMinorParser.CMinorStatement_IfContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>cMinorStatement_While</c>
	/// labeled alternative in <see cref="CMinorParser.cMinorStatement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorStatement_While([NotNull] CMinorParser.CMinorStatement_WhileContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="CMinorParser.cMinorStatements"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCMinorStatements([NotNull] CMinorParser.CMinorStatementsContext context) { return VisitChildren(context); }
}
