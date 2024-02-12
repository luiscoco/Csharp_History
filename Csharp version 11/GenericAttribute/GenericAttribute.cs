using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAttribute
{
    // Define a generic attribute
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = false)]
    public class TypeInfoAttribute<T> : Attribute
    {
        public TypeInfoAttribute()
        {
            Type = typeof(T);
        }

        public Type Type { get; }
    }
}
