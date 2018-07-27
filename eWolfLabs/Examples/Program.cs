using Examples.AsyncCode;

namespace Examples
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            BackGroundTask bgt = new BackGroundTask();
            bgt.TaskRunner();
        }
    }
}