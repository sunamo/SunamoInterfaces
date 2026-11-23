# SunamoInterfaces

## Short description

Sada rozhraní sdílených napříč balíčky Sunamo, například IAsync, IAsyncFile, IClipboardHelper, IClipboardMonitor a IConvertConvention. Umožňuje volnou vazbu mezi balíčky bez přímých referencí. Obsahuje Runner a testy.


Interfaces shared across many packages in the Sunamo ecosystem.

## Overview

SunamoInterfaces provides a collection of platform-independent interface definitions and shared types for .NET development. It serves as a contract layer between various Sunamo NuGet packages, enabling loose coupling and consistent API design.

## Installation

```bash
dotnet add package SunamoInterfaces
```

## Key Features

- **Parsing interfaces** - `IParser`, `IParserCollection<T>`, `IXmlParser`, `IXParser` for text and XML parsing
- **Serialization** - `ISerialization`, `IJsSerializer` for save/load and JSON operations
- **File system** - `IFSItem`, `IFSWin`, `IAsyncFile` for file operations
- **Search** - `ISearching`, `ISearchingAll<T>`, `ISearchable` for search functionality
- **Cryptography** - `ICryptHelper`, `ICryptString` for encryption/decryption
- **Browser control** - `ISunamoBrowser` for web browser automation
- **Text output** - `ITextOutputGenerator`, `IXmlGenerator` for formatted output generation
- **Progress tracking** - `ProgressState`, `IProgressBarHelper` for progress reporting

## Dependencies

- **HtmlAgilityPack** (v1.12.4)
- **Newtonsoft.Json** (v13.0.4)
- **Microsoft.Extensions.Logging.Abstractions** (v10.0.2)

## Target Frameworks

- net10.0
- net9.0
- net8.0

## License

MIT - See the repository root for license information.

<!-- sunamo:test-coverage:start -->
## Test coverage

| Metric | Value |
|---|---|
| Method | static |
| Test projects | 1 |
| Public types referenced by tests | 0/81 (0.0 %) |
| Public methods referenced by tests | 0/6 (0.0 %) |
| Line coverage | n/a |
| Branch coverage | n/a |
| Generated (UTC) | 2026-11-22 21:24 |

<!-- sunamo:test-coverage:data {"package":"SunamoInterfaces","container":"pinp","testProjects":1,"publicTypes":81,"typesReferencedByTests":0,"publicMethods":6,"methodsReferencedByTests":0,"lineRate":null,"branchRate":null,"method":"static","generatedUtc":"2026-11-22 21:24"} -->
<!-- sunamo:test-coverage:end -->
