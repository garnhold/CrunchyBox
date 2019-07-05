using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
	static public class GameObjectComponentExtensions_Process
    {
		static public void ProcessComponent<T>(this GameObject item, Process<T> process)
        {
            item.GetComponent<T>().IfNotNull(process);
        }

        static public void ProcessComponentUpward<T>(this GameObject item, Process<T> process)
        {
			item.GetComponentUpward<T>().IfNotNull(process);
        }
		static public void ProcessComponentUpwardFromParent<T>(this GameObject item, Process<T> process)
		{
			item.GetComponentUpwardFromParent<T>().IfNotNull(process);
		}

		static public void ProcessComponentDownward<T>(this GameObject item, Process<T> process)
		{
			item.GetComponentDownward<T>().IfNotNull(process);
		}
		static public void ProcessComponentDownwardFromChildren<T>(this GameObject item, Process<T> process)
		{
			item.GetComponentDownwardFromChildren<T>().IfNotNull(process);
		}

		static public void ProcessComponent<T>(this Component item, Process<T> process)
        {
            item.GetComponent<T>().IfNotNull(process);
        }

        static public void ProcessComponentUpward<T>(this Component item, Process<T> process)
        {
			item.GetComponentUpward<T>().IfNotNull(process);
        }
		static public void ProcessComponentUpwardFromParent<T>(this Component item, Process<T> process)
		{
			item.GetComponentUpwardFromParent<T>().IfNotNull(process);
		}

		static public void ProcessComponentDownward<T>(this Component item, Process<T> process)
		{
			item.GetComponentDownward<T>().IfNotNull(process);
		}
		static public void ProcessComponentDownwardFromChildren<T>(this Component item, Process<T> process)
		{
			item.GetComponentDownwardFromChildren<T>().IfNotNull(process);
		}

	}
}