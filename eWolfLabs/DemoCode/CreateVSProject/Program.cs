using CreateVSProject.Builders;
using CreateVSProject.Holders;
using System;
using System.Collections.Generic;
using System.IO;

namespace CreateVSProject
{
    public class Program
    {
        private static string _path = @"C:\GitHub\eWolfLabs\eWolfLabs\DemoCode\Output\";

        private static void CreateMainProject(List<string> folderToAdd, List<string> filesToAdd)
        {
            ProjectDetailsHolder pdh = new ProjectDetailsHolder()
            {
                Name = "NewCTO",
                Guid = Guid.NewGuid(),
                FoldersToAdd = folderToAdd,
                FilesToAdd = filesToAdd
            };

            pdh.OutputPath = Path.Combine(_path, pdh.Name, pdh.Name);

            VSProject vsp = new VSProject(pdh);

            vsp.CreateProject();
        }

        private static void CreateUnitTestProject(List<string> folderToAdd, List<string> filesToAdd)
        {
            ProjectDetailsHolder pdh = new ProjectDetailsHolder()
            {
                Name = "NewCTO",
                Guid = Guid.NewGuid(),
                UnitTest = true,
                FoldersToAdd = folderToAdd,
                FilesToAdd = filesToAdd
            };

            pdh.OutputPath = Path.Combine(_path, pdh.Name, pdh.Name + ".UnitTests");
            pdh.Name += ".UnitTests";

            VSProject vsp = new VSProject(pdh);
            vsp.AddExtraFiles();
            vsp.CreateProject();
        }

        private static void Main(string[] args)
        {
            List<string> filesToAdd = new List<string>();
            List<string> foldersToAdd = new List<string>();

            foldersToAdd.Add("Inbound");
            foldersToAdd.Add("Outbound");
            foldersToAdd.Add("Components");

            filesToAdd.Add(@"Components\MyComponent.cs");

            CreateMainProject(foldersToAdd, filesToAdd);
            CreateUnitTestProject(foldersToAdd, filesToAdd);
        }
    }
}