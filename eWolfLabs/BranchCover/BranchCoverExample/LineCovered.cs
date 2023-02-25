namespace BranchCoverExample
{
    public class LineCovered
    {
        public DataObject DoStuff(string dataTypeToCreate)
        {
            DataObject results = null;

            if (dataTypeToCreate == "a")
            {
                results = new DataObject() { Value = 10 };
            }

            if (dataTypeToCreate == "b")
            {
                results = new DataObject() { Value = 20 };
            }

            return results;
        }
    }
}