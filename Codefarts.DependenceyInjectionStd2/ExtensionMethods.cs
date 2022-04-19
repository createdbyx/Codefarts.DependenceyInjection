// <copyright file="ExtensionMethods.cs" company="Codefarts">
// Copyright (c) Codefarts
// contact@codefarts.com
// http://www.codefarts.com
// </copyright>

namespace Codefarts.DependencyInjection
{
    using System;

    public static class ExtensionMethods
    {
        public static void Register<T>(this IDependencyInjectionProvider provider, Func<T> callback)
        {
            if (callback == null)
            {
                throw new ArgumentNullException(nameof(callback));
            }

            provider.Register(typeof(T), () => callback());
        }

        public static T Resolve<T>(this IDependencyInjectionProvider provider)
        {
            return (T)provider.Resolve(typeof(T));
        }

        public static void Register<T>(this IDependencyInjectionProvider provider, Type concrete)
        {
            if (concrete == null)
            {
                throw new ArgumentNullException(nameof(concrete));
            }

            provider.Register(typeof(T), concrete);
        }

        public static void Register<T, TConcrete>(this IDependencyInjectionProvider provider)
        {
            provider.Register(typeof(T), typeof(TConcrete));
        }
    }
}