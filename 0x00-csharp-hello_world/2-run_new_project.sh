#!/usr/bin/env bash
# creates a new C# project, build and run
dotnet new console -o ./2-new_project
dotnet build ./2-new_project
dotnet run -p ./2-new_project
