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

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.2")]
[System.CLSCompliant(false)]
public partial class TyonParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		REAL=18, INTEGER=19, STRING=20, BOOL=21, ID=22, WHITESPACE=23;
	public const int
		RULE_tyonType = 0, RULE_tyonObject = 1, RULE_tyonSurrogate = 2, RULE_tyonArray = 3, 
		RULE_tyonValue = 4, RULE_tyonAddress = 5, RULE_tyonVariable = 6;
	public static readonly string[] ruleNames = {
		"tyonType", "tyonObject", "tyonSurrogate", "tyonArray", "tyonValue", "tyonAddress", 
		"tyonVariable"
	};

	private static readonly string[] _LiteralNames = {
		null, "'<'", "','", "'>'", "'['", "']'", "'('", "'&'", "')'", "'{'", "'}'", 
		"'$'", "':'", "'null'", "'typeof'", "'@'", "'='", "';'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, "REAL", "INTEGER", "STRING", "BOOL", 
		"ID", "WHITESPACE"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Tyon.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static TyonParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public TyonParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public TyonParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class TyonTypeContext : ParserRuleContext {
		public TyonTypeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_tyonType; } }
	 
		public TyonTypeContext() { }
		public virtual void CopyFrom(TyonTypeContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class TyonType_NormalContext : TyonTypeContext {
		public ITerminalNode ID() { return GetToken(TyonParser.ID, 0); }
		public TyonType_NormalContext(TyonTypeContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITyonVisitor<TResult> typedVisitor = visitor as ITyonVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTyonType_Normal(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class TyonType_ArrayContext : TyonTypeContext {
		public TyonTypeContext tyonType() {
			return GetRuleContext<TyonTypeContext>(0);
		}
		public TyonType_ArrayContext(TyonTypeContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITyonVisitor<TResult> typedVisitor = visitor as ITyonVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTyonType_Array(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class TyonType_TemplatedContext : TyonTypeContext {
		public ITerminalNode ID() { return GetToken(TyonParser.ID, 0); }
		public TyonTypeContext[] tyonType() {
			return GetRuleContexts<TyonTypeContext>();
		}
		public TyonTypeContext tyonType(int i) {
			return GetRuleContext<TyonTypeContext>(i);
		}
		public TyonType_TemplatedContext(TyonTypeContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITyonVisitor<TResult> typedVisitor = visitor as ITyonVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTyonType_Templated(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TyonTypeContext tyonType() {
		return tyonType(0);
	}

	private TyonTypeContext tyonType(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		TyonTypeContext _localctx = new TyonTypeContext(Context, _parentState);
		TyonTypeContext _prevctx = _localctx;
		int _startState = 0;
		EnterRecursionRule(_localctx, 0, RULE_tyonType, _p);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 28;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,1,Context) ) {
			case 1:
				{
				_localctx = new TyonType_NormalContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;

				State = 15; Match(ID);
				}
				break;
			case 2:
				{
				_localctx = new TyonType_TemplatedContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 16; Match(ID);
				State = 17; Match(T__0);
				State = 18; tyonType(0);
				State = 23;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==T__1) {
					{
					{
					State = 19; Match(T__1);
					State = 20; tyonType(0);
					}
					}
					State = 25;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 26; Match(T__2);
				}
				break;
			}
			Context.Stop = TokenStream.LT(-1);
			State = 35;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,2,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new TyonType_ArrayContext(new TyonTypeContext(_parentctx, _parentState));
					PushNewRecursionContext(_localctx, _startState, RULE_tyonType);
					State = 30;
					if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
					State = 31; Match(T__3);
					State = 32; Match(T__4);
					}
					} 
				}
				State = 37;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,2,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public partial class TyonObjectContext : ParserRuleContext {
		public TyonTypeContext tyonType() {
			return GetRuleContext<TyonTypeContext>(0);
		}
		public TyonAddressContext tyonAddress() {
			return GetRuleContext<TyonAddressContext>(0);
		}
		public TyonVariableContext[] tyonVariable() {
			return GetRuleContexts<TyonVariableContext>();
		}
		public TyonVariableContext tyonVariable(int i) {
			return GetRuleContext<TyonVariableContext>(i);
		}
		public TyonObjectContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_tyonObject; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITyonVisitor<TResult> typedVisitor = visitor as ITyonVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTyonObject(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TyonObjectContext tyonObject() {
		TyonObjectContext _localctx = new TyonObjectContext(Context, State);
		EnterRule(_localctx, 2, RULE_tyonObject);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 38; tyonType(0);
			State = 44;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==T__5) {
				{
				State = 39; Match(T__5);
				State = 40; Match(T__6);
				State = 41; tyonAddress();
				State = 42; Match(T__7);
				}
			}

			State = 46; Match(T__8);
			State = 50;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==ID) {
				{
				{
				State = 47; tyonVariable();
				}
				}
				State = 52;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 53; Match(T__9);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TyonSurrogateContext : ParserRuleContext {
		public TyonTypeContext tyonType() {
			return GetRuleContext<TyonTypeContext>(0);
		}
		public TyonValueContext tyonValue() {
			return GetRuleContext<TyonValueContext>(0);
		}
		public TyonSurrogateContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_tyonSurrogate; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITyonVisitor<TResult> typedVisitor = visitor as ITyonVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTyonSurrogate(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TyonSurrogateContext tyonSurrogate() {
		TyonSurrogateContext _localctx = new TyonSurrogateContext(Context, State);
		EnterRule(_localctx, 4, RULE_tyonSurrogate);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 55; Match(T__10);
			State = 56; tyonType(0);
			State = 57; Match(T__11);
			State = 58; tyonValue();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TyonArrayContext : ParserRuleContext {
		public TyonTypeContext tyonType() {
			return GetRuleContext<TyonTypeContext>(0);
		}
		public TyonValueContext[] tyonValue() {
			return GetRuleContexts<TyonValueContext>();
		}
		public TyonValueContext tyonValue(int i) {
			return GetRuleContext<TyonValueContext>(i);
		}
		public TyonArrayContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_tyonArray; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITyonVisitor<TResult> typedVisitor = visitor as ITyonVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTyonArray(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TyonArrayContext tyonArray() {
		TyonArrayContext _localctx = new TyonArrayContext(Context, State);
		EnterRule(_localctx, 6, RULE_tyonArray);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 60; tyonType(0);
			State = 61; Match(T__3);
			State = 70;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__6) | (1L << T__10) | (1L << T__12) | (1L << T__13) | (1L << T__14) | (1L << REAL) | (1L << INTEGER) | (1L << STRING) | (1L << BOOL) | (1L << ID))) != 0)) {
				{
				State = 62; tyonValue();
				State = 67;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==T__1) {
					{
					{
					State = 63; Match(T__1);
					State = 64; tyonValue();
					}
					}
					State = 69;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				}
			}

			State = 72; Match(T__4);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TyonValueContext : ParserRuleContext {
		public TyonValueContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_tyonValue; } }
	 
		public TyonValueContext() { }
		public virtual void CopyFrom(TyonValueContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class TyonValue_InternalAddressContext : TyonValueContext {
		public TyonAddressContext tyonAddress() {
			return GetRuleContext<TyonAddressContext>(0);
		}
		public TyonValue_InternalAddressContext(TyonValueContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITyonVisitor<TResult> typedVisitor = visitor as ITyonVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTyonValue_InternalAddress(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class TyonValue_ExternalAddressContext : TyonValueContext {
		public TyonAddressContext tyonAddress() {
			return GetRuleContext<TyonAddressContext>(0);
		}
		public TyonValue_ExternalAddressContext(TyonValueContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITyonVisitor<TResult> typedVisitor = visitor as ITyonVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTyonValue_ExternalAddress(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class TyonValue_SurrogateContext : TyonValueContext {
		public TyonSurrogateContext tyonSurrogate() {
			return GetRuleContext<TyonSurrogateContext>(0);
		}
		public TyonValue_SurrogateContext(TyonValueContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITyonVisitor<TResult> typedVisitor = visitor as ITyonVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTyonValue_Surrogate(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class TyonValue_RealContext : TyonValueContext {
		public ITerminalNode REAL() { return GetToken(TyonParser.REAL, 0); }
		public TyonValue_RealContext(TyonValueContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITyonVisitor<TResult> typedVisitor = visitor as ITyonVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTyonValue_Real(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class TyonValue_ArrayContext : TyonValueContext {
		public TyonArrayContext tyonArray() {
			return GetRuleContext<TyonArrayContext>(0);
		}
		public TyonValue_ArrayContext(TyonValueContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITyonVisitor<TResult> typedVisitor = visitor as ITyonVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTyonValue_Array(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class TyonValue_ObjectContext : TyonValueContext {
		public TyonObjectContext tyonObject() {
			return GetRuleContext<TyonObjectContext>(0);
		}
		public TyonValue_ObjectContext(TyonValueContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITyonVisitor<TResult> typedVisitor = visitor as ITyonVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTyonValue_Object(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class TyonValue_IntegerContext : TyonValueContext {
		public ITerminalNode INTEGER() { return GetToken(TyonParser.INTEGER, 0); }
		public TyonValue_IntegerContext(TyonValueContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITyonVisitor<TResult> typedVisitor = visitor as ITyonVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTyonValue_Integer(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class TyonValue_BooleanContext : TyonValueContext {
		public ITerminalNode BOOL() { return GetToken(TyonParser.BOOL, 0); }
		public TyonValue_BooleanContext(TyonValueContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITyonVisitor<TResult> typedVisitor = visitor as ITyonVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTyonValue_Boolean(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class TyonValue_TypeContext : TyonValueContext {
		public TyonTypeContext tyonType() {
			return GetRuleContext<TyonTypeContext>(0);
		}
		public TyonValue_TypeContext(TyonValueContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITyonVisitor<TResult> typedVisitor = visitor as ITyonVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTyonValue_Type(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class TyonValue_NullContext : TyonValueContext {
		public TyonValue_NullContext(TyonValueContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITyonVisitor<TResult> typedVisitor = visitor as ITyonVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTyonValue_Null(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class TyonValue_StringContext : TyonValueContext {
		public ITerminalNode STRING() { return GetToken(TyonParser.STRING, 0); }
		public TyonValue_StringContext(TyonValueContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITyonVisitor<TResult> typedVisitor = visitor as ITyonVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTyonValue_String(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TyonValueContext tyonValue() {
		TyonValueContext _localctx = new TyonValueContext(Context, State);
		EnterRule(_localctx, 8, RULE_tyonValue);
		try {
			State = 91;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,7,Context) ) {
			case 1:
				_localctx = new TyonValue_IntegerContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 74; Match(INTEGER);
				}
				break;
			case 2:
				_localctx = new TyonValue_RealContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 75; Match(REAL);
				}
				break;
			case 3:
				_localctx = new TyonValue_BooleanContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				State = 76; Match(BOOL);
				}
				break;
			case 4:
				_localctx = new TyonValue_StringContext(_localctx);
				EnterOuterAlt(_localctx, 4);
				{
				State = 77; Match(STRING);
				}
				break;
			case 5:
				_localctx = new TyonValue_NullContext(_localctx);
				EnterOuterAlt(_localctx, 5);
				{
				State = 78; Match(T__12);
				}
				break;
			case 6:
				_localctx = new TyonValue_TypeContext(_localctx);
				EnterOuterAlt(_localctx, 6);
				{
				State = 79; Match(T__13);
				State = 80; Match(T__5);
				State = 81; tyonType(0);
				State = 82; Match(T__7);
				}
				break;
			case 7:
				_localctx = new TyonValue_InternalAddressContext(_localctx);
				EnterOuterAlt(_localctx, 7);
				{
				State = 84; Match(T__6);
				State = 85; tyonAddress();
				}
				break;
			case 8:
				_localctx = new TyonValue_ExternalAddressContext(_localctx);
				EnterOuterAlt(_localctx, 8);
				{
				State = 86; Match(T__14);
				State = 87; tyonAddress();
				}
				break;
			case 9:
				_localctx = new TyonValue_ObjectContext(_localctx);
				EnterOuterAlt(_localctx, 9);
				{
				State = 88; tyonObject();
				}
				break;
			case 10:
				_localctx = new TyonValue_SurrogateContext(_localctx);
				EnterOuterAlt(_localctx, 10);
				{
				State = 89; tyonSurrogate();
				}
				break;
			case 11:
				_localctx = new TyonValue_ArrayContext(_localctx);
				EnterOuterAlt(_localctx, 11);
				{
				State = 90; tyonArray();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TyonAddressContext : ParserRuleContext {
		public TyonAddressContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_tyonAddress; } }
	 
		public TyonAddressContext() { }
		public virtual void CopyFrom(TyonAddressContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class TyonAddress_IdentifierContext : TyonAddressContext {
		public ITerminalNode ID() { return GetToken(TyonParser.ID, 0); }
		public TyonAddress_IdentifierContext(TyonAddressContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITyonVisitor<TResult> typedVisitor = visitor as ITyonVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTyonAddress_Identifier(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class TyonAddress_IntegerContext : TyonAddressContext {
		public ITerminalNode INTEGER() { return GetToken(TyonParser.INTEGER, 0); }
		public TyonAddress_IntegerContext(TyonAddressContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITyonVisitor<TResult> typedVisitor = visitor as ITyonVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTyonAddress_Integer(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class TyonAddress_StringContext : TyonAddressContext {
		public ITerminalNode STRING() { return GetToken(TyonParser.STRING, 0); }
		public TyonAddress_StringContext(TyonAddressContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITyonVisitor<TResult> typedVisitor = visitor as ITyonVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTyonAddress_String(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TyonAddressContext tyonAddress() {
		TyonAddressContext _localctx = new TyonAddressContext(Context, State);
		EnterRule(_localctx, 10, RULE_tyonAddress);
		try {
			State = 96;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case ID:
				_localctx = new TyonAddress_IdentifierContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 93; Match(ID);
				}
				break;
			case INTEGER:
				_localctx = new TyonAddress_IntegerContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 94; Match(INTEGER);
				}
				break;
			case STRING:
				_localctx = new TyonAddress_StringContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				State = 95; Match(STRING);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TyonVariableContext : ParserRuleContext {
		public ITerminalNode ID() { return GetToken(TyonParser.ID, 0); }
		public TyonValueContext tyonValue() {
			return GetRuleContext<TyonValueContext>(0);
		}
		public TyonVariableContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_tyonVariable; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITyonVisitor<TResult> typedVisitor = visitor as ITyonVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTyonVariable(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TyonVariableContext tyonVariable() {
		TyonVariableContext _localctx = new TyonVariableContext(Context, State);
		EnterRule(_localctx, 12, RULE_tyonVariable);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 98; Match(ID);
			State = 99; Match(T__15);
			State = 100; tyonValue();
			State = 101; Match(T__16);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 0: return tyonType_sempred((TyonTypeContext)_localctx, predIndex);
		}
		return true;
	}
	private bool tyonType_sempred(TyonTypeContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(Context, 1);
		}
		return true;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\x19', 'j', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', 
		'\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', '\t', '\b', 
		'\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', 
		'\x3', '\x2', '\x3', '\x2', '\a', '\x2', '\x18', '\n', '\x2', '\f', '\x2', 
		'\xE', '\x2', '\x1B', '\v', '\x2', '\x3', '\x2', '\x3', '\x2', '\x5', 
		'\x2', '\x1F', '\n', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', 
		'\a', '\x2', '$', '\n', '\x2', '\f', '\x2', '\xE', '\x2', '\'', '\v', 
		'\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x5', '\x3', '/', '\n', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\a', '\x3', '\x33', '\n', '\x3', '\f', '\x3', '\xE', '\x3', '\x36', 
		'\v', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x5', '\a', '\x5', '\x44', '\n', '\x5', '\f', 
		'\x5', '\xE', '\x5', 'G', '\v', '\x5', '\x5', '\x5', 'I', '\n', '\x5', 
		'\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', 
		'\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', 
		'\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', 
		'\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x5', '\x6', 
		'^', '\n', '\x6', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x5', '\a', 
		'\x63', '\n', '\a', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', 
		'\x3', '\b', '\x3', '\b', '\x2', '\x3', '\x2', '\t', '\x2', '\x4', '\x6', 
		'\b', '\n', '\f', '\xE', '\x2', '\x2', '\x2', 'u', '\x2', '\x1E', '\x3', 
		'\x2', '\x2', '\x2', '\x4', '(', '\x3', '\x2', '\x2', '\x2', '\x6', '\x39', 
		'\x3', '\x2', '\x2', '\x2', '\b', '>', '\x3', '\x2', '\x2', '\x2', '\n', 
		']', '\x3', '\x2', '\x2', '\x2', '\f', '\x62', '\x3', '\x2', '\x2', '\x2', 
		'\xE', '\x64', '\x3', '\x2', '\x2', '\x2', '\x10', '\x11', '\b', '\x2', 
		'\x1', '\x2', '\x11', '\x1F', '\a', '\x18', '\x2', '\x2', '\x12', '\x13', 
		'\a', '\x18', '\x2', '\x2', '\x13', '\x14', '\a', '\x3', '\x2', '\x2', 
		'\x14', '\x19', '\x5', '\x2', '\x2', '\x2', '\x15', '\x16', '\a', '\x4', 
		'\x2', '\x2', '\x16', '\x18', '\x5', '\x2', '\x2', '\x2', '\x17', '\x15', 
		'\x3', '\x2', '\x2', '\x2', '\x18', '\x1B', '\x3', '\x2', '\x2', '\x2', 
		'\x19', '\x17', '\x3', '\x2', '\x2', '\x2', '\x19', '\x1A', '\x3', '\x2', 
		'\x2', '\x2', '\x1A', '\x1C', '\x3', '\x2', '\x2', '\x2', '\x1B', '\x19', 
		'\x3', '\x2', '\x2', '\x2', '\x1C', '\x1D', '\a', '\x5', '\x2', '\x2', 
		'\x1D', '\x1F', '\x3', '\x2', '\x2', '\x2', '\x1E', '\x10', '\x3', '\x2', 
		'\x2', '\x2', '\x1E', '\x12', '\x3', '\x2', '\x2', '\x2', '\x1F', '%', 
		'\x3', '\x2', '\x2', '\x2', ' ', '!', '\f', '\x3', '\x2', '\x2', '!', 
		'\"', '\a', '\x6', '\x2', '\x2', '\"', '$', '\a', '\a', '\x2', '\x2', 
		'#', ' ', '\x3', '\x2', '\x2', '\x2', '$', '\'', '\x3', '\x2', '\x2', 
		'\x2', '%', '#', '\x3', '\x2', '\x2', '\x2', '%', '&', '\x3', '\x2', '\x2', 
		'\x2', '&', '\x3', '\x3', '\x2', '\x2', '\x2', '\'', '%', '\x3', '\x2', 
		'\x2', '\x2', '(', '.', '\x5', '\x2', '\x2', '\x2', ')', '*', '\a', '\b', 
		'\x2', '\x2', '*', '+', '\a', '\t', '\x2', '\x2', '+', ',', '\x5', '\f', 
		'\a', '\x2', ',', '-', '\a', '\n', '\x2', '\x2', '-', '/', '\x3', '\x2', 
		'\x2', '\x2', '.', ')', '\x3', '\x2', '\x2', '\x2', '.', '/', '\x3', '\x2', 
		'\x2', '\x2', '/', '\x30', '\x3', '\x2', '\x2', '\x2', '\x30', '\x34', 
		'\a', '\v', '\x2', '\x2', '\x31', '\x33', '\x5', '\xE', '\b', '\x2', '\x32', 
		'\x31', '\x3', '\x2', '\x2', '\x2', '\x33', '\x36', '\x3', '\x2', '\x2', 
		'\x2', '\x34', '\x32', '\x3', '\x2', '\x2', '\x2', '\x34', '\x35', '\x3', 
		'\x2', '\x2', '\x2', '\x35', '\x37', '\x3', '\x2', '\x2', '\x2', '\x36', 
		'\x34', '\x3', '\x2', '\x2', '\x2', '\x37', '\x38', '\a', '\f', '\x2', 
		'\x2', '\x38', '\x5', '\x3', '\x2', '\x2', '\x2', '\x39', ':', '\a', '\r', 
		'\x2', '\x2', ':', ';', '\x5', '\x2', '\x2', '\x2', ';', '<', '\a', '\xE', 
		'\x2', '\x2', '<', '=', '\x5', '\n', '\x6', '\x2', '=', '\a', '\x3', '\x2', 
		'\x2', '\x2', '>', '?', '\x5', '\x2', '\x2', '\x2', '?', 'H', '\a', '\x6', 
		'\x2', '\x2', '@', '\x45', '\x5', '\n', '\x6', '\x2', '\x41', '\x42', 
		'\a', '\x4', '\x2', '\x2', '\x42', '\x44', '\x5', '\n', '\x6', '\x2', 
		'\x43', '\x41', '\x3', '\x2', '\x2', '\x2', '\x44', 'G', '\x3', '\x2', 
		'\x2', '\x2', '\x45', '\x43', '\x3', '\x2', '\x2', '\x2', '\x45', '\x46', 
		'\x3', '\x2', '\x2', '\x2', '\x46', 'I', '\x3', '\x2', '\x2', '\x2', 'G', 
		'\x45', '\x3', '\x2', '\x2', '\x2', 'H', '@', '\x3', '\x2', '\x2', '\x2', 
		'H', 'I', '\x3', '\x2', '\x2', '\x2', 'I', 'J', '\x3', '\x2', '\x2', '\x2', 
		'J', 'K', '\a', '\a', '\x2', '\x2', 'K', '\t', '\x3', '\x2', '\x2', '\x2', 
		'L', '^', '\a', '\x15', '\x2', '\x2', 'M', '^', '\a', '\x14', '\x2', '\x2', 
		'N', '^', '\a', '\x17', '\x2', '\x2', 'O', '^', '\a', '\x16', '\x2', '\x2', 
		'P', '^', '\a', '\xF', '\x2', '\x2', 'Q', 'R', '\a', '\x10', '\x2', '\x2', 
		'R', 'S', '\a', '\b', '\x2', '\x2', 'S', 'T', '\x5', '\x2', '\x2', '\x2', 
		'T', 'U', '\a', '\n', '\x2', '\x2', 'U', '^', '\x3', '\x2', '\x2', '\x2', 
		'V', 'W', '\a', '\t', '\x2', '\x2', 'W', '^', '\x5', '\f', '\a', '\x2', 
		'X', 'Y', '\a', '\x11', '\x2', '\x2', 'Y', '^', '\x5', '\f', '\a', '\x2', 
		'Z', '^', '\x5', '\x4', '\x3', '\x2', '[', '^', '\x5', '\x6', '\x4', '\x2', 
		'\\', '^', '\x5', '\b', '\x5', '\x2', ']', 'L', '\x3', '\x2', '\x2', '\x2', 
		']', 'M', '\x3', '\x2', '\x2', '\x2', ']', 'N', '\x3', '\x2', '\x2', '\x2', 
		']', 'O', '\x3', '\x2', '\x2', '\x2', ']', 'P', '\x3', '\x2', '\x2', '\x2', 
		']', 'Q', '\x3', '\x2', '\x2', '\x2', ']', 'V', '\x3', '\x2', '\x2', '\x2', 
		']', 'X', '\x3', '\x2', '\x2', '\x2', ']', 'Z', '\x3', '\x2', '\x2', '\x2', 
		']', '[', '\x3', '\x2', '\x2', '\x2', ']', '\\', '\x3', '\x2', '\x2', 
		'\x2', '^', '\v', '\x3', '\x2', '\x2', '\x2', '_', '\x63', '\a', '\x18', 
		'\x2', '\x2', '`', '\x63', '\a', '\x15', '\x2', '\x2', '\x61', '\x63', 
		'\a', '\x16', '\x2', '\x2', '\x62', '_', '\x3', '\x2', '\x2', '\x2', '\x62', 
		'`', '\x3', '\x2', '\x2', '\x2', '\x62', '\x61', '\x3', '\x2', '\x2', 
		'\x2', '\x63', '\r', '\x3', '\x2', '\x2', '\x2', '\x64', '\x65', '\a', 
		'\x18', '\x2', '\x2', '\x65', '\x66', '\a', '\x12', '\x2', '\x2', '\x66', 
		'g', '\x5', '\n', '\x6', '\x2', 'g', 'h', '\a', '\x13', '\x2', '\x2', 
		'h', '\xF', '\x3', '\x2', '\x2', '\x2', '\v', '\x19', '\x1E', '%', '.', 
		'\x34', '\x45', 'H', ']', '\x62',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
