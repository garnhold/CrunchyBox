
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: 10/6/2017 11:43:24 PM

using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
	public abstract partial class TyonValue : TyonElement
	{
        public abstract void Render(TextDocumentCanvas canvas);
        public abstract void PushToVariable(VariableInstance variable, TyonHydrater hydrater);

        public string Render()
        {
            TextDocumentCanvas canvas = new TextDocumentCanvas();

            Render(canvas);
            return canvas.ToString();
        }
	}
	
}
