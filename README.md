[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE) [![NuGet Badge](https://buildstats.info/nuget/Damurka.ShortId)](https://www.nuget.org/packages/Damurka.ShortId)

# ShortId

## About ShortId
A C# library that can generate random and unique id's 

## Getting Started

To make use of the `ShortId`, add it to your project via the Nuget package manager UI or console via this command:

#### Package Manager

```
Install-Package Damurka.ShortId
```

#### .NET CLI
```
dotnet add package Damurka.ShortId
```

## Usage

To generate a unique id of 8 characters, you call the `Generate` method without parameters.

```csharp
string id = Generator.Generate();
```

If you want to specify the size of the generated id.

```csharp
string id = Generator.Generate(17);
```

If you do want special characters ( _ and -*)in your generated id.

```csharp
string id = Generator.Generate(12, useNumbers: true, useSpecial: true);
```
