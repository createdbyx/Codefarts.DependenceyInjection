// <copyright file="RegistrationHandlerArgs.cs" company="Codefarts">
// Copyright (c) Codefarts
// </copyright>

namespace Codefarts.DependencyInjection
{
    using System;

    public delegate void RegistrationHandler(object sender, RegistrationHandlerArgs e);

    public class RegistrationHandlerArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrationHandlerArgs"/> class.
        /// </summary>
        /// <param name="provider">A reference to the Ioc container.</param>
        public RegistrationHandlerArgs(IDependencyInjectionProvider provider)
        {
            this.DependencyInjectionProvider = provider ?? throw new ArgumentNullException(nameof(provider));
        }

        public IDependencyInjectionProvider DependencyInjectionProvider
        {
            get;
        }
    }
}