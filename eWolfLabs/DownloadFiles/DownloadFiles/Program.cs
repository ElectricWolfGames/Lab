
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DownloadFiles
{
    public class Programme
    {
        public static void Main()
        {

            string foGCMLEvents = "https://docs.google.com/spreadsheets/d/1YT-kYbwVZ7etp7824DV2KeSqan02bjGXCHNeFqMvEJs/edit#gid=0";

            IWebDriver driver;
            driver = new ChromeDriver("D:\\3rdparty\\chrome");
            driver.Url = foGCMLEvents;

            var usrename = driver.FindElement(By.Id("identifierId"));
            usrename.SendKeys("????@GoogleMail.com");


            var nextButton = driver.FindElement(By.Id("identifierNext"));
            nextButton.Click();

            // See https://aka.ms/new-console-template for more information
            Console.WriteLine("Done");
            
            Console.ReadKey();
            driver.Close();
        }

    }
}