# SunamoStringJoinPairs

## Short description

Malá knihovna pro spojování dvojic řetězců pomocí dvou konfigurovatelných oddělovačů. Součást sbírky pinp s testy a Runnerem.


A lightweight .NET library for concatenating string pairs with two configurable delimiters.

## Overview

SunamoStringJoinPairs is part of the Sunamo package ecosystem, providing modular, platform-independent utilities for .NET development.

## Main Components

### Key Classes

- **SHJoinPairs** - Provides methods for joining string pairs with configurable delimiters.

### Key Methods

- `JoinPairs(params string[] parts)` - Joins pairs using semicolons as default delimiters.
- `JoinPairs(string firstDelimiter, string secondDelimiter, params string[] parts)` - Joins pairs using custom delimiters.

## Installation

```bash
dotnet add package SunamoStringJoinPairs
```

## Target Frameworks

`net10.0`, `net9.0`, `net8.0`

## Dependencies

None (standalone package).

## Related Packages

This package is part of the Sunamo package ecosystem. For more information about related packages, visit the main repository.

## License

MIT

<!-- sunamo:test-coverage:start -->
## Test coverage

| Metric | Value |
|---|---|
| Method | static |
| Test projects | 1 |
| Public types referenced by tests | 1/1 (100.0 %) |
| Public methods referenced by tests | 1/1 (100.0 %) |
| Line coverage | n/a |
| Branch coverage | n/a |
| Generated (UTC) | 2026-11-22 21:24 |

<!-- sunamo:test-coverage:data {"package":"SunamoStringJoinPairs","container":"pinp","testProjects":1,"publicTypes":1,"typesReferencedByTests":1,"publicMethods":1,"methodsReferencedByTests":1,"lineRate":null,"branchRate":null,"method":"static","generatedUtc":"2026-11-22 21:24"} -->
<!-- sunamo:test-coverage:end -->
