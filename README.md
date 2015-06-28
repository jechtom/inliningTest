# InliningTest project
Visual Studio 2015 RC is doing more aggressive inlining of .NET 4/4.5 projects.

## VS2013 Debug + Release, VS2015 Debug output:
```
Calling assembly: InliningTest

Stack trace:
Implementation.cs | System.String GetContextInfo()
Implementation.cs | System.String ExecuteInternal()
BaseClass.cs | Void Execute()
Program.cs | Void Main(System.String[])
```

## VS2015 Release output:
```
Calling assembly: InliningTest.SecondAssembly

Stack trace:
Implementation.cs | System.String GetContextInfo()
BaseClass.cs | Void Execute()
Program.cs | Void Main(System.String[])
```
