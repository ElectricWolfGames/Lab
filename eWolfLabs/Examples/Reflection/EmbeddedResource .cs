using System;
using System.IO;
using System.Reflection;

namespace Examples.Reflection
{
    public static class EmbeddedResource
    {
        public static string LoadExampleFile()
        {
            string filename = "Examples.Reflection.Data.ResourceFileA.txt";
            return LoadFile(filename);
        }

        public static void ShouldAllEmbeddedResources()
        {
            Console.WriteLine("List of all Embedded Resources files in project");
            Assembly assembly = Assembly.GetExecutingAssembly();

            string[] fileNames = assembly.GetManifestResourceNames();
            foreach (string name in fileNames)
            {
                Console.WriteLine(name);
            }
        }

        private static string LoadFile(string filename)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            using (Stream stream = assembly.GetManifestResourceStream(filename))
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
