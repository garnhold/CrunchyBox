
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: March 02 2019 21:52:08 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
	public partial class TyonSurrogate : TyonElement
	{
        public TyonSurrogate(Type type, object surrogate, TyonDehydrater dehydrater) : this()
        {
            SetTyonType(TyonType.CreateTyonType(type));
            SetTyonAddress(dehydrater.CreateTyonAddress(surrogate));
        }

        public object ResolveSystemObject(TyonHydrater hydrater)
        {
            Type type = GetTyonType().GetSystemType(hydrater);
            object surrogate = GetTyonAddress().GetAddressValue(hydrater);

            return hydrater.GetContext()
                .GetSettings()
                .GetTypeResolver(type)
                .ResolveSurrogate(type, surrogate, hydrater);
        }

        public string Render()
        {
            TextDocumentCanvas canvas = new TextDocumentCanvas();

            Render(canvas);
            return canvas.ToString();
        }

        public void Render(TextDocumentCanvas canvas)
        {
            canvas.AppendToLine("$");
            GetTyonType().Render(canvas);
            canvas.AppendToLine(":");
            GetTyonAddress().Render(canvas);
        }

        public override string ToString()
        {
            return Render();
        }
	}
	
}
