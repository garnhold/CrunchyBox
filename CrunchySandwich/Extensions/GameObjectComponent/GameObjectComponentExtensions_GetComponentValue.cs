using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class GameObjectComponentExtensions_GetComponentValue
    {
		static public J GetComponentValue<T, J>(this GameObject item, Operation<J, T> operation)
        {
            return item.GetComponent<T>().IfNotNull(operation);
        }
        static public J GetComponentValue<T, J>(this GameObject item, Operation<J, T> operation, J if_null)
        {
            return item.GetComponent<T>().IfNotNull(operation, if_null);
        }

		static public J GetComponentValueUpward<T, J>(this GameObject item, Operation<J, T> operation)
		{
			return item.GetComponentUpward<T>().IfNotNull(operation);
		}
		static public J GetComponentValueUpward<T, J>(this GameObject item, Operation<J, T> operation, J if_null)
		{
			return item.GetComponentUpward<T>().IfNotNull(operation, if_null);
		}
        
        static public J GetComponentValueUpwardFromParent<T, J>(this GameObject item, Operation<J, T> operation)
        {
            return item.GetComponentUpwardFromParent<T>().IfNotNull(operation);
        }
        static public J GetComponentValueUpwardFromParent<T, J>(this GameObject item, Operation<J, T> operation, J if_null)
        {
            return item.GetComponentUpwardFromParent<T>().IfNotNull(operation, if_null);
        }

		static public J GetComponentValue<T, J>(this Component item, Operation<J, T> operation)
        {
            return item.GetComponent<T>().IfNotNull(operation);
        }
        static public J GetComponentValue<T, J>(this Component item, Operation<J, T> operation, J if_null)
        {
            return item.GetComponent<T>().IfNotNull(operation, if_null);
        }

		static public J GetComponentValueUpward<T, J>(this Component item, Operation<J, T> operation)
		{
			return item.GetComponentUpward<T>().IfNotNull(operation);
		}
		static public J GetComponentValueUpward<T, J>(this Component item, Operation<J, T> operation, J if_null)
		{
			return item.GetComponentUpward<T>().IfNotNull(operation, if_null);
		}
        
        static public J GetComponentValueUpwardFromParent<T, J>(this Component item, Operation<J, T> operation)
        {
            return item.GetComponentUpwardFromParent<T>().IfNotNull(operation);
        }
        static public J GetComponentValueUpwardFromParent<T, J>(this Component item, Operation<J, T> operation, J if_null)
        {
            return item.GetComponentUpwardFromParent<T>().IfNotNull(operation, if_null);
        }

	}
}