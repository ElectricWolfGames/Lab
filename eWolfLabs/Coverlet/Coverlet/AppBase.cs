using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coverlet
{
    public class AppBase
    {
        public string GetString(int value)
        {
            string retStr = string.Empty;

            if (value != 0)
                retStr = value.ToString();

            return retStr;
        }
    }
}
