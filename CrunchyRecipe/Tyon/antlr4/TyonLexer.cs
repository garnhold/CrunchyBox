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
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.2")]
[System.CLSCompliant(false)]
public partial class TyonLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, REAL=17, 
		INTEGER=18, STRING=19, BOOL=20, ID=21, WHITESPACE=22;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "REAL", 
		"INTEGER", "STRING", "BOOL", "ID", "WHITESPACE"
	};


	public TyonLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public TyonLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'<'", "','", "'>'", "'['", "']'", "'('", "'&'", "')'", "'{'", "'}'", 
		"':'", "'null'", "'typeof'", "'@'", "'='", "';'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, "REAL", "INTEGER", "STRING", "BOOL", "ID", 
		"WHITESPACE"
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

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static TyonLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x18', '\x91', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x3', '\x2', '\x3', 
		'\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', 
		'\x3', '\b', '\x3', '\b', '\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', 
		'\n', '\x3', '\v', '\x3', '\v', '\x3', '\f', '\x3', '\f', '\x3', '\r', 
		'\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\xE', '\x3', 
		'\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', 
		'\xE', '\x3', '\xF', '\x3', '\xF', '\x3', '\x10', '\x3', '\x10', '\x3', 
		'\x11', '\x3', '\x11', '\x3', '\x12', '\x5', '\x12', 'Y', '\n', '\x12', 
		'\x3', '\x12', '\x6', '\x12', '\\', '\n', '\x12', '\r', '\x12', '\xE', 
		'\x12', ']', '\x3', '\x12', '\x3', '\x12', '\x6', '\x12', '\x62', '\n', 
		'\x12', '\r', '\x12', '\xE', '\x12', '\x63', '\x3', '\x13', '\x5', '\x13', 
		'g', '\n', '\x13', '\x3', '\x13', '\x6', '\x13', 'j', '\n', '\x13', '\r', 
		'\x13', '\xE', '\x13', 'k', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', 
		'\x3', '\x14', '\a', '\x14', 'r', '\n', '\x14', '\f', '\x14', '\xE', '\x14', 
		'u', '\v', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x15', '\x3', 
		'\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', 
		'\x15', '\x3', '\x15', '\x3', '\x15', '\x5', '\x15', '\x82', '\n', '\x15', 
		'\x3', '\x16', '\x3', '\x16', '\a', '\x16', '\x86', '\n', '\x16', '\f', 
		'\x16', '\xE', '\x16', '\x89', '\v', '\x16', '\x3', '\x17', '\x6', '\x17', 
		'\x8C', '\n', '\x17', '\r', '\x17', '\xE', '\x17', '\x8D', '\x3', '\x17', 
		'\x3', '\x17', '\x3', 's', '\x2', '\x18', '\x3', '\x3', '\x5', '\x4', 
		'\a', '\x5', '\t', '\x6', '\v', '\a', '\r', '\b', '\xF', '\t', '\x11', 
		'\n', '\x13', '\v', '\x15', '\f', '\x17', '\r', '\x19', '\xE', '\x1B', 
		'\xF', '\x1D', '\x10', '\x1F', '\x11', '!', '\x12', '#', '\x13', '%', 
		'\x14', '\'', '\x15', ')', '\x16', '+', '\x17', '-', '\x18', '\x3', '\x2', 
		'\a', '\x4', '\x2', '-', '-', '/', '/', '\x3', '\x2', '\x32', ';', '\x5', 
		'\x2', '\x43', '\\', '\x61', '\x61', '\x63', '|', '\a', '\x2', '\x30', 
		'\x30', '\x32', ';', '\x43', '\\', '\x61', '\x61', '\x63', '|', '\x5', 
		'\x2', '\v', '\f', '\xF', '\xF', '\"', '\"', '\x2', '\x9A', '\x2', '\x3', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x5', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x2', '\r', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', '\x2', '\x11', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x13', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x15', '\x3', '\x2', '\x2', '\x2', '\x2', '\x17', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x19', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1B', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x1F', '\x3', '\x2', '\x2', '\x2', '\x2', '!', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '#', '\x3', '\x2', '\x2', '\x2', '\x2', '%', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\'', '\x3', '\x2', '\x2', '\x2', '\x2', ')', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '+', '\x3', '\x2', '\x2', '\x2', '\x2', '-', 
		'\x3', '\x2', '\x2', '\x2', '\x3', '/', '\x3', '\x2', '\x2', '\x2', '\x5', 
		'\x31', '\x3', '\x2', '\x2', '\x2', '\a', '\x33', '\x3', '\x2', '\x2', 
		'\x2', '\t', '\x35', '\x3', '\x2', '\x2', '\x2', '\v', '\x37', '\x3', 
		'\x2', '\x2', '\x2', '\r', '\x39', '\x3', '\x2', '\x2', '\x2', '\xF', 
		';', '\x3', '\x2', '\x2', '\x2', '\x11', '=', '\x3', '\x2', '\x2', '\x2', 
		'\x13', '?', '\x3', '\x2', '\x2', '\x2', '\x15', '\x41', '\x3', '\x2', 
		'\x2', '\x2', '\x17', '\x43', '\x3', '\x2', '\x2', '\x2', '\x19', '\x45', 
		'\x3', '\x2', '\x2', '\x2', '\x1B', 'J', '\x3', '\x2', '\x2', '\x2', '\x1D', 
		'Q', '\x3', '\x2', '\x2', '\x2', '\x1F', 'S', '\x3', '\x2', '\x2', '\x2', 
		'!', 'U', '\x3', '\x2', '\x2', '\x2', '#', 'X', '\x3', '\x2', '\x2', '\x2', 
		'%', '\x66', '\x3', '\x2', '\x2', '\x2', '\'', 'm', '\x3', '\x2', '\x2', 
		'\x2', ')', '\x81', '\x3', '\x2', '\x2', '\x2', '+', '\x83', '\x3', '\x2', 
		'\x2', '\x2', '-', '\x8B', '\x3', '\x2', '\x2', '\x2', '/', '\x30', '\a', 
		'>', '\x2', '\x2', '\x30', '\x4', '\x3', '\x2', '\x2', '\x2', '\x31', 
		'\x32', '\a', '.', '\x2', '\x2', '\x32', '\x6', '\x3', '\x2', '\x2', '\x2', 
		'\x33', '\x34', '\a', '@', '\x2', '\x2', '\x34', '\b', '\x3', '\x2', '\x2', 
		'\x2', '\x35', '\x36', '\a', ']', '\x2', '\x2', '\x36', '\n', '\x3', '\x2', 
		'\x2', '\x2', '\x37', '\x38', '\a', '_', '\x2', '\x2', '\x38', '\f', '\x3', 
		'\x2', '\x2', '\x2', '\x39', ':', '\a', '*', '\x2', '\x2', ':', '\xE', 
		'\x3', '\x2', '\x2', '\x2', ';', '<', '\a', '(', '\x2', '\x2', '<', '\x10', 
		'\x3', '\x2', '\x2', '\x2', '=', '>', '\a', '+', '\x2', '\x2', '>', '\x12', 
		'\x3', '\x2', '\x2', '\x2', '?', '@', '\a', '}', '\x2', '\x2', '@', '\x14', 
		'\x3', '\x2', '\x2', '\x2', '\x41', '\x42', '\a', '\x7F', '\x2', '\x2', 
		'\x42', '\x16', '\x3', '\x2', '\x2', '\x2', '\x43', '\x44', '\a', '<', 
		'\x2', '\x2', '\x44', '\x18', '\x3', '\x2', '\x2', '\x2', '\x45', '\x46', 
		'\a', 'p', '\x2', '\x2', '\x46', 'G', '\a', 'w', '\x2', '\x2', 'G', 'H', 
		'\a', 'n', '\x2', '\x2', 'H', 'I', '\a', 'n', '\x2', '\x2', 'I', '\x1A', 
		'\x3', '\x2', '\x2', '\x2', 'J', 'K', '\a', 'v', '\x2', '\x2', 'K', 'L', 
		'\a', '{', '\x2', '\x2', 'L', 'M', '\a', 'r', '\x2', '\x2', 'M', 'N', 
		'\a', 'g', '\x2', '\x2', 'N', 'O', '\a', 'q', '\x2', '\x2', 'O', 'P', 
		'\a', 'h', '\x2', '\x2', 'P', '\x1C', '\x3', '\x2', '\x2', '\x2', 'Q', 
		'R', '\a', '\x42', '\x2', '\x2', 'R', '\x1E', '\x3', '\x2', '\x2', '\x2', 
		'S', 'T', '\a', '?', '\x2', '\x2', 'T', ' ', '\x3', '\x2', '\x2', '\x2', 
		'U', 'V', '\a', '=', '\x2', '\x2', 'V', '\"', '\x3', '\x2', '\x2', '\x2', 
		'W', 'Y', '\t', '\x2', '\x2', '\x2', 'X', 'W', '\x3', '\x2', '\x2', '\x2', 
		'X', 'Y', '\x3', '\x2', '\x2', '\x2', 'Y', '[', '\x3', '\x2', '\x2', '\x2', 
		'Z', '\\', '\t', '\x3', '\x2', '\x2', '[', 'Z', '\x3', '\x2', '\x2', '\x2', 
		'\\', ']', '\x3', '\x2', '\x2', '\x2', ']', '[', '\x3', '\x2', '\x2', 
		'\x2', ']', '^', '\x3', '\x2', '\x2', '\x2', '^', '_', '\x3', '\x2', '\x2', 
		'\x2', '_', '\x61', '\a', '\x30', '\x2', '\x2', '`', '\x62', '\t', '\x3', 
		'\x2', '\x2', '\x61', '`', '\x3', '\x2', '\x2', '\x2', '\x62', '\x63', 
		'\x3', '\x2', '\x2', '\x2', '\x63', '\x61', '\x3', '\x2', '\x2', '\x2', 
		'\x63', '\x64', '\x3', '\x2', '\x2', '\x2', '\x64', '$', '\x3', '\x2', 
		'\x2', '\x2', '\x65', 'g', '\t', '\x2', '\x2', '\x2', '\x66', '\x65', 
		'\x3', '\x2', '\x2', '\x2', '\x66', 'g', '\x3', '\x2', '\x2', '\x2', 'g', 
		'i', '\x3', '\x2', '\x2', '\x2', 'h', 'j', '\t', '\x3', '\x2', '\x2', 
		'i', 'h', '\x3', '\x2', '\x2', '\x2', 'j', 'k', '\x3', '\x2', '\x2', '\x2', 
		'k', 'i', '\x3', '\x2', '\x2', '\x2', 'k', 'l', '\x3', '\x2', '\x2', '\x2', 
		'l', '&', '\x3', '\x2', '\x2', '\x2', 'm', 's', '\a', '$', '\x2', '\x2', 
		'n', 'o', '\a', '^', '\x2', '\x2', 'o', 'r', '\a', '$', '\x2', '\x2', 
		'p', 'r', '\v', '\x2', '\x2', '\x2', 'q', 'n', '\x3', '\x2', '\x2', '\x2', 
		'q', 'p', '\x3', '\x2', '\x2', '\x2', 'r', 'u', '\x3', '\x2', '\x2', '\x2', 
		's', 't', '\x3', '\x2', '\x2', '\x2', 's', 'q', '\x3', '\x2', '\x2', '\x2', 
		't', 'v', '\x3', '\x2', '\x2', '\x2', 'u', 's', '\x3', '\x2', '\x2', '\x2', 
		'v', 'w', '\a', '$', '\x2', '\x2', 'w', '(', '\x3', '\x2', '\x2', '\x2', 
		'x', 'y', '\a', 'v', '\x2', '\x2', 'y', 'z', '\a', 't', '\x2', '\x2', 
		'z', '{', '\a', 'w', '\x2', '\x2', '{', '\x82', '\a', 'g', '\x2', '\x2', 
		'|', '}', '\a', 'h', '\x2', '\x2', '}', '~', '\a', '\x63', '\x2', '\x2', 
		'~', '\x7F', '\a', 'n', '\x2', '\x2', '\x7F', '\x80', '\a', 'u', '\x2', 
		'\x2', '\x80', '\x82', '\a', 'g', '\x2', '\x2', '\x81', 'x', '\x3', '\x2', 
		'\x2', '\x2', '\x81', '|', '\x3', '\x2', '\x2', '\x2', '\x82', '*', '\x3', 
		'\x2', '\x2', '\x2', '\x83', '\x87', '\t', '\x4', '\x2', '\x2', '\x84', 
		'\x86', '\t', '\x5', '\x2', '\x2', '\x85', '\x84', '\x3', '\x2', '\x2', 
		'\x2', '\x86', '\x89', '\x3', '\x2', '\x2', '\x2', '\x87', '\x85', '\x3', 
		'\x2', '\x2', '\x2', '\x87', '\x88', '\x3', '\x2', '\x2', '\x2', '\x88', 
		',', '\x3', '\x2', '\x2', '\x2', '\x89', '\x87', '\x3', '\x2', '\x2', 
		'\x2', '\x8A', '\x8C', '\t', '\x6', '\x2', '\x2', '\x8B', '\x8A', '\x3', 
		'\x2', '\x2', '\x2', '\x8C', '\x8D', '\x3', '\x2', '\x2', '\x2', '\x8D', 
		'\x8B', '\x3', '\x2', '\x2', '\x2', '\x8D', '\x8E', '\x3', '\x2', '\x2', 
		'\x2', '\x8E', '\x8F', '\x3', '\x2', '\x2', '\x2', '\x8F', '\x90', '\b', 
		'\x17', '\x2', '\x2', '\x90', '.', '\x3', '\x2', '\x2', '\x2', '\r', '\x2', 
		'X', ']', '\x63', '\x66', 'k', 'q', 's', '\x81', '\x87', '\x8D', '\x3', 
		'\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
