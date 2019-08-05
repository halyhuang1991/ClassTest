dotnet new console -o test
dotnet new classlib -o test.Common
dotnet new classlib -o test.Service
dotnet new classlib -o test.Models

dotnet add test reference test.Common\test.Common.csproj
dotnet add test reference test.Service\test.Service.csproj


dotnet  D:\C\github\ClassTest\test\bin\Debug\netcoreapp2.0\test.dll

dotnet add test package test.models -s "D:\C\github\ClassTest\mypack"


dotnet new mstest -o Demo.Test

dotnet new xunit -o Demo.Test


echo "# ClassTest" >> README.md
git init
git add README.md
git commit -m "first commit"
git remote add origin git@github.com:halyhuang1991/ClassTest.git
git push -u origin master



