using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    public delegate void BasicDelegateRemover(object obj, object evt);
    public delegate void DelegateRemover<T>(object obj, T evt);

    static public class DelegateRemoverExtensions
    {
        static public DelegateRemover<T> GetTypeSafe<T>(this BasicDelegateRemover item)
        {
            return delegate(object obj, T value) {
                item(obj, value);
            };
        }
    }
}