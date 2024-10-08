namespace Body
{
    public class Programme
    {
        public static void Main()
        {
            // See https://aka.ms/new-console-template for more information
            //Console.WriteLine("Hello, World!");

            //var process = Process.GetCurrentProcess();

            var pw = new ProcessWatcher();

            while (true)
            {
                pw.Check();
                Thread.Sleep(1000);
                //Console.Write(".");
            }
        }
    }
}