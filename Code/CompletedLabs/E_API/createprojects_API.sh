#!/usr/bin/env bash
dotnet new webapi -lang c# -n AutoLot.Api -au none -o .\AutoLot.Api --use-controllers -f net9.0
dotnet sln AutoLot.sln add AutoLot.Api
echo "create the ASP.NET Core Web App (MVC) project and add it to the solution"
dotnet add AutoLot.Api reference AutoLot.Models
dotnet add AutoLot.Api reference AutoLot.Dal
dotnet add AutoLot.Api reference AutoLot.Services

echo "add packages"
dotnet add AutoLot.Api package Asp.Versioning.Mvc -v '[8.*,10.0)' 
dotnet add AutoLot.Api package Asp.Versioning.Mvc.ApiExplorer -v '[8.*,10.0)'
dotnet add AutoLot.Api package Microsoft.AspNetCore.OpenApi -v '[9.*,10.0)'
dotnet add AutoLot.Api package Microsoft.EntityFrameworkCore.SqlServer -v '[9.0.*,10.0)' 
dotnet add AutoLot.Api package Microsoft.EntityFrameworkCore.Design -v '[9.0.*,10.0)'  
dotnet add AutoLot.Api package Microsoft.VisualStudio.Threading.Analyzers -v '[17.*,18.0)'
dotnet add AutoLot.Api package Microsoft.VisualStudio.Web.CodeGeneration.Design -v '[9.0.*,10.0)'
dotnet add AutoLot.Api package Swashbuckle.AspNetCore -v '[9.*,10.0)'
dotnet add AutoLot.Api package Swashbuckle.AspNetCore.Annotations -v '[9.*,10.0)'
dotnet add AutoLot.Api package Swashbuckle.AspNetCore.Swagger -v '[9.*,10.0)'
dotnet add AutoLot.Api package Swashbuckle.AspNetCore.SwaggerGen -v '[9.*,10.0)'
dotnet add AutoLot.Api package Swashbuckle.AspNetCore.SwaggerUI -v '[9.*,10.0)'
dotnet add AutoLot.Api package System.Text.Json -v '[9.0.*,10.0)'

read -p "Press Enter to continue" </dev/ttyc
