# DangerBug

A console reference tool that tells you whether an insect is dangerous, a nuisance, or harmless.

Pair-programming exercise for GET Academy Emne 3 — an inheritance exercise: a `Bug` base class with derived insect types, browsed through a small console menu.

## Stack

C# · .NET 10 · NUnit

## Structure

- `DangerBug.Core` — domain model: the `Bug` base class and the insect types (no console/IO).
- `DangerBug.Console` — the menu loop; all console input/output lives here.
- `DangerBug.Tests` — NUnit tests for `DangerBug.Core`.

## Run

```
dotnet run --project DangerBug.Console
```

## Test

```
dotnet test
```

## Menu

1. List bugs — pick one to see its traits (risk level, plague, good stuff).
2. Add a bug — enter a new insect from the console.
0. Exit
