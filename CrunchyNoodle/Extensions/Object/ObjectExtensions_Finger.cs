using System;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class ObjectExtensions_Finger
    {
        static public int GetFingerPrint(this object item)
        {
            return item.GetType().GetFingerPrintOperation()(item);
        }

        static public int GetFingerPrintEX(this object item)
        {
            if (item != null)
                return item.GetFingerPrint();

            return 0;
        }

        static public bool IsFingerEquivolent(this object item, object target)
        {
            return item.GetType().GetIsFingerEquivolentOperation()(item, target);
        }

        static public bool IsFingerEquivolentEX(this object item, object target)
        {
            if (item.EqualsEX(target))
                return true;

            if (item != null)
                return item.IsFingerEquivolent(target);

            return false;
        }
    }
}