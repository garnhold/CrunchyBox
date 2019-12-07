using System;
using System.Reflection;
using System.Reflection.Emit;

namespace Crunchy.Salt
{
    static public class TypeAttributesExtensions
    {
        private const TypeAttributes _PUBLIC = TypeAttributes.Public;
        private const TypeAttributes _PRIVATE = TypeAttributes.NotPublic;
        private const TypeAttributes _STATIC = TypeAttributes.Sealed | TypeAttributes.Abstract;
        private const TypeAttributes _CLASS = TypeAttributes.Class | TypeAttributes.AutoClass | TypeAttributes.AnsiClass | TypeAttributes.AutoLayout;

        public const TypeAttributes PUBLIC_CLASS = _PUBLIC | _CLASS;
        public const TypeAttributes PRIVATE_CLASS = _PRIVATE | _CLASS;

        public const TypeAttributes STATIC_PUBLIC_CLASS = _STATIC | _PUBLIC | _CLASS;
        public const TypeAttributes STATIC_PRIVATE_CLASS = _STATIC | _PRIVATE | _CLASS;
    }
}