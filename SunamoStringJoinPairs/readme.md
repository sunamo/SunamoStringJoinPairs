# SunamoStringJoinPairs

A lightweight .NET library for concatenating string pairs with two configurable delimiters.

## Usage

```csharp
// Default delimiters (semicolons)
var result = SHJoinPairs.JoinPairs("key1", "value1", "key2", "value2");
// Result: "key1;value1;key2;value2;"

// Custom delimiters
var result = SHJoinPairs.JoinPairs("=", ",", "key1", "value1", "key2", "value2");
// Result: "key1=value1,key2=value2,"
```

## Installation

```bash
dotnet add package SunamoStringJoinPairs
```

## Target Frameworks

`net10.0`, `net9.0`, `net8.0`

## Links

- [NuGet](https://www.nuget.org/profiles/sunamo)
- [GitHub](https://github.com/sunamo/PlatformIndependentNuGetPackages)
- [Developer site](https://sunamo.cz)

## License

MIT
