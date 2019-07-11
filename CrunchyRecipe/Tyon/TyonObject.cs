
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: 10/6/2017 11:43:24 PM

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
	public partial class TyonObject : TyonElement, TyonAddressable
	{
        public TyonObject(object obj, TyonContext_Dehydration context) : this()
        {
            context.RegisterInternalObject(obj, this);

            SetTyonType(TyonType.CreateTyonType(obj.GetType()));
            SetTyonVariables(
                context.GetDesignatedVariables(obj.GetType())
                    .Convert(v => new TyonVariable(v.CreateStrongInstance(obj), context))
            );
        }

        public void PushToSystemObject(object obj, TyonContext_Hydration context)
        {
            context.RegisterInternalObject(obj, GetTyonAddress());
            GetTyonVariables().Process(v => v.PushToSystemObject(obj, context));
        }

        public object InstanceSystemObject(TyonContext_Hydration context)
        {
            object obj = GetTyonType().InstanceSystemType();

            PushToSystemObject(obj, context);
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
            canvas.Indent();
                GetTyonVariables().Process(v => v.Render(canvas));
            canvas.Dedent();
            canvas.AppendToNewline("}");
        }

        public TyonAddress RequestAddress(TyonContext_Dehydration context)
        {
            if (GetTyonAddress() == null)
                SetTyonAddress(context.GetNewInternalAddress());

            return GetTyonAddress();
        }
	}
	
}
