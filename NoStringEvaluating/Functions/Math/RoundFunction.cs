﻿using System.Collections.Generic;
using NoStringEvaluating.Factories;
using NoStringEvaluating.Functions.Base;
using NoStringEvaluating.Models.Values;

namespace NoStringEvaluating.Functions.Math;

/// <summary>
/// Rounds the designated number to the specified decimals
/// <para>Round(15.7865; 2)</para>
/// </summary>
public sealed class RoundFunction : IFunction
{
    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; } = string.Intern("ROUND");

    /// <summary>
    /// Can handle IsNull arguments?
    /// </summary>
    public bool CanHandleNullArguments { get; }

    /// <summary>
    /// Execute value
    /// </summary>
    public InternalEvaluatorValue Execute(List<InternalEvaluatorValue> args, ValueFactory factory)
    {
        return System.Math.Round(args[0].Number, (int)args[1].Number);
    }
}

/// <summary>
/// Rounds the designated number to the specified decimals
/// <para>Round(15.7865; 2)</para>
/// </summary>
public sealed class RoundToZeroFunction : IFunction
{
    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; } = string.Intern("ROUNDTOZERO");

    /// <summary>
    /// Can handle IsNull arguments?
    /// </summary>
    public bool CanHandleNullArguments { get; }

    /// <summary>
    /// Execute value
    /// </summary>
    public InternalEvaluatorValue Execute(List<InternalEvaluatorValue> args, ValueFactory factory)
    {
        return args[0].Number >= 0 ? (long)args[0].Number : -((long)(-args[0].Number));
    }
}
