Failing.Cake.Powershell

Cake.Powershell addin is failing to debug in VSCode with this error message: Error: Cake.Core.CakeException: Failed to install addin 'Cake.Powershell'.

Steps to reproduce:

1. Clone this repo
2. Open the main folder in VSCode
3. Run ".\build.ps1" to download the tools and be sure that the project works as expected
4. Switch to debugging window [Ctrl+Shift+D]
5. Select ".NET Core Launch (console)"
6. Start debugging [F5]
7. See the output in Debug Console [Ctrl+Shift+Y]

You should see something like this:

```
-------------------------------------------------------------------
You may only use the Microsoft .NET Core Debugger (vsdbg) with
Visual Studio Code, Visual Studio or Visual Studio for Mac software
to help you develop and test your applications.
-------------------------------------------------------------------
Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.9\System.Private.CoreLib.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Users\lukia\source\repos\Cake\Failing.Cake.Powershell\tools\Cake.CoreCLR\Cake.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.9\System.Runtime.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Users\lukia\source\repos\Cake\Failing.Cake.Powershell\tools\Cake.CoreCLR\Cake.Core.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Users\lukia\source\repos\Cake\Failing.Cake.Powershell\tools\Cake.CoreCLR\Autofac.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.9\netstandard.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.9\System.Runtime.Extensions.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.9\System.Linq.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Users\lukia\source\repos\Cake\Failing.Cake.Powershell\tools\Cake.CoreCLR\Cake.Common.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Users\lukia\source\repos\Cake\Failing.Cake.Powershell\tools\Cake.CoreCLR\Cake.NuGet.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.9\System.Collections.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.9\System.Console.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.9\System.Reflection.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.9\System.Threading.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.9\System.Collections.Concurrent.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.9\System.ComponentModel.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.9\System.Globalization.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.9\System.Linq.Expressions.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.9\System.Reflection.Emit.ILGeneration.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.9\System.Reflection.Primitives.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.9\System.Reflection.Emit.Lightweight.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'Anonymously Hosted DynamicMethods Assembly'. 
Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.9\System.Reflection.Extensions.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.9\System.Runtime.InteropServices.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.9\System.Runtime.InteropServices.RuntimeInformation.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.9\System.IO.FileSystem.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Module directory does not exist.

Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.9\System.ObjectModel.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Users\lukia\source\repos\Cake\Failing.Cake.Powershell\tools\Cake.CoreCLR\NuGet.Frameworks.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Users\lukia\source\repos\Cake\Failing.Cake.Powershell\tools\Cake.CoreCLR\NuGet.Common.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.9\System.Threading.Tasks.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Users\lukia\source\repos\Cake\Failing.Cake.Powershell\tools\Cake.CoreCLR\NuGet.Configuration.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Users\lukia\source\repos\Cake\Failing.Cake.Powershell\tools\Cake.CoreCLR\NuGet.PackageManagement.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Users\lukia\source\repos\Cake\Failing.Cake.Powershell\tools\Cake.CoreCLR\NuGet.Protocol.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Users\lukia\source\repos\Cake\Failing.Cake.Powershell\tools\Cake.CoreCLR\NuGet.Packaging.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Users\lukia\source\repos\Cake\Failing.Cake.Powershell\tools\Cake.CoreCLR\NuGet.Versioning.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.9\System.Resources.ResourceManager.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
NuGet.config not found.

Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.9\System.IO.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.9\System.Xml.ReaderWriter.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.9\System.Private.Xml.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.9\System.Xml.XDocument.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.9\System.Private.Xml.Linq.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.9\System.Threading.Thread.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.9\System.Security.Cryptography.Algorithms.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.9\System.Security.Cryptography.Primitives.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.9\System.Text.Encoding.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.9\System.IO.FileSystem.Primitives.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.9\System.Private.Uri.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.9\System.Text.Encoding.Extensions.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Users\lukia\source\repos\Cake\Failing.Cake.Powershell\tools\Cake.CoreCLR\NuGet.Packaging.Core.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.9\System.Text.RegularExpressions.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Performing debug...

Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.9\System.Diagnostics.Process.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.9\System.ComponentModel.Primitives.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Attach debugger to process 15828 to continue

Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.9\System.Diagnostics.Debug.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Debugger attached

Analyzing build script...

Analyzing C:/Users/lukia/source/repos/Cake/Failing.Cake.Powershell/build.cake...

Processing build script...

Installing tools...

Loaded 'C:\Users\lukia\source\repos\Cake\Failing.Cake.Powershell\tools\Cake.CoreCLR\NuGet.ProjectModel.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Users\lukia\source\repos\Cake\Failing.Cake.Powershell\tools\Cake.CoreCLR\NuGet.Resolver.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.9\System.IO.Compression.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.9\System.Buffers.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Users\lukia\source\repos\Cake\Failing.Cake.Powershell\tools\Cake.CoreCLR\NuGet.Commands.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Found package 'NUnit.ConsoleRunner 3.9.0' in 'C:/Users/lukia/source/repos/Cake/Failing.Cake.Powershell/tools'.

Package NUnit.ConsoleRunner.3.9.0 has already been installed.

Successfully installed 'NUnit.ConsoleRunner 3.9.0' to C:/Users/lukia/source/repos/Cake/Failing.Cake.Powershell/tools

Executing nuget actions took 30,66 ms

Installing addins...

Found package 'Cake.Powershell 0.4.7' in 'C:/Users/lukia/source/repos/Cake/Failing.Cake.Powershell/tools/Addins'.

Package Cake.Powershell.0.4.7 has already been installed.

Successfully installed 'Cake.Powershell 0.4.7' to C:/Users/lukia/source/repos/Cake/Failing.Cake.Powershell/tools/Addins

Executing nuget actions took 0,66 ms

Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.9\System.Diagnostics.StackTrace.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Users\lukia\source\repos\Cake\Failing.Cake.Powershell\tools\Cake.CoreCLR\System.Reflection.Metadata.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Users\lukia\source\repos\Cake\Failing.Cake.Powershell\tools\Cake.CoreCLR\System.Collections.Immutable.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.9\System.IO.MemoryMappedFiles.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
Error: Cake.Core.CakeException: Failed to install addin 'Cake.Powershell'.

   at Cake.Core.Scripting.ScriptProcessor.InstallAddins(IReadOnlyCollection`1 addins, DirectoryPath installPath) in C:\projects\cake\src\Cake.Core\Scripting\ScriptProcessor.cs:line 114

   at Cake.Core.Scripting.ScriptRunner.Run(IScriptHost host, FilePath scriptPath, IDictionary`2 arguments) in C:\projects\cake\src\Cake.Core\Scripting\ScriptRunner.cs:line 152

   at Cake.Commands.DebugCommand.Execute(CakeOptions options) in C:\projects\cake\src\Cake\Commands\DebugCommand.cs:line 50

   at Cake.CakeApplication.Run(CakeOptions options) in C:\projects\cake\src\Cake\CakeApplication.cs:line 45

   at Cake.Program.Main() in C:\projects\cake\src\Cake\Program.cs:line 73

The program '[15828] Cake.dll' has exited with code 1 (0x1).
```
