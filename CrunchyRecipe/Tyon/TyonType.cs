
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: 10/6/2017 11:43:23 PM

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract partial class TyonType : TyonElement
	{
        static public TyonType CreateTyonType(Type type)
        {
            if (type.IsArray)
                return new TyonType_Array(type);

            if (type.IsGenericClass())
                return new TyonType_Direct_Templated(type);

            return new TyonType_Direct_Normal(type);
        }

        public abstract Type GetSystemType(TyonHydrater hydrater);
        public abstract object InstanceSystemType(TyonHydrater hydrater, object[] arguments);
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
