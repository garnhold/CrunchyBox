using System;
using System.IO;

using Android;
using Android.App;
using Android.Views;
using Android.Content;
using Android.Content.Res;

using CrunchyDough;
using CrunchyNoodle;
using CrunchySack;

namespace CrunchySack_Android
{
    static public class FunctionSyncroExtensions_EventHandler
    {
        static public EventHandler GetEventHandler(this FunctionSyncro item)
        {
            if (item.GetFunction().HasNoParameters())
            {
                return delegate(object sender, EventArgs e) {
                    item.Execute();
                };
            }

            if (item.GetFunction().CanParametersHold<object, EventArgs>())
            {
                return delegate(object sender, EventArgs e) {
                    item.Execute(new object[] { sender, e });
                };
            }

            if (item.GetFunction().CanParametersHold<EventArgs>())
            {
                return delegate(object sender, EventArgs e) {
                    item.Execute(new object[] { e });
                };
            }

            throw new UnexpectedSignatureException(item.GetFunction().GetParameterTypes());
        }
    }
}