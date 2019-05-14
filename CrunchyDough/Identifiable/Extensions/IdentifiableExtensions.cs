﻿using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IdentifiableExtensions
    {
        static public string GetIdentityEX(this Identifiable item)
        {
            if (item != null)
                return item.GetIdentity();

            return "";
        }
    }
}