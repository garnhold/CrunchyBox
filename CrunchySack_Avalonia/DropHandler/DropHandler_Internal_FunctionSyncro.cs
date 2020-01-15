using System;
using System.IO;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;

namespace Crunchy.Sack_Avalonia
{
    using Dough;
    using Noodle;
    using Sack;
    using System;
    
    public class DropHandler_Internal_FunctionSyncro : DropHandler_Internal
    {
        private FunctionSyncro on_enter;
        private FunctionSyncro on_over;
        private FunctionSyncro on_leave;

        private FunctionSyncro on_drop;

        protected override bool OnEnterInternal(Point point, object obj)
        {
            return Execute(on_enter, point, obj);
        }

        protected override bool OnOverInternal(Point point, object obj)
        {
            return Execute(on_over, point, obj);
        }

        protected override bool OnLeaveInternal(Point point, object obj)
        {
            return Execute(on_leave, point, obj);
        }

        protected override bool OnDropInternal(Point point, object obj)
        {
            return Execute(on_drop, point, obj);
        }

        private bool Execute(FunctionSyncro syncro, Point point, object obj)
        {
            if(syncro != null)
            {
                Type type = syncro.GetFunction().GetParameterType(0);
                object converted_obj = obj.ConvertEX(type);

                if (converted_obj != null)
                {
                    if (syncro.GetFunction().CanParametersHold(type))
                    {
                        syncro.Execute(new object[] { converted_obj });
                        return true;
                    }

                    if (syncro.GetFunction().CanParametersHold(type, typeof(Point)))
                    {
                        syncro.Execute(new object[] { converted_obj, point});
                        return true;
                    }

                    throw new UnexpectedSignatureException(syncro.GetFunction().GetParameterTypes());
                }
            }

            return false;
        }

        public DropHandler_Internal_FunctionSyncro()
        {
        }

        public void SetOnEnter(FunctionSyncro f)
        {
            on_enter = f;
        }

        public void SetOnOver(FunctionSyncro f)
        {
            on_over = f;
        }

        public void SetOnLeave(FunctionSyncro f)
        {
            on_leave = f;
        }

        public void SetOnDrop(FunctionSyncro f)
        {
            on_drop = f;
        }

        public FunctionSyncro GetOnEnter()
        {
            return on_enter;
        }

        public FunctionSyncro GetOnOver()
        {
            return on_over;
        }

        public FunctionSyncro GetOnLeave()
        {
            return on_leave;
        }

        public FunctionSyncro GetOnDrop()
        {
            return on_drop;
        }
    }
}