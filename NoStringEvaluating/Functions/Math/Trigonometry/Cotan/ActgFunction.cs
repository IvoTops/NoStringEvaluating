﻿using System.Collections.Generic;
using NoStringEvaluating.Factories;
using NoStringEvaluating.Functions.Base;
using NoStringEvaluating.Models.Values;

namespace NoStringEvaluating.Functions.Math.Trigonometry.Cotan;

/// <summary>
/// Function - actg
/// </summary>
public sealed class ActgFunction : IFunction
{
    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; } = string.Intern("ACTG");

    /// <summary>
    /// Can handle IsNull arguments?
    /// </summary>
    public bool CanHandleNullArguments { get; }

    /// <summary>
    /// Evaluate value
    /// </summary>
    public InternalEvaluatorValue Execute(List<InternalEvaluatorValue> args, ValueFactory factory)
    {
        // Math.PI / 2 == 1.5707963267948966
        return 1.5707963267948966 - System.Math.Atan(args[0].Number);
    }
}
