
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: 10/6/2017 11:43:23 PM

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
	public abstract partial class TyonType : TyonElement
	{
        static public TyonType CreateTyonType(Type type)
        {
            if (type.IsGenericClass())
                return new TyonType_Templated(type);

            return new TyonType_Normal(type);
        }

        public abstract Type GetSystemType();
        public abstract void Render(TextDocumentCanvas canvas);

        public object InstanceSystemType()
        {
            return GetSystemType().CreateForcedInstance();
        }

        public string Render()
        {
            TextDocumentCanvas canvas = new TextDocumentCanvas();

            Render(canvas);
            return canvas.ToString();
        }
	}
	
}
