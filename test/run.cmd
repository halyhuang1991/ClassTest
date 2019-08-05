rem dotnet pkg install Newtonsoft.Json –version 8.0.2
rem dotnet pkg install test.Models –version 1.0.0
rem dotnet add test package test.Models -s mypack



dotnet add test package test.Models

dotnet publish –output /pubapp