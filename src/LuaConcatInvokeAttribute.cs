using System;

namespace NLua
{
    /// <summary>
    /// Marks a method to be used when the metamethod "__concat" is invoked with the object
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
    public sealed class LuaConcatInvokeAttribute : Attribute
    {
    }
}
