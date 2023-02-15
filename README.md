## Requirememnts

dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 7.0.3

dotnet add package Microsoft.EntityFrameworkCore.Tools --version 7.0.3

Microsoft.Extensions.Configuration

    Microsoft.EntityFrameworkCore.SqlServer: This package is used to interact with SQL Server from our C# and .Net Core.
    Microsoft.EntityFrameworkCore.Tools: This package is contained various commands like Add-Migration, Drop-Database, Get-DbContext, Get-Migration, Remove-Migration, Scaffold-DbContext, Script-Migration, Update-Database. In this article, we use Add-Migration and Update-Database commands.
    Microsoft.Extensions.Configuration: Using this NuGet package we can read data from our app setting file. We will get our connection string from the app setting file.

1. create entity
2. created db context

3. connecting with sql

https://learn.microsoft.com/en-us/ef/core/performance/advanced-performance-topics?tabs=with-di%2Cwith-constant#dbcontext-pooling

spin up conttainer to run

docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=yourStrong(!)Password" -e "MSSQL_PID=Express" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2019-latest



generate migration
https://learn.microsoft.com/en-us/ef/core/cli/dotnet  --. install migration

dotnet ef migrations add InitialCreate