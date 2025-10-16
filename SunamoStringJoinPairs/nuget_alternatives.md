# NuGet Alternatives to SunamoStringJoinPairs

This document lists popular NuGet packages that provide similar functionality to SunamoStringJoinPairs.

## Overview

Key-value pair joining

## Alternative Packages

### System.String.Join
- **NuGet**: System.Runtime
- **Purpose**: Join with formatting
- **Key Features**: Format key-value pairs

### System.Linq
- **NuGet**: System.Linq
- **Purpose**: Select and join
- **Key Features**: Select(x => $"{x.Key}={x.Value}") + String.Join

### QueryString helpers
- **NuGet**: Microsoft.AspNetCore.WebUtilities
- **Purpose**: Query string building
- **Key Features**: QueryHelpers.AddQueryString

## Comparison Notes

LINQ Select + String.Join handles most pair joining scenarios.

## Choosing an Alternative

Consider these alternatives based on your specific needs:
- **System.String.Join**: Join with formatting
- **System.Linq**: Select and join
- **QueryString helpers**: Query string building
