# SunamoInterfaces

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
