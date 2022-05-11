#!/bin/sh -x

dotnet tool restore
dotnet fable watch src -o lib --lang dart

# Local Fable development
# dotnet run --project ../Fable/src/Fable.Cli -- watch src -o lib --lang dart