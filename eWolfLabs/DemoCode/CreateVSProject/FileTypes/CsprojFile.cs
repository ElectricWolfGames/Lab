using CreateVSProject.Holders;
using CreateVSProject.Interfaces;
using System;
using System.IO;
using System.Text;

namespace CreateVSProject.FileTypes
{
    public class CsprojFile : IOutputFile
    {
        public ProjectDetailsHolder ProjectDetailsHolder { get; set; }

        public string Output()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(ProjectStart());
            sb.Append(PropertyGroup());
            sb.Append(ItemGroupReferenceInclude());
            sb.Append(ItemGroupProjectFolders());
            sb.Append(ItemGroupProjectFiles());
            if (ProjectDetailsHolder.UnitTest)
            {
                sb.Append(ItemGroupProjectFilesListUnitTests());
            }
            else
            {
                sb.Append(ItemGroupProjectFilesList());
            }
            sb.Append(ItemGroupSonarQube());

            sb.Append(ProjectEnd());
            return sb.ToString();
        }

        public string FileName
        {
            get
            {
                return $"{ProjectDetailsHolder.Name}.csproj";
            }
        }

        private string ItemGroupProjectFolders()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(@"  <ItemGroup>");

            foreach (string folderName in ProjectDetailsHolder.FoldersToAdd)
            {
                Directory.CreateDirectory(Path.Combine(ProjectDetailsHolder.OutputPath, folderName));

                sb.AppendLine($@"    <Folder Include=""{folderName}\"" />");
            }
            sb.AppendLine(@"  </ItemGroup>");
            return sb.ToString();
        }

        private string ItemGroupProjectFilesListUnitTests()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(@"  <ItemGroup>");

            foreach (string fileName in ProjectDetailsHolder.FilesToAdd)
            {
                string fileNameUpdated = fileName.Replace(".", "Test.");
                string file = CreateBasicUnitTestCSFile(ProjectDetailsHolder, fileName);
                string fullFileName = Path.Combine(ProjectDetailsHolder.OutputPath, fileNameUpdated);
                File.WriteAllText(fullFileName, file);

                sb.AppendLine($@"    <Compile Include=""{fileNameUpdated}"" />");
            }
            sb.AppendLine(@"  </ItemGroup>");
            return sb.ToString();
        }

        private string ItemGroupProjectFilesList()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(@"  <ItemGroup>");

            foreach (string fileName in ProjectDetailsHolder.FilesToAdd)
            {
                string file = CreateBasicCSFile(ProjectDetailsHolder, fileName);
                string fullFileName = Path.Combine(ProjectDetailsHolder.OutputPath, fileName);
                File.WriteAllText(fullFileName, file);

                sb.AppendLine($@"    <Compile Include=""{fileName}"" />");
            }
            sb.AppendLine(@"  </ItemGroup>");
            return sb.ToString();
        }

        private string CreateBasicUnitTestCSFile(ProjectDetailsHolder projectDetailsHolder, string name)
        {
            CSUnitTestFile csFile = new CSUnitTestFile(name)
            {
                ProjectDetailsHolder = projectDetailsHolder
            };
            return csFile.Output();
        }

        private string CreateBasicCSFile(ProjectDetailsHolder projectDetailsHolder, string name)
        {
            CSFile csFile = new CSFile(name)
            {
                ProjectDetailsHolder = projectDetailsHolder
            };
            return csFile.Output();
        }

        private string ItemGroupProjectFiles()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(@"  <ItemGroup>");
            sb.AppendLine(@"    <Compile Include=""Properties\AssemblyInfo.cs"" />");
            sb.AppendLine(@"  </ItemGroup>");
            sb.AppendLine(@"  <ItemGroup>");
            sb.AppendLine(@"        <None Include=""App.config"" />");
            sb.AppendLine(@"        <None Include=""packages.config"" />");
            sb.AppendLine(@"  </ItemGroup>");
            return sb.ToString();
        }

        private string ItemGroupSonarQube()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(@"  <ItemGroup>");
            sb.AppendLine(@"   <Analyzer Include=""..\..\..\packages\SonarAnalyzer.CSharp.7.14.0.8411\analyzers\Google.Protobuf.dll"" />");
            sb.AppendLine(@"   <Analyzer Include=""..\..\..\packages\SonarAnalyzer.CSharp.7.14.0.8411\analyzers\SonarAnalyzer.CSharp.dll"" />");
            sb.AppendLine(@"   <Analyzer Include=""..\..\..\packages\SonarAnalyzer.CSharp.7.14.0.8411\analyzers\SonarAnalyzer.dll"" />");
            sb.AppendLine(@"  </ItemGroup>");

            return sb.ToString();
        }

        private string ItemGroupReferenceInclude()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(@"  <ItemGroup>");
            if (ProjectDetailsHolder.UnitTest)
            {
                sb.AppendLine(@"<Reference Include=""nunit.framework, Version = 3.12.0.0, Culture = neutral, PublicKeyToken = 2638cd05610744eb, processorArchitecture = MSIL"">");
                sb.AppendLine(@"    <HintPath>..\..\..\..\packages\NUnit.3.12.0\lib\net45\nunit.framework.dll</HintPath>");
                sb.AppendLine(@"</Reference>");
            }

            sb.AppendLine(@"    <Reference Include=""System"" />");
            sb.AppendLine(@"    <Reference Include=""System.Core"" />");
            sb.AppendLine(@"    <Reference Include=""System.Xml.Linq"" />");
            sb.AppendLine(@"    <Reference Include=""System.Data.DataSetExtensions"" />");
            sb.AppendLine(@"    <Reference Include=""Microsoft.CSharp"" />");
            sb.AppendLine(@"    <Reference Include=""System.Data"" />");
            sb.AppendLine(@"    <Reference Include=""System.Net.Http"" />");
            sb.AppendLine(@"    <Reference Include=""System.Xml"" />");
            sb.AppendLine(@"  </ItemGroup>");
            return sb.ToString();
        }

        private string ProjectEnd()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(@" <Import Project=""$(MSBuildToolsPath)\Microsoft.CSharp.targets"" /> ");
            if (ProjectDetailsHolder.UnitTest)
            {
                sb.AppendLine(@"  <Target Name=""EnsureNuGetPackageBuildImports"" BeforeTargets=""PrepareForBuild"">");
                sb.AppendLine(@"    <PropertyGroup>");
                sb.AppendLine(@"      <ErrorText>This project references NuGet package(s) that are missing on this computer. Use NuGet Package Restore to download them.  For more information, see http://go.microsoft.com/fwlink/?LinkID=322105. The missing file is {0}.</ErrorText>");
                sb.AppendLine(@"    </PropertyGroup>");
                sb.AppendLine(@"    <Error Condition=""!Exists('..\..\..\packages\NUnit.3.12.0\build\NUnit.props')"" Text=""$([System.String]::Format('$(ErrorText)', '..\..\..\packages\NUnit.3.12.0\build\NUnit.props'))"" />");
                sb.AppendLine(@"    <Error Condition=""!Exists('..\..\..\packages\NUnit3TestAdapter.3.13.0\build\net35\NUnit3TestAdapter.props')"" Text=""$([System.String]::Format('$(ErrorText)', '..\..\..\packages\NUnit3TestAdapter.3.13.0\build\net35\NUnit3TestAdapter.props'))"" />");
                sb.AppendLine(@"  </Target>");
            }
            sb.AppendLine(@"</Project>");
            return sb.ToString();
        }

        private string ProjectStart()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(@"<?xml version=""1.0"" encoding=""utf-8""?>");
            sb.AppendLine(@"<Project ToolsVersion=""15.0"" xmlns=""http://schemas.microsoft.com/developer/msbuild/2003"">");
            return sb.ToString();
        }

        private string PropertyGroup()
        {
            StringBuilder sb = new StringBuilder();
            if (ProjectDetailsHolder.UnitTest)
            {
                sb.AppendLine(@"  <Import Project=""..\..\..\packages\NUnit3TestAdapter.3.13.0\build\net35\NUnit3TestAdapter.props"" Condition=""Exists('..\..\..\..\..\packages\NUnit3TestAdapter.3.13.0\build\net35\NUnit3TestAdapter.props')"" />");
                sb.AppendLine(@"  <Import Project=""..\..\..\packages\NUnit.3.12.0\build\NUnit.props"" Condition=""Exists('..\..\..\packages\NUnit.3.12.0\build\NUnit.props')"" />");
            }

            sb.AppendLine(@" <Import Project=""$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props"" Condition=""Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')"" />");
            sb.AppendLine(@"  <PropertyGroup>");
            sb.AppendLine(@"    <Configuration Condition="" '$(Configuration)' == '' "">Debug</Configuration>");
            sb.AppendLine(@"    <Platform Condition="" '$(Platform)' == '' "">AnyCPU</Platform>");
            sb.AppendLine($@"    <ProjectGuid>{{{ProjectDetailsHolder.Guid.ToString()}}}</ProjectGuid>");
            sb.AppendLine(@"    <OutputType>Library</OutputType>");
            sb.AppendLine($@"    <RootNamespace>{ProjectDetailsHolder.Name}</RootNamespace>");
            sb.AppendLine($@"    <AssemblyName>{ProjectDetailsHolder.Name}</AssemblyName>");
            sb.AppendLine(@"    <TargetFrameworkVersion>v4.7.1</TargetFrameworkVersion>");
            sb.AppendLine(@"    <FileAlignment>512</FileAlignment>");
            sb.AppendLine(@"    <AutoGenerateBindingRedirects>true</AutoGenerateBindingRedirects>");
            sb.AppendLine(@"    <Deterministic>true</Deterministic>");
            sb.AppendLine(@"    <NuGetPackageImportStamp>");
            sb.AppendLine(@"    </NuGetPackageImportStamp>");

            sb.AppendLine(@" </PropertyGroup>");

            sb.AppendLine(@"  <PropertyGroup Condition="" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' "">");
            sb.AppendLine(@"    <PlatformTarget>AnyCPU</PlatformTarget>");
            sb.AppendLine(@"    <DebugSymbols>true</DebugSymbols>");
            sb.AppendLine(@"    <DebugType>full</DebugType>");
            sb.AppendLine(@"    <Optimize>false</Optimize>");
            sb.AppendLine(@"    <OutputPath>bin\Debug\</OutputPath>");
            sb.AppendLine(@"    <DefineConstants>DEBUG;TRACE</DefineConstants>");
            sb.AppendLine(@"    <ErrorReport>prompt</ErrorReport>");
            sb.AppendLine(@"    <WarningLevel>4</WarningLevel>");
            sb.AppendLine(@"  </PropertyGroup>");

            sb.AppendLine(@"  <PropertyGroup Condition="" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' "">");
            sb.AppendLine(@"    <PlatformTarget>AnyCPU</PlatformTarget>");
            sb.AppendLine(@"    <DebugType>pdbonly</DebugType>");
            sb.AppendLine(@"    <Optimize>true</Optimize>");
            sb.AppendLine(@"    <OutputPath>bin\Release\</OutputPath>");
            sb.AppendLine(@"    <DefineConstants>TRACE</DefineConstants>");
            sb.AppendLine(@"    <ErrorReport>prompt</ErrorReport>");
            sb.AppendLine(@"    <WarningLevel>4</WarningLevel>");
            sb.AppendLine(@"  </PropertyGroup>");

            return sb.ToString();
        }
    }
}