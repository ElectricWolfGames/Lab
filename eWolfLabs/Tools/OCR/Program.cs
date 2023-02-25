using IronOcr;

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
                Input.AddImage(@"E:\Projects\GitHub\eWolfLabs\eWolfLabs\Tools\OCR\TestImage.PNG");
                var Result = Ocr.Read(Input);
                Console.WriteLine(Result.Text);
            }
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Do();
        }
    }
}