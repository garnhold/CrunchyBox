
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
	public partial class TyonValue_Object : TyonValue
	{
        public TyonValue_Object(object value, TyonContext_Dehydration context) : this()
        {
            SetTyonObject(new TyonObject(value, context));
        }

        public TyonValue_Object(VariableInstance variable, TyonContext_Dehydration context) : this(variable.GetContents(), context) { }

        public override void Render(TextDocumentCanvas canvas)
        {
            GetTyonObject().Render(canvas);
        }

        public override void PushToVariable(VariableInstance variable, TyonContext_Hydration context)
        {
            if (variable.GetVariableType().IsTypicalReferenceType())
            {
                object current_value = variable.GetContents();

                if (current_value != null)
                {
                    GetTyonObject().PushToSystemObject(current_value, context);
                    return;
                }
            }

            object value = GetTyonObject().InstanceSystemObject(context);

            context.DeferProcess(delegate() {
                variable.SetContents(value);
            });
        }
	}
}
