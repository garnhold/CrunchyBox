using System;
using System.Reflection;
using System.Reflection.Emit;

namespace CrunchySalt
{
    static public class FieldAttributesExtensions
    {
        private const FieldAttributes _PUBLIC = FieldAttributes.Public;
        private const FieldAttributes _PROTECTED = FieldAttributes.Family;
        private const FieldAttributes _PRIVATE = FieldAttributes.Private;

        public const FieldAttributes PUBLIC = _PUBLIC;
        public const FieldAttributes PROTECTED = _PROTECTED;
        public const FieldAttributes PRIVATE = _PRIVATE;
    }
}