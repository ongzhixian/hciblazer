# dotnet-cli

1.  Create global.json file to set the version of .NET Core SDK to use

```dotnet
dotnet new globaljson --sdk-version 2.1.603
```

2.  Create new solution

```dotnet
dotnet new sln -n HciBlazer
```

3.  Create new website

```dotnet
dotnet new mvc -n HciBlazer.WebApp
```

4.  Create new library

```dotnet
dotnet new classlib -n HciBlazer.Data
dotnet new classlib -n HciBlazer.Data.Tests
```

5.  Adding project to solution

Assumes the solution file is in the directory where the command is executed and
that the project file is in a sub-directory call Csi.WebApp

```dotnet
dotnet sln HciBlazer.sln add HciBlazer.WebApp/HciBlazer.WebApp.csproj
dotnet sln HciBlazer.sln add HciBlazer.Data/HciBlazer.Data.csproj
```

6.  Packages to install

Because we a target .NET Core 2.1, we have to specify version

```dotnet
REM Required for dotnet aspnet-codegenerator
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 2.1.9

REM Identity as a nuget package
dotnet add package Microsoft.AspNetCore.Identity.UI --version 2.1.6

dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 2.1.6

dotnet add package Microsoft.Extensions.Configuration --version 2.1.1
dotnet add package Microsoft.Extensions.Configuration.Json --version 2.1.1

REM Required for dotnet ef
dotnet add package Microsoft.EntityFrameworkCore.Design --version 2.1.8

REM Entity Framework Providers for Sqlite and MySql
dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 2.1.8
dotnet add package MySql.Data.EntityFrameworkCore 
```