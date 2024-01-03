# dotnet_System.CommandLine_example1

## 概要

System.CommandLine のサンプル

## 参考

チュートリアル: System.CommandLine の概要  
https://learn.microsoft.com/ja-jp/dotnet/standard/commandline/get-started-tutorial  

nuget - System.CommandLine  
https://www.nuget.org/packages/System.CommandLine  

GitHub - command-line-api  
https://github.com/dotnet/command-line-api  

## 詳細

```
dotnet new console
dotnet add package System.CommandLine --prerelease
```

```
> dotnet run
Option '--name' is required.

Description:
  Sample app for System.CommandLine

Usage:
  dotnet_System.CommandLine_example1 [options]

Options:
  --name <name> (REQUIRED)  The name of the person to greet
  --version                 Show version information
  -?, -h, --help            Show help and usage information
```

```
> dotnet run --name Tobotobo
Hello Tobotobo!
```

### NativeAOT
→ NativeAOT対応してる  
　ただし、このサンプルでも 4 MB (※)

※(参考)Hello World のコンソールアプリで 1.5 MB

.csproj
```xml
  <PropertyGroup>
    <PublishAot>true</PublishAot>
  </PropertyGroup>
```

```
dotnet publish
```

```
> dir

    Directory: dotnet_System.CommandLine_example1\bin\Release\net8.0\win-x64\publish

Mode                 LastWriteTime         Length Name
----                 -------------         ------ ----
-a---          2024/01/03    14:53        4080128 dotnet_System.CommandLine_example1.exe
-a---          2024/01/03    14:53       26390528 dotnet_System.CommandLine_example1.pdb
```

```
> .\dotnet_System.CommandLine_example1.exe
Option '--name' is required.

Description:
  Sample app for System.CommandLine

Usage:
  dotnet_System.CommandLine_example1 [options]

Options:
  --name <name> (REQUIRED)  The name of the person to greet
  --version                 Show version information
  -?, -h, --help            Show help and usage information
```

```
> .\dotnet_System.CommandLine_example1.exe --name Tobotobo
Hello Tobotobo!
```

## 環境

```
> dotnet --info
.NET SDK:
 Version:           8.0.100
 Commit:            57efcf1350
 Workload version:  8.0.100-manifests.3b83835e

ランタイム環境:
 OS Name:     Windows
 OS Version:  10.0.19045
 OS Platform: Windows
 RID:         win-x64
 Base Path:   C:\Program Files\dotnet\sdk\8.0.100\

インストール済みの .NET ワークロード:
 Workload version: 8.0.100-manifests.3b83835e
```