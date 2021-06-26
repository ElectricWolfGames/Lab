using System;
using System.Collections.Generic;

namespace CreateVSProject.Holders
{
    public class ProjectDetailsHolder
    {
        public string Name { get; set; }

        public Guid Guid { get; set; }

        public string OutputPath { get; set; }

        public bool UnitTest { get; set; }

        public List<string> FoldersToAdd { get; set; }

        public List<string> FilesToAdd { get; set; }
    }
}