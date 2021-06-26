using CreateVSProject.Holders;

namespace CreateVSProject.Interfaces
{
    public interface IOutputFile
    {
        ProjectDetailsHolder ProjectDetailsHolder
        {
            set;
        }

        string Output();

        string FileName { get; }
    }
}