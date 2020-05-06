# DotNet Core Framework

.NET Framework comes with Windows as Windows Only Runtime

.NET Core is a cross-platform runtime, supports C# and can be run on Linux

- .NET is just a runtime
- .NET has a CLR - common language runtime
- other programs can also be run on top of .NET, such as F# and Visual Basic
- Also comes with FCL - Framework Class Library
- FCL is essentially the language's base library packages

### Inside the `dotnet run`
- First, a `dotnet restore` is run
  - it uses a package management system called NuGet, it installs dependencies
  - it will look through the `.csproj` file to check for package dependencies
- Next, dotnet runs a `dotnet build`
  - this is what compiles the code
  - this creates a DLL file 
  - however, in Dotnet Core, the DLL is not Dynamic Link Library - it is an assembly 
  - that's why it is placed in the bin folder 
- the obj folder creates some temporary files during the restore and build process
- the DLL file requires a runtime - so the dotnet cli can do this:
  - dotnet run
  - `dotnet \path\*.dll`

