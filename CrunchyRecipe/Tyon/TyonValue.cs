
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: 10/6/2017 11:43:24 PM

using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract partial class TyonValue : TyonElement
	{
        public abstract void Render(TextDocumentCanvas canvas);
        public abstract TyonPushResult PushToVariable(VariableInstance variable, TyonHydrater hydrater);

        public virtual void CompileInitialize(TyonCompiler compiler) { }
        public abstract ILValue CompileValue(TyonCompiler compiler);

        public string Render()
        {
            TextDocumentCanvas canvas = new TextDocumentCanvas();

            Render(canvas);
            return canvas.ToString();
        }

        public override string ToString()
        {
            return Render();
        }
	}
	
}
