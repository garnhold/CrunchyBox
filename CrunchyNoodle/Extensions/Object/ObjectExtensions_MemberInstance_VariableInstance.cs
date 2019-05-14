using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
	static public class ObjectExtensions_MemberInstance_VariableInstance_Weak
    {
        static public VariableInstance GetWeakVariableInstanceByComponent(this object item, string component)
        {
			return item.GetWeakTarget().GetVariableInstanceByComponent(component);
        }

        static public VariableInstance GetWeakVariableInstanceByPathAndComponent(this object item, string path, string component)
        {
            return item.GetWeakTarget().GetVariableInstanceByPathAndComponent(path, component);
        }

        static public VariableInstance GetWeakVariableInstanceByPath(this object item, string full_path)
        {
            return item.GetWeakTarget().GetVariableInstanceByPath(full_path);
        }

        static public VariableInstance GetWeakVariableInstanceByParentablePath(this object item, object parent, string full_path)
        {
            if(full_path.TryTrimPrefix("parent.", out full_path))
                return parent.GetWeakVariableInstanceByPath(full_path);

            return item.GetWeakVariableInstanceByPath(full_path);
        }
    }

	static public class ObjectExtensions_MemberInstance_VariableInstance_Strong
    {
        static public VariableInstance GetStrongVariableInstanceByComponent(this object item, string component)
        {
			return item.GetStrongTarget().GetVariableInstanceByComponent(component);
        }

        static public VariableInstance GetStrongVariableInstanceByPathAndComponent(this object item, string path, string component)
        {
            return item.GetStrongTarget().GetVariableInstanceByPathAndComponent(path, component);
        }

        static public VariableInstance GetStrongVariableInstanceByPath(this object item, string full_path)
        {
            return item.GetStrongTarget().GetVariableInstanceByPath(full_path);
        }

        static public VariableInstance GetStrongVariableInstanceByParentablePath(this object item, object parent, string full_path)
        {
            if(full_path.TryTrimPrefix("parent.", out full_path))
                return parent.GetStrongVariableInstanceByPath(full_path);

            return item.GetStrongVariableInstanceByPath(full_path);
        }
    }

}