﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public interface SerializationCorruptable
    {
        bool IsSerializationCorrupt();
    }
}