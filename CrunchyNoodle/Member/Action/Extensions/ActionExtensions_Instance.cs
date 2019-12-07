using System;

namespace Crunchy.Noodle
{
    using Dough;
    
    static public class ActionExtensions_Instance
    {
        static public ActionInstance CreateInstance(this Action item, TargetInstance target)
        {
            return new ActionInstance(target, item);
        }

        static public ActionInstance CreateWeakInstance(this Action item, object obj)
        {
            return item.CreateInstance(obj.GetWeakTarget());
        }

        static public ActionInstance CreateStrongInstance(this Action item, object obj)
        {
            return item.CreateInstance(obj.GetStrongTarget());
        }
    }
}