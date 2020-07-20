# audit wk1

## command line

-create file -> touch
-create dir -> mkdir
-display content of dir -> ls, flags -a for all -l long
-change dir -> cd
-remove file or dir -> rm, flags  -r(recursive) and -f (force)
-run privileged commands -> sudo
-install new packages -> apt install
-read file content -> cat
-edit file content -> nano
-print current path -> pwd

## version control system

- git add -> copy resources into virtual directory or local server
- git commit -> save resources to virtual directory or local server
- git status -> display changed resources in history
- git init -> initialize virtual directory or local server
- git config -> configure name, email, or git options
- git remote -> edit or remove connection to remote server
- git clone -> copy resorces from remote server to local server
- git push -> copy resources from local server to remote server
- git log -> print history of virtual directory

## ssh 

- ssh-keygen -> generate a private/public key pair, similar to username and password, 
          flags = -t(algorithm type) -b (binary length), -C(comment)
- ssh-agent -> run current directory in privileged state with ssh
- ssh-add -> add private key to privileged state with ssh

## dotnet [.NET]

- .NET Standard = supports both .NET Framework (Win only) and .NET Core (Multiplatform)
- .NET Core = supports Languages, Desktop Apps, Mobile Apps, and Web Apps
-          --Languages = support for C#, F#, Visual Basic, VB.NET, C, C++, Python, JS
-          --Desktop = support for UWP/UAP(Win10), XAML(Win10), WPF(Win 7+8)
-          --Mobile = support for Xamarin (Windows, Linux, macOS)
-          --Web = support for MVC, Web API (REST), gRPC (Remote Procedure Call)
- dotnet new, sln, build, run, test, add

## C#

- CIL, MSIL, IL = compile to intermediate language(assembly), supoort CLI (Common Language Infrastructure)
- Assembly = compiled codebase into DLL, EXE or SVC (Web, Host)
- Language = object-based, strongly-typed, compiled, managed, general programming language
- Datatypes = primitives, reference, value
- Primitive = int, float, double, decimal, string, char, bool (including unsigned)
- Reference = string, class, interface
- Value = all primitives except string, struct, enum
- CLR = .NET Runtime from assembly to bytecode, support BCL(Base Class Library), 
     CTS(Common Type System), VES(Virtual Execution System), JIT (Just in Time Compiler)
- Runtime = portability, interoperability, memory management, performance
- Scopes = support for 4 levels of scoping, manely namespace, data structure, method, block
- Collections = support for array (1-D, multi-dimensional), List
- Exception Handling = handle with try/catch/throw/finally, try with no catch(not recommended), catch (handle at error or throw to invocation caller),
     finally(handle resources cleanup)
- Unit Testing = support for running codebase logic without application start, structurally setup with arrange/act/assert blocks, test coverage
- Serialization = convert data from one system to another, transfer object to xml text format 
- Debugging = support for running codebase in steps including breakpoints, conditions, handle logic errors
- Modifiers = supports 2 types, access (public > protected > internal > private) 
          and regular/extended (const, readonly, static, override)
- Method Overloading = support for methods in the same data structure, with same name but different signature
- Method Overriding = support for methods in different data structure, with same name and same signature through inheritance
- Object Oriented Programming = support for Abstraction, Encapsulation, Inheritance, Polymorphism
- Casting = support for implicit (smaller to larger no loss of def) 
          and explicit (exception casting `(datatype) object` or null casting `(object as datatype)`)
- Reference = support for `ref` (pass by value with value being reference/pointer to memory address)
          and `out` (pass by value with value being the copy of the variable in memory address)
- Parsing = support for converting between primitive datatypes


