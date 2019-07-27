using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using NUnit.Framework;

[assembly: AssemblyTitle("UnitTestProject")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("EPAM Systems")]
[assembly: AssemblyProduct("UnitTestProject")]
[assembly: AssemblyCopyright("Copyright © EPAM Systems 2018")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: ComVisible(false)]

[assembly: Guid("e6548acc-59b1-4d8e-b76e-24527ce423cb")]

// run in parallel
[assembly: Parallelizable(ParallelScope.Fixtures)]
[assembly: LevelOfParallelism(8)]

// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]


