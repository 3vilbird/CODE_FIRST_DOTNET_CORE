## Requirememnts

dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 7.0.3

dotnet add package Microsoft.EntityFrameworkCore.Tools --version 7.0.3

Microsoft.Extensions.Configuration

    Microsoft.EntityFrameworkCore.SqlServer: This package is used to interact with SQL Server from our C# and .Net Core.
    Microsoft.EntityFrameworkCore.Tools: This package is contained various commands like Add-Migration, Drop-Database, Get-DbContext, Get-Migration, Remove-Migration, Scaffold-DbContext, Script-Migration, Update-Database. In this article, we use Add-Migration and Update-Database commands.
    Microsoft.Extensions.Configuration: Using this NuGet package we can read data from our app setting file. We will get our connection string from the app setting file.

1. create entity
2. created db context  