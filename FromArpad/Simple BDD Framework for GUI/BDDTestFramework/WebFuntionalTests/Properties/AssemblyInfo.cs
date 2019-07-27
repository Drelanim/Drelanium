using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using NUnit.Framework;

[assembly: AssemblyTitle("PlanetWinE2ETests")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("EPAM Systems")]
[assembly: AssemblyProduct("PlanetWinE2ETests")]
[assembly: AssemblyCopyright("Copyright © EPAM Systems 2018")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: ComVisible(false)]

[assembly: Guid("8fba4aee-06ec-4e43-a81f-4a6f45fc742a")]

// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

// add this to run in parallel
[assembly: Parallelizable(ParallelScope.Fixtures)]
[assembly: LevelOfParallelism(8)]
