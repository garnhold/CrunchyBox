using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class UnknownSymbolException : ApplicationException
    {
        private string text;
        private int index;

        public UnknownSymbolException(string t, int i)
        {
            text = t;
            index = i;
        }

        public override string Message
        {
            get
            {
                return "An unknown symbol(" + GetSymbol() + ") was encounted on line " + GetLineNumber() + ": " + GetLine();
            }
        }

        public char GetSymbol()
        {
            return text[index];
        }

        public string GetLine()
        {
            return text.GetLineAt(index);
        }

        public int GetLineNumber()
        {
            return text.GetLineNumberAt(index);
        }
    }
}