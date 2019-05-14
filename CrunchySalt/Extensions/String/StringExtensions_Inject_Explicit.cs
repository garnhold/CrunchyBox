using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
	static public class StringExtensions_Inject_Explicit
	{
			
		static private readonly OperationCache<Operation<string, object>, string> INJECT_EXPLICIT1 = TextParsingCache.Get().NewOperationCache(delegate(string format) {
			return typeof(string).CreateDynamicMethodDelegate<Operation<string, object>>("FormatString", delegate(MethodBase method) {
				return new ILReturn(
					new ILStringExpression(format, s => method.GetTechnicalILParameter(s.ParseInt()))
				);
            });
        });
		static public string Inject(this string item, object arg1)
        {
            return INJECT_EXPLICIT1.Fetch(item)(arg1);
        }
			
		static private readonly OperationCache<Operation<string, object, object>, string> INJECT_EXPLICIT2 = TextParsingCache.Get().NewOperationCache(delegate(string format) {
			return typeof(string).CreateDynamicMethodDelegate<Operation<string, object, object>>("FormatString", delegate(MethodBase method) {
				return new ILReturn(
					new ILStringExpression(format, s => method.GetTechnicalILParameter(s.ParseInt()))
				);
            });
        });
		static public string Inject(this string item, object arg1, object arg2)
        {
            return INJECT_EXPLICIT2.Fetch(item)(arg1, arg2);
        }
			
		static private readonly OperationCache<Operation<string, object, object, object>, string> INJECT_EXPLICIT3 = TextParsingCache.Get().NewOperationCache(delegate(string format) {
			return typeof(string).CreateDynamicMethodDelegate<Operation<string, object, object, object>>("FormatString", delegate(MethodBase method) {
				return new ILReturn(
					new ILStringExpression(format, s => method.GetTechnicalILParameter(s.ParseInt()))
				);
            });
        });
		static public string Inject(this string item, object arg1, object arg2, object arg3)
        {
            return INJECT_EXPLICIT3.Fetch(item)(arg1, arg2, arg3);
        }
			
		static private readonly OperationCache<Operation<string, object, object, object, object>, string> INJECT_EXPLICIT4 = TextParsingCache.Get().NewOperationCache(delegate(string format) {
			return typeof(string).CreateDynamicMethodDelegate<Operation<string, object, object, object, object>>("FormatString", delegate(MethodBase method) {
				return new ILReturn(
					new ILStringExpression(format, s => method.GetTechnicalILParameter(s.ParseInt()))
				);
            });
        });
		static public string Inject(this string item, object arg1, object arg2, object arg3, object arg4)
        {
            return INJECT_EXPLICIT4.Fetch(item)(arg1, arg2, arg3, arg4);
        }
			
		static private readonly OperationCache<Operation<string, object, object, object, object, object>, string> INJECT_EXPLICIT5 = TextParsingCache.Get().NewOperationCache(delegate(string format) {
			return typeof(string).CreateDynamicMethodDelegate<Operation<string, object, object, object, object, object>>("FormatString", delegate(MethodBase method) {
				return new ILReturn(
					new ILStringExpression(format, s => method.GetTechnicalILParameter(s.ParseInt()))
				);
            });
        });
		static public string Inject(this string item, object arg1, object arg2, object arg3, object arg4, object arg5)
        {
            return INJECT_EXPLICIT5.Fetch(item)(arg1, arg2, arg3, arg4, arg5);
        }
			
		static private readonly OperationCache<Operation<string, object, object, object, object, object, object>, string> INJECT_EXPLICIT6 = TextParsingCache.Get().NewOperationCache(delegate(string format) {
			return typeof(string).CreateDynamicMethodDelegate<Operation<string, object, object, object, object, object, object>>("FormatString", delegate(MethodBase method) {
				return new ILReturn(
					new ILStringExpression(format, s => method.GetTechnicalILParameter(s.ParseInt()))
				);
            });
        });
		static public string Inject(this string item, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6)
        {
            return INJECT_EXPLICIT6.Fetch(item)(arg1, arg2, arg3, arg4, arg5, arg6);
        }
			
		static private readonly OperationCache<Operation<string, object, object, object, object, object, object, object>, string> INJECT_EXPLICIT7 = TextParsingCache.Get().NewOperationCache(delegate(string format) {
			return typeof(string).CreateDynamicMethodDelegate<Operation<string, object, object, object, object, object, object, object>>("FormatString", delegate(MethodBase method) {
				return new ILReturn(
					new ILStringExpression(format, s => method.GetTechnicalILParameter(s.ParseInt()))
				);
            });
        });
		static public string Inject(this string item, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7)
        {
            return INJECT_EXPLICIT7.Fetch(item)(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
			
		static private readonly OperationCache<Operation<string, object, object, object, object, object, object, object, object>, string> INJECT_EXPLICIT8 = TextParsingCache.Get().NewOperationCache(delegate(string format) {
			return typeof(string).CreateDynamicMethodDelegate<Operation<string, object, object, object, object, object, object, object, object>>("FormatString", delegate(MethodBase method) {
				return new ILReturn(
					new ILStringExpression(format, s => method.GetTechnicalILParameter(s.ParseInt()))
				);
            });
        });
		static public string Inject(this string item, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8)
        {
            return INJECT_EXPLICIT8.Fetch(item)(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }
			
		static private readonly OperationCache<Operation<string, object, object, object, object, object, object, object, object, object>, string> INJECT_EXPLICIT9 = TextParsingCache.Get().NewOperationCache(delegate(string format) {
			return typeof(string).CreateDynamicMethodDelegate<Operation<string, object, object, object, object, object, object, object, object, object>>("FormatString", delegate(MethodBase method) {
				return new ILReturn(
					new ILStringExpression(format, s => method.GetTechnicalILParameter(s.ParseInt()))
				);
            });
        });
		static public string Inject(this string item, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9)
        {
            return INJECT_EXPLICIT9.Fetch(item)(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }
			
		static private readonly OperationCache<Operation<string, object, object, object, object, object, object, object, object, object, object>, string> INJECT_EXPLICIT10 = TextParsingCache.Get().NewOperationCache(delegate(string format) {
			return typeof(string).CreateDynamicMethodDelegate<Operation<string, object, object, object, object, object, object, object, object, object, object>>("FormatString", delegate(MethodBase method) {
				return new ILReturn(
					new ILStringExpression(format, s => method.GetTechnicalILParameter(s.ParseInt()))
				);
            });
        });
		static public string Inject(this string item, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10)
        {
            return INJECT_EXPLICIT10.Fetch(item)(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }
		}
}