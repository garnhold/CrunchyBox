using System;
using System.Reflection;
using System.Reflection.Emit;

namespace Crunchy.Salt
{
    static public class MethodAttributesExtensions
    {
        private const MethodAttributes _PUBLIC = MethodAttributes.Public;
        private const MethodAttributes _PROTECTED = MethodAttributes.Family;
        private const MethodAttributes _PRIVATE = MethodAttributes.Private;
        private const MethodAttributes _STATIC = MethodAttributes.Static;
        private const MethodAttributes _VIRTUAL = MethodAttributes.Virtual;
        private const MethodAttributes _ABSTRACT = MethodAttributes.Abstract;

        public const MethodAttributes PUBLIC = _PUBLIC;
        public const MethodAttributes PROTECTED = _PROTECTED;
        public const MethodAttributes PRIVATE = _PRIVATE;

        public const MethodAttributes ABSTRACT_PUBLIC = _ABSTRACT | _PUBLIC;
        public const MethodAttributes ABSTRACT_PROTECTED = _ABSTRACT | _PROTECTED;

        public const MethodAttributes VIRTUAL_PUBLIC = _VIRTUAL | _PUBLIC;
        public const MethodAttributes VIRTUAL_PROTECTED = _VIRTUAL | _PROTECTED;

        public const MethodAttributes STATIC_PUBLIC = _PUBLIC | _STATIC;
        public const MethodAttributes STATIC_PRIVATE = _PRIVATE | _STATIC;
    }
}