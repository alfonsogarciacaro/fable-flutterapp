#!/bin/sh -x

dotnet tool restore
dotnet fable watch src/App -o lib --lang dart --exclude Fable.Flutter

# Local Fable development
# dotnet run --project ../Fable/src/Fable.Cli watch src/App -o lib --lang dart --exclude Fable.Flutter --noCache