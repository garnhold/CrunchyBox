using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Gtk;

namespace Crunchy.Sack_Gtk
{
    using Dough;
    using Noodle;
    using Sack;
    
    static public class WindowExtensions_AccelGroup
    {
        static private readonly AttachedObjectField<Window, AccelGroup> BASIC_ACCEL_GROUP_FIELD = new AttachedObjectField<Window, AccelGroup>(delegate (Window window) {
            AccelGroup accel_group = new AccelGroup();

            window.AddAccelGroup(accel_group);
            return accel_group;
        });

        static public AccelGroup GetBasicAccelGroup(this Window item)
        {
            return BASIC_ACCEL_GROUP_FIELD.GetValue(item);
        }
    }
}