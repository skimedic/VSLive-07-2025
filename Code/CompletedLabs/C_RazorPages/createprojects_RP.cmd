rem create the ASP.NET Core Razor Pages project add it to the solution
dotnet new razor -lang c# -n AutoLot.Web -au none -o .\AutoLot.Web -f net9.0
dotnet sln AutoLot9.sln add AutoLot.Web
rem add project references
dotnet add AutoLot.Web reference AutoLot.Models
dotnet add AutoLot.Web reference AutoLot.Dal
dotnet add AutoLot.Web reference AutoLot.Services
rem add packages
dotnet add AutoLot.Web package System.Text.Json -v [9.0.*,10.0) 
dotnet add AutoLot.Web package LigerShark.WebOptimizer.Core -v [3.0.*,4)
dotnet add AutoLot.Web package Microsoft.Web.LibraryManager.Build -v [3.*,4.0)
dotnet add AutoLot.Web package Microsoft.EntityFrameworkCore.SqlServer -v [9.0.*,10.0)
dotnet add AutoLot.Web package Microsoft.EntityFrameworkCore.Design -v [9.0.*,10.0)
dotnet add AutoLot.Web package Microsoft.VisualStudio.Web.CodeGeneration.Design -v [9.0.*,10.0)
dotnet add AutoLot.Web package Microsoft.VisualStudio.Threading.Analyzers -v [17.*,18.0)
pause
