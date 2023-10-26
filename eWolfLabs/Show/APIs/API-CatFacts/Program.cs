namespace API_CatFacts
{
    // more here!
    // https://mixedanalytics.com/blog/list-actually-free-open-no-auth-needed-apis/
    // maybe  https://list.ly/api/docs

    internal class Program
    {
        private static void Main(string[] args)
        {
            var catFacts = new CatFacts();
            catFacts.MakeRequest();
        }
    }
}