using System;
using System.Reflection;

namespace NLua
{
    [AttributeUsage(AttributeTargets.Parameter)]
    public class LuaResolveParamAttribute : Attribute
    {
        public Type DelegateType;
        public Type ClassType;
        public string MethodName;
        public Type[] ResolveToTypes;

        protected LuaResolveParamAttribute(Type delegateType, Type classType, string methodName, params Type[] resolveToTypes)
        {
            DelegateType = delegateType;
            ClassType = classType;
            MethodName = methodName;
            ResolveToTypes = resolveToTypes;
        }

        public object Resolve(MethodBase methodBase, object value)
        {
            return Delegate.CreateDelegate(DelegateType, ClassType, MethodName)?.DynamicInvoke(methodBase, value, ResolveToTypes);
        }
    }
}
