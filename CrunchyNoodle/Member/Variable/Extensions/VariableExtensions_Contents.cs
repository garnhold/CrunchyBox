using System;

namespace Crunchy.Noodle
{
    using Dough;
    
    static public class VariableExtensions_Contents
    {
        static public bool ClearContents(this Variable item, object target)
        {
            return item.SetContents(target, null);
        }

        static public bool CreateContents(this Variable item, object target, Type type)
        {
            return item.SetContents(target, type.CreateBlankValue());
        }

        static public bool EnsureContents(this Variable item, object target, Type type)
        {
            object current_contents = item.GetContents(target);

            if (current_contents.GetTypeEX() != type)
                return item.SetContents(target, current_contents.ConvertEX(type) ?? type.CreateBlankValue());

            return true;
        }
    }
}