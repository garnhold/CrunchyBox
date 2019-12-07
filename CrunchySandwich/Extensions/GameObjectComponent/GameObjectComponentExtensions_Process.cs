using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class GameObjectComponentExtensions_Process
    {
		static public void ProcessComponent<T>(this GameObject item, Process<T> process)
        {
            item.GetComponent<T>().IfNotNull(process);
        }

		static public void ProcessComponents<T>(this GameObject item, Process<T> process)
		{
			item.GetComponents<T>().Process(process);
		}

        static public void ProcessComponentUpward<T>(this GameObject item, Process<T> process)
        {
			item.GetComponentUpward<T>().IfNotNull(process);
        }
		static public void ProcessComponentUpwardFromParent<T>(this GameObject item, Process<T> process)
		{
			item.GetComponentUpwardFromParent<T>().IfNotNull(process);
		}

		static public void ProcessComponentsUpward<T>(this GameObject item, Process<T> process)
		{
			item.GetComponentsUpward<T>().Process(process);
		}
		static public void ProcessComponentsUpwardFromParent<T>(this GameObject item, Process<T> process)
		{
			item.GetComponentsUpwardFromParent<T>().Process(process);
		}

		static public void ProcessComponentDownward<T>(this GameObject item, Process<T> process)
		{
			item.GetComponentDownward<T>().IfNotNull(process);
		}
		static public void ProcessComponentDownwardFromChildren<T>(this GameObject item, Process<T> process)
		{
			item.GetComponentDownwardFromChildren<T>().IfNotNull(process);
		}

		static public void ProcessComponentsDownward<T>(this GameObject item, Process<T> process)
		{
			item.GetComponentsDownward<T>().Process(process);
		}
		static public void ProcessComponentsDownwardFromChildren<T>(this GameObject item, Process<T> process)
		{
			item.GetComponentsDownwardFromChildren<T>().Process(process);
		}

		static public void ProcessComponent<T>(this Component item, Process<T> process)
        {
            item.GetComponent<T>().IfNotNull(process);
        }

		static public void ProcessComponents<T>(this Component item, Process<T> process)
		{
			item.GetComponents<T>().Process(process);
		}

        static public void ProcessComponentUpward<T>(this Component item, Process<T> process)
        {
			item.GetComponentUpward<T>().IfNotNull(process);
        }
		static public void ProcessComponentUpwardFromParent<T>(this Component item, Process<T> process)
		{
			item.GetComponentUpwardFromParent<T>().IfNotNull(process);
		}

		static public void ProcessComponentsUpward<T>(this Component item, Process<T> process)
		{
			item.GetComponentsUpward<T>().Process(process);
		}
		static public void ProcessComponentsUpwardFromParent<T>(this Component item, Process<T> process)
		{
			item.GetComponentsUpwardFromParent<T>().Process(process);
		}

		static public void ProcessComponentDownward<T>(this Component item, Process<T> process)
		{
			item.GetComponentDownward<T>().IfNotNull(process);
		}
		static public void ProcessComponentDownwardFromChildren<T>(this Component item, Process<T> process)
		{
			item.GetComponentDownwardFromChildren<T>().IfNotNull(process);
		}

		static public void ProcessComponentsDownward<T>(this Component item, Process<T> process)
		{
			item.GetComponentsDownward<T>().Process(process);
		}
		static public void ProcessComponentsDownwardFromChildren<T>(this Component item, Process<T> process)
		{
			item.GetComponentsDownwardFromChildren<T>().Process(process);
		}

	}
}