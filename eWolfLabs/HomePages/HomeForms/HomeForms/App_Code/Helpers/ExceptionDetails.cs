using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeForms.Helpers
{
    public class ExceptionDetails
    {
        private string _message;
        private List<string> _rawLines;
        private List<string> _withLineNumbers;

        public ExceptionDetails(string message)
        {
            ApplyDetails(message);
        }

        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                ApplyDetails(value);
            }
        }

        public List<string> RawLines { get => _rawLines; set => _rawLines = value; }

        public List<string> WithLineNumbers { get => _withLineNumbers; set => _withLineNumbers = value; }

        public string GetDisplayMessage()
        {
            // return string.Join("\r\n", _rawLines);
            return string.Join("<br/>", _rawLines);
        }

        private void ApplyDetails(string message)
        {
            _message = message;
            List<string> items = message.Split(new[] { "at " }, StringSplitOptions.None).ToList();
            WithLineNumbers = new List<string>();

            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Contains("line"))
                {
                    WithLineNumbers.Add(items[i]);
                }

                if (i > 1)
                {
                    items[i] = "at " + items[i];
                }
            }

            // now find any lines that have in or a line number in them
            // and store that in the second list.
            _rawLines = items;
        }
    }
}
