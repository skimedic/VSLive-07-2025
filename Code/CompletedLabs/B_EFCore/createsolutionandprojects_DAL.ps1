dotnet new globaljson --sdk-version 9.0.100 --roll-forward feature --force
dotnet new nugetconfig 
dotnet new install xunit.v3.templates
dotnet new sln -n AutoLot
dotnet new classlib -lang c# -n AutoLot.Models -o .\AutoLot.Models -f net9.0
dotnet sln AutoLot.sln add AutoLot.Models
dotnet add AutoLot.Models package Microsoft.EntityFrameworkCore.SqlServer -v '[9.0.*,10.0)'
dotnet add AutoLot.Models package System.Text.Json -v '[9.0.*,10.0)'
dotnet add AutoLot.Models package Microsoft.VisualStudio.Threading.Analyzers -v '[17.*,18.0)'
dotnet new classlib -lang c# -n AutoLot.Dal -o .\AutoLot.Dal -f net9.0
dotnet sln AutoLot.sln add AutoLot.Dal
dotnet add AutoLot.Dal reference AutoLot.Models
dotnet add AutoLot.Dal package Microsoft.EntityFrameworkCore.SqlServer -v '[9.0.*,10.0)'
dotnet add AutoLot.Dal package Microsoft.EntityFrameworkCore.Design -v '[9.0.*,10.0)'
dotnet add AutoLot.Dal package Microsoft.VisualStudio.Threading.Analyzers -v '[17.*,18.0)'
dotnet new classlib -lang c# -n AutoLot.Services -o .\AutoLot.Services -f net9.0
dotnet sln AutoLot.sln add AutoLot.Services
dotnet add AutoLot.Services reference AutoLot.Models
dotnet add AutoLot.Services reference AutoLot.Dal
dotnet add AutoLot.Services package Microsoft.VisualStudio.Threading.Analyzers -v '[17.*,18.0)'
dotnet add AutoLot.Services package Microsoft.Extensions.Hosting.Abstractions  -v '[9.0.*,10.0)'
dotnet add AutoLot.Services package Microsoft.Extensions.Options  -v '[9.0.*,10.0)'
dotnet add AutoLot.Services package Serilog.AspNetCore -v '[9.0.*,10.0)'
dotnet add AutoLot.Services package Serilog.Enrichers.Environment  -v '[2.*,3.0)'
dotnet add AutoLot.Services package Serilog.Settings.Configuration  -v '[9.0.*,10.0)'
dotnet add AutoLot.Services package Serilog.Sinks.Console -v '[6.0.*,7.0)'
dotnet add AutoLot.Services package Serilog.Sinks.File -v '[7.0.*,8.0)'
dotnet add AutoLot.Services package Serilog.Sinks.MSSqlServer -v '[6.*,7.0)'
dotnet add AutoLot.Services package System.Text.Json -v '[9.0.*,10.0)'
dotnet new xunit3 -lang c# -n AutoLot.Dal.Tests -o .\AutoLot.Dal.Tests -f net9.0
dotnet sln AutoLot.sln add AutoLot.Dal.Tests
dotnet add AutoLot.Dal.Tests reference AutoLot.Dal
dotnet add AutoLot.Dal.Tests reference AutoLot.Models
dotnet add AutoLot.Dal.Tests package Microsoft.EntityFrameworkCore.SqlServer -v '[9.0.*,10.0)'
dotnet add AutoLot.Dal.Tests package Microsoft.EntityFrameworkCore.Design -v '[9.0.*,10.0)'
dotnet add AutoLot.Dal.Tests package Microsoft.Extensions.Configuration.Json -v '[9.0.*,10.0)'
dotnet add AutoLot.Dal.Tests package Microsoft.NET.Test.Sdk -v '[17.*,18.0)'
dotnet add AutoLot.Dal.Tests package Microsoft.VisualStudio.Threading.Analyzers -v '[17.*,18.0)'
dotnet add AutoLot.Dal.Tests package xunit.v3 -v '[2.*,3.0)'
dotnet add AutoLot.Dal.Tests package xunit.runner.visualstudio -v '[3.*,4.0)'


