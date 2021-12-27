
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: 10/6/2017 11:43:24 PM

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class TyonObject : TyonElement, TyonAddressable
	{
        public TyonObject(object obj, TyonDehydrater dehydrater) : this()
        {
            dehydrater.RegisterInternalObject(obj, this);

            SetTyonType(TyonType.CreateTyonType(obj.GetType()));
            SetTyonVariables(
                dehydrater.GetDesignatedVariables(obj.GetType())
                    .Convert(v => new TyonVariable(v.CreateStrongInstance(obj), dehydrater))
            );
        }

        public void PushToSystemObject(object obj, TyonHydrater hydrater)
        {
            hydrater.RegisterInternalObject(obj, GetTyonAddress());
            GetTyonVariables().Process(v => v.PushToSystemObject(obj, hydrater));
        }

        public object InstanceSystemObject(TyonHydrater hydrater)
        {
            object system_object = null;

            if (GetTyonValueList() != null)
            {
                Variable_IndexedLog log = Variable_IndexedLog.New(typeof(object));

                GetTyonValueList().PushToVariable(log, hydrater);

                system_object = GetTyonType().InstanceSystemType(hydrater, log.GetValues().ToArray());
            }
            else
            {
                system_object = GetTyonType().InstanceSystemType(hydrater, Empty.Array<object>());
            }

            return system_object.ChainIfNotNull(o => PushToSystemObject(o, hydrater));
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
                canvas.AppendToLine("&");
                GetTyonAddress().Render(canvas);
            }

            if (GetTyonValueList() != null)
            {
                canvas.AppendToLine("(");
                GetTyonValueList().Render(canvas, false);
                canvas.AppendToLine(")");
            }

            canvas.AppendToLine(" {");
            canvas.Indent();
                GetTyonVariables().Process(v => v.Render(canvas));
            canvas.Dedent();
            canvas.AppendToNewline("}");
        }

        public TyonAddress RequestAddress(TyonDehydrater dehydrater)
        {
            if (GetTyonAddress() == null)
                SetTyonAddress(dehydrater.GetNewInternalAddress());

            return GetTyonAddress();
        }

        public bool AllowsHotloading()
        {
            if (GetTyonValueList() == null)
                return true;

            return false;
        }

        public Type GetSystemType(TyonHydrater hydrater)
        {
            return GetTyonType().GetSystemType(hydrater);
        }

        public override string ToString()
        {
            return Render();
        }
	}
	
}
