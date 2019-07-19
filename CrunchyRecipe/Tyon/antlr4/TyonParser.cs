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

using System;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.1")]
[System.CLSCompliant(false)]
public partial class TyonParser : Parser {
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, NUMBER=15, STRING=16, 
		ID=17, WHITESPACE=18;
	public const int
		RULE_tyonType = 0, RULE_tyonObject = 1, RULE_tyonSurrogate = 2, RULE_tyonArray = 3, 
		RULE_tyonValue = 4, RULE_tyonAddress = 5, RULE_tyonVariable = 6;
	public static readonly string[] ruleNames = {
		"tyonType", "tyonObject", "tyonSurrogate", "tyonArray", "tyonValue", "tyonAddress", 
		"tyonVariable"
	};

	private static readonly string[] _LiteralNames = {
		null, "'<'", "','", "'>'", "'['", "']'", "'('", "'&'", "')'", "'{'", "'}'", 
		"'null'", "'@'", "'='", "';'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, "NUMBER", "STRING", "ID", "WHITESPACE"
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

	public override string SerializedAtn { get { return _serializedATN; } }

	public TyonParser(ITokenStream input)
		: base(input)
	{
		Interpreter = new ParserATNSimulator(this,_ATN);
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
				_la = TokenStream.La(1);
				while (_la==T__1) {
					{
					{
					State = 19; Match(T__1);
					State = 20; tyonType(0);
					}
					}
					State = 25;
					ErrorHandler.Sync(this);
					_la = TokenStream.La(1);
				}
				State = 26; Match(T__2);
				}
				break;
			}
			Context.Stop = TokenStream.Lt(-1);
			State = 35;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,2,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber ) {
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
			_la = TokenStream.La(1);
			if (_la==T__5) {
				{
				State = 39; Match(T__5);
				State = 40; Match(T__6);
				State = 41; tyonAddress();
				State = 42; Match(T__7);
				}
			}

			State = 54;
			_la = TokenStream.La(1);
			if (_la==T__8) {
				{
				State = 46; Match(T__8);
				State = 50;
				ErrorHandler.Sync(this);
				_la = TokenStream.La(1);
				while (_la==ID) {
					{
					{
					State = 47; tyonVariable();
					}
					}
					State = 52;
					ErrorHandler.Sync(this);
					_la = TokenStream.La(1);
				}
				State = 53; Match(T__9);
				}
			}

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
		public ITerminalNode STRING() { return GetToken(TyonParser.STRING, 0); }
		public TyonAddressContext tyonAddress() {
			return GetRuleContext<TyonAddressContext>(0);
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
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 56; tyonType(0);
			State = 62;
			_la = TokenStream.La(1);
			if (_la==T__5) {
				{
				State = 57; Match(T__5);
				State = 58; Match(T__6);
				State = 59; tyonAddress();
				State = 60; Match(T__7);
				}
			}

			State = 64; Match(T__8);
			State = 65; Match(STRING);
			State = 66; Match(T__9);
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
			State = 68; tyonType(0);
			State = 69; Match(T__3);
			State = 78;
			_la = TokenStream.La(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__6) | (1L << T__10) | (1L << T__11) | (1L << NUMBER) | (1L << STRING) | (1L << ID))) != 0)) {
				{
				State = 70; tyonValue();
				State = 75;
				ErrorHandler.Sync(this);
				_la = TokenStream.La(1);
				while (_la==T__1) {
					{
					{
					State = 71; Match(T__1);
					State = 72; tyonValue();
					}
					}
					State = 77;
					ErrorHandler.Sync(this);
					_la = TokenStream.La(1);
				}
				}
			}

			State = 80; Match(T__4);
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
	public partial class TyonValue_NumberContext : TyonValueContext {
		public ITerminalNode NUMBER() { return GetToken(TyonParser.NUMBER, 0); }
		public TyonValue_NumberContext(TyonValueContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITyonVisitor<TResult> typedVisitor = visitor as ITyonVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTyonValue_Number(this);
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
			State = 92;
			switch ( Interpreter.AdaptivePredict(TokenStream,9,Context) ) {
			case 1:
				_localctx = new TyonValue_NumberContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 82; Match(NUMBER);
				}
				break;
			case 2:
				_localctx = new TyonValue_StringContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 83; Match(STRING);
				}
				break;
			case 3:
				_localctx = new TyonValue_NullContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				State = 84; Match(T__10);
				}
				break;
			case 4:
				_localctx = new TyonValue_InternalAddressContext(_localctx);
				EnterOuterAlt(_localctx, 4);
				{
				State = 85; Match(T__6);
				State = 86; tyonAddress();
				}
				break;
			case 5:
				_localctx = new TyonValue_ExternalAddressContext(_localctx);
				EnterOuterAlt(_localctx, 5);
				{
				State = 87; Match(T__11);
				State = 88; tyonAddress();
				}
				break;
			case 6:
				_localctx = new TyonValue_ObjectContext(_localctx);
				EnterOuterAlt(_localctx, 6);
				{
				State = 89; tyonObject();
				}
				break;
			case 7:
				_localctx = new TyonValue_SurrogateContext(_localctx);
				EnterOuterAlt(_localctx, 7);
				{
				State = 90; tyonSurrogate();
				}
				break;
			case 8:
				_localctx = new TyonValue_ArrayContext(_localctx);
				EnterOuterAlt(_localctx, 8);
				{
				State = 91; tyonArray();
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
	public partial class TyonAddress_ObjectContext : TyonAddressContext {
		public TyonObjectContext tyonObject() {
			return GetRuleContext<TyonObjectContext>(0);
		}
		public TyonAddress_ObjectContext(TyonAddressContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITyonVisitor<TResult> typedVisitor = visitor as ITyonVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTyonAddress_Object(this);
			else return visitor.VisitChildren(this);
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
	public partial class TyonAddress_IntContext : TyonAddressContext {
		public ITerminalNode NUMBER() { return GetToken(TyonParser.NUMBER, 0); }
		public TyonAddress_IntContext(TyonAddressContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITyonVisitor<TResult> typedVisitor = visitor as ITyonVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTyonAddress_Int(this);
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
			State = 98;
			switch ( Interpreter.AdaptivePredict(TokenStream,10,Context) ) {
			case 1:
				_localctx = new TyonAddress_IdentifierContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 94; Match(ID);
				}
				break;
			case 2:
				_localctx = new TyonAddress_IntContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 95; Match(NUMBER);
				}
				break;
			case 3:
				_localctx = new TyonAddress_StringContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				State = 96; Match(STRING);
				}
				break;
			case 4:
				_localctx = new TyonAddress_ObjectContext(_localctx);
				EnterOuterAlt(_localctx, 4);
				{
				State = 97; tyonObject();
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
			State = 100; Match(ID);
			State = 101; Match(T__12);
			State = 102; tyonValue();
			State = 103; Match(T__13);
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

	public static readonly string _serializedATN =
		"\x3\x430\xD6D1\x8206\xAD2D\x4417\xAEF1\x8D80\xAADD\x3\x14l\x4\x2\t\x2"+
		"\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x3\x2\x3"+
		"\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\a\x2\x18\n\x2\f\x2\xE\x2\x1B\v\x2\x3"+
		"\x2\x3\x2\x5\x2\x1F\n\x2\x3\x2\x3\x2\x3\x2\a\x2$\n\x2\f\x2\xE\x2\'\v\x2"+
		"\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x5\x3/\n\x3\x3\x3\x3\x3\a\x3\x33"+
		"\n\x3\f\x3\xE\x3\x36\v\x3\x3\x3\x5\x3\x39\n\x3\x3\x4\x3\x4\x3\x4\x3\x4"+
		"\x3\x4\x3\x4\x5\x4\x41\n\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x5\x3\x5\x3\x5"+
		"\x3\x5\x3\x5\a\x5L\n\x5\f\x5\xE\x5O\v\x5\x5\x5Q\n\x5\x3\x5\x3\x5\x3\x6"+
		"\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x5\x6_\n\x6\x3"+
		"\a\x3\a\x3\a\x3\a\x5\a\x65\n\a\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x2\x3\x2"+
		"\t\x2\x4\x6\b\n\f\xE\x2\x2w\x2\x1E\x3\x2\x2\x2\x4(\x3\x2\x2\x2\x6:\x3"+
		"\x2\x2\x2\b\x46\x3\x2\x2\x2\n^\x3\x2\x2\x2\f\x64\x3\x2\x2\x2\xE\x66\x3"+
		"\x2\x2\x2\x10\x11\b\x2\x1\x2\x11\x1F\a\x13\x2\x2\x12\x13\a\x13\x2\x2\x13"+
		"\x14\a\x3\x2\x2\x14\x19\x5\x2\x2\x2\x15\x16\a\x4\x2\x2\x16\x18\x5\x2\x2"+
		"\x2\x17\x15\x3\x2\x2\x2\x18\x1B\x3\x2\x2\x2\x19\x17\x3\x2\x2\x2\x19\x1A"+
		"\x3\x2\x2\x2\x1A\x1C\x3\x2\x2\x2\x1B\x19\x3\x2\x2\x2\x1C\x1D\a\x5\x2\x2"+
		"\x1D\x1F\x3\x2\x2\x2\x1E\x10\x3\x2\x2\x2\x1E\x12\x3\x2\x2\x2\x1F%\x3\x2"+
		"\x2\x2 !\f\x3\x2\x2!\"\a\x6\x2\x2\"$\a\a\x2\x2# \x3\x2\x2\x2$\'\x3\x2"+
		"\x2\x2%#\x3\x2\x2\x2%&\x3\x2\x2\x2&\x3\x3\x2\x2\x2\'%\x3\x2\x2\x2(.\x5"+
		"\x2\x2\x2)*\a\b\x2\x2*+\a\t\x2\x2+,\x5\f\a\x2,-\a\n\x2\x2-/\x3\x2\x2\x2"+
		".)\x3\x2\x2\x2./\x3\x2\x2\x2/\x38\x3\x2\x2\x2\x30\x34\a\v\x2\x2\x31\x33"+
		"\x5\xE\b\x2\x32\x31\x3\x2\x2\x2\x33\x36\x3\x2\x2\x2\x34\x32\x3\x2\x2\x2"+
		"\x34\x35\x3\x2\x2\x2\x35\x37\x3\x2\x2\x2\x36\x34\x3\x2\x2\x2\x37\x39\a"+
		"\f\x2\x2\x38\x30\x3\x2\x2\x2\x38\x39\x3\x2\x2\x2\x39\x5\x3\x2\x2\x2:@"+
		"\x5\x2\x2\x2;<\a\b\x2\x2<=\a\t\x2\x2=>\x5\f\a\x2>?\a\n\x2\x2?\x41\x3\x2"+
		"\x2\x2@;\x3\x2\x2\x2@\x41\x3\x2\x2\x2\x41\x42\x3\x2\x2\x2\x42\x43\a\v"+
		"\x2\x2\x43\x44\a\x12\x2\x2\x44\x45\a\f\x2\x2\x45\a\x3\x2\x2\x2\x46G\x5"+
		"\x2\x2\x2GP\a\x6\x2\x2HM\x5\n\x6\x2IJ\a\x4\x2\x2JL\x5\n\x6\x2KI\x3\x2"+
		"\x2\x2LO\x3\x2\x2\x2MK\x3\x2\x2\x2MN\x3\x2\x2\x2NQ\x3\x2\x2\x2OM\x3\x2"+
		"\x2\x2PH\x3\x2\x2\x2PQ\x3\x2\x2\x2QR\x3\x2\x2\x2RS\a\a\x2\x2S\t\x3\x2"+
		"\x2\x2T_\a\x11\x2\x2U_\a\x12\x2\x2V_\a\r\x2\x2WX\a\t\x2\x2X_\x5\f\a\x2"+
		"YZ\a\xE\x2\x2Z_\x5\f\a\x2[_\x5\x4\x3\x2\\_\x5\x6\x4\x2]_\x5\b\x5\x2^T"+
		"\x3\x2\x2\x2^U\x3\x2\x2\x2^V\x3\x2\x2\x2^W\x3\x2\x2\x2^Y\x3\x2\x2\x2^"+
		"[\x3\x2\x2\x2^\\\x3\x2\x2\x2^]\x3\x2\x2\x2_\v\x3\x2\x2\x2`\x65\a\x13\x2"+
		"\x2\x61\x65\a\x11\x2\x2\x62\x65\a\x12\x2\x2\x63\x65\x5\x4\x3\x2\x64`\x3"+
		"\x2\x2\x2\x64\x61\x3\x2\x2\x2\x64\x62\x3\x2\x2\x2\x64\x63\x3\x2\x2\x2"+
		"\x65\r\x3\x2\x2\x2\x66g\a\x13\x2\x2gh\a\xF\x2\x2hi\x5\n\x6\x2ij\a\x10"+
		"\x2\x2j\xF\x3\x2\x2\x2\r\x19\x1E%.\x34\x38@MP^\x64";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
