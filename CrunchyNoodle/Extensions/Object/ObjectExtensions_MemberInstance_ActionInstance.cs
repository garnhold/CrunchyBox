using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    	static public class ObjectExtensions_MemberInstance_ActionInstance_Weak
    {
        static public ActionInstance GetWeakActionInstanceByComponent(this object item, string component, IEnumerable<object> arguments)
        {
			return item.GetWeakTarget().GetActionInstanceByComponent(component, arguments);
        }
        static public ActionInstance GetWeakActionInstanceByComponent(this object item, string component, params object[] arguments)
        {
            return item.GetWeakActionInstanceByComponent(component, (IEnumerable<object>)arguments);
        }

        static public ActionInstance GetWeakActionInstanceByPathAndComponent(this object item, string path, string component, IEnumerable<object> arguments)
        {
			return item.GetWeakTarget().GetActionInstanceByPathAndComponent(path, component, arguments);
        }
        static public ActionInstance GetWeakActionInstanceByPathAndComponent(this object item, string path, string component, params object[] arguments)
        {
            return item.GetWeakActionInstanceByPathAndComponent(path, component, (IEnumerable<object>)arguments);
        }

        static public ActionInstance GetWeakActionInstanceByPath(this object item, string full_path, IEnumerable<object> arguments)
        {
            return item.GetWeakTarget().GetActionInstanceByPath(full_path, arguments);
        }
        static public ActionInstance GetWeakActionInstanceByPath(this object item, string full_path, params object[] arguments)
        {
            return item.GetWeakActionInstanceByPath(full_path, (IEnumerable<object>)arguments);
        }

        static public ActionInstance GetWeakActionInstanceByParentablePath(this object item, object parent, string full_path, IEnumerable<object> arguments)
        {
            if(full_path.TryTrimPrefix("parent.", out full_path))
                return parent.GetWeakActionInstanceByPath(full_path, arguments);

            return item.GetWeakActionInstanceByPath(full_path, arguments);
        }
        static public ActionInstance GetWeakActionInstanceByParentablePath(this object item, object parent, string full_path, params object[] arguments)
        {
            return item.GetWeakActionInstanceByParentablePath(parent, full_path, (IEnumerable<object>)arguments);
        }
    }

	static public class ObjectExtensions_MemberInstance_ActionInstance_Strong
    {
        static public ActionInstance GetStrongActionInstanceByComponent(this object item, string component, IEnumerable<object> arguments)
        {
			return item.GetStrongTarget().GetActionInstanceByComponent(component, arguments);
        }
        static public ActionInstance GetStrongActionInstanceByComponent(this object item, string component, params object[] arguments)
        {
            return item.GetStrongActionInstanceByComponent(component, (IEnumerable<object>)arguments);
        }

        static public ActionInstance GetStrongActionInstanceByPathAndComponent(this object item, string path, string component, IEnumerable<object> arguments)
        {
			return item.GetStrongTarget().GetActionInstanceByPathAndComponent(path, component, arguments);
        }
        static public ActionInstance GetStrongActionInstanceByPathAndComponent(this object item, string path, string component, params object[] arguments)
        {
            return item.GetStrongActionInstanceByPathAndComponent(path, component, (IEnumerable<object>)arguments);
        }

        static public ActionInstance GetStrongActionInstanceByPath(this object item, string full_path, IEnumerable<object> arguments)
        {
            return item.GetStrongTarget().GetActionInstanceByPath(full_path, arguments);
        }
        static public ActionInstance GetStrongActionInstanceByPath(this object item, string full_path, params object[] arguments)
        {
            return item.GetStrongActionInstanceByPath(full_path, (IEnumerable<object>)arguments);
        }

        static public ActionInstance GetStrongActionInstanceByParentablePath(this object item, object parent, string full_path, IEnumerable<object> arguments)
        {
            if(full_path.TryTrimPrefix("parent.", out full_path))
                return parent.GetStrongActionInstanceByPath(full_path, arguments);

            return item.GetStrongActionInstanceByPath(full_path, arguments);
        }
        static public ActionInstance GetStrongActionInstanceByParentablePath(this object item, object parent, string full_path, params object[] arguments)
        {
            return item.GetStrongActionInstanceByParentablePath(parent, full_path, (IEnumerable<object>)arguments);
        }
    }

}