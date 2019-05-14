using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public partial class Physics2DExtensions
    {
        static public IEnumerable<ContactPoint2D> GetContacts(Collider2D collider1, Collider2D collider2)
        {
            return CONTACT_POINT_POOL.UseEnumerateExpand(delegate(ContactPoint2D[] contacts) {
                return Physics2D.GetContacts(collider1, collider2, ContactFilter2DExtensions.NONE, contacts);
            });
        }

        static public IEnumerable<ContactPoint2D> GetContacts(Collider2D collider, int layer_mask = IntBits.ALL_BITS)
        {
            return OverlapColliderAll(collider, layer_mask).Convert(c => GetContacts(collider, c));
        }
    }
}