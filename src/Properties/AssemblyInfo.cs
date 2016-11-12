using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("SPC.Nop.Plugin.VirtualDirectoryFix")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("SPC Internet Ltd")]
[assembly: AssemblyProduct("SPC.Nop.Plugin.VirtualDirectoryFix")]
//[assembly: AssemblyCopyright("Copyright ©  2016")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("4867fe9b-f8a7-4103-812e-dc2c50794b32")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
#if DEBUG
[assembly: AssemblyCopyright("Compiled as DEBUG")]
[assembly: AssemblyMetadata("CompileMode", "Compiled as DEBUG")]
#else
[assembly: AssemblyMetadata("CompileMode", "Compiled as RELEASE")]
[assembly: AssemblyCopyright("Compiled as RELEASE")]
#endif
