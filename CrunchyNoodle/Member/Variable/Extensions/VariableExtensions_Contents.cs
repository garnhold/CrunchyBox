using System;

namespace Crunchy.Noodle
{
    using Dough;
    
    static public class VariableExtensions_Contents
    {
        static public ValueChangeResult ClearContents(this Variable item, object target)
        {
            return item.ChangeContents(target, null);
        }

        static public ValueChangeResult CreateContents(this Variable item, object target, Type type)
        {
            return item.ChangeContents(target, type.CreateBlankValue());
        }

        static public ValueChangeResult EnsureContents(this Variable item, object target, Type type)
        {
            object current_contents = item.GetContents(target);

            if (current_contents.GetTypeEX() != type)
                return item.ChangeContents(target, current_contents.ConvertEX(type) ?? type.CreateBlankValue());

            return ValueChangeResult.SuccessUnchanged;
        }
    }
}