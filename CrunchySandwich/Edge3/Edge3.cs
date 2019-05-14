﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public struct Edge3
    {
        public readonly Vector3 v0;
        public readonly Vector3 v1;

        public Edge3(Vector3 nv0, Vector3 nv1)
        {
            v0 = nv0;
            v1 = nv1;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;

                hash = hash * 23 + v0.GetHashCodeEX();
                hash = hash * 23 + v1.GetHashCodeEX();
                return hash;
            }
        }

        public override bool Equals(object obj)
        {
            Edge3 cast;

            if (obj.Convert<Edge3>(out cast))
            {
                if (cast.v0.Equals(v0))
                {
                    if (cast.v1.Equals(v1))
                        return true;
                }
            }

            return false;
        }

        public override string ToString()
        {
            return "(" + v0 + ", " + v1 + ")";
        }
    }
}