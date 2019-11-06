# Yellow Belt Exercises

Unit tests with Mocks.

## Exercises

Add dependencies:

```s
# Required mock dependency such as NSubstitute
dotnet add package NSubstitute

# Optional but recommended FluentAssertions
dotnet add package FluentAssertions
```

### Invoice

1. Mock the DAO
2. Mock the Invoice total
3. Verify and Test `InvoiceService` class

## Testing

```s
dotnet restore
dotnet test
```