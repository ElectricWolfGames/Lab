using CreateVSProject.FileTypes;
using CreateVSProject.Holders;
using CreateVSProject.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace CreateVSProject.Builders
{
    public class VSProject
    {
        private CsprojFile CsprojFile = new CsprojFile();
        public PackagesFile PackagesFile = new PackagesFile();
        private AppFile AppFile = new AppFile();
        private AssemblyInfoFile AssemblyInfoFile = new AssemblyInfoFile();
        private List<string> _folders = new List<string>();

        private ProjectDetailsHolder _projectDetailsHolder;

        public VSProject(ProjectDetailsHolder pdh)
        {
            _projectDetailsHolder = pdh;
            _folders.Add("Properties");
        }

        internal void AddFluentAssertions()
        {
            throw new NotImplementedException();
        }

        internal void AddExtraFiles()
        {
            if (_projectDetailsHolder.UnitTest)
            {
                PackagesFile.Files.Add(@"  <package id=""NUnit"" version=""3.12.0"" targetFramework=""net471"" />");
                PackagesFile.Files.Add(@"  <package id=""NUnit3TestAdapter"" version=""3.10.0"" targetFramework=""net461"" />");
                PackagesFile.Files.Add(@"  <package id=""FluentAssertions"" version=""5.4.2"" targetFramework=""net461"" />");
            }
        }

        public void CreateProject()
        {
            CreateEmptyFolders();
            CreateFile(PackagesFile);
            CreateFile(AppFile);
            CreateFile(AssemblyInfoFile);
            CreateFile(CsprojFile);
        }

        private void CreateEmptyFolders()
        {
            foreach (string folder in _folders)
            {
                Directory.CreateDirectory(Path.Combine(_projectDetailsHolder.OutputPath, folder));
            }
        }

        private void CreateFile(IOutputFile outFile)
        {
            outFile.ProjectDetailsHolder = _projectDetailsHolder;

            string fileName = Path.Combine(_projectDetailsHolder.OutputPath, outFile.FileName);
            File.WriteAllText(fileName, outFile.Output());
        }
    }
}
