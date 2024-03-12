using System;
using System.Threading;
using System.Windows;
using System.Windows.Controls;

namespace OpenBing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Timer temp;

        public MainWindow()
        {
            InitializeComponent();
            Start();

            temp = new Timer(refreshh_Tick, null, 0, 15 * 1000);
        }

        public void FindNext(string text, WebBrowser webBrowser2)
        {
            var doc = Browser1.Document;
        }

        public void OpenWithStartInfo()
        {
            Random rnd = new Random();
            int year = rnd.Next(0, 1999);
            int day = rnd.Next(1, 30);
            int month = rnd.Next(1, 12);
            string text = $"What happen in the year {year} day {day} month {month}";
            string search = $"http://www.bing.com/search?q={text}";

            Browser1.Navigate(search);
        }

        private void refreshh_Tick(object sender)
        {
            Random rnd = new Random();
            int year = rnd.Next(0, 1999);
            int day = rnd.Next(1, 30);
            int month = rnd.Next(1, 12);
            string text = $"What happen in the year {year} day {day} month {month}";
            string search = $"http://www.bing.com/search?q={text}";

            this.Dispatcher.Invoke(() =>
            {
                try
                {
                    Browser1.Navigate(search);
                }
                catch { }
            });
        }

        private void Start()
        {
            OpenWithStartInfo();
        }
    }
}