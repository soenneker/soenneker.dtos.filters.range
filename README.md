[![](https://img.shields.io/nuget/v/soenneker.dtos.filters.range.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.filters.range/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.filters.range/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.filters.range/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dtos.filters.range.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.filters.range/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.filters.range/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.filters.range/actions/workflows/codeql.yml)

# Soenneker.Dtos.Filters.Range

Represents inclusive or exclusive bounds for a named comparable field.

## Installation

```bash
dotnet add package Soenneker.Dtos.Filters.Range
```

## Numeric range

```csharp
using Soenneker.Dtos.Filters.Range;

var filter = new RangeFilter
{
    Field = "price",
    GreaterThanOrEqual = 10.00m,
    LessThan = 50.00m
};
```

## Timestamp range

```csharp
var filter = new RangeFilter
{
    Field = "createdAt",
    GreaterThanOrEqual = new DateTimeOffset(2026, 1, 1, 0, 0, 0, TimeSpan.Zero),
    LessThan = new DateTimeOffset(2027, 1, 1, 0, 0, 0, TimeSpan.Zero)
};
```

Both System.Text.Json and Newtonsoft.Json use `field`, `greaterThan`, `greaterThanOrEqual`, `lessThan`, and `lessThanOrEqual` as wire names.

Normally choose at most one lower bound and one upper bound:

- `GreaterThan` is exclusive; `GreaterThanOrEqual` is inclusive.
- `LessThan` is exclusive; `LessThanOrEqual` is inclusive.

The DTO does not reject conflicting lower or upper operators, reversed ranges, incomparable types, null-only filters, or unsupported fields. `object?` bounds also deserialize to serializer-specific untyped representations such as `JsonElement` or `JValue`.

At the server boundary, allow-list `Field`, choose the expected CLR type from server-owned metadata, convert each supplied bound, reject contradictory combinations, and parameterize the resulting query. Never concatenate field names or bound values into a query expression.
