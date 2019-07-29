
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
	public partial class TyonSurrogate : TyonElement, TyonAddressable
	{
        private void LoadContextIntermediateString(string input)
        {
            SetString(input.ExtractStringValueFromLiteralString());
        }

        public TyonSurrogate(object obj, TyonDehydrater dehydrater) : this()
        {
            dehydrater.RegisterInternalObject(obj, this);

            SetTyonType(TyonType.CreateTyonType(obj.GetType()));
            SetString(obj.ToStringEX());
        }

        public object InstanceSystemObject(TyonHydrater hydrater)
        {
            object obj = GetString().ConvertEX(GetTyonType().GetSystemType());

            if (obj == null)
                obj = GetTyonType().InstanceSystemType();

            hydrater.RegisterInternalObject(obj, GetTyonAddress());
            return obj;
        }

        public string Render()
        {
            TextDocumentCanvas canvas = new TextDocumentCanvas();

            Render(canvas);
            return canvas.ToString();
        }

        public void Render(TextDocumentCanvas canvas)
        {
            GetTyonType().Render(canvas);

            if (GetTyonAddress() != null)
            {
                canvas.AppendToLine("(&");
                GetTyonAddress().Render(canvas);
                canvas.AppendToLine(")");
            }

            canvas.AppendToLine(" {");
                canvas.AppendToLine(GetString().StyleAsLiteralString());
            canvas.AppendToLine("}");
        }

        public TyonAddress RequestAddress(TyonDehydrater dehydrater)
        {
            if (GetTyonAddress() == null)
                SetTyonAddress(dehydrater.GetNewInternalAddress());

            return GetTyonAddress();
        }
	}
	
}
