
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: February 28 2019 23:32:29 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
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
