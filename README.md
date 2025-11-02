#  C# Console Programs from Microsoft & FreecodeCamp C# Foundations Course 

This repository contains multiple **C# console applications**, each demonstrating different features or topics.  
All projects are managed and run via the **.NET CLI**.

---

## Requirements

Before running any project, make sure you have the following installed:

###  Prerequisites
- [.NET SDK (≥ .NET 9.0)](https://dotnet.microsoft.com/en-us/download/dotnet)
  - Includes both the **runtime** and **CLI tools**
- A text editor or IDE such as:
  - [Visual Studio Code](https://code.visualstudio.com/)
  - [Visual Studio](https://visualstudio.microsoft.com/)
  - [JetBrains Rider](https://www.jetbrains.com/rider/)

You can verify installation with:
```bash
dotnet --version
````

You should see something like:

```
9.0.x
```
---

## Create a New Project

To create a new console project via CLI:

```bash
dotnet new console -o ProjectName
```

Example:

```bash
dotnet new console -o 17.Exception-Handling-createNThrow
```

This command generates a folder `17.Exception-Handling-createNThrow` containing:

```
17.Exception-Handling-createNThrow.csproj
Program.cs
```

---

## Build a Project

To build (compile) a project:

```bash
dotnet build <path-to-csproj>
```

Example:

```bash
dotnet build 02.ExceptionHandling/02.ExceptionHandling.csproj
```

The compiled output will be placed in:

```
bin/Debug/net9.0/
```

OR

Navigate into the projects directory :

```bash
cd <project-directory>
```
 And then run : 
 ```bash
dotnet build
```

---

## Run a Project

To run any console project:

```bash
dotnet run --project <path-to-csproj>
```
Example:

```bash
dotnet run --project 01.Basics/01.Basics.csproj
```

If the `.csproj` is in the current directory:

```bash
dotnet run
```

---

## Clean the Build Artifacts

To remove compiled output (bin/ and obj/ folders):

```bash
dotnet clean <path-to-csproj>
```

---

##  Tips

* To list all available .NET SDKs and runtimes:

  ```bash
  dotnet --list-sdks
  dotnet --list-runtimes
  ```

* To restore dependencies:

  ```bash
  dotnet restore
  ```

* To publish an executable:

  ```bash
  dotnet publish -c Release -r win-x64 --self-contained false
  ```

---

## Summary of Common Commands

| Action                   | Command                                 |
| ------------------------ | --------------------------------------- |
| Create a new console app | `dotnet new console -n ProjectName`     |
| Build a project          | `dotnet build <path-to-csproj>`         |
| Run a project            | `dotnet run --project <path-to-csproj>` |
| Clean build outputs      | `dotnet clean <path-to-csproj>`         |
| Create a solution        | `dotnet new sln -n SolutionName`        |
| Add project to solution  | `dotnet sln add <path-to-csproj>`       |

---


