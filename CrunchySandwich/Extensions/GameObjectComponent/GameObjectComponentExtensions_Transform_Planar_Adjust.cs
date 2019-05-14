using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
	static public class GameObjectComponentExtensions_Transform_Planar_Adjust
    {
		static public void AdjustPlanarPosition(this GameObject item, Vector2 amount)
        {
            item.transform.AdjustPlanarPosition(amount);
        }
        static public void AdjustLocalPlanarPosition(this GameObject item, Vector2 amount)
        {
            item.transform.AdjustLocalPlanarPosition(amount);
        }
		static public void Adjust2DPosition(this GameObject item, Vector2 amount)
		{
			Rigidbody2D rigidbody = item.GetComponent<Rigidbody2D>();

			if(rigidbody != null)
				rigidbody.AdjustPosition(amount);
			else
				item.AdjustPlanarPosition(amount);
		}

        static public void AdjustPlanarRotation(this GameObject item, float amount)
        {
            item.transform.AdjustPlanarRotation(amount);
        }
        static public void AdjustLocalPlanarRotation(this GameObject item, float amount)
        {
            item.transform.AdjustLocalPlanarRotation(amount);
        }
		static public void Adjust2DRotation(this GameObject item, float amount)
		{
			Rigidbody2D rigidbody = item.GetComponent<Rigidbody2D>();

			if(rigidbody != null)
				rigidbody.AdjustRotation(amount);
			else
				item.AdjustPlanarRotation(amount);
		}

        static public void AdjustPlanarScale(this GameObject item, Vector2 amount)
        {
            item.transform.AdjustPlanarScale(amount);
        }
        static public void AdjustLocalPlanarScale(this GameObject item, Vector2 amount)
        {
            item.transform.AdjustLocalPlanarScale(amount);
        }

		static public void AdjustPlanarPosition(this Component item, Vector2 amount)
        {
            item.transform.AdjustPlanarPosition(amount);
        }
        static public void AdjustLocalPlanarPosition(this Component item, Vector2 amount)
        {
            item.transform.AdjustLocalPlanarPosition(amount);
        }
		static public void Adjust2DPosition(this Component item, Vector2 amount)
		{
			Rigidbody2D rigidbody = item.GetComponent<Rigidbody2D>();

			if(rigidbody != null)
				rigidbody.AdjustPosition(amount);
			else
				item.AdjustPlanarPosition(amount);
		}

        static public void AdjustPlanarRotation(this Component item, float amount)
        {
            item.transform.AdjustPlanarRotation(amount);
        }
        static public void AdjustLocalPlanarRotation(this Component item, float amount)
        {
            item.transform.AdjustLocalPlanarRotation(amount);
        }
		static public void Adjust2DRotation(this Component item, float amount)
		{
			Rigidbody2D rigidbody = item.GetComponent<Rigidbody2D>();

			if(rigidbody != null)
				rigidbody.AdjustRotation(amount);
			else
				item.AdjustPlanarRotation(amount);
		}

        static public void AdjustPlanarScale(this Component item, Vector2 amount)
        {
            item.transform.AdjustPlanarScale(amount);
        }
        static public void AdjustLocalPlanarScale(this Component item, Vector2 amount)
        {
            item.transform.AdjustLocalPlanarScale(amount);
        }

	}
}