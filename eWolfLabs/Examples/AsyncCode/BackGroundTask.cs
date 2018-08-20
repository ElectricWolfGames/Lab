using System;
using System.Threading;
using System.Threading.Tasks;

namespace Examples.AsyncCode
{
    public class BackGroundTask
    {
        public void TaskRunner()
        {
            TaskHolder();
            while (true)
            {
                string result = Console.ReadLine();
                Console.WriteLine("You typed: " + result);
            }
        }

        private static async void TaskHolder()
        {
            // This method runs asynchronously.
            int t = await Task.Run(() => BackGroundWork());
            Console.WriteLine("Compute: " + t);
        }

        private static int BackGroundWork()
        {
            // Compute total count of digits in strings.
            int size = 0;
            for (int z = 0; z < 100; z++)
            {
                for (int i = 0; i < 1000000; i++)
                {
                    string value = i.ToString();
                    size += value.Length;
                    Thread.Sleep(100);
                    Console.Write(".");
                }
            }
            return size;
        }
    }
}