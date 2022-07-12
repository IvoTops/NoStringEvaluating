﻿using System.Collections.Generic;
using NoStringEvaluating.Factories;
using NoStringEvaluating.Functions.Base;
using NoStringEvaluating.Models.Values;

namespace NoStringEvaluating.Functions.Math.Trigonometry.Cotan;

/// <summary>
/// Function - arccoth
/// </summary>
public class ArccothFunction : IFunction
{
    /// <summary>
    /// Name
    /// </summary>
    public virtual string Name { get; } = "ARCCOTH";

    /// <summary>
    /// Evaluate value
    /// </summary>
    public InternalEvaluatorValue Execute(List<InternalEvaluatorValue> args, ValueFactory factory)
    {
        var x = args[0];
        return System.Math.Log((x + 1) / (x - 1)) / 2;
    }
}
