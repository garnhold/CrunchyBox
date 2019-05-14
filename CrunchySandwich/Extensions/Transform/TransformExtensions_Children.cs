﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class TransformExtensions_Children
    {
        static public Transform AddChild(this Transform item, Transform child)
        {
            child.SetParent(item, true);
            return child;
        }

        static public Transform AddChildAtSelf(this Transform item, Transform child)
        {
            item.AddChild(child).position = item.position;
            return child;
        }

        static public bool RemoveChild(this Transform item, Transform child)
        {
            if (item.GetChildren().Has(child))
            {
                child.ClearParent();
                return true;
            }

            return false;
        }

        static public bool RemoveChildAtSelf(this Transform item, Transform child)
        {
            if (item.RemoveChild(child))
            {
                child.position = item.position;
                return true;
            }

            return false;
        }

        static public IEnumerable<Transform> GetChildren(this Transform item)
        {
            return item.Bridge<Transform>();
        }
    }
}