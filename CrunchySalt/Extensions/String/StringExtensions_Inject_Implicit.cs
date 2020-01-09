using System;
using System.Text;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class StringExtensions_Inject_Implicit
    {
        static private readonly OperationCache<Operation<string, object[]>, string> INJECT_IMPLICIT = TextParsingCache.Get().NewOperationCache("INJECT_IMPLICIT", delegate(string format) {
            return typeof(string).CreateDynamicMethodDelegate<Operation<string, object[]>>("FormatString", delegate(MethodBase method) {
                ILParameter array = method.GetTechnicalILParameter(0);

                return new ILReturn(
                    new ILStringExpression(format, s => array.GetILIndexed(s.ParseInt()))
                );
            });
        });
        static public string Inject(this string item, params object[] args)
        {
            return INJECT_IMPLICIT.Fetch(item)(args);
        }
    }
}