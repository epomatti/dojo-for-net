# White Belt Exercises

Unit tests without mocks.

## Exercises

Add FluentAssertions dependency:

```s
dotnet add package FluentAssertions
```

### Calculator

1. Create `Calculator.Add()` unit tests
2. Code `Subtract`, `Divide` and `Multiply` methods for the Calculator, and the relative unit tests

## Testing

```s
dotnet restore
dotnet test
```

## Tips

```cs
using FluentAssertions;
Assert.AreEqual(expected, actual);
actual.Should().Be(expected);
[Theory]
[InlineData(value)]
```