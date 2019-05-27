using CreateVSProject.Holders;
using CreateVSProject.Interfaces;
using System.Text;

namespace CreateVSProject.FileTypes
{
    public class AssemblyInfoFile : IOutputFile
    {
        public ProjectDetailsHolder ProjectDetailsHolder { get; set; }

        public string Output()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("using System.Reflection;");
            sb.AppendLine("using System.Runtime.CompilerServices;");
            sb.AppendLine("using System.Runtime.InteropServices;");
            sb.AppendLine("");
            sb.AppendLine("// General Information about an assembly is controlled through the following");
            sb.AppendLine("// set of attributes. Change these attribute values to modify the information");
            sb.AppendLine("// associated with an assembly.");
            sb.AppendLine($@"[assembly: AssemblyTitle(""{ProjectDetailsHolder.Name}"")]");
            sb.AppendLine(@"[assembly: AssemblyDescription("""")]");
            sb.AppendLine(@"[assembly: AssemblyConfiguration("""")]");
            sb.AppendLine(@"[assembly: AssemblyCompany("""")]");
            sb.AppendLine($@"[assembly: AssemblyProduct(""{ProjectDetailsHolder.Name}"")]");
            sb.AppendLine(@"[assembly: AssemblyCopyright(""Copyright ©  2019"")]");
            sb.AppendLine(@"[assembly: AssemblyTrademark("""")]");
            sb.AppendLine(@"[assembly: AssemblyCulture("""")]");
            sb.AppendLine("");
            sb.AppendLine("// Setting ComVisible to false makes the types in this assembly not visible");
            sb.AppendLine("// to COM components.  If you need to access a type in this assembly from");
            sb.AppendLine("// COM, set the ComVisible attribute to true on that type.");
            sb.AppendLine("[assembly: ComVisible(false)]");
            sb.AppendLine("");
            sb.AppendLine("// The following GUID is for the ID of the typelib if this project is exposed to COM");
            sb.AppendLine($@"[assembly: Guid(""{ProjectDetailsHolder.Guid}"")]");
            sb.AppendLine("");
            sb.AppendLine("// Version information for an assembly consists of the following four values:");
            sb.AppendLine("//");
            sb.AppendLine("//      Major Version");
            sb.AppendLine("//      Minor Version");
            sb.AppendLine("//      Build Number");
            sb.AppendLine("//      Revision");
            sb.AppendLine("//");
            sb.AppendLine("// You can specify all the values or you can default the Build and Revision Numbers");
            sb.AppendLine("// by using the '*' as shown below:");
            sb.AppendLine(@"// [assembly: AssemblyVersion(""1.0.* "")]");
            sb.AppendLine(@"[assembly: AssemblyVersion(""1.0.0.0"")]");
            sb.AppendLine(@"[assembly: AssemblyFileVersion(""1.0.0.0"")]");

            return sb.ToString();
        }

        public string FileName
        {
            get
            {
                return @"Properties\AssemblyInfo.cs";
            }
        }
    }
}
