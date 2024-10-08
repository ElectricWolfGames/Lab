﻿using IronOcr;

namespace OCR
{
    // https://www.c-sharpcorner.com/article/ocr-using-tesseract-in-C-Sharp/
    internal class Program
    {
        private static void Do()
        {
            var Ocr = new IronTesseract(); // nothing to configure
            Ocr.Language = OcrLanguage.English;
            using (var Input = new OcrInput())
            {
                Input.AddImage(@"E:\Trains\Photos - Main\2024\2024-04-06 Bingham Model Railway Show\WhatsApp Image 2024-04-07 at 20.08.42_cea37aea.jpg");
                var Result = Ocr.Read(Input);
                Console.WriteLine(Result.Text);
            }
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Do();
            //DoFolder("E:\\Trains\\Photos - Main\\2023\\2023-08-12 Soar Vally Model Railway Club\\Descriptions\\");
        }

        private static void DoFolder(string path)
        {
            var files = Directory.GetFiles(path);

            foreach (var file in files)
            {
                string saveName = file.Replace(".png", ".Txt");

                var Ocr = new IronTesseract(); // nothing to configure
                Ocr.Language = OcrLanguage.English;
                using (var Input = new OcrInput())
                {
                    Input.AddImage(file);
                    var result = Ocr.Read(Input);
                    File.WriteAllText(saveName, result.Text);
                    Console.WriteLine(result.Text);
                }
            }
        }
    }
}