using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    public delegate void BasicDelegateAdder(object obj, object evt);
    public delegate void DelegateAdder<T>(object obj, T evt);

    static public class DelegateAdderExtensions
    {
        static public DelegateAdder<T> GetTypeSafe<T>(this BasicDelegateAdder item)
        {
            return delegate(object obj, T value) {
                item(obj, value);
            };
        }
    }
}