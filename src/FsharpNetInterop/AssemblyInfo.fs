namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("FsharpNetInterop")>]
[<assembly: AssemblyProductAttribute("FsharpNetInterop")>]
[<assembly: AssemblyDescriptionAttribute("Utilities for interoperability with .NET languages")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
