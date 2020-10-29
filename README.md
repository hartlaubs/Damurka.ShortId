[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE) [![NuGet Badge](https://buildstats.info/nuget/Damurka.ShortId)](https://www.nuget.org/packages/Damurka.ShortId)

# ShortId

## What is it
ShortId can used to generate non-sequential unique IDs that are cryptographically secure.
By default it uses characters A-Za-z0-9 with a length of 8 characters.

## Package Manager

Install with nuget:

```
PM> Install-Package Damurka.ShortId
```

## Usage

To generate a unique id of 8 characters, you call the `Generate` method without parameters.

```csharp
string id = ShortId.Generate();
```

If you want to specify the size of the generated id.

```csharp
string id = ShortId.Generate(17);
```

If you do want to specify your custom character and default number of characters

```csharp
string id = ShortId.Generate(allowableCharacters: "abcdefghijkmnpqrstuvwxyz2345678");
```
