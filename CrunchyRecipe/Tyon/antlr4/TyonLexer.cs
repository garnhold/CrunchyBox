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
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.1")]
[System.CLSCompliant(false)]
public partial class TyonLexer : Lexer {
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, NUMBER=16, 
		STRING=17, ID=18, WHITESPACE=19;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "NUMBER", "STRING", 
		"ID", "WHITESPACE"
	};


	public TyonLexer(ICharStream input)
		: base(input)
	{
		Interpreter = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "'<'", "','", "'>'", "'('", "'&'", "')'", "'{'", "'}'", "'['", "']'", 
		"'typeof'", "'null'", "'@'", "'='", "';'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, "NUMBER", "STRING", "ID", "WHITESPACE"
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

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\x430\xD6D1\x8206\xAD2D\x4417\xAEF1\x8D80\xAADD\x2\x15y\b\x1\x4\x2"+
		"\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4"+
		"\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10"+
		"\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x3\x2\x3\x2"+
		"\x3\x3\x3\x3\x3\x4\x3\x4\x3\x5\x3\x5\x3\x6\x3\x6\x3\a\x3\a\x3\b\x3\b\x3"+
		"\t\x3\t\x3\n\x3\n\x3\v\x3\v\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\r\x3"+
		"\r\x3\r\x3\r\x3\r\x3\xE\x3\xE\x3\xF\x3\xF\x3\x10\x3\x10\x3\x11\x5\x11"+
		"Q\n\x11\x3\x11\x6\x11T\n\x11\r\x11\xE\x11U\x3\x11\x3\x11\a\x11Z\n\x11"+
		"\f\x11\xE\x11]\v\x11\x5\x11_\n\x11\x3\x12\x3\x12\x3\x12\x3\x12\a\x12\x65"+
		"\n\x12\f\x12\xE\x12h\v\x12\x3\x12\x3\x12\x3\x13\x3\x13\a\x13n\n\x13\f"+
		"\x13\xE\x13q\v\x13\x3\x14\x6\x14t\n\x14\r\x14\xE\x14u\x3\x14\x3\x14\x3"+
		"\x66\x2\x15\x3\x3\x5\x4\a\x5\t\x6\v\a\r\b\xF\t\x11\n\x13\v\x15\f\x17\r"+
		"\x19\xE\x1B\xF\x1D\x10\x1F\x11!\x12#\x13%\x14\'\x15\x3\x2\a\x4\x2--//"+
		"\x3\x2\x32;\x5\x2\x43\\\x61\x61\x63|\x6\x2\x32;\x43\\\x61\x61\x63|\x5"+
		"\x2\v\f\xF\xF\"\"\x80\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2"+
		"\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2"+
		"\x2\x2\x11\x3\x2\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3"+
		"\x2\x2\x2\x2\x19\x3\x2\x2\x2\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2"+
		"\x1F\x3\x2\x2\x2\x2!\x3\x2\x2\x2\x2#\x3\x2\x2\x2\x2%\x3\x2\x2\x2\x2\'"+
		"\x3\x2\x2\x2\x3)\x3\x2\x2\x2\x5+\x3\x2\x2\x2\a-\x3\x2\x2\x2\t/\x3\x2\x2"+
		"\x2\v\x31\x3\x2\x2\x2\r\x33\x3\x2\x2\x2\xF\x35\x3\x2\x2\x2\x11\x37\x3"+
		"\x2\x2\x2\x13\x39\x3\x2\x2\x2\x15;\x3\x2\x2\x2\x17=\x3\x2\x2\x2\x19\x44"+
		"\x3\x2\x2\x2\x1BI\x3\x2\x2\x2\x1DK\x3\x2\x2\x2\x1FM\x3\x2\x2\x2!P\x3\x2"+
		"\x2\x2#`\x3\x2\x2\x2%k\x3\x2\x2\x2\'s\x3\x2\x2\x2)*\a>\x2\x2*\x4\x3\x2"+
		"\x2\x2+,\a.\x2\x2,\x6\x3\x2\x2\x2-.\a@\x2\x2.\b\x3\x2\x2\x2/\x30\a*\x2"+
		"\x2\x30\n\x3\x2\x2\x2\x31\x32\a(\x2\x2\x32\f\x3\x2\x2\x2\x33\x34\a+\x2"+
		"\x2\x34\xE\x3\x2\x2\x2\x35\x36\a}\x2\x2\x36\x10\x3\x2\x2\x2\x37\x38\a"+
		"\x7F\x2\x2\x38\x12\x3\x2\x2\x2\x39:\a]\x2\x2:\x14\x3\x2\x2\x2;<\a_\x2"+
		"\x2<\x16\x3\x2\x2\x2=>\av\x2\x2>?\a{\x2\x2?@\ar\x2\x2@\x41\ag\x2\x2\x41"+
		"\x42\aq\x2\x2\x42\x43\ah\x2\x2\x43\x18\x3\x2\x2\x2\x44\x45\ap\x2\x2\x45"+
		"\x46\aw\x2\x2\x46G\an\x2\x2GH\an\x2\x2H\x1A\x3\x2\x2\x2IJ\a\x42\x2\x2"+
		"J\x1C\x3\x2\x2\x2KL\a?\x2\x2L\x1E\x3\x2\x2\x2MN\a=\x2\x2N \x3\x2\x2\x2"+
		"OQ\t\x2\x2\x2PO\x3\x2\x2\x2PQ\x3\x2\x2\x2QS\x3\x2\x2\x2RT\t\x3\x2\x2S"+
		"R\x3\x2\x2\x2TU\x3\x2\x2\x2US\x3\x2\x2\x2UV\x3\x2\x2\x2V^\x3\x2\x2\x2"+
		"W[\a\x30\x2\x2XZ\t\x3\x2\x2YX\x3\x2\x2\x2Z]\x3\x2\x2\x2[Y\x3\x2\x2\x2"+
		"[\\\x3\x2\x2\x2\\_\x3\x2\x2\x2][\x3\x2\x2\x2^W\x3\x2\x2\x2^_\x3\x2\x2"+
		"\x2_\"\x3\x2\x2\x2`\x66\a$\x2\x2\x61\x62\a^\x2\x2\x62\x65\a$\x2\x2\x63"+
		"\x65\v\x2\x2\x2\x64\x61\x3\x2\x2\x2\x64\x63\x3\x2\x2\x2\x65h\x3\x2\x2"+
		"\x2\x66g\x3\x2\x2\x2\x66\x64\x3\x2\x2\x2gi\x3\x2\x2\x2h\x66\x3\x2\x2\x2"+
		"ij\a$\x2\x2j$\x3\x2\x2\x2ko\t\x4\x2\x2ln\t\x5\x2\x2ml\x3\x2\x2\x2nq\x3"+
		"\x2\x2\x2om\x3\x2\x2\x2op\x3\x2\x2\x2p&\x3\x2\x2\x2qo\x3\x2\x2\x2rt\t"+
		"\x6\x2\x2sr\x3\x2\x2\x2tu\x3\x2\x2\x2us\x3\x2\x2\x2uv\x3\x2\x2\x2vw\x3"+
		"\x2\x2\x2wx\b\x14\x2\x2x(\x3\x2\x2\x2\v\x2PU[^\x64\x66ou\x3\b\x2\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
