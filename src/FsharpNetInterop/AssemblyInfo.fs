namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("FsharpNetInterop")>]
[<assembly: AssemblyProductAttribute("FsharpNetInterop")>]
[<assembly: AssemblyDescriptionAttribute("Utilities for interoperability with .NET languages")>]
[<assembly: AssemblyVersionAttribute("0.1.0")>]
[<assembly: AssemblyFileVersionAttribute("0.1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.1.0"
