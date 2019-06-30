
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: June 29 2019 16:17:33 -07:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyCheese
{
	public partial class MExpEntry : MExpElement
	{
        private Dictionary<string, int> terms;

        static public T Compile<T>(string text, IEnumerable<string> terms)
        {
            MExpEntry entry = DOMify(text);

            entry.SetTerms(terms);
            return entry.CompileOperation<T>();
        }
        static public T Compile<T>(string text, params string[] terms)
        {
            return Compile<T>(text, (IEnumerable<string>)terms);
        }

        public T CompileOperation<T>()
        {
            return GetType().CreateDynamicMethodDelegate<T>(
                new ILReturn(GetMExpExpression().GetILValue())
            );
        }

        public void SetTerms(IEnumerable<string> t)
        {
            terms = t.ConvertToKeyOfIndexedPair().ToDictionary();
        }
        public void SetTerms(params string[] t)
        {
            SetTerms((IEnumerable<string>)t);
        }

        public int GetTermIndex(string id)
        {
            return terms.GetValue(id);
        }
	}
	
}
