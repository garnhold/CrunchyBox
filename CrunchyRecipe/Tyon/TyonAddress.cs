
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: February 28 2019 23:32:29 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
	public abstract partial class TyonAddress : TyonElement
	{
        public abstract void Render(TextDocumentCanvas canvas);

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
