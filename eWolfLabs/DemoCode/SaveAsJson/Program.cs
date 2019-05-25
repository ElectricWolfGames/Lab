using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveAsJson
{
    public class Program
    {
        public class DataToSave
        {
            public string Name { get; set; }
            public int Index { get; set; }
        }

        private static void Main(string[] args)
        {
            DataToSave dts = new DataToSave();
            dts.Name = "MyName";

            string output = JsonConvert.SerializeObject(dts);
            string path = @"C:\GitHub\eWolfLabs\eWolfLabs\DemoCode\SaveAsJson\Data\FileSaved.json";

            File.WriteAllText(path, output);

            DataToSave dtl = JsonConvert.DeserializeObject<DataToSave>(output);
        }
    }
}
