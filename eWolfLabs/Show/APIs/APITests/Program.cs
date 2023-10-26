namespace APIs
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var words = new ExchangerateAPIS();
            words.MakeRequest();
        }
    }
}