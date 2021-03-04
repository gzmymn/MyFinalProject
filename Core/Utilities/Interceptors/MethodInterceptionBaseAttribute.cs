using Castle.DynamicProxy;
using Core.Aspects.Autofac.Performance;
using System;

namespace Core.Utilities.Interceptors
{
    //[PerformanceAspect(5)]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public abstract class MethodInterceptionBaseAttribute : Attribute, IInterceptor
    {
        public int Priority { get; set; }

        public virtual void Intercept(IInvocation invocation)
        {

        }
    }

}
