﻿// -----------------------------------------------------------------------------------------------------------------
// <copyright file="ISubscriber.cs" company="my-libraries">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

using System;

// ReSharper disable once CheckNamespace

namespace Chapter.Net.Mediation;

/// <summary>
///     Represents a single subscription on an object type.
/// </summary>
public interface ISubscriber : IDisposable
{
    /// <summary>
    ///     Gets raised if this subscriber got disposed.
    /// </summary>
    public event EventHandler Disposed;

    /// <summary>
    ///     Enables the dispatcher the callback gets invoked on.
    /// </summary>
    /// <param name="scheduler">The scheduler the callback gets invoked on.</param>
    /// <returns>The subscriber.</returns>
    ISubscriber On(IScheduler scheduler);
}