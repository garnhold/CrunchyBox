﻿using System;

namespace CrunchyNoodle
{
    public abstract class Member
    {
        private Type declaring_type;

        public Member(Type d)
        {
            declaring_type = d;
        }

        public Type GetDeclaringType()
        {
            return declaring_type;
        }
    }
}