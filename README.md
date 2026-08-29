[![](https://img.shields.io/nuget/v/soenneker.dtos.filters.range.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.filters.range/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.filters.range/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.filters.range/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dtos.filters.range.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.filters.range/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.filters.range/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.filters.range/actions/workflows/codeql.yml)

# Soenneker.Dtos.Filters.Range

Selects records by applying inclusive or exclusive lower and upper bounds to a named comparable field.

## Install

```bash
dotnet add package Soenneker.Dtos.Filters.Range
```

## What you get

- `RangeFilter` — Selects records by applying inclusive or exclusive lower and upper bounds to a named comparable field.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `RangeFilter.GreaterThan` | Exclusive lower bound; matching field values must be greater than this value. | Exclusive lower bound; matching field values must be greater than this value. |
| `RangeFilter.GreaterThanOrEqual` | Inclusive lower bound; matching field values must be greater than or equal to this value. | Inclusive lower bound; matching field values must be greater than or equal to this value. |
| `RangeFilter.LessThan` | Exclusive upper bound; matching field values must be less than this value. | Exclusive upper bound; matching field values must be less than this value. |
| `RangeFilter.LessThanOrEqual` | Inclusive upper bound; matching field values must be less than or equal to this value. | Inclusive upper bound; matching field values must be less than or equal to this value. |
