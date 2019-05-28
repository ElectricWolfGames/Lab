using CreateVSProject.Holders;
using CreateVSProject.Interfaces;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CreateVSProject.FileTypes
{
    public class CSUnitTestFile : IOutputFile
    {
        public ProjectDetailsHolder ProjectDetailsHolder { get; set; }
        private string _fileName;

        public CSUnitTestFile(string name)
        {
            _fileName = name;
        }

        public string Output()
        {
            string name = Path.GetFileNameWithoutExtension(_fileName);
            var namespaceList = _fileName.Split('\\').ToList();

            List<string> itemsInTheNameSpace = new List<string>();
            itemsInTheNameSpace.Add(ProjectDetailsHolder.Name);

            for (int i = 0; i < namespaceList.Count - 1; i++)
            {
                itemsInTheNameSpace.Add(namespaceList[i]);
            }

            string nameSpaceSet = string.Join(".", itemsInTheNameSpace);

            StringBuilder sb = new StringBuilder();

            sb.AppendLine(@"using System;");
            sb.AppendLine(@"using System.Collections.Generic;");
            sb.AppendLine(@"using System.Linq;");
            sb.AppendLine(@"using System.Text;");
            sb.AppendLine(@"using System.Threading.Tasks;");
            sb.AppendLine(@"using FluentAssertions;");
            sb.AppendLine(@"using NUnit.Framework;");

            sb.AppendLine(@"");
            sb.AppendLine($@"namespace {nameSpaceSet}");
            sb.AppendLine(@"{");
            sb.AppendLine($@"    public class {name}Tests");
            sb.AppendLine(@"    {");
            sb.AppendLine(@"        [Test]");
            sb.AppendLine(@"        public void Should_()");
            sb.AppendLine(@"        {");
            sb.AppendLine(@"        }");
            sb.AppendLine(@"    }");
            sb.AppendLine(@"}");
            sb.AppendLine(@"");
            sb.AppendLine(@"");

            return sb.ToString();
        }

        public string FileName
        {
            get
            {
                return Path.GetFileNameWithoutExtension(_fileName);
            }
        }
    }
}
