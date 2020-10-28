[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE) [![NuGet Badge](https://buildstats.info/nuget/Damurka.ShortId)](https://www.nuget.org/packages/Damurka.ShortId)

# ShortId

## About ShortId
A C# library that can generate random and unique id's 

## Getting Started

To make use of the `shortid`, add it to your project via the Nuget package manager UI or console via this command:

#### Package Manager

```
Install-Package Damurka.ShortId
```

#### .NET CLI
```
> dotnet add package Damurka.ShortId
```

## Usage

This gives your code access the classes and methods of the `shortid` namespace.

To generate a unique id of 8 and 15characters, you call the `Generate` method without parameters.

```csharp
string id = Generator.Generate();
```

If you want to include numbers in the generated id, then you call the `Generate` method with options indicating your preference.

```csharp
string id = Generator.Generate(17);
```

If you do want special characters *i.e _ and -* with numbers in your generated id.

```csharp
string id = Generator.Generate(12, useNumbers: true, useSpecial: true);
```
