using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Newtonsoft.Json
{
    /// <summary>
    /// PlazSoft modified.
    /// 
    /// This attribute is honored by our modified JSON.NET converter,
    /// and indicates that the given type should not be converted by
    /// TypeConverter -> to string, even if it is available.
    /// 
    /// See Serialization/DefaultContractResolver.cs, line 1003, CanConvertToString(Type type)
    /// in MODIFIED JSON.NET for the other side of this implementation.
    /// </summary>
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Interface, AllowMultiple = false)]
    public class JsonNoToStringAttribute : Attribute
    {
    }

    /// <summary>
    /// PlazSoft modified.
    /// 
    /// This interface indicates that the type covnerter implementing
    /// it should not be used for serializing as a string.
    /// </summary>
    public interface IJsonUnusedTypeConverter
    {
    }

    /// <summary>
    /// PlazSoft modified.
    /// 
    /// Adds a hook for replacing assembly names when deserializing.
    /// </summary>
    public static class AssemblyReplace
    {
        /// <summary>
        /// Receives the assembly name and returns the assembly name
        /// to deserialize from.
        /// </summary>
        /// <param name="typeName">Type name specified in JSON</param>
        /// <param name="assemblyName">Assembly name specified in JSON</param>
        public delegate void AssemblyReplaceDelegate(ref string typeName, ref string assemblyName);

        /// <summary>
        /// If not null, this will be used to determine what assembly
        /// to deserialize a type from.
        /// </summary>
        public static AssemblyReplaceDelegate Hook;
    }
}
