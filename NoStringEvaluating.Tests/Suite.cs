using NUnit.Framework;

namespace NoStringEvaluating.Tests;

[SetUpFixture]
public class Suite
{
    [OneTimeSetUp]
    public void RunBeforeAnyTests()
    {
        // No longer supported
        // AssertionOptions.AssertEquivalencyUsing(o => o.WithStrictOrdering());
    }
}