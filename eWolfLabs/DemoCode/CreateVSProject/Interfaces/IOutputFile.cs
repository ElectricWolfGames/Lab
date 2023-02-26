using CreateVSProject.Holders;

namespace CreateVSProject.Interfaces
{
    public interface IOutputFile
    {
        string FileName { get; }

        ProjectDetailsHolder ProjectDetailsHolder
        {
            set;
        }

        string Output();
    }
}