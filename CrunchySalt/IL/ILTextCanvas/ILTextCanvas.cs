using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
    public class ILTextCanvas : TextDocumentCanvas
    {
        private MethodBase method;

        public ILTextCanvas(MethodBase m)
        {
            method = m;
        }

        public void AppendInstruction(string instruction, string parameter)
        {
            AppendNewline();

            AppendToLine(instruction.PadRight(16));
            AppendToLine(parameter);
        }
        public void AppendInstruction(string instruction)
        {
            AppendNewline();

            AppendToLine(instruction);
        }

        public MethodBase GetMethod()
        {
            return method;
        }
    }
}