namespace APIs
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var words = new ExchangeEateAPIS();
            words.MakeRequest();
        }
    }
}